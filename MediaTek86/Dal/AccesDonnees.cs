using System;
using System.Collections.Generic;
using MediaTek86.Connexion;
using MySql.Data.MySqlClient;
using MediaTek86.Modele;

namespace MediaTek86.Dal
{
    public class AccesDonnees
    {
        // <summary>
        /// Chaine de connexion à la BDD Mediatek
        /// </summary>
        private static string connectionString = "server=localhost;database=mediatek86;uid=root;pwd=@Azerty85!;";

        /// <summary>
        /// Fenêtre d'authentification 
        /// Vérification que les identifiants correspondent bien à ceux de la table "Responsable"
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
        /// Récupération des données de la liste des personnels pour l'afficher dans la datagrid
        /// </summary>
        /// <returns>liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            ///<summary>
            ///Requete SQL de selection de la liste des personnels pour chaque colonne, et des noms des services de la table service
            ///Ajout d'un group by pour éviter doublons et order pour le tri
            /// </summary>
            string req = "SELECT p.idpersonnel AS IDPERSONNEL, p.nom AS NOM, p.prenom AS PRENOM, p.tel AS TEL, p.mail AS MAIL, s.idservice AS IDSERVICE, s.nom AS 'SERVICE'";
            req += "FROM personnel p JOIN service s USING(IDSERVICE) GROUP BY p.NOM ORDER BY p.NOM";

            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null); //Doit utiliser la connexion à la BDD pour travailler sur cette BDD, sert à exécuter la requête
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

    }
}
