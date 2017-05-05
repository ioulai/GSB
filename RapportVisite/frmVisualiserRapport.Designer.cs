namespace RapportVisite
{
    partial class frmVisualiserRapport
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
            this.cbo_idRap = new System.Windows.Forms.ComboBox();
            this.dgv_Rap = new System.Windows.Forms.DataGridView();
            this.pl_rapport = new System.Windows.Forms.Panel();
            this.lb_etat = new System.Windows.Forms.Label();
            this.txt_etat = new System.Windows.Forms.TextBox();
            this.txt_quantite = new System.Windows.Forms.TextBox();
            this.lb_quantité = new System.Windows.Forms.Label();
            this.txt_medicament = new System.Windows.Forms.Label();
            this.cb_medicament = new System.Windows.Forms.ComboBox();
            this.lb_medicament = new System.Windows.Forms.Label();
            this.txt_bilan = new System.Windows.Forms.TextBox();
            this.txt_motif = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txtPreMed = new System.Windows.Forms.TextBox();
            this.txtNomMed = new System.Windows.Forms.TextBox();
            this.txt_idRap = new System.Windows.Forms.TextBox();
            this.lb_bilan = new System.Windows.Forms.Label();
            this.lb_motif = new System.Windows.Forms.Label();
            this.lb_Adresse = new System.Windows.Forms.Label();
            this.lb_Prenom = new System.Windows.Forms.Label();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.lb_idRapport = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_idRap = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_titre = new System.Windows.Forms.Label();
            this.lb_iformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rap)).BeginInit();
            this.pl_rapport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_idRap
            // 
            this.cbo_idRap.FormattingEnabled = true;
            this.cbo_idRap.Location = new System.Drawing.Point(465, 36);
            this.cbo_idRap.Name = "cbo_idRap";
            this.cbo_idRap.Size = new System.Drawing.Size(121, 21);
            this.cbo_idRap.TabIndex = 0;
            this.cbo_idRap.SelectedIndexChanged += new System.EventHandler(this.cbo_idRap_SelectedIndexChanged);
            // 
            // dgv_Rap
            // 
            this.dgv_Rap.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_Rap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rap.Location = new System.Drawing.Point(12, 64);
            this.dgv_Rap.Name = "dgv_Rap";
            this.dgv_Rap.Size = new System.Drawing.Size(702, 79);
            this.dgv_Rap.TabIndex = 1;
            this.dgv_Rap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Rapport);
            // 
            // pl_rapport
            // 
            this.pl_rapport.BackColor = System.Drawing.Color.Transparent;
            this.pl_rapport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_rapport.Controls.Add(this.lb_etat);
            this.pl_rapport.Controls.Add(this.txt_etat);
            this.pl_rapport.Controls.Add(this.txt_quantite);
            this.pl_rapport.Controls.Add(this.lb_quantité);
            this.pl_rapport.Controls.Add(this.txt_medicament);
            this.pl_rapport.Controls.Add(this.cb_medicament);
            this.pl_rapport.Controls.Add(this.lb_medicament);
            this.pl_rapport.Controls.Add(this.txt_bilan);
            this.pl_rapport.Controls.Add(this.txt_motif);
            this.pl_rapport.Controls.Add(this.txt_date);
            this.pl_rapport.Controls.Add(this.txtPreMed);
            this.pl_rapport.Controls.Add(this.txtNomMed);
            this.pl_rapport.Controls.Add(this.txt_idRap);
            this.pl_rapport.Controls.Add(this.lb_bilan);
            this.pl_rapport.Controls.Add(this.lb_motif);
            this.pl_rapport.Controls.Add(this.lb_Adresse);
            this.pl_rapport.Controls.Add(this.lb_Prenom);
            this.pl_rapport.Controls.Add(this.lb_Nom);
            this.pl_rapport.Controls.Add(this.lb_idRapport);
            this.pl_rapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pl_rapport.Location = new System.Drawing.Point(12, 132);
            this.pl_rapport.Name = "pl_rapport";
            this.pl_rapport.Size = new System.Drawing.Size(702, 200);
            this.pl_rapport.TabIndex = 2;
            // 
            // lb_etat
            // 
            this.lb_etat.AutoSize = true;
            this.lb_etat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_etat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_etat.Location = new System.Drawing.Point(371, 137);
            this.lb_etat.Name = "lb_etat";
            this.lb_etat.Size = new System.Drawing.Size(70, 16);
            this.lb_etat.TabIndex = 21;
            this.lb_etat.Text = "Cloturer :";
            // 
            // txt_etat
            // 
            this.txt_etat.Location = new System.Drawing.Point(450, 136);
            this.txt_etat.Name = "txt_etat";
            this.txt_etat.Size = new System.Drawing.Size(121, 20);
            this.txt_etat.TabIndex = 20;
            // 
            // txt_quantite
            // 
            this.txt_quantite.Location = new System.Drawing.Point(450, 98);
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.Size = new System.Drawing.Size(121, 20);
            this.txt_quantite.TabIndex = 19;
            // 
            // lb_quantité
            // 
            this.lb_quantité.AutoSize = true;
            this.lb_quantité.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_quantité.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_quantité.Location = new System.Drawing.Point(372, 105);
            this.lb_quantité.Name = "lb_quantité";
            this.lb_quantité.Size = new System.Drawing.Size(73, 16);
            this.lb_quantité.TabIndex = 18;
            this.lb_quantité.Text = "Quantité :";
            // 
            // txt_medicament
            // 
            this.txt_medicament.AutoSize = true;
            this.txt_medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_medicament.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_medicament.Location = new System.Drawing.Point(62, 102);
            this.txt_medicament.Name = "txt_medicament";
            this.txt_medicament.Size = new System.Drawing.Size(100, 16);
            this.txt_medicament.TabIndex = 17;
            this.txt_medicament.Text = "Médicament :";
            // 
            // cb_medicament
            // 
            this.cb_medicament.FormattingEnabled = true;
            this.cb_medicament.Location = new System.Drawing.Point(171, 97);
            this.cb_medicament.Name = "cb_medicament";
            this.cb_medicament.Size = new System.Drawing.Size(121, 21);
            this.cb_medicament.TabIndex = 16;
            this.cb_medicament.SelectedIndexChanged += new System.EventHandler(this.cb_medicament_SelectedIndexChanged);
            // 
            // lb_medicament
            // 
            this.lb_medicament.AutoSize = true;
            this.lb_medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_medicament.Location = new System.Drawing.Point(19, 275);
            this.lb_medicament.Name = "lb_medicament";
            this.lb_medicament.Size = new System.Drawing.Size(0, 13);
            this.lb_medicament.TabIndex = 14;
            // 
            // txt_bilan
            // 
            this.txt_bilan.Location = new System.Drawing.Point(171, 136);
            this.txt_bilan.Name = "txt_bilan";
            this.txt_bilan.Size = new System.Drawing.Size(121, 20);
            this.txt_bilan.TabIndex = 11;
            // 
            // txt_motif
            // 
            this.txt_motif.Location = new System.Drawing.Point(171, 173);
            this.txt_motif.Name = "txt_motif";
            this.txt_motif.Size = new System.Drawing.Size(400, 20);
            this.txt_motif.TabIndex = 10;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(171, 59);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(121, 20);
            this.txt_date.TabIndex = 9;
            // 
            // txtPreMed
            // 
            this.txtPreMed.Location = new System.Drawing.Point(450, 59);
            this.txtPreMed.Name = "txtPreMed";
            this.txtPreMed.Size = new System.Drawing.Size(121, 20);
            this.txtPreMed.TabIndex = 8;
            // 
            // txtNomMed
            // 
            this.txtNomMed.Location = new System.Drawing.Point(450, 16);
            this.txtNomMed.Name = "txtNomMed";
            this.txtNomMed.Size = new System.Drawing.Size(121, 20);
            this.txtNomMed.TabIndex = 7;
            // 
            // txt_idRap
            // 
            this.txt_idRap.Location = new System.Drawing.Point(171, 16);
            this.txt_idRap.Name = "txt_idRap";
            this.txt_idRap.Size = new System.Drawing.Size(121, 20);
            this.txt_idRap.TabIndex = 6;
            // 
            // lb_bilan
            // 
            this.lb_bilan.AutoSize = true;
            this.lb_bilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_bilan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_bilan.Location = new System.Drawing.Point(112, 177);
            this.lb_bilan.Name = "lb_bilan";
            this.lb_bilan.Size = new System.Drawing.Size(50, 16);
            this.lb_bilan.TabIndex = 5;
            this.lb_bilan.Text = "bilan :";
            // 
            // lb_motif
            // 
            this.lb_motif.AutoSize = true;
            this.lb_motif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_motif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_motif.Location = new System.Drawing.Point(113, 140);
            this.lb_motif.Name = "lb_motif";
            this.lb_motif.Size = new System.Drawing.Size(49, 16);
            this.lb_motif.TabIndex = 4;
            this.lb_motif.Text = "motif :";
            // 
            // lb_Adresse
            // 
            this.lb_Adresse.AutoSize = true;
            this.lb_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Adresse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Adresse.Location = new System.Drawing.Point(43, 66);
            this.lb_Adresse.Name = "lb_Adresse";
            this.lb_Adresse.Size = new System.Drawing.Size(124, 16);
            this.lb_Adresse.TabIndex = 3;
            this.lb_Adresse.Text = "Date du rapport :";
            // 
            // lb_Prenom
            // 
            this.lb_Prenom.AutoSize = true;
            this.lb_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Prenom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Prenom.Location = new System.Drawing.Point(324, 66);
            this.lb_Prenom.Name = "lb_Prenom";
            this.lb_Prenom.Size = new System.Drawing.Size(132, 16);
            this.lb_Prenom.TabIndex = 2;
            this.lb_Prenom.Text = "Prénom medecin :";
            // 
            // lb_Nom
            // 
            this.lb_Nom.AutoSize = true;
            this.lb_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Nom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Nom.Location = new System.Drawing.Point(341, 19);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(111, 16);
            this.lb_Nom.TabIndex = 1;
            this.lb_Nom.Text = "Nom Médecin :";
            // 
            // lb_idRapport
            // 
            this.lb_idRapport.AutoSize = true;
            this.lb_idRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_idRapport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_idRapport.Location = new System.Drawing.Point(74, 19);
            this.lb_idRapport.Name = "lb_idRapport";
            this.lb_idRapport.Size = new System.Drawing.Size(89, 16);
            this.lb_idRapport.TabIndex = 0;
            this.lb_idRapport.Text = "Id Rapport :";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::RapportVisite.Properties.Resources.logoGSB_ConvertImage_1;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_logo.Location = new System.Drawing.Point(645, 313);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(69, 50);
            this.pb_logo.TabIndex = 18;
            this.pb_logo.TabStop = false;
            // 
            // lb_idRap
            // 
            this.lb_idRap.AutoSize = true;
            this.lb_idRap.BackColor = System.Drawing.Color.Transparent;
            this.lb_idRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_idRap.ForeColor = System.Drawing.Color.White;
            this.lb_idRap.Location = new System.Drawing.Point(366, 41);
            this.lb_idRap.Name = "lb_idRap";
            this.lb_idRap.Size = new System.Drawing.Size(93, 16);
            this.lb_idRap.TabIndex = 3;
            this.lb_idRap.Text = "Id Rapport : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUITTERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qUITTERToolStripMenuItem
            // 
            this.qUITTERToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.qUITTERToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            this.qUITTERToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.qUITTERToolStripMenuItem.Text = "QUITTER";
            this.qUITTERToolStripMenuItem.Click += new System.EventHandler(this.qUITTERToolStripMenuItem_Click);
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_titre.ForeColor = System.Drawing.Color.White;
            this.lb_titre.Location = new System.Drawing.Point(55, 41);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(179, 16);
            this.lb_titre.TabIndex = 20;
            this.lb_titre.Text = "Visualisation de Rapport";
            // 
            // lb_iformation
            // 
            this.lb_iformation.AutoSize = true;
            this.lb_iformation.BackColor = System.Drawing.Color.Transparent;
            this.lb_iformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_iformation.ForeColor = System.Drawing.Color.White;
            this.lb_iformation.Location = new System.Drawing.Point(12, 335);
            this.lb_iformation.Name = "lb_iformation";
            this.lb_iformation.Size = new System.Drawing.Size(112, 16);
            this.lb_iformation.TabIndex = 21;
            this.lb_iformation.Text = "INFORMATION";
            // 
            // frmVisualiserRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(726, 375);
            this.Controls.Add(this.lb_iformation);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lb_idRap);
            this.Controls.Add(this.pl_rapport);
            this.Controls.Add(this.dgv_Rap);
            this.Controls.Add(this.cbo_idRap);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVisualiserRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAjouterRapportVisite";
            this.Load += new System.EventHandler(this.frmVisualiserRapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rap)).EndInit();
            this.pl_rapport.ResumeLayout(false);
            this.pl_rapport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_idRap;
        private System.Windows.Forms.DataGridView dgv_Rap;
        private System.Windows.Forms.Panel pl_rapport;
        private System.Windows.Forms.Label lb_Prenom;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.Label lb_idRapport;
        private System.Windows.Forms.Label lb_bilan;
        private System.Windows.Forms.Label lb_motif;
        private System.Windows.Forms.Label lb_Adresse;
        private System.Windows.Forms.TextBox txt_bilan;
        private System.Windows.Forms.TextBox txt_motif;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txtPreMed;
        private System.Windows.Forms.TextBox txtNomMed;
        private System.Windows.Forms.TextBox txt_idRap;
        private System.Windows.Forms.Label lb_medicament;
        private System.Windows.Forms.ComboBox cb_medicament;
        private System.Windows.Forms.Label txt_medicament;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_idRap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_quantite;
        private System.Windows.Forms.Label lb_quantité;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.Label lb_etat;
        private System.Windows.Forms.TextBox txt_etat;
        private System.Windows.Forms.Label lb_iformation;
    }
}