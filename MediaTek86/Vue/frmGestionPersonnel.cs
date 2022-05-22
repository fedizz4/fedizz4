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
        /// <summary>
        /// Création d'un booleen pour créer les méthodes ajouter/modifier/supprimer
        /// </summary>
        private Boolean afficher;

        ///<summary>
        ///Création des objets bindingSource
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();
        BindingSource bdgService = new BindingSource();

        /// <summary>
        /// Initialisation de l'interface graphique
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
        /// Initialisation de la datagrid remplie
        /// </summary>
        private void Init()
        {
            AfficherDGVPersonnels();
            RemplirCboServices();
            Vider();

        }

        /// <summary>
        /// Méthode pour afficher la liste des personnels dans la datagrid "Personnel"
        /// </summary>
        private void AfficherDGVPersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();//Appel des fonctions du controleur
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;//On cache l'id du personnel et du service car c'est pas utile pour l'utilisateur de voir les numéros
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
        private void dgvPersonnels_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPersonnel.CurrentRow;
            txtNom.Text = row.Cells["Nom"].Value.ToString();
            txtPrenom.Text = row.Cells["Prenom"].Value.ToString();
            txtTel.Text = row.Cells["Tel"].Value.ToString();
            txtMail.Text = row.Cells["Mail"].Value.ToString();
            cboServices.Text = row.Cells["Service"].Value.ToString();
        }

        /// <summary>
        /// Procédure évènementielle ajout d'un personnel
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
                MessageBox.Show("Le personnel a été ajouté avec succès.", "Information");
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
                    personnel = new Personnel(personnel.Idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);

                if (MessageBox.Show("Voulez-vous modifier les informations de ce personnel ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                if (MessageBox.Show("Voulez-vous supprimer" + personnel.Nom + "" + personnel.Prenom + "?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
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

        private void btnAbsences_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Vider les champs
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
