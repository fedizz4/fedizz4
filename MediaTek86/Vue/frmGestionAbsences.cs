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
    public partial class frmGestionAbsences : Form
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
        ///Création des objets pour gérer les listes
        /// </summary>
        BindingSource bdgAbsences = new BindingSource();
        BindingSource bdgPersonnels = new BindingSource();
        BindingSource bdgMotifs = new BindingSource();
        ///<summary>
        ///Initialisation des composants graphiques
        /// </summary>
        /// <param name="controle"></param>
        public frmGestionAbsences(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }
        private void Init()
        {
            RemplirDGVAbsences();
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        public void RemplirDGVAbsences()
        {
            List<Absence> lesAbsences = controle.GetLesAbsences();
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = true;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

    }


}
