namespace MediaTek86.Modele
{
    /// <summary>
    /// Création de la classe métier pour la table Personnel
    /// Génération des Getters pour les colonnes de la table Personnel
    /// </summary>
    public class Personnel
    {

        private int IDPERSONNEL;
        private string NOM;
        private string PRENOM;
        private string TEL;
        private string MAIL;
        private int IDSERVICE;
        private string SERVICE;

        public int Idpersonnel { get => IDPERSONNEL; }
        public string Nom { get => NOM; }
        public string Prenom { get => PRENOM; }
        public string Tel { get => TEL; }
        public string Mail { get => MAIL; }
        public int Idservice { get => IDSERVICE; }
        public string Service { get => SERVICE; }


        /// <summary>
        /// Appel du constructeur pour accéder à la table Personel et la remplir 
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice, string service)
        {
            this.IDPERSONNEL = idpersonnel;
            this.NOM = nom;
            this.PRENOM = prenom;
            this.TEL = tel;
            this.MAIL = mail;
            this.IDSERVICE = idservice;
            this.SERVICE = service;
        }


    }

}
