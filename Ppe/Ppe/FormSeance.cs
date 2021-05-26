using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ppe
{
    public partial class FormSeance : Form
    {
        public FormSeance(string S)
        {
            InitializeComponent();
            labPseudo.Text = S;
        }
        private void clean()
        {
            tbCodePresta.Clear();
            numPrix.Value = 0;
            numNbrePlaces.Value = 0;
            numTerrain.Value = 0;
            dtSeance.Value = DateTime.Now;
            timeDebut.Value = DateTime.Now;
            timeFin.Value = DateTime.Now;
        }
        private void refresh()
        {
            lbSeance.Items.Clear();
            cbCodePresta.Items.Clear();
            remplir();
        }
        private void remplir()
        {
            List<Seance> ls = Orm.AfficherSeance();
            lbSeance.Items.AddRange(ls.ToArray());
            foreach (Seance S in ls)
            {
                cbCodePresta.Items.Add(S.GetCodePresta());
            }
        }
        private void btDeco_Click_1(object sender, EventArgs e)
        {
            bool etatD = Orm.Deconnexion();
            if (etatD)
            {
                this.Hide();
                FormAccueil Frm = new FormAccueil();
                Frm.Show();
            }
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            string pseudo = labPseudo.Text;
            this.Hide();
            FormAdmin Admin = new FormAdmin(pseudo);
            Admin.Show();
        }

        private void btAjoutSeance_Click(object sender, EventArgs e)
        {
            string CodePresta = Convert.ToString(tbCodePresta.Text);
            DateTime DateSeance = Convert.ToDateTime(dtSeance.Value);
            int Prix = Convert.ToInt32(numPrix.Value);
            DateTime HeureDebut = Convert.ToDateTime(timeDebut.Value);
            DateTime HeureFin = Convert.ToDateTime(timeFin.Value);
            TimeSpan HeureDebuut = TimeSpan.FromTicks(HeureDebut.Ticks);
            TimeSpan HeureFiin = TimeSpan.FromTicks(HeureFin.Ticks);
            int NbrePlaces = Convert.ToInt32(numNbrePlaces.Value);
            int NumTerrain = Convert.ToInt32(numTerrain.Value);
            if (Orm.AjouterSeance(CodePresta, DateSeance, Prix, HeureDebut, HeureFin, NbrePlaces, NumTerrain))
                MessageBox.Show("Reussi");
            else
                MessageBox.Show("Erreur");
            clean();
            refresh();
        }

        private void FormSeance_Load(object sender, EventArgs e)
        {
            remplir();
        }
        private void btModifSeance_Click(object sender, EventArgs e)
        {
            string CodePresta = Convert.ToString(tbCodePresta.Text);
            string AncienCodePresta = Convert.ToString(cbCodePresta.SelectedItem);
            DateTime DateSeance = Convert.ToDateTime(dtSeance.Value);
            int Prix = Convert.ToInt32(numPrix.Value);
            DateTime HeureDebut = Convert.ToDateTime(timeDebut.Value);
            DateTime HeureFin = Convert.ToDateTime(timeFin.Value);
            TimeSpan HeureDebuut = TimeSpan.FromTicks(HeureDebut.Ticks);
            TimeSpan HeureFiin = TimeSpan.FromTicks(HeureFin.Ticks);
            int NbrePlaces = Convert.ToInt32(numNbrePlaces.Value);
            int NumTerrain = Convert.ToInt32(numTerrain.Value);
            if (Orm.ModifierSeance(CodePresta,AncienCodePresta, DateSeance, Prix, HeureDebut, HeureFin, NbrePlaces, NumTerrain))
                MessageBox.Show("Reussi");
            else
                MessageBox.Show("Erreur");
            clean();
            refresh();
        }

        private void btSuppSeance_Click(object sender, EventArgs e)
        {
            /* string AncienCodePresta = Convert.ToString(cbCodePresta.SelectedItem);
             DateTime DateSeance = Convert.ToDateTime(dtSeance.Value);*/
            Seance S = (Seance) lbSeance.SelectedItem;
            string AncienCodePresta = S.GetCodePresta();
            DateTime DateSeance = S.GetdateSeance();
            if (Orm.SupprimerSeance(AncienCodePresta, DateSeance))
                MessageBox.Show("Reussi");
            else
                MessageBox.Show("Erreur");
            refresh();
        }
    }
}
