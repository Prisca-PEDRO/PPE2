using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ppe
{
    public partial class FormInscriptionSeance : Form
    {
        public FormInscriptionSeance(String S)
        {
            InitializeComponent();
            lbPseudoo.Text = S;
        }
        private void remplir()
        {
            List<Seance> ls = Orm.AfficherSeance();
            lbseance.Items.AddRange(ls.ToArray());
            List<Inscription> li = Orm.AfficherInscri(lbPseudoo.Text);
            lbSeanceInscri.Items.AddRange(li.ToArray());
        }
        private void refresh()
        {
            lbSeanceInscri.Items.Clear();
            lbseance.Items.Clear();
            remplir();
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

        private void btRetour_Click(object sender, EventArgs e)
        {
            string pseudo = lbPseudoo.Text;
            this.Hide();
            if (Orm.Admin(pseudo))
            {
                FormAdmin Admin = new FormAdmin(pseudo);
                Admin.Show();
            }
            else
            {
                FormUser User = new FormUser(pseudo);
                User.Show();
            }
        }

        private void FormInscriptionSeance_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void btMinscrire_Click(object sender, EventArgs e)
        {
            Seance S = (Seance)lbseance.SelectedItem;
            string codepresta = S.GetCodePresta();
            DateTime dateseance = S.GetdateSeance();
            string pseudo = lbPseudoo.Text;
            DateTime dateinscription = DateTime.Now;
            int nbrejoueurs = Convert.ToInt32(numJoueurs.Value);
            if (Orm.ExistInscri(codepresta, dateseance, pseudo) == false)
            {
                if (Orm.PossibiliteInscri(codepresta, dateseance, nbrejoueurs) == true)
                {
                    if (Orm.Minscrire(codepresta, dateseance, pseudo, dateinscription, nbrejoueurs))
                    {
                        MessageBox.Show("Réussi");
                        Orm.UpdateNbPlaces(codepresta, dateseance, nbrejoueurs);
                    }
                    else
                        MessageBox.Show("Erreur");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Plus assez de places disponibles");
                }
            }
            else
            {
                MessageBox.Show("Tu es déjà inscrit");
            }
        }

        private void btDesinscrire_Click(object sender, EventArgs e)
        {
            Inscription i = (Inscription)lbSeanceInscri.SelectedItem;
            string codepresta = i.GetCodePresta();
            DateTime dateseance = i.GetDateSeance();
            string pseudo = i.GetPseudo();
            int nbjoueurs = i.GetNbreJoueurs();
            if (Orm.SeDesinscrire(codepresta, dateseance, pseudo))
            {
                MessageBox.Show("Réussi");
                Orm.RajoutNbPlaces(codepresta, dateseance, nbjoueurs);
            }
            else
                MessageBox.Show("Erreur");
                refresh();
            }
        }
    } 

