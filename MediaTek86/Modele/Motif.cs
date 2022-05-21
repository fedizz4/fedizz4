namespace MediaTek86.Modele
{
    /// <summary>
    /// Création de la classe métier correspondant aux Motifs des absences
    /// Utilisation des fonctions Getter pour l'IdMotif et le libelle
    /// </summary>
    public class Motif
    {

        private int idmotif;
        private string libelle;

        public int Idmotif { get => idmotif; }
        public string Libelle { get => libelle; }

        /// <summary>
        /// Appel du constructeur pour accéder à la table des Motifs et remplir la cboMotifs
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// On souhaite afficher le libelle du motif
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
