using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.Vue;

namespace MediaTek86.Controleur
{
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
    }
}
