using System;
using System.Collections.Generic;
using System.Text;

namespace Ppe
{
    public class Inscription
    {
        private string codepresta;
        private DateTime dateseance;
        private string pseudo;
        private DateTime dateinscription;
        private int nbrejoueurs;

        public Inscription(string codepresta, DateTime dateseance, string pseudo, DateTime dateinscription, int nbrejoueurs)
        {
            this.codepresta = codepresta;
            this.dateseance = dateseance;
            this.pseudo = pseudo;
            this.dateinscription = dateinscription;
            this.nbrejoueurs = nbrejoueurs;
        }
        public string GetCodePresta()
        {
            return codepresta;
        }
        public DateTime GetDateSeance()
        {
            return dateseance;
        }
        public string GetPseudo()
        {
            return pseudo;
        }
        public DateTime GetDateInscription()
        {
            return dateinscription;
        }
        public int GetNbreJoueurs()
        {
            return nbrejoueurs;
        }
        public override string ToString()
        {
            return "Code Presation : " + codepresta + " Date Seance : " + dateseance.ToShortDateString() + " Nombre Joueurs : " + nbrejoueurs;
        }
    }
}
