namespace Ppe
{
    partial class FormPrestaAdmin
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
            this.labPseudo = new System.Windows.Forms.Label();
            this.btDeco = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.tbCodePresta = new System.Windows.Forms.TextBox();
            this.tbNomPresta = new System.Windows.Forms.TextBox();
            this.numNbrePlaces = new System.Windows.Forms.NumericUpDown();
            this.numTarifPresta = new System.Windows.Forms.NumericUpDown();
            this.dtValidité = new System.Windows.Forms.DateTimePicker();
            this.numAgeLimite = new System.Windows.Forms.NumericUpDown();
            this.rtbDescriptionPresta = new System.Windows.Forms.RichTextBox();
            this.rtbCommentairePresta = new System.Windows.Forms.RichTextBox();
            this.btModifPresta = new System.Windows.Forms.Button();
            this.btSuppPresta = new System.Windows.Forms.Button();
            this.btAjoutPresta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPresta = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCodePresta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNbrePlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarifPresta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // labPseudo
            // 
            this.labPseudo.AutoSize = true;
            this.labPseudo.Location = new System.Drawing.Point(17, 22);
            this.labPseudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPseudo.Name = "labPseudo";
            this.labPseudo.Size = new System.Drawing.Size(59, 25);
            this.labPseudo.TabIndex = 3;
            this.labPseudo.Text = "label1";
            // 
            // btDeco
            // 
            this.btDeco.Location = new System.Drawing.Point(17, 47);
            this.btDeco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeco.Name = "btDeco";
            this.btDeco.Size = new System.Drawing.Size(141, 43);
            this.btDeco.TabIndex = 2;
            this.btDeco.Text = "Deconnexion";
            this.btDeco.UseVisualStyleBackColor = true;
            this.btDeco.Click += new System.EventHandler(this.btDeco_Click_1);
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(1000, 20);
            this.btRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(107, 38);
            this.btRetour.TabIndex = 4;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // tbCodePresta
            // 
            this.tbCodePresta.Location = new System.Drawing.Point(119, 335);
            this.tbCodePresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCodePresta.Name = "tbCodePresta";
            this.tbCodePresta.Size = new System.Drawing.Size(170, 31);
            this.tbCodePresta.TabIndex = 5;
            // 
            // tbNomPresta
            // 
            this.tbNomPresta.Location = new System.Drawing.Point(353, 335);
            this.tbNomPresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNomPresta.Name = "tbNomPresta";
            this.tbNomPresta.Size = new System.Drawing.Size(163, 31);
            this.tbNomPresta.TabIndex = 6;
            
