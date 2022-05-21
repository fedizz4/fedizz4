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
        /// Initialisation de l'interface graphique
        /// Récupération du controleur 
        /// </summary>
        /// <param name="controle"></param>
        public frmGestionPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

    }
}
