using System;
using System.Collections.Generic;
using MediaTek86.Connexion;
using MediaTek86.Modele;


namespace MediaTek86.Dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les données distantes
    /// </summary>
    public class AccesDonnees
    {
        /// <summary>
        /// Chaine de connexion à la BDD MediaTek86
        /// </summary>
        private static string connectionString = "server=changeme;database=changeme;uid=changeme;pwd=changeme;";

        /// <summary>
        /// Fenêtre d'authentification 
        /// Les identifiants doivent correspondre à ceux de la table "Responsable"
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns>Correspondance des identifiants avec ceux d'un responsable</returns>
        public static Boolean Authentification(string login, string pwd)
        {
            string req = "SELECT * FROM responsable ";
            req += "WHERE login = @login AND pwd = SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, parameters);

            if (curseur.Read())
            {
                curseur.Close();
                return true;
            }
            else
            {
                curseur.Close();
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>Liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();

            //Requete SQL de selection de la liste des personnels pour chaque colonne, et des noms des services de la table service
            //Ajout d'un group by pour éviter doublons et order pour le tri
            string req = "SELECT p.idpersonnel AS IDPERSONNEL, p.nom AS NOM, p.prenom AS PRENOM, p.tel AS TEL, p.mail AS MAIL, s.idservice AS IDSERVICE, s.nom AS 'SERVICE'";
            req += "FROM personnel p JOIN service s USING(IDSERVICE) GROUP BY p.NOM ORDER BY p.NOM";

            //Utilisation de la connexion à la BDD pour travailler sur la BDD
            //Permet d'exécuter la requête
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Personnel personnel = new Personnel((int)curseur.Field("IDPERSONNEL"),
                    (string)curseur.Field("NOM"),
                    (string)curseur.Field("PRENOM"),
                    (string)curseur.Field("TEL"),
                    (string)curseur.Field("MAIL"),
                    (int)curseur.Field("IDSERVICE"),
                    (string)curseur.Field("SERVICE"));
                lesPersonnels.Add(personnel);
            }
            curseur.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupération des données de la liste des services
        /// </summary>
        /// <returns>Liste des services</returns>
        public static List<Service> GetLesServices()
        {
            // Récupération de l'ID et du Nom du service
            List<Service> lesServices = new List<Service>();
            string req = "SELECT * FROM service";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Service service = new Service((int)curseur.Field("IDSERVICE"),
                    (string)curseur.Field("NOM"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        ///<param name="personnel">Personnel à ajouter</param>"
        public static void AjouterPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel(nom, prenom, tel, mail, idservice) ";
            req += "SELECT * FROM(SELECT @nom AS nom, @prenom AS prenom, @tel AS tel, @mail AS mail, @idservice AS idservice) AS req ";
            req += "WHERE NOT EXISTS(SELECT nom, prenom FROM personnel WHERE nom = @nom AND prenom = @prenom); ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel à modifier</param>
        public static void ModifierPersonnel(Personnel personnel)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            string req = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonnel";
            curseur.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel à supprimer</param>
        public static void SupprimerPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Récupère et retourne les absences provenant de la BDD
        /// </summary>
        /// <param name="idpersonnel"> id du personnel sélectionné</param>
        /// <returns>Liste des absences</returns>
        public static List<Absence> GetLesAbsences(int idpersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();

            //Récupère et retourne les absences du personnel sélectionné   
            string req = "SELECT a.datedebut AS 'datedebut', a.datefin AS 'datefin', a.idpersonnel AS 'idpersonnel', a.idmotif AS 'idmotif', m.libelle AS 'motif' FROM absence a JOIN motif m USING (idmotif)";
            req += "WHERE idpersonnel=" + idpersonnel + " ORDER BY dateDebut DESC";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Absence absence = new Absence((DateTime)curseur.Field("DATEDEBUT"),
                    (DateTime)curseur.Field("DATEFIN"),
                    (int)curseur.Field("idpersonnel"),
                    (int)curseur.Field("IDMOTIF"),
                    (string)curseur.Field("MOTIF"));
                lesAbsences.Add(absence);
            }
            curseur.Close();
            return lesAbsences;      
        }

        /// <summary>
        /// Récupération de l'id du personnel sélectionné
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <returns>Récupère l'id du personnel sélectionné</returns>
        public static int recupererIdPersonnel(string nom, string prenom)
        {
            // On déclare l'ID à 0 par défaut
            int idpersonnel = 0;
            // On sélectionne l'ID de la personne 
            string req = "SELECT idpersonnel FROM personnel WHERE nom='" + nom + "' AND prenom = '" + prenom + "'";

            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);

            // On loop sur la valeur retournée
            while (curseur.Read())
                idpersonnel = (int)curseur.Field("IDPERSONNEL");
            // On renvoie l'id du personnel (0 par défaut, différent si ligne trouvée)
            return idpersonnel;
        }
        /// <summary>
        /// Récupère et retourne les motifs provenant de la BDD
        /// </summary>
        /// <returns>Liste des motifs</returns>
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "SELECT * FROM motif ORDER BY libelle;";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Motif motif = new Motif((int)curseur.Field("idmotif"), (string)curseur.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curseur.Close();
            return lesMotifs;
        }

        /// <summary>
        /// Ajouter une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="idpersonnel"></param> 
        public static void AjouterAbsence(Absence absence,int idpersonnel)
        {
            string req = "INSERT INTO absence(datedebut, datefin, idpersonnel, idmotif) ";
            req += "SELECT * FROM (SELECT @datedebut AS datedebut, @datefin AS datefin, " + idpersonnel + " AS idpersonnel, @idmotif AS idmotif) AS req ";
            req += "WHERE NOT EXISTS(SELECT datedebut, idpersonnel FROM absence WHERE datedebut = @datedebut AND idpersonnel = " + idpersonnel + "); ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idpersonnel", idpersonnel);
            parameters.Add("@idmotif", absence.Idmotif);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Supprimer une absence
        /// </summary>
        /// <param name="absence"></param>
        /// /// <param name="idpersonnel"></param>
        public static void SupprimerAbsence(Absence absence, int idpersonnel)
        {
            string req = "DELETE FROM absence WHERE idpersonnel = " + idpersonnel;
            req += " AND datedebut = @datedebut;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
    }
}