            // 
            // numNbrePlaces
            // 
            this.numNbrePlaces.Location = new System.Drawing.Point(607, 337);
            this.numNbrePlaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNbrePlaces.Name = "numNbrePlaces";
            this.numNbrePlaces.Size = new System.Drawing.Size(171, 31);
            this.numNbrePlaces.TabIndex = 7;
            // 
            // numTarifPresta
            // 
            this.numTarifPresta.Location = new System.Drawing.Point(839, 337);
            this.numTarifPresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTarifPresta.Name = "numTarifPresta";
            this.numTarifPresta.Size = new System.Drawing.Size(171, 31);
            this.numTarifPresta.TabIndex = 8;
            // 
            // dtValidité
            // 
            this.dtValidité.Location = new System.Drawing.Point(353, 433);
            this.dtValidité.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtValidité.Name = "dtValidité";
            this.dtValidité.Size = new System.Drawing.Size(424, 31);
            this.dtValidité.TabIndex = 10;
            // 
            // numAgeLimite
            // 
            this.numAgeLimite.Location = new System.Drawing.Point(839, 433);
            this.numAgeLimite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numAgeLimite.Name = "numAgeLimite";
            this.numAgeLimite.Size = new System.Drawing.Size(171, 31);
            this.numAgeLimite.TabIndex = 11;
            // 
            // rtbDescriptionPresta
            // 
            this.rtbDescriptionPresta.Location = new System.Drawing.Point(79, 513);
            this.rtbDescriptionPresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDescriptionPresta.Name = "rtbDescriptionPresta";
            this.rtbDescriptionPresta.Size = new System.Drawing.Size(436, 151);
            this.rtbDescriptionPresta.TabIndex = 12;
            this.rtbDescriptionPresta.Text = "";
            // 
            // rtbCommentairePresta
            // 
            this.rtbCommentairePresta.Location = new System.Drawing.Point(606, 513);
            this.rtbCommentairePresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbCommentairePresta.Name = "rtbCommentairePresta";
            this.rtbCommentairePresta.Size = new System.Drawing.Size(431, 151);
            this.rtbCommentairePresta.TabIndex = 12;
            this.rtbCommentairePresta.Text = "";
            // 
            // btModifPresta
            // 
            this.btModifPresta.Location = new System.Drawing.Point(502, 693);
            this.btModifPresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btModifPresta.Name = "btModifPresta";
            this.btModifPresta.Size = new System.Drawing.Size(140, 68);
            this.btModifPresta.TabIndex = 13;
            this.btModifPresta.Text = "Modifier Prestation";
            this.btModifPresta.UseVisualStyleBackColor = true;
            this.btModifPresta.Click += new System.EventHandler(this.btModifPresta_Click);
            // 
            // btSuppPresta
            // 
            this.btSuppPresta.Location = new System.Drawing.Point(969, 693);
            this.btSuppPresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSuppPresta.Name = "btSuppPresta";
            this.btSuppPresta.Size = new System.Drawing.Size(138, 68);
            this.btSuppPresta.TabIndex = 14;
            this.btSuppPresta.Text = "Supprimer Prestaion";
            this.btSuppPresta.UseVisualStyleBackColor = true;
            this.btSuppPresta.Click += new System.EventHandler(this.btSuppPresta_Click);
            // 
            // btAjoutPresta
            // 
            this.btAjoutPresta.Location = new System.Drawing.Point(39, 693);
            this.btAjoutPresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAjoutPresta.Name = "btAjoutPresta";
            this.btAjoutPresta.Size = new System.Drawing.Size(149, 68);
            this.btAjoutPresta.TabIndex = 15;
            this.btAjoutPresta.Text = "Ajouter Prestation";
            this.btAjoutPresta.UseVisualStyleBackColor = true;
            this.btAjoutPresta.Click += new System.EventHandler(this.btAjoutPresta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code Prestation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom Prestation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre de Places :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(839, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tarif Prestation :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 378);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 50);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ancien Code Presta : \r\n(Pour modif ou supp)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPresta
            // 
            this.lbPresta.FormattingEnabled = true;
            this.lbPresta.HorizontalScrollbar = true;
            this.lbPresta.ItemHeight = 25;
            this.lbPresta.Location = new System.Drawing.Point(17, 115);
            this.lbPresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbPresta.Name = "lbPresta";
            this.lbPresta.Size = new System.Drawing.Size(1181, 179);
            this.lbPresta.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 483);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Description Prestation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 483);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Commentaire Prestation :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 403);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Date de Validité :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(839, 403);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Age limite :";
            // 
            // cbCodePresta
            // 
            this.cbCodePresta.FormattingEnabled = true;
            this.cbCodePresta.Location = new System.Drawing.Point(117, 432);
            this.cbCodePresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCodePresta.Name = "cbCodePresta";
            this.cbCodePresta.Size = new System.Drawing.Size(171, 33);
            this.cbCodePresta.TabIndex = 25;
            // 
            // FormPrestaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 775);
            this.Controls.Add(this.cbCodePresta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPresta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAjoutPresta);
            this.Controls.Add(this.btSuppPresta);
            this.Controls.Add(this.btModifPresta);
            this.Controls.Add(this.rtbCommentairePresta);
            this.Controls.Add(this.rtbDescriptionPresta);
            this.Controls.Add(this.numAgeLimite);
            this.Controls.Add(this.dtValidité);
            this.Controls.Add(this.numTarifPresta);
            this.Controls.Add(this.numNbrePlaces);
            this.Controls.Add(this.tbNomPresta);
            this.Controls.Add(this.tbCodePresta);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.btDeco);
            this.Controls.Add(this.labPseudo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrestaAdmin";
            this.Text = "FormPresta";
            this.Load += new System.EventHandler(this.FormPresta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNbrePlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarifPresta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPseudo;
        private System.Windows.Forms.Button btDeco;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.TextBox tbCodePresta;
        private System.Windows.Forms.TextBox tbNomPresta;
        private System.Windows.Forms.NumericUpDown numNbrePlaces;
        private System.Windows.Forms.NumericUpDown numTarifPresta;
        private System.Windows.Forms.DateTimePicker dtValidité;
        private System.Windows.Forms.NumericUpDown numAgeLimite;
        private System.Windows.Forms.RichTextBox rtbDescriptionPresta;
        private System.Windows.Forms.RichTextBox rtbCommentairePresta;
        private System.Windows.Forms.Button btModifPresta;
        private System.Windows.Forms.Button btSuppPresta;
        private System.Windows.Forms.Button btAjoutPresta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPresta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCodePresta;
    }
}