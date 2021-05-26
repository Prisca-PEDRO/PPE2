namespace Ppe
{
    partial class FormAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.btInscri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(206, 120);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(124, 23);
            this.tbId.TabIndex = 0;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(206, 172);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(124, 23);
            this.tbMdp.TabIndex = 1;
            this.tbMdp.UseSystemPasswordChar = true;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(216, 217);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(104, 23);
            this.bt_Connect.TabIndex = 2;
            this.bt_Connect.Text = "Connectez-vous";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // btInscri
            // 
            this.btInscri.AccessibleName = "";
            this.btInscri.Location = new System.Drawing.Point(216, 255);
            this.btInscri.Name = "btInscri";
            this.btInscri.Size = new System.Drawing.Size(104, 23);
            this.btInscri.TabIndex = 3;
            this.btInscri.Text = "Inscrivez-vous";
            this.btInscri.UseVisualStyleBackColor = true;
            this.btInscri.Click += new System.EventHandler(this.btInscri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pseudo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe :";
            // 
            // FormAccueil
            // 
            this.AccessibleName = "BtInscri";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btInscri);
            this.Controls.Add(this.bt_Connect);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbId);
            this.Name = "FormAccueil";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button btInscri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

