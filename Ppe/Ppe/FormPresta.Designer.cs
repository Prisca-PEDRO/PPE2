namespace Ppe
{
    partial class FormPresta
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
            this.lbPresta = new System.Windows.Forms.ListBox();
            this.btRetour = new System.Windows.Forms.Button();
            this.btDeco = new System.Windows.Forms.Button();
            this.labPseudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPresta
            // 
            this.lbPresta.FormattingEnabled = true;
            this.lbPresta.HorizontalScrollbar = true;
            this.lbPresta.ItemHeight = 15;
            this.lbPresta.Location = new System.Drawing.Point(12, 62);
            this.lbPresta.Name = "lbPresta";
            this.lbPresta.Size = new System.Drawing.Size(763, 109);
            this.lbPresta.TabIndex = 20;
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(700, 5);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 4;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btDeco
            // 
            this.btDeco.Location = new System.Drawing.Point(12, 21);
            this.btDeco.Name = "btDeco";
            this.btDeco.Size = new System.Drawing.Size(99, 26);
            this.btDeco.TabIndex = 2;
            this.btDeco.Text = "Deconnexion";
            this.btDeco.UseVisualStyleBackColor = true;
            this.btDeco.Click += new System.EventHandler(this.btDeco_Click_1);
            // 
            // labPseudo
            // 
            this.labPseudo.AutoSize = true;
            this.labPseudo.Location = new System.Drawing.Point(12, 6);
            this.labPseudo.Name = "labPseudo";
            this.labPseudo.Size = new System.Drawing.Size(38, 15);
            this.labPseudo.TabIndex = 3;
            this.labPseudo.Text = "label1";
            // 
            // FormPresta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labPseudo);
            this.Controls.Add(this.btDeco);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lbPresta);
            this.Name = "FormPresta";
            this.Text = "FormPresta";
            this.Load += new System.EventHandler(this.FormPresta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPresta;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btDeco;
        private System.Windows.Forms.Label labPseudo;
    }
}