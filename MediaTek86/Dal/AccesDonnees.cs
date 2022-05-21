using System;
using System.Collections.Generic;
using MediaTek86.Connexion;
using MySql.Data.MySqlClient;

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
    }
}
