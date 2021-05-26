namespace Ppe
{
    partial class FormUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btShowPres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Deconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btDeco_Click);
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Location = new System.Drawing.Point(17, 15);
            this.lbPseudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(59, 25);
            this.lbPseudo.TabIndex = 3;
            this.lbPseudo.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 232);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 68);
            this.button2.TabIndex = 6;
            this.button2.Text = "Inscription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btInscription_Click);
            // 
            // btShowPres
            // 
            this.btShowPres.Location = new System.Drawing.Point(33, 232);
            this.btShowPres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btShowPres.Name = "btShowPres";
            this.btShowPres.Size = new System.Drawing.Size(126, 65);
            this.btShowPres.TabIndex = 8;
            this.btShowPres.Text = "Voir les Prestations";
            this.btShowPres.UseVisualStyleBackColor = true;
            this.btShowPres.Click += new System.EventHandler(this.btShowPres_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 465);
            this.Controls.Add(this.btShowPres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbPseudo);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btShowPres;
    }
}