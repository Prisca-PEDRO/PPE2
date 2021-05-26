using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ppe
{
    public partial class FormPrestaAdmin : Form
    {
        public FormPrestaAdmin(String S)
        {
            InitializeComponent();
            labPseudo.Text = S;
        }

        private void btDeco_Click_1(object sender, EventArgs e)
        {
            bool etatD = Orm.Deconnexion();
            if (etatD)
            {
                this.Close();
                FormAccueil Frm = new FormAccueil();
                Frm.Show();
            }
        }
        private void Remplir()
        {
            List<Prestation> lp = Orm.AfficherPrestaion();
            lbPresta.Items.AddRange(lp.ToArray());
            foreach (Prestation p in lp)
            {
                cbCodePresta.Items.Add(p.GetCodeP());
            }
        }
        private void refresh()
        {
            lbPresta.Items.Clear();
            cbCodePresta.Items.Clear();
            Remplir();
        }
        private void btRetour_Click(object sender, EventArgs e)
        {
            string pseudo = labPseudo.Text;
            this.Hide();
            FormAdmin Admin = new FormAdmin(pseudo);
            Admin.Show();
        }

        private void FormPresta_Load(object sender, EventArgs e)
        {
            Remplir();
        }
        private void btAjoutPresta_Click(object sender, EventArgs e)
        {
            string codepresta = Convert.ToString(tbCodePresta.Text);
            string nompresta = Convert.ToString(tbNomPresta.Text);
            int nbreplaces = Convert.ToInt32(numNbrePlaces.Value);
            int tarifpresta = Convert.ToInt32(numTarifPresta.Value);
            DateTime datecreation = DateTime.Now;
            DateTime datevalidite = Convert.ToDateTime(dtValidité.Value);
            int agelimite = Convert.ToInt32(numAgeLimite.Value);
            string descripresta = Convert.ToString(rtbDescriptionPresta.Text);
            string commentpresta = Convert.ToString(rtbCommentairePresta.Text);
            if (Orm.AjouterPrestation(codepresta,nompresta,nbreplaces,tarifpresta,datecreation,datevalidite,agelimite,descripresta,commentpresta))
                MessageBox.Show("Reussi");
            else
                MessageBox.Show("Erreur");
            refresh();
        }

        private void btModifPresta_Click(object sender, EventArgs e)
        {
            string codepresta = Convert.ToString(tbCodePresta.Text);
            string anciencodepresta = Convert.ToString(cbCodePresta.SelectedItem);
            string nompresta = Convert.ToString(tbNomPresta.Text);
            int nbreplaces = Convert.ToInt32(numNbrePlaces.Value);
            int tarifpresta = Convert.ToInt32(numTarifPresta.Value);
            DateTime datecreation = DateTime.Now;
            DateTime datevalidite = Convert.ToDateTime(dtValidité.Value);
            int agelimite = Convert.ToInt32(numAgeLimite.Value);
            string descripresta = Convert.ToString(rtbDescriptionPresta.Text);
            string commentpresta = Convert.ToString(rtbCommentairePresta.Text);
            if (Orm.ModifierPrestation(codepresta, anciencodepresta, nompresta, nbreplaces, tarifpresta, datecreation, datevalidite, agelimite, descripresta, commentpresta))
                MessageBox.Show("Reussi");
            else
                MessageBox.Show("Erreur");
            refresh();
        }

        private void btSuppPresta_Click(object sender, EventArgs e)
        {
            Prestation p = (Prestation)lbPresta.SelectedItem;
            string AncienCodePresta = p.GetCodeP();
            if (Orm.SupprimerPresta(AncienCodePresta))
                MessageBox.Show("Reussi");
            else
                MessageBox.Show("Erreur");
            refresh();
        }
    }
}
