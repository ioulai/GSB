namespace RapportVisite
{
    partial class FrmModifierRapport
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
            this.components = new System.ComponentModel.Container();
            this.lb_motif = new System.Windows.Forms.Label();
            this.lb_bilan = new System.Windows.Forms.Label();
            this.txt_bilan = new System.Windows.Forms.TextBox();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.Panel_Modifier = new System.Windows.Forms.Panel();
            this.txt_cloturer = new System.Windows.Forms.Label();
            this.chb_cloturer = new System.Windows.Forms.CheckBox();
            this.cb_motif = new System.Windows.Forms.ComboBox();
            this.txt_Prenom_Medecin = new System.Windows.Forms.TextBox();
            this.lb_prenomMedicin = new System.Windows.Forms.Label();
            this.lb_nomMedecin = new System.Windows.Forms.Label();
            this.cb_Nom_Medecin = new System.Windows.Forms.ComboBox();
            this.btn_Maj = new System.Windows.Forms.Button();
            this.dgv_Raport = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_titre = new System.Windows.Forms.Label();
            this.lb_iformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            this.Panel_Modifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Raport)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_motif
            // 
            this.lb_motif.AutoSize = true;
            this.lb_motif.BackColor = System.Drawing.Color.Transparent;
            this.lb_motif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_motif.ForeColor = System.Drawing.Color.White;
            this.lb_motif.Location = new System.Drawing.Point(93, 45);
            this.lb_motif.Name = "lb_motif";
            this.lb_motif.Size = new System.Drawing.Size(49, 16);
            this.lb_motif.TabIndex = 4;
            this.lb_motif.Text = "Motif :";
            // 
            // lb_bilan
            // 
            this.lb_bilan.AutoSize = true;
            this.lb_bilan.BackColor = System.Drawing.Color.Transparent;
            this.lb_bilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_bilan.ForeColor = System.Drawing.Color.White;
            this.lb_bilan.Location = new System.Drawing.Point(93, 90);
            this.lb_bilan.Name = "lb_bilan";
            this.lb_bilan.Size = new System.Drawing.Size(50, 16);
            this.lb_bilan.TabIndex = 5;
            this.lb_bilan.Text = "bilan :";
            // 
            // txt_bilan
            // 
            this.txt_bilan.Location = new System.Drawing.Point(155, 86);
            this.txt_bilan.Name = "txt_bilan";
            this.txt_bilan.Size = new System.Drawing.Size(121, 20);
            this.txt_bilan.TabIndex = 9;
            // 
            // bsRapport
            // 
            this.bsRapport.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Panel_Modifier
            // 
            this.Panel_Modifier.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Modifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Modifier.Controls.Add(this.txt_cloturer);
            this.Panel_Modifier.Controls.Add(this.chb_cloturer);
            this.Panel_Modifier.Controls.Add(this.cb_motif);
            this.Panel_Modifier.Controls.Add(this.txt_Prenom_Medecin);
            this.Panel_Modifier.Controls.Add(this.lb_prenomMedicin);
            this.Panel_Modifier.Controls.Add(this.lb_nomMedecin);
            this.Panel_Modifier.Controls.Add(this.cb_Nom_Medecin);
            this.Panel_Modifier.Controls.Add(this.lb_bilan);
            this.Panel_Modifier.Controls.Add(this.lb_motif);
            this.Panel_Modifier.Controls.Add(this.txt_bilan);
            this.Panel_Modifier.Location = new System.Drawing.Point(305, 55);
            this.Panel_Modifier.Name = "Panel_Modifier";
            this.Panel_Modifier.Size = new System.Drawing.Size(307, 254);
            this.Panel_Modifier.TabIndex = 14;
            // 
            // txt_cloturer
            // 
            this.txt_cloturer.AutoSize = true;
            this.txt_cloturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cloturer.ForeColor = System.Drawing.Color.White;
            this.txt_cloturer.Location = new System.Drawing.Point(-4, 9);
            this.txt_cloturer.Name = "txt_cloturer";
            this.txt_cloturer.Size = new System.Drawing.Size(80, 15);
            this.txt_cloturer.TabIndex = 17;
            this.txt_cloturer.Text = "information";
            // 
            // chb_cloturer
            // 
            this.chb_cloturer.AutoSize = true;
            this.chb_cloturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chb_cloturer.ForeColor = System.Drawing.Color.Transparent;
            this.chb_cloturer.Location = new System.Drawing.Point(154, 215);
            this.chb_cloturer.Name = "chb_cloturer";
            this.chb_cloturer.Size = new System.Drawing.Size(81, 20);
            this.chb_cloturer.TabIndex = 16;
            this.chb_cloturer.Text = "Cloturer";
            this.chb_cloturer.UseVisualStyleBackColor = true;
            // 
            // cb_motif
            // 
            this.cb_motif.FormattingEnabled = true;
            this.cb_motif.Location = new System.Drawing.Point(155, 40);
            this.cb_motif.Name = "cb_motif";
            this.cb_motif.Size = new System.Drawing.Size(121, 21);
            this.cb_motif.TabIndex = 15;
            this.cb_motif.SelectedIndexChanged += new System.EventHandler(this.cb_motif_SelectedIndexChanged);
            // 
            // txt_Prenom_Medecin
            // 
            this.txt_Prenom_Medecin.Location = new System.Drawing.Point(154, 178);
            this.txt_Prenom_Medecin.Name = "txt_Prenom_Medecin";
            this.txt_Prenom_Medecin.Size = new System.Drawing.Size(121, 20);
            this.txt_Prenom_Medecin.TabIndex = 14;
            // 
            // lb_prenomMedicin
            // 
            this.lb_prenomMedicin.AutoSize = true;
            this.lb_prenomMedicin.BackColor = System.Drawing.Color.Transparent;
            this.lb_prenomMedicin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_prenomMedicin.ForeColor = System.Drawing.Color.White;
            this.lb_prenomMedicin.Location = new System.Drawing.Point(13, 182);
            this.lb_prenomMedicin.Name = "lb_prenomMedicin";
            this.lb_prenomMedicin.Size = new System.Drawing.Size(132, 16);
            this.lb_prenomMedicin.TabIndex = 13;
            this.lb_prenomMedicin.Text = "Prénom médecin :";
            // 
            // lb_nomMedecin
            // 
            this.lb_nomMedecin.AutoSize = true;
            this.lb_nomMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lb_nomMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_nomMedecin.ForeColor = System.Drawing.Color.White;
            this.lb_nomMedecin.Location = new System.Drawing.Point(34, 138);
            this.lb_nomMedecin.Name = "lb_nomMedecin";
            this.lb_nomMedecin.Size = new System.Drawing.Size(111, 16);
            this.lb_nomMedecin.TabIndex = 12;
            this.lb_nomMedecin.Text = "Nom Médecin :";
            // 
            // cb_Nom_Medecin
            // 
            this.cb_Nom_Medecin.FormattingEnabled = true;
            this.cb_Nom_Medecin.Location = new System.Drawing.Point(154, 133);
            this.cb_Nom_Medecin.Name = "cb_Nom_Medecin";
            this.cb_Nom_Medecin.Size = new System.Drawing.Size(121, 21);
            this.cb_Nom_Medecin.TabIndex = 11;
            this.cb_Nom_Medecin.SelectedIndexChanged += new System.EventHandler(this.cb_Nom_Medecin_SelectedIndexChanged);
            // 
            // btn_Maj
            // 
            this.btn_Maj.Location = new System.Drawing.Point(460, 318);
            this.btn_Maj.Name = "btn_Maj";
            this.btn_Maj.Size = new System.Drawing.Size(75, 23);
            this.btn_Maj.TabIndex = 19;
            this.btn_Maj.Text = "Mise à jour";
            this.btn_Maj.UseVisualStyleBackColor = true;
            this.btn_Maj.Click += new System.EventHandler(this.btn_Maj_Click);
            // 
            // dgv_Raport
            // 
            this.dgv_Raport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Raport.Location = new System.Drawing.Point(12, 55);
            this.dgv_Raport.Name = "dgv_Raport";
            this.dgv_Raport.Size = new System.Drawing.Size(240, 254);
            this.dgv_Raport.TabIndex = 20;
            this.dgv_Raport.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Raport_CellMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUITTERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 21;
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
            this.pb_logo.Location = new System.Drawing.Point(543, 315);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(69, 50);
            this.pb_logo.TabIndex = 22;
            this.pb_logo.TabStop = false;
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_titre.ForeColor = System.Drawing.Color.White;
            this.lb_titre.Location = new System.Drawing.Point(12, 32);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(182, 18);
            this.lb_titre.TabIndex = 23;
            this.lb_titre.Text = "Modification de rapport";
            // 
            // lb_iformation
            // 
            this.lb_iformation.AutoSize = true;
            this.lb_iformation.BackColor = System.Drawing.Color.Transparent;
            this.lb_iformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_iformation.ForeColor = System.Drawing.Color.White;
            this.lb_iformation.Location = new System.Drawing.Point(12, 318);
            this.lb_iformation.Name = "lb_iformation";
            this.lb_iformation.Size = new System.Drawing.Size(112, 16);
            this.lb_iformation.TabIndex = 24;
            this.lb_iformation.Text = "INFORMATION";
            // 
            // FrmModifierRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(624, 375);
            this.Controls.Add(this.lb_iformation);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.dgv_Raport);
            this.Controls.Add(this.btn_Maj);
            this.Controls.Add(this.Panel_Modifier);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmModifierRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmModifier";
            this.Load += new System.EventHandler(this.FrmModifierRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            this.Panel_Modifier.ResumeLayout(false);
            this.Panel_Modifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Raport)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_motif;
        private System.Windows.Forms.Label lb_bilan;
        private System.Windows.Forms.TextBox txt_bilan;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.Panel Panel_Modifier;
        private System.Windows.Forms.Button btn_Maj;
        private System.Windows.Forms.ComboBox cb_Nom_Medecin;
        private System.Windows.Forms.Label lb_nomMedecin;
        private System.Windows.Forms.TextBox txt_Prenom_Medecin;
        private System.Windows.Forms.Label lb_prenomMedicin;
        private System.Windows.Forms.DataGridView dgv_Raport;
        private System.Windows.Forms.ComboBox cb_motif;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.Label lb_iformation;
        private System.Windows.Forms.CheckBox chb_cloturer;
        private System.Windows.Forms.Label txt_cloturer;
    }
}