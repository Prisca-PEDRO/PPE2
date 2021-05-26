using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ppe
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                Orm.Connexion();
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            string pseudo = Convert.ToString(tbId.Text);
            string mdp = Convert.ToString(tbMdp.Text);
            if (Orm.Existance(pseudo,mdp))
            {
                if (Orm.Connexion() && Orm.Admin(pseudo))
                {    
                    this.Hide();
                    FormAdmin Admin = new FormAdmin(pseudo);
                    Admin.Show();
                }
                if (Orm.Connexion() && !Orm.Admin(pseudo))
                {
                    this.Hide();
                    FormUser User = new FormUser(pseudo);
                    User.Show();
                }
            }
            else {
                MessageBox.Show("Utilisateur inconnu");
            }
        }

        private void btInscri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInscri Inscri = new FormInscri();
            Inscri.Show();
        }
    }
}
