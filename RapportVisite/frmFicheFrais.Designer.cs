namespace RapportVisite
{
    partial class frmFicheFrais
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMois = new System.Windows.Forms.ComboBox();
            this.textBox_NbJustificatif = new System.Windows.Forms.TextBox();
            this.textBox_MontantValide = new System.Windows.Forms.TextBox();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_recap_idEtat = new System.Windows.Forms.TextBox();
            this.textBox_recap_date = new System.Windows.Forms.TextBox();
            this.textBox_recap_montantValide = new System.Windows.Forms.TextBox();
            this.textBox_recap_nbJustificatif = new System.Windows.Forms.TextBox();
            this.textBox_recap_mois = new System.Windows.Forms.TextBox();
            this.textBox_recap_idVisiteur = new System.Windows.Forms.TextBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(14, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 13);
            label2.TabIndex = 45;
            label2.Text = "Mois";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(168, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 13);
            label3.TabIndex = 53;
            label3.Text = "Nb justificatifs";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(516, 101);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(30, 13);
            label7.TabIndex = 54;
            label7.Text = "Etat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(328, 101);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 13);
            label5.TabIndex = 55;
            label5.Text = "Montant validé";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(563, 41);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(34, 13);
            label6.TabIndex = 56;
            label6.Text = "Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Vous etes connecté en  tant que";
            // 
            // cbMois
            // 
            this.cbMois.FormattingEnabled = true;
            this.cbMois.Items.AddRange(new object[] {
            "Janv",
            "Fév",
            "Mars",
            "Avr",
            "Mai",
            "Ju",
            "Juill",
            "Aout",
            "Sept",
            "Oct",
            "Nov",
            "Déc"});
            this.cbMois.Location = new System.Drawing.Point(17, 118);
            this.cbMois.Name = "cbMois";
            this.cbMois.Size = new System.Drawing.Size(114, 21);
            this.cbMois.TabIndex = 33;
            this.cbMois.SelectedIndexChanged += new System.EventHandler(this.cbMois_SelectedIndexChanged);
            // 
            // textBox_NbJustificatif
            // 
            this.textBox_NbJustificatif.Location = new System.Drawing.Point(171, 118);
            this.textBox_NbJustificatif.Name = "textBox_NbJustificatif";
            this.textBox_NbJustificatif.Size = new System.Drawing.Size(66, 20);
            this.textBox_NbJustificatif.TabIndex = 34;
            this.textBox_NbJustificatif.TextChanged += new System.EventHandler(this.textBox_NbJustificatif_TextChanged_1);
            // 
            // textBox_MontantValide
            // 
            this.textBox_MontantValide.Location = new System.Drawing.Point(331, 118);
            this.textBox_MontantValide.Name = "textBox_MontantValide";
            this.textBox_MontantValide.Size = new System.Drawing.Size(100, 20);
            this.textBox_MontantValide.TabIndex = 37;
            this.textBox_MontantValide.TextChanged += new System.EventHandler(this.textBox_MontantValide_TextChanged_1);
            // 
            // cbEtat
            // 
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Location = new System.Drawing.Point(519, 118);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(155, 21);
            this.cbEtat.TabIndex = 41;
            this.cbEtat.SelectedIndexChanged += new System.EventHandler(this.cbEtat_SelectedIndexChanged_1);
            // 
            // textBox_Date
            // 
            this.textBox_Date.Location = new System.Drawing.Point(599, 38);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(75, 20);
            this.textBox_Date.TabIndex = 42;
            this.textBox_Date.TextChanged += new System.EventHandler(this.textBox_Date_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox_recap_idEtat);
            this.groupBox1.Controls.Add(this.textBox_recap_date);
            this.groupBox1.Controls.Add(this.textBox_recap_montantValide);
            this.groupBox1.Controls.Add(this.textBox_recap_nbJustificatif);
            this.groupBox1.Controls.Add(this.textBox_recap_mois);
            this.groupBox1.Controls.Add(this.textBox_recap_idVisiteur);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 100);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Récapitulatif";
            // 
            // textBox_recap_idEtat
            // 
            this.textBox_recap_idEtat.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_recap_idEtat.Location = new System.Drawing.Point(475, 38);
            this.textBox_recap_idEtat.Name = "textBox_recap_idEtat";
            this.textBox_recap_idEtat.Size = new System.Drawing.Size(55, 20);
            this.textBox_recap_idEtat.TabIndex = 5;
            // 
            // textBox_recap_date
            // 
            this.textBox_recap_date.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_recap_date.Location = new System.Drawing.Point(347, 38);
            this.textBox_recap_date.Name = "textBox_recap_date";
            this.textBox_recap_date.Size = new System.Drawing.Size(75, 20);
            this.textBox_recap_date.TabIndex = 4;
            // 
            // textBox_recap_montantValide
            // 
            this.textBox_recap_montantValide.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_recap_montantValide.Location = new System.Drawing.Point(256, 38);
            this.textBox_recap_montantValide.Name = "textBox_recap_montantValide";
            this.textBox_recap_montantValide.Size = new System.Drawing.Size(53, 20);
            this.textBox_recap_montantValide.TabIndex = 3;
            // 
            // textBox_recap_nbJustificatif
            // 
            this.textBox_recap_nbJustificatif.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_recap_nbJustificatif.Location = new System.Drawing.Point(172, 38);
            this.textBox_recap_nbJustificatif.Name = "textBox_recap_nbJustificatif";
            this.textBox_recap_nbJustificatif.Size = new System.Drawing.Size(53, 20);
            this.textBox_recap_nbJustificatif.TabIndex = 2;
            // 
            // textBox_recap_mois
            // 
            this.textBox_recap_mois.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_recap_mois.Location = new System.Drawing.Point(92, 38);
            this.textBox_recap_mois.Name = "textBox_recap_mois";
            this.textBox_recap_mois.Size = new System.Drawing.Size(53, 20);
            this.textBox_recap_mois.TabIndex = 1;
            // 
            // textBox_recap_idVisiteur
            // 
            this.textBox_recap_idVisiteur.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_recap_idVisiteur.Location = new System.Drawing.Point(20, 38);
            this.textBox_recap_idVisiteur.Name = "textBox_recap_idVisiteur";
            this.textBox_recap_idVisiteur.Size = new System.Drawing.Size(53, 20);
            this.textBox_recap_idVisiteur.TabIndex = 0;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(611, 263);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(79, 23);
            this.btn_Ajouter.TabIndex = 44;
            this.btn_Ajouter.Text = "valider";
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click_1);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AccessibleName = "";
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(243, 38);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(41, 18);
            this.lbl_nom.TabIndex = 50;
            this.lbl_nom.Text = "nom";
            this.lbl_nom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom.Location = new System.Drawing.Point(321, 38);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(65, 18);
            this.lbl_prenom.TabIndex = 51;
            this.lbl_prenom.Text = "prenom";
            // 
            // frmFicheFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.ClientSize = new System.Drawing.Size(711, 296);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label7);
            this.Controls.Add(label3);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(label2);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.cbEtat);
            this.Controls.Add(this.textBox_MontantValide);
            this.Controls.Add(this.textBox_NbJustificatif);
            this.Controls.Add(this.cbMois);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFicheFrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFicheFrais";
            this.Load += new System.EventHandler(this.frmFicheFrais_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMois;
        private System.Windows.Forms.TextBox textBox_NbJustificatif;
        private System.Windows.Forms.TextBox textBox_MontantValide;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_recap_idEtat;
        private System.Windows.Forms.TextBox textBox_recap_date;
        private System.Windows.Forms.TextBox textBox_recap_montantValide;
        private System.Windows.Forms.TextBox textBox_recap_nbJustificatif;
        private System.Windows.Forms.TextBox textBox_recap_mois;
        private System.Windows.Forms.TextBox textBox_recap_idVisiteur;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
    }
}