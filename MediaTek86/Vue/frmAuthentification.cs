using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.Controleur;
using MediaTek86.Vue;
using MediaTek86.Dal;
using MySql.Data.MySqlClient;

namespace MediaTek86.Vue
{
    /// <summary>
    /// Fenêtre d'authentification
    /// </summary>
    public partial class frmAuthentification : Form
    {
        /// <summary>
        /// Récupération du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation de l'interface graphique et du controleur
        /// </summary>
        /// <param name="controle"></param>
        public frmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            //masquer le mdp
            txtPassword.UseSystemPasswordChar = true;
        }


        /// <summary>
        /// Procédure évènementielle du bouton Connexion
        /// On vérifie que les identifiants sont corrects pour pouvoir accéder à la BDD
        /// Si l'authentification est incorrecte, une messageBox s'affiche pour signaler l'alerte
        /// Si les champs ne sont pas tous remplis, une messageBox s'affiche pour signaler l'information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
  
                if (!txtIdentifiant.Text.Equals("") && !txtPassword.Text.Equals(""))
                {
                    if (!controle.Authentification(txtIdentifiant.Text, txtPassword.Text))
                    {
                        MessageBox.Show("Authentification incorrecte", "Alerte");
                        txtIdentifiant.Text = "";
                        txtPassword.Text = "";
                        txtIdentifiant.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            
        }

        /// <summary>
        /// Affichage du mdp si la case est cochée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPassword_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
  
}

