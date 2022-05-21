using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.Vue;
using System.Windows.Forms;
using MediaTek86.Controleur;
using MediaTek86.Dal;
using MySql.Data.MySqlClient;
using MediaTek86.Modele;


namespace MediaTek86.Controleur
{
    /// <summary>
    /// Création du controleur
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// Fenêtre d'authentification
        /// </summary>
        private frmAuthentification frmAuthentification;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmAuthentification = new frmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        /// <summary>
        /// Demande la vérification de l'authentification
        /// La fenêtre de gestion du personnel apparait si les identifiants du responsable sont corrects
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Boolean Authentification(string login, string pwd)
        {
            if (AccesDonnees.Authentification(login, pwd))
            {
                ///<summary>
                /// Il faut masquer la fenêtre d'authentification
                ///Pour afficher ensuite la fenêtre de gestionPersonnel
                ///</summary>
                frmAuthentification.Hide();
                (new frmGestionPersonnel(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Récupère les infos du personnel provenant de la BDD pour les envoyer dans la fonction de remplissage de la datagrid
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }
    }
}
