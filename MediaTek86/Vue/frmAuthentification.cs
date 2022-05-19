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

namespace MediaTek86.Vue
{
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
    }
   
}

