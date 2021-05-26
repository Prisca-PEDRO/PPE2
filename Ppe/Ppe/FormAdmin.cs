using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ppe
{
    public partial class FormAdmin : Form
    {
        public FormAdmin(String S)
        {
            InitializeComponent();
            lbPseudo.Text = S;
        }

        private void btPresta_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                string s = lbPseudo.Text;
                FormPrestaAdmin presta = new FormPrestaAdmin(s);
                presta.Show();
            }
        }   
            private void btSeance_Click(object sender, EventArgs e)
            {
            this.Hide();
            string s = lbPseudo.Text;
            FormSeance seance = new FormSeance(s);
            seance.Show();
            }

            private void btInscription_Click(object sender, EventArgs e)
            {
            this.Hide();
            string s = lbPseudo.Text;
            FormInscriptionSeance inscri = new FormInscriptionSeance(s);
            inscri.Show();
            }

        private void btDeco_Click(object sender, EventArgs e)
        {
            bool etatD = Orm.Deconnexion();
            if (etatD)
            {
                this.Close();
                FormAccueil Frm = new FormAccueil();
                Frm.Show();
            }
        }

        private void lbPseudo_Click(object sender, EventArgs e)
        {

        }
    }
    }