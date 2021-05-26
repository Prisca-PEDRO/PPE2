using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ppe
{
    public partial class FormPresta : Form
    {
        public FormPresta(String S)
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
        }
        private void btRetour_Click(object sender, EventArgs e)
        {
            string pseudo = labPseudo.Text;
            this.Hide();
            FormUser user = new FormUser(pseudo);
            user.Show();
        }

        private void FormPresta_Load(object sender, EventArgs e)
        {
            Remplir();
        }
    }
}
