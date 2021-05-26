using System;
using System.Collections.Generic;
using System.Text;

namespace Ppe
{
    public class Compte
    {
        private string pseudo;
        private string nomCompte;
        private string prenomCompte;
        private string adrCompte;
        private int numTelCompte;
        private DateTime dateNaissance;
        private DateTime dateInscription;
        private string mdpCompte;

        public Compte(string pseudo, string nomCompte, string prenomCompte, string adrCompte, int numTelCompte, DateTime dateNaissance, DateTime dateInscription, string mdpCompte)
        {
            this.pseudo = pseudo;
            this.nomCompte = nomCompte;
            this.prenomCompte = prenomCompte;
            this.adrCompte = adrCompte;
            this.numTelCompte = numTelCompte;
            this.dateNaissance = dateNaissance;
            this.dateInscription = dateInscription;
            this.mdpCompte = mdpCompte;
        }
        public Compte()
        {
            this.pseudo = "Pseudo";
            this.nomCompte = "NomCompte";
            this.prenomCompte = "PrenomCompte";
            this.adrCompte = "AdresseCompte";
            this.numTelCompte = 0784989865;
            this.dateNaissance =  new DateTime(1905,5,10);
            this.dateInscription = DateTime.Today;
            this.mdpCompte = "MdpCompte";
        }

        public string GetPseudo()
        {
            return pseudo;
        }
        public void SetPseudo(string pseudo)
        {
            this.pseudo = pseudo;
        }
        public string GetnomCompte()
        {
            return nomCompte;
        }
        public void SetNomCompte(string nomCompte)
        {
            this.nomCompte = nomCompte;
        }
        public string GetprenomCompte()
        {
            return prenomCompte;
        }
        public void SetPrenomCompte(string prenomCompte)
        {
            this.prenomCompte = prenomCompte;
        }
        public string GetadrCompte()
        {
            return adrCompte;
        }
        public void SetadrCompte(string adrCompte)
        {
            this.adrCompte = adrCompte ;
        }
        public int GetnumTelCompte()
        {
            return numTelCompte;
        }
        public void SetnumTelCompte(int numTelCompte)
        {
            this.numTelCompte = numTelCompte ;
        }
        public DateTime GetdateNaissance()
        {
            return dateNaissance;
        }
        public void SetDateNaissance(DateTime DateNaissance)
        {
            this.dateNaissance = DateNaissance;
        }
        public DateTime GetdateInscription()
        {
            return dateInscription;
        }
        public void SetPseudo(DateTime dateInscription)
        {
            this.dateInscription = dateInscription;
        }
        public string GetMdpCompte()
        {
            return mdpCompte;
        }
        public void SetMdpCompte(string MdpCompte)
        {
            this.mdpCompte = MdpCompte;
        }
        public override string ToString()
        {
            return "Test" + pseudo;
        }
    }
}
