using System;

namespace MediaTek86.Modele
{
    /// <summary>
    /// Création de la classe métier pour la table des Absences
    /// Utilisation des fonctions getter pour les colonnes contenues dans la table Absences
    /// </summary>
    public class Absence
    {
        private DateTime datedebut;
        private DateTime datefin;
        private int idpersonnel;
        private int idmotif;
        private string motif;


        public DateTime Datedebut { get => datedebut.Date; }
        public DateTime Datefin { get => datefin.Date; }
        public int Idpersonnel { get => idpersonnel; }
        public int Idmotif { get => idmotif; }
        public string Motif { get => motif; }


        /// <summary>
        /// Constructeur : Valorise les propriétés
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idpersonnel"></param>
        /// <param name="idmotif"></param>
        /// <param name="motif"></param>
        public Absence(DateTime datedebut, DateTime datefin, int idpersonnel, int idmotif, string motif)
        {
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idpersonnel = idpersonnel;
            this.idmotif = idmotif;
            this.motif = motif;
        }

    }
}
