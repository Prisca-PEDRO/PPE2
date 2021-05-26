namespace Ppe
{
    partial class FormInscriptionSeance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDeco = new System.Windows.Forms.Button();
            this.lbPseudoo = new System.Windows.Forms.Label();
            this.btRetour = new System.Windows.Forms.Button();
            this.btMinscrire = new System.Windows.Forms.Button();
            this.btDesinscrire = new System.Windows.Forms.Button();
            this.lbseance = new System.Windows.Forms.ListBox();
            this.numJoueurs = new System.Windows.Forms.NumericUpDown();
            this.lbSeanceInscri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numJoueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btDeco
            // 
            this.btDeco.Location = new System.Drawing.Point(17, 45);
            this.btDeco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeco.Name = "btDeco";
            this.btDeco.Size = new System.Drawing.Size(141, 38);
            this.btDeco.TabIndex = 2;
            this.btDeco.Text = "Deconnexion";
            this.btDeco.UseVisualStyleBackColor = true;
            this.btDeco.Click += new System.EventHandler(this.btDeco_Click);
            // 
            // lbPseudoo
            // 
            this.lbPseudoo.AutoSize = true;
            this.lbPseudoo.Location = new System.Drawing.Point(17, 15);
            this.lbPseudoo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPseudoo.Name = "lbPseudoo";
            this.lbPseudoo.Size = new System.Drawing.Size(59, 25);
            this.lbPseudoo.TabIndex = 3;
            this.lbPseudoo.Text = "label1";
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(1006, 45);
            this.btRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(107, 38);
            this.btRetour.TabIndex = 4;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btMinscrire
            // 
            this.btMinscrire.Location = new System.Drawing.Point(257, 368);
            this.btMinscrire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMinscrire.Name = "btMinscrire";
            this.btMinscrire.Size = new System.Drawing.Size(114, 38);
            this.btMinscrire.TabIndex = 5;
            this.btMinscrire.Text = "M\'inscrire";
            this.btMinscrire.UseVisualStyleBackColor = true;
            this.btMinscrire.Click += new System.EventHandler(this.btMinscrire_Click);
            // 
            // btDesinscrire
            // 
            this.btDesinscrire.Location = new System.Drawing.Point(754, 368);
            this.btDesinscrire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDesinscrire.Name = "btDesinscrire";
            this.btDesinscrire.Size = new System.Drawing.Size(187, 38);
            this.btDesinscrire.TabIndex = 6;
            this.btDesinscrire.Text = "Me désisncrire";
            this.btDesinscrire.UseVisualStyleBackColor = true;
            this.btDesinscrire.Click += new System.EventHandler(this.btDesinscrire_Click);
            // 
            // lbseance
            // 
            this.lbseance.FormattingEnabled = true;
            this.lbseance.ItemHeight = 25;
            this.lbseance.Location = new System.Drawing.Point(17, 109);
            this.lbseance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbseance.Name = "lbseance";
            this.lbseance.Size = new System.Drawing.Size(1281, 179);
            this.lbseance.TabIndex = 7;
            // 
            // numJoueurs
            // 
            this.numJoueurs.Location = new System.Drawing.Point(480, 368);
            this.numJoueurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numJoueurs.Name = "numJoueurs";
            this.numJoueurs.Size = new System.Drawing.Size(171, 31);
            this.numJoueurs.TabIndex = 8;
            // 
            // lbSeanceInscri
            // 
            this.lbSeanceInscri.FormattingEnabled = true;
            this.lbSeanceInscri.ItemHeight = 25;
            this.lbSeanceInscri.Location = new System.Drawing.Point(17, 497);
            this.lbSeanceInscri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSeanceInscri.Name = "lbSeanceInscri";
            this.lbSeanceInscri.Size = new System.Drawing.Size(1281, 179);
            this.lbSeanceInscri.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de joueurs :";
            // 
            // FormInscriptionSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSeanceInscri);
            this.Controls.Add(this.numJoueurs);
            this.Controls.Add(this.lbseance);
            this.Controls.Add(this.btDesinscrire);
            this.Controls.Add(this.btMinscrire);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lbPseudoo);
            this.Controls.Add(this.btDeco);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormInscriptionSeance";
            this.Text = "FormInscriptionSeance";
            this.Load += new System.EventHandler(this.FormInscriptionSeance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numJoueurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeco;
        private System.Windows.Forms.Label lbPseudoo;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btMinscrire;
        private System.Windows.Forms.Button btDesinscrire;
        private System.Windows.Forms.ListBox lbseance;
        private System.Windows.Forms.NumericUpDown numJoueurs;
        private System.Windows.Forms.ListBox lbSeanceInscri;
        private System.Windows.Forms.Label label1;
    }
}