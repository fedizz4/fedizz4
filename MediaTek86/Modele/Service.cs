namespace MediaTek86.Modele
{
    /// <summary>
    /// Création de la classe métier correspondant aux Services
    /// Utilisation des fonctions getter pour l'idservice et le nom du service
    /// </summary>
    public class Service
    {
        private int IDSERVICE;
        private string NOM;

        public int Idservice { get => IDSERVICE; }
        public string Nom { get => NOM; }

        /// <summary>
        /// Appel du construction pour accéder à la table des services et remplir la cboServices
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.IDSERVICE = idservice;
            this.NOM = nom;
        }

        /// <summary>
        /// On souhaite afficher le nom du service, c'est plus clair que d'afficher l'id du service
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.NOM;
        }

    }
}
