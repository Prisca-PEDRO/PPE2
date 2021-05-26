using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ppe
{
    public partial class FormInscri : Form
    {
        public FormInscri()
        {
            InitializeComponent();
        }

        private void btValidInscr_Click(object sender, EventArgs e)
        {
            string pseudo = Convert.ToString(tbPseudoInscri.Text);
            string nom = Convert.ToString(tbNomInscri.Text);
            string prenom = Convert.ToString(tbPrenomInscrit.Text);
            string mdp = Convert.ToString(tbMdpInscri.Text);
            string adr = Convert.ToString(tbAdrMail.Text);
            long num = Convert.ToInt64(tbTelInscrit.Text);
            DateTime datenaissance = Convert.ToDateTime(dtPickNaissance.Value);
            DateTime dateInscri = DateTime.Now;
            DateTime datefin = dateInscri.AddYears(1);
            string type = "User";
            Orm.Inscription(pseudo, nom, prenom, adr, (int) num, datenaissance, datefin, mdp, type);
            bool result = Orm.Inscription(pseudo, nom, prenom, adr, (int)num, datenaissance, datefin, mdp, type);
            string message = "";
            if (result == false)
                message = "Erreur lors de l'inscription";
            else
                MessageBox.Show("Vous êtes inscrit");
            MessageBox.Show(message);
            this.Hide();
            FormAccueil fr = new FormAccueil();
            fr.Show();
        }
    }
}
