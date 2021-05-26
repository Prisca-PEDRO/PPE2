namespace Ppe
{
    partial class FormSeance
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
            this.btSuppSeance = new System.Windows.Forms.Button();
            this.btAjoutSeance = new System.Windows.Forms.Button();
            this.labPseudo = new System.Windows.Forms.Label();
            this.btDeco = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.btModifSeance = new System.Windows.Forms.Button();
            this.lbSeance = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCodePresta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCodePresta = new System.Windows.Forms.TextBox();
            this.numTerrain = new System.Windows.Forms.NumericUpDown();
            this.numNbrePlaces = new System.Windows.Forms.NumericUpDown();
            this.timeDebut = new System.Windows.Forms.DateTimePicker();
            this.timeFin = new System.Windows.Forms.DateTimePicker();
            this.dtSeance = new System.Windows.Forms.DateTimePicker();
            this.numPrix = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTerrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbrePlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // btSuppSeance
            // 
            this.btSuppSeance.Location = new System.Drawing.Point(1010, 681);
            this.btSuppSeance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSuppSeance.Name = "btSuppSeance";
            this.btSuppSeance.Size = new System.Drawing.Size(159, 49);
            this.btSuppSeance.TabIndex = 6;
            this.btSuppSeance.Text = "Suprimer Activité";
            this.btSuppSeance.UseVisualStyleBackColor = true;
            this.btSuppSeance.Click += new System.EventHandler(this.btSuppSeance_Click);
            // 
            // btAjoutSeance
            // 
            this.btAjoutSeance.Location = new System.Drawing.Point(20, 681);
            this.btAjoutSeance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAjoutSeance.Name = "btAjoutSeance";
            this.btAjoutSeance.Size = new System.Drawing.Size(141, 49);
            this.btAjoutSeance.TabIndex = 5;
            this.btAjoutSeance.Text = "Ajouter Activité";
            this.btAjoutSeance.UseVisualStyleBackColor = true;
            this.btAjoutSeance.Click += new System.EventHandler(this.btAjoutSeance_Click);
            // 
            // labPseudo
            // 
            this.labPseudo.AutoSize = true;
            this.labPseudo.Location = new System.Drawing.Point(20, 27);
            this.labPseudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPseudo.Name = "labPseudo";
            this.labPseudo.Size = new System.Drawing.Size(59, 25);
            this.labPseudo.TabIndex = 3;
            this.labPseudo.Text = "label1";
            // 
            // btDeco
            // 
            this.btDeco.Location = new System.Drawing.Point(20, 57);
            this.btDeco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeco.Name = "btDeco";
            this.btDeco.Size = new System.Drawing.Size(141, 38);
            this.btDeco.TabIndex = 2;
            this.btDeco.Text = "Deconnexion";
            this.btDeco.UseVisualStyleBackColor = true;
            this.btDeco.Click += new System.EventHandler(this.btDeco_Click_1);
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(994, 20);
            this.btRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(107, 38);
            this.btRetour.TabIndex = 15;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btModifSeance
            // 
            this.btModifSeance.Location = new System.Drawing.Point(529, 681);
            this.btModifSeance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btModifSeance.Name = "btModifSeance";
            this.btModifSeance.Size = new System.Drawing.Size(156, 49);
            this.btModifSeance.TabIndex = 4;
            this.btModifSeance.Text = "Modifier Activité";
            this.btModifSeance.UseVisualStyleBackColor = true;
            this.btModifSeance.Click += new System.EventHandler(this.btModifSeance_Click);
            // 
            // lbSeance
            // 
            this.lbSeance.FormattingEnabled = true;
            this.lbSeance.ItemHeight = 25;
            this.lbSeance.Location = new System.Drawing.Point(20, 140);
            this.lbSeance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSeance.Name = "lbSeance";
            this.lbSeance.Size = new System.Drawing.Size(1251, 204);
            this.lbSeance.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 528);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ancien Code Presta (Pour Modif ou supp ) :";
            // 
            // cbCodePresta
            // 
            this.cbCodePresta.FormattingEnabled = true;
            this.cbCodePresta.Location = new System.Drawing.Point(21, 558);
            this.cbCodePresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCodePresta.Name = "cbCodePresta";
            this.cbCodePresta.Size = new System.Drawing.Size(265, 33);
            this.cbCodePresta.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 528);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Numéro Terrain :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 528);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Heure fin séance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 528);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Heure début séance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(961, 383);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nombre de Places :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(711, 383);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Prix Séance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date Séance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Code Presta :";
            // 
            // tbCodePresta
            // 
            this.tbCodePresta.Location = new System.Drawing.Point(21, 413);
            this.tbCodePresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCodePresta.Name = "tbCodePresta";
            this.tbCodePresta.Size = new System.Drawing.Size(257, 31);
            this.tbCodePresta.TabIndex = 10;
            // 
            // numTerrain
            // 
            this.numTerrain.Location = new System.Drawing.Point(961, 558);
            this.numTerrain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTerrain.Name = "numTerrain";
            this.numTerrain.Size = new System.Drawing.Size(171, 31);
            this.numTerrain.TabIndex = 12;
            // 
            // numNbrePlaces
            // 
            this.numNbrePlaces.Location = new System.Drawing.Point(961, 413);
            this.numNbrePlaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numNbrePlaces.Name = "numNbrePlaces";
            this.numNbrePlaces.Size = new System.Drawing.Size(171, 31);
            this.numNbrePlaces.TabIndex = 12;
            // 
            // timeDebut
            // 
            this.timeDebut.Checked = false;
            this.timeDebut.CustomFormat = "";
            this.timeDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeDebut.Location = new System.Drawing.Point(369, 558);
            this.timeDebut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeDebut.Name = "timeDebut";
            this.timeDebut.ShowUpDown = true;
            this.timeDebut.Size = new System.Drawing.Size(285, 31);
            this.timeDebut.TabIndex = 13;
            // 
            // timeFin
            // 
            this.timeFin.Checked = false;
            this.timeFin.CustomFormat = "";
            this.timeFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeFin.Location = new System.Drawing.Point(711, 558);
            this.timeFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeFin.Name = "timeFin";
            this.timeFin.ShowUpDown = true;
            this.timeFin.Size = new System.Drawing.Size(173, 31);
            this.timeFin.TabIndex = 13;
            // 
            // dtSeance
            // 
            this.dtSeance.Location = new System.Drawing.Point(369, 413);
            this.dtSeance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtSeance.Name = "dtSeance";
            this.dtSeance.Size = new System.Drawing.Size(285, 31);
            this.dtSeance.TabIndex = 14;
            // 
            // numPrix
            // 
            this.numPrix.Location = new System.Drawing.Point(714, 413);
            this.numPrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPrix.Name = "numPrix";
            this.numPrix.Size = new System.Drawing.Size(171, 31);
            this.numPrix.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(479, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 67);
            this.label9.TabIndex = 24;
            this.label9.Text = "Activité :";
            // 
            // FormSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 750);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numPrix);
            this.Controls.Add(this.dtSeance);
            this.Controls.Add(this.timeFin);
            this.Controls.Add(this.timeDebut);
            this.Controls.Add(this.numNbrePlaces);
            this.Controls.Add(this.numTerrain);
            this.Controls.Add(this.tbCodePresta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCodePresta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSeance);
            this.Controls.Add(this.btModifSeance);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.btDeco);
            this.Controls.Add(this.labPseudo);
            this.Controls.Add(this.btAjoutSeance);
            this.Controls.Add(this.btSuppSeance);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSeance";
            this.Text = "FormSeance";
            this.Load += new System.EventHandler(this.FormSeance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTerrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbrePlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSuppSeance;
        private System.Windows.Forms.Button btAjoutSeance;
        private System.Windows.Forms.Label labPseudo;
        private System.Windows.Forms.Button btDeco;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btModifSeance;
        private System.Windows.Forms.ListBox lbSeance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCodePresta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCodePresta;
        private System.Windows.Forms.NumericUpDown numTerrain;
        private System.Windows.Forms.NumericUpDown numNbrePlaces;
        private System.Windows.Forms.DateTimePicker timeDebut;
        private System.Windows.Forms.DateTimePicker timeFin;
        private System.Windows.Forms.DateTimePicker dtSeance;
        private System.Windows.Forms.NumericUpDown numPrix;
        private System.Windows.Forms.Label label9;
    }
}