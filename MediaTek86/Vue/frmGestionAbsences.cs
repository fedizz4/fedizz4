using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.Controleur;
using MediaTek86.Dal;
using MediaTek86.Modele;

namespace MediaTek86.Vue
{
    /// <summary>
    /// Fonctionnalités de la fenêtre de gestion des absences
    /// </summary>
    public partial class frmGestionAbsences : Form
    {
        /// <summary>
        /// Instance du Controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation de la variable idpersonnel
        /// Utile lors de la récupération de l'id du personnel sélectionné
        /// Pour la liaison des données d'une Form à une autre Form
        /// </summary>
        int idpersonnel;

        /// <summary>
        /// Création des objets pour gérer les listes
        /// </summary>
        BindingSource bdgAbsences = new BindingSource();
        BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques, ajout des paramètres nom et prenom
        /// Affichage dans les zones de texte de la frmGestionAbsences
        /// Liaison des données des txtBox "nom/prenom" de FormPersonnel vers FormAbsences
        /// </summary>
        /// <param name="controle"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public frmGestionAbsences(Controle controle, string nom, string prenom)
        {
            InitializeComponent();
            this.controle = controle;

            // Récupération de l'id du personnel sélectionné à l'aide du nom et prénom
            int idpersonnel = AccesDonnees.recupererIdPersonnel(nom, prenom);
            this.idpersonnel = idpersonnel;
            txtNom.Text = nom;
            txtPrenom.Text = prenom;

            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes d'absences et des motifs
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
        /// Affiche les informations de l'absence sélectionnée dans les zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dgvAbsences_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Récupération de l'id du personnel sélectionné à l'aide du nom et prénom
            List<Absence> lesAbsences = controle.GetLesAbsences(idpersonnel);
            DataGridViewRow row = dgvAbsences.CurrentRow;
            dtpDebut.Value = (DateTime)row.Cells["Datedebut"].Value;
            dtpFin.Value = (DateTime)row.Cells["Datefin"].Value;
            cboMotifs.Text = row.Cells["Motif"].Value.ToString();
        }

        /// <summary>
        /// Affiche les motifs des absences dans la cboMotifs
        /// </summary>
        public void RemplirCboMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotifs.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Vide les zones de saisie
        /// </summary>
        private void Vider()
        {
            dtpDebut.Text = "";
            dtpFin.Text = "";
            cboMotifs.SelectedIndex = -1;
            dgvAbsences.ClearSelection();
            txtNom.Focus();
        }

        /// <summary>
        /// Vide les champs lors du clic_bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVider_Click(object sender, EventArgs e)
        {
            Vider();
        }

        /// <summary>
        /// Ajoute une absence au personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterAbs_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !dtpDebut.Value.Equals("") && !dtpFin.Value.Equals("") && cboMotifs.SelectedIndex != -1)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                Absence absence = new Absence(dtpDebut.Value, dtpFin.Value, idpersonnel, motif.Idmotif, cboMotifs.Text);
                if (MessageBox.Show("Voulez-vous ajouter l'absence du " + dtpDebut.Value+ " au " + dtpFin.Value + " ?", "Confirmation d'ajout de l'absence.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.AjouterAbsence(absence, idpersonnel);
                    RemplirDGVAbsences(idpersonnel);
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Alerte");
            }
        }

        /// <summary>
        /// Supprime l'absence du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                /// <summary>
                /// Confirmation de suppression de l'absence du personnel 
                /// </summary>
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du " + absence.Datedebut.ToShortDateString() + " au " + absence.Datefin.ToShortDateString() + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.SupprimerAbsence(absence, idpersonnel);
                    RemplirDGVAbsences(idpersonnel);
                }
            }
            else
            {   
                // Selection obligatoire d'une ligne de la datagrid
                MessageBox.Show("Une ligne doit être sélectionnée.", "Alerte");
            }
        }

        /// <summary>
        /// Modifie une absence sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                // Récupération des données de l'absence sélectionnée
                // On doit stocker les données dans une variable "absInitiale"
                Absence absInitiale = new Absence((DateTime)dgvAbsences.CurrentRow.Cells["Datedebut"].Value,
                                                 (DateTime)dgvAbsences.CurrentRow.Cells["Datefin"].Value,
                                                 idpersonnel,
                                                 (int)dgvAbsences.CurrentRow.Cells["Idmotif"].Value,
                                                 (string)dgvAbsences.CurrentRow.Cells["Motif"].Value);
                // Stockage de la saisie des modifications demandées dans une variable "absUpdate"
                Absence absUpdate= new Absence(dtpDebut.Value, dtpFin.Value, idpersonnel, motif.Idmotif, motif.Libelle);

                if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !dtpDebut.Value.Equals("") && !dtpFin.Value.Equals("") && cboMotifs.SelectedIndex != -1)
                {
                    // Date de début de l'absence doit être inférieure à la date de fin de l'absence
                    // Sinon on repart dans la zone de saisie des absences
                    if (dtpFin.Value < dtpDebut.Value)
                    {
                        MessageBox.Show("La date de fin de l'absence ne peut pas être inférieure à la date de début de l'absence.", "Alerte");
                        return;
                    }
                    // Confirmation des modifications de l'absence sélectionnée
                    if (MessageBox.Show("Voulez-vous modifier les informations concernant cette absence ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Supprimer l'absence initiale une fois qu'elle a été modifiée, sinon elle apparaît toujours dans la base
                        controle.SupprimerAbsence(absInitiale, idpersonnel);
                        // Ajout de l'absence modifiée
                        controle.AjouterAbsence(absUpdate, idpersonnel);
                        // Si on n'ajoute pas l'absence modifiée, on remet l'absence initiale 
                        int retourAbsInitiale = dgvAbsences.Rows.Count;
                        RemplirDGVAbsences(idpersonnel);
                        MessageBox.Show("L'absence a bien été modifiée.", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Alerte");
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Alerte");
            }
        }

        /// <summary>
        /// Masque la fenêtre de gestion des absences
        /// Affichage de la fenêtre de gestion du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            (this).Hide();
            controle.Retour();
        }
    }
}
