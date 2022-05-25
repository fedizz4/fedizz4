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
using MySql.Data.MySqlClient;
using MediaTek86.Dal;
using MediaTek86.Modele;

namespace MediaTek86.Vue
{
    /// <summary>
    /// /// Fenêtre de gestion du personnel
    /// /// </summary>
    public partial class frmGestionPersonnel : Form
    {
        ///<summary>
        ///instance du Controleur
        /// </summary>
        private Controle controle;

        ///<summary>
        ///Création des objets pour gérer les listes
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();
        BindingSource bdgService = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur 
        /// </summary>
        /// <param name="controle"></param>
        public frmGestionPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        private void Init()
        {
            AfficherDGVPersonnels();
            RemplirCboServices();
            Vider();

        }

        /// <summary>
        /// Affiche la liste des personnels dans la datagrid "Personnel"
        /// </summary>
        public void AfficherDGVPersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = true;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services dans la cboBox
        /// </summary>
        private void RemplirCboServices()
        {
            ///<summary>
            ///Source de données "GetLesServices()"
            /// </summary>
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            cboServices.DataSource = bdgService;
        }

        /// <summary>
        /// Affiche les informations du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dgvPersonnels_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPersonnel.CurrentRow;
            txtNom.Text = row.Cells["Nom"].Value.ToString();
            txtPrenom.Text = row.Cells["Prenom"].Value.ToString();
            txtTel.Text = row.Cells["Tel"].Value.ToString();
            txtMail.Text = row.Cells["Mail"].Value.ToString();
            cboServices.Text = row.Cells["Service"].Value.ToString();
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboServices.SelectedIndex != -1)
            {
                int idpersonnel = 0;
                Service service = (Service)bdgService.List[bdgService.Position];
                Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);
                controle.AjouterPersonnel(personnel);
                AfficherDGVPersonnels(); 
                MessageBox.Show("Le personnel "+personnel.Nom + " " + personnel.Prenom +" a été ajouté avec succès.", "Information");
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
    
        }
    
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
             {
                    Service service = (Service)bdgService.List[bdgService.Position];
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel = new Personnel(personnel.Idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text,
                        txtMail.Text, service.Idservice, service.Nom);

                if (MessageBox.Show("Voulez-vous modifier les informations de "+personnel.Nom+" " + personnel.Prenom + " ?",
                    "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.ModifierPersonnel(personnel);
                    AfficherDGVPersonnels();
                }
                dgvPersonnel.CurrentCell.Selected = true;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }      
        }
     
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", 
                    "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                {
                    controle.SupprimerPersonnel(personnel);
                    AfficherDGVPersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Masque la fenêtre de gestion du personnel
        /// Affichage de la fenêtre de gestion des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsences_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            controle.Absences(txtNom.Text, txtPrenom.Text);
        }



        /// <summary>
        /// Vider les zones de saisie
        /// </summary>
        private void Vider()
        {
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
                cboServices.SelectedIndex = -1;
                dgvPersonnel.ClearSelection();
                txtNom.Focus();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            Vider();
        }

    }
}
