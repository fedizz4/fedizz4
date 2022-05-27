using System;
using System.Windows.Forms;
using MediaTek86.Controleur;

namespace MediaTek86
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Controle(); 
     
        }
    }
}
