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
    /// Fenêtre de gestion des absences
    /// </summary>
    public partial class frmGestionAbsences : Form
    {
        ///<summary>
        ///instance du Controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation de la variable idpersonnel
        /// </summary>
        int idpersonnel;

        ///<summary>
        ///Création des objets pour gérer les listes
        /// </summary>
        BindingSource bdgAbsences = new BindingSource();
        BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques, ajout des paramètres nom et prenom
        /// Affichage dans les zones de texte de la frmGestionAbsences
        /// </summary>
        /// <param name="controle"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public frmGestionAbsences(Controle controle, string nom, string prenom)
        {
            InitializeComponent();
            this.controle = controle;

            /// <summary>
            /// Récupération de l'id du personnel sélectionné à l'aide du nom et prénom
            /// </summary>
            int idpersonnel = AccesDonnees.recupererIdPersonnel(nom, prenom);
            this.idpersonnel = idpersonnel;
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        private void Init()
        {
            controle.GetLesAbsences(idpersonnel);
            RemplirDGVAbsences(idpersonnel);
            RemplirCboMotifs();
        }

        /// <summary>
        /// Affiche la grille des absences
        /// </summary>
        public void RemplirDGVAbsences(int idpersonnel)
        {
            List<Absence> lesAbsences = controle.GetLesAbsences(idpersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = true;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        /// <summary>
        /// Affiche les motifs 
        /// </summary>
        public void RemplirCboMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotifs.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Vider les zones de saisie
        /// </summary>
        private void Vider()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            dtpDebut.Text = "";
            dtpFin.Text = "";
            cboMotifs.SelectedIndex = -1;
            dgvAbsences.ClearSelection();
            txtNom.Focus();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            Vider();
        }
    }

}
