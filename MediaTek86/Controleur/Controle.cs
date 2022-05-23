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
    /// Gère les interactions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// Fenêtre d'authentification
        /// </summary>
        private frmAuthentification frmAuthentification;

        frmGestionAbsences abc;
        frmGestionPersonnel abcd;

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
        /// La fenêtre de gestion des absences apparait 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <returns></returns>
        public Boolean Absences(string nom, string prenom)
        {
            /// <summary>
            /// Stockage de la frmGestionAbsences dans une variable "abc"
            /// </summary>
            frmGestionAbsences abc = new frmGestionAbsences(this, nom, prenom);
            abc.ShowDialog();
            return true;
        }
    
        /// <summary>
        /// Récupère et retourne les infos des personnels provenant de la BDD
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

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel à modifier</param>
        public void AjouterPersonnel(Personnel personnel)
        {
            AccesDonnees.AjouterPersonnel(personnel);
        }


        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void ModifierPersonnel(Personnel personnel)
        {
            AccesDonnees.ModifierPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à supprimer</param>
        public void SupprimerPersonnel(Personnel personnel)
        {
            AccesDonnees.SupprimerPersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des absences provenant de la BDD
        /// </summary>
        /// <returns>liste des absences/returns>
        public List<Absence> GetLesAbsences(int idpersonnel = 0)
        {
            return AccesDonnees.GetLesAbsences(idpersonnel);

        }

        /// <summary>
        /// Récupère et retourne les infos des motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

    }
}
