using System;
using System.Collections.Generic;
using MediaTek86.Connexion;
using MySql.Data.MySqlClient;
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
        private static string connectionString = "server=localhost;database=mediatek86;uid=root;pwd=@Azerty85!;";

        /// <summary>
        /// Fenêtre d'authentification 
        /// Les identifiants doivent correspondre à ceux de la table "Responsable"
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
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
            ///<summary>
            ///Requete SQL de selection de la liste des personnels pour chaque colonne, et des noms des services de la table service
            ///Ajout d'un group by pour éviter doublons et order pour le tri
            /// </summary>
            string req = "SELECT p.idpersonnel AS IDPERSONNEL, p.nom AS NOM, p.prenom AS PRENOM, p.tel AS TEL, p.mail AS MAIL, s.idservice AS IDSERVICE, s.nom AS 'SERVICE'";
            req += "FROM personnel p JOIN service s USING(IDSERVICE) GROUP BY p.NOM ORDER BY p.NOM";

            ///<summary>
            ///Utilisation de la connexion à la BDD pour travailler sur la BDD
            ///Permet d'exécuter la requête
            /// </summary>
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
            /// <summary>
            /// Récupération de l'ID et du Nom du service
            /// </summary>
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
        /// <param name="personnel"></param>
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
        /// <param name="personnel">Objet personnel à supprimer</param>
        public static void SupprimerPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, parameters);
        }


    }
}
