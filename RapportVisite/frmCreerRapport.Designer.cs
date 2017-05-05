namespace RapportVisite
{
    partial class frmCreerRapport
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
            this.cb_medecin = new System.Windows.Forms.ComboBox();
            this.cb_motif = new System.Windows.Forms.ComboBox();
            this.txt_bilan = new System.Windows.Forms.TextBox();
            this.dtp_dateRapport = new System.Windows.Forms.DateTimePicker();
            this.medecin = new System.Windows.Forms.Label();
            this.lb_idMotif = new System.Windows.Forms.Label();
            this.lb_bilan = new System.Windows.Forms.Label();
            this.lb_dateRapport = new System.Windows.Forms.Label();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.lb_quantiter = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.lb_med = new System.Windows.Forms.Label();
            this.cb_med = new System.Windows.Forms.ComboBox();
            this.lb_iformation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_titre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_medecin
            // 
            this.cb_medecin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_medecin.FormattingEnabled = true;
            this.cb_medecin.Location = new System.Drawing.Point(178, 9);
            this.cb_medecin.Name = "cb_medecin";
            this.cb_medecin.Size = new System.Drawing.Size(181, 21);
            this.cb_medecin.TabIndex = 0;
            this.cb_medecin.SelectedIndexChanged += new System.EventHandler(this.cb_medecin_SelectedIndexChanged);
            // 
            // cb_motif
            // 
            this.cb_motif.FormattingEnabled = true;
            this.cb_motif.Location = new System.Drawing.Point(178, 97);
            this.cb_motif.Name = "cb_motif";
            this.cb_motif.Size = new System.Drawing.Size(181, 21);
            this.cb_motif.TabIndex = 1;
            this.cb_motif.SelectedIndexChanged += new System.EventHandler(this.cb_motif_SelectedIndexChanged);
            // 
            // txt_bilan
            // 
            this.txt_bilan.Location = new System.Drawing.Point(178, 139);
            this.txt_bilan.Name = "txt_bilan";
            this.txt_bilan.Size = new System.Drawing.Size(181, 20);
            this.txt_bilan.TabIndex = 3;
            // 
            // dtp_dateRapport
            // 
            this.dtp_dateRapport.Location = new System.Drawing.Point(178, 52);
            this.dtp_dateRapport.Name = "dtp_dateRapport";
            this.dtp_dateRapport.Size = new System.Drawing.Size(181, 20);
            this.dtp_dateRapport.TabIndex = 4;
            // 
            // medecin
            // 
            this.medecin.AutoSize = true;
            this.medecin.BackColor = System.Drawing.Color.Transparent;
            this.medecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecin.ForeColor = System.Drawing.Color.White;
            this.medecin.Location = new System.Drawing.Point(97, 9);
            this.medecin.Name = "medecin";
            this.medecin.Size = new System.Drawing.Size(75, 16);
            this.medecin.TabIndex = 5;
            this.medecin.Text = "Medecin :";
            // 
            // lb_idMotif
            // 
            this.lb_idMotif.AutoSize = true;
            this.lb_idMotif.BackColor = System.Drawing.Color.Transparent;
            this.lb_idMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idMotif.ForeColor = System.Drawing.Color.White;
            this.lb_idMotif.Location = new System.Drawing.Point(118, 97);
            this.lb_idMotif.Name = "lb_idMotif";
            this.lb_idMotif.Size = new System.Drawing.Size(49, 16);
            this.lb_idMotif.TabIndex = 6;
            this.lb_idMotif.Text = "Motif :";
            // 
            // lb_bilan
            // 
            this.lb_bilan.AutoSize = true;
            this.lb_bilan.BackColor = System.Drawing.Color.Transparent;
            this.lb_bilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bilan.ForeColor = System.Drawing.Color.White;
            this.lb_bilan.Location = new System.Drawing.Point(120, 141);
            this.lb_bilan.Name = "lb_bilan";
            this.lb_bilan.Size = new System.Drawing.Size(51, 16);
            this.lb_bilan.TabIndex = 8;
            this.lb_bilan.Text = "Bilan :";
            // 
            // lb_dateRapport
            // 
            this.lb_dateRapport.AutoSize = true;
            this.lb_dateRapport.BackColor = System.Drawing.Color.Transparent;
            this.lb_dateRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dateRapport.ForeColor = System.Drawing.Color.White;
            this.lb_dateRapport.Location = new System.Drawing.Point(66, 52);
            this.lb_dateRapport.Name = "lb_dateRapport";
            this.lb_dateRapport.Size = new System.Drawing.Size(109, 16);
            this.lb_dateRapport.TabIndex = 9;
            this.lb_dateRapport.Text = "Date Rapport :";
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_enregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_enregistrer.Location = new System.Drawing.Point(301, 336);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(88, 27);
            this.btn_enregistrer.TabIndex = 10;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // lb_quantiter
            // 
            this.lb_quantiter.AutoSize = true;
            this.lb_quantiter.BackColor = System.Drawing.Color.Transparent;
            this.lb_quantiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantiter.ForeColor = System.Drawing.Color.White;
            this.lb_quantiter.Location = new System.Drawing.Point(7, 219);
            this.lb_quantiter.Name = "lb_quantiter";
            this.lb_quantiter.Size = new System.Drawing.Size(161, 16);
            this.lb_quantiter.TabIndex = 12;
            this.lb_quantiter.Text = "Quantité medicament :";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(178, 219);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(181, 20);
            this.txt_quant.TabIndex = 11;
            // 
            // lb_med
            // 
            this.lb_med.AutoSize = true;
            this.lb_med.BackColor = System.Drawing.Color.Transparent;
            this.lb_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_med.ForeColor = System.Drawing.Color.White;
            this.lb_med.Location = new System.Drawing.Point(71, 178);
            this.lb_med.Name = "lb_med";
            this.lb_med.Size = new System.Drawing.Size(100, 16);
            this.lb_med.TabIndex = 14;
            this.lb_med.Text = "Medicament :";
            // 
            // cb_med
            // 
            this.cb_med.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_med.FormattingEnabled = true;
            this.cb_med.Location = new System.Drawing.Point(179, 178);
            this.cb_med.Name = "cb_med";
            this.cb_med.Size = new System.Drawing.Size(180, 21);
            this.cb_med.TabIndex = 13;
            this.cb_med.SelectedIndexChanged += new System.EventHandler(this.cb_med_SelectedIndexChanged);
            // 
            // lb_iformation
            // 
            this.lb_iformation.AutoSize = true;
            this.lb_iformation.BackColor = System.Drawing.Color.Transparent;
            this.lb_iformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_iformation.ForeColor = System.Drawing.Color.White;
            this.lb_iformation.Location = new System.Drawing.Point(47, 313);
            this.lb_iformation.Name = "lb_iformation";
            this.lb_iformation.Size = new System.Drawing.Size(112, 16);
            this.lb_iformation.TabIndex = 15;
            this.lb_iformation.Text = "INFORMATION";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUITTERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-2, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qUITTERToolStripMenuItem
            // 
            this.qUITTERToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.qUITTERToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            this.qUITTERToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.qUITTERToolStripMenuItem.Text = "QUITTER";
            this.qUITTERToolStripMenuItem.Click += new System.EventHandler(this.qUITTERToolStripMenuItem_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::RapportVisite.Properties.Resources.logoGSB_ConvertImage_1;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_logo.Location = new System.Drawing.Point(395, 313);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(69, 50);
            this.pb_logo.TabIndex = 17;
            this.pb_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_medecin);
            this.panel1.Controls.Add(this.cb_motif);
            this.panel1.Controls.Add(this.txt_bilan);
            this.panel1.Controls.Add(this.lb_med);
            this.panel1.Controls.Add(this.dtp_dateRapport);
            this.panel1.Controls.Add(this.cb_med);
            this.panel1.Controls.Add(this.medecin);
            this.panel1.Controls.Add(this.lb_quantiter);
            this.panel1.Controls.Add(this.lb_idMotif);
            this.panel1.Controls.Add(this.txt_quant);
            this.panel1.Controls.Add(this.lb_bilan);
            this.panel1.Controls.Add(this.lb_dateRapport);
            this.panel1.Location = new System.Drawing.Point(39, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 253);
            this.panel1.TabIndex = 18;
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_titre.ForeColor = System.Drawing.Color.White;
            this.lb_titre.Location = new System.Drawing.Point(35, 31);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(160, 18);
            this.lb_titre.TabIndex = 19;
            this.lb_titre.Text = "Création de Rapport";
            // 
            // frmCreerRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(476, 375);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lb_iformation);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCreerRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCreerRapport";
            this.Load += new System.EventHandler(this.frmCreerRapport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_medecin;
        private System.Windows.Forms.ComboBox cb_motif;
        private System.Windows.Forms.TextBox txt_bilan;
        private System.Windows.Forms.DateTimePicker dtp_dateRapport;
        private System.Windows.Forms.Label medecin;
        private System.Windows.Forms.Label lb_idMotif;
        private System.Windows.Forms.Label lb_bilan;
        private System.Windows.Forms.Label lb_dateRapport;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Label lb_quantiter;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Label lb_med;
        private System.Windows.Forms.ComboBox cb_med;
        private System.Windows.Forms.Label lb_iformation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_titre;
    }
}