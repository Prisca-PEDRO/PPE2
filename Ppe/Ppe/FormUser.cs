using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ppe
{
    public partial class FormUser : Form
    {
        public FormUser(string S)
        {
            InitializeComponent();
            lbPseudo.Text = S;
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

        private void btInscription_Click(object sender, EventArgs e)
        {
            this.Hide();
            string s = lbPseudo.Text;
            FormInscriptionSeance inscri = new FormInscriptionSeance(s);
            inscri.Show();
        }

        private void btShowPres_Click(object sender, EventArgs e)
        {
            this.Hide();
            string s = lbPseudo.Text;
            FormPresta presta = new FormPresta(s);
            presta.Show();
        }
    }
}
