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
        ///Création des objets bindingSource
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();

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
        public void Init()
        {
            AfficherDGVPersonnels();
        }

        /// <summary>
        /// Méthode pour afficher la liste des personnels dans la datagrid "Personnel"
        /// </summary>
        public void AfficherDGVPersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();//Appel des fonctions du controleur
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;//On cache l'id du personnel et du service car c'est pas utile pour l'utilisateur de voir les numéros
            dgvPersonnel.Columns["idservice"].Visible = true;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

    }
}
