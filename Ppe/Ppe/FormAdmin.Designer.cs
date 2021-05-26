namespace Ppe
{
    partial class FormAdmin
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
            this.btSeance = new System.Windows.Forms.Button();
            this.btPresta = new System.Windows.Forms.Button();
            this.btInscription = new System.Windows.Forms.Button();
            this.btDeco = new System.Windows.Forms.Button();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSeance
            // 
            this.btSeance.Location = new System.Drawing.Point(169, 370);
            this.btSeance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSeance.Name = "btSeance";
            this.btSeance.Size = new System.Drawing.Size(126, 68);
            this.btSeance.TabIndex = 4;
            this.btSeance.Text = "Gérer les activités";
            this.btSeance.UseVisualStyleBackColor = true;
            this.btSeance.Click += new System.EventHandler(this.btSeance_Click);
            // 
            // btPresta
            // 
            this.btPresta.Location = new System.Drawing.Point(170, 245);
            this.btPresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPresta.Name = "btPresta";
            this.btPresta.Size = new System.Drawing.Size(124, 68);
            this.btPresta.TabIndex = 5;
            this.btPresta.Text = "Gérer les prestations";
            this.btPresta.UseVisualStyleBackColor = true;
            this.btPresta.Click += new System.EventHandler(this.btPresta_Click);
            // 
            // btInscription
            // 
            this.btInscription.Location = new System.Drawing.Point(169, 493);
            this.btInscription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btInscription.Name = "btInscription";
            this.btInscription.Size = new System.Drawing.Size(126, 68);
            this.btInscription.TabIndex = 6;
            this.btInscription.Text = "Inscription";
            this.btInscription.UseVisualStyleBackColor = true;
            this.btInscription.Click += new System.EventHandler(this.btInscription_Click);
            // 
            // btDeco
            // 
            this.btDeco.Location = new System.Drawing.Point(30, 62);
            this.btDeco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeco.Name = "btDeco";
            this.btDeco.Size = new System.Drawing.Size(141, 38);
            this.btDeco.TabIndex = 2;
            this.btDeco.Text = "Deconnexion";
            this.btDeco.UseVisualStyleBackColor = true;
            this.btDeco.Click += new System.EventHandler(this.btDeco_Click);
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Location = new System.Drawing.Point(30, 32);
            this.lbPseudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(59, 25);
            this.lbPseudo.TabIndex = 3;
            this.lbPseudo.Text = "label1";
            this.lbPseudo.Click += new System.EventHandler(this.lbPseudo_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 750);
            this.Controls.Add(this.btInscription);
            this.Controls.Add(this.btPresta);
            this.Controls.Add(this.btSeance);
            this.Controls.Add(this.lbPseudo);
            this.Controls.Add(this.btDeco);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdmin";
            this.Text = "Administateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSeance;
        private System.Windows.Forms.Button btPresta;
        private System.Windows.Forms.Button btInscription;
        private System.Windows.Forms.Button btDeco;
        private System.Windows.Forms.Label lbPseudo;
    }
}