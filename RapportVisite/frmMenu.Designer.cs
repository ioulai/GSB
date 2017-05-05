namespace RapportVisite
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MS_Déconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Profil = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_VoirD = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_RapportVisite = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ajouter = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Frais = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_util = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_titre = new System.Windows.Forms.Label();
            this.lb_iformation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_util)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Déconnexion,
            this.MS_Profil,
            this.MS_RapportVisite,
            this.MS_Frais});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MS_Déconnexion
            // 
            this.MS_Déconnexion.BackColor = System.Drawing.Color.Transparent;
            this.MS_Déconnexion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_Déconnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MS_Déconnexion.Name = "MS_Déconnexion";
            this.MS_Déconnexion.Size = new System.Drawing.Size(104, 20);
            this.MS_Déconnexion.Text = "Déconnexion";
            this.MS_Déconnexion.Click += new System.EventHandler(this.MS_Déconnexion_Click);
            // 
            // MS_Profil
            // 
            this.MS_Profil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_VoirD,
            this.MS_Gestion});
            this.MS_Profil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.MS_Profil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MS_Profil.Name = "MS_Profil";
            this.MS_Profil.Size = new System.Drawing.Size(54, 20);
            this.MS_Profil.Text = "Profil";
            // 
            // MS_VoirD
            // 
            this.MS_VoirD.Name = "MS_VoirD";
            this.MS_VoirD.Size = new System.Drawing.Size(198, 22);
            this.MS_VoirD.Text = "Voir Données ";
            this.MS_VoirD.Click += new System.EventHandler(this.MS_VoirD_Click);
            // 
            // MS_Gestion
            // 
            this.MS_Gestion.Name = "MS_Gestion";
            this.MS_Gestion.Size = new System.Drawing.Size(198, 22);
            this.MS_Gestion.Text = "Gestion Utilisateurs";
            this.MS_Gestion.Click += new System.EventHandler(this.MS_Gestion_Click);
            // 
            // MS_RapportVisite
            // 
            this.MS_RapportVisite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_ajouter,
            this.MS_modifier,
            this.visualiserToolStripMenuItem});
            this.MS_RapportVisite.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.MS_RapportVisite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MS_RapportVisite.Name = "MS_RapportVisite";
            this.MS_RapportVisite.Size = new System.Drawing.Size(109, 20);
            this.MS_RapportVisite.Text = "Rapport Visite";
            // 
            // MS_ajouter
            // 
            this.MS_ajouter.Name = "MS_ajouter";
            this.MS_ajouter.Size = new System.Drawing.Size(138, 22);
            this.MS_ajouter.Text = "Ajouter ";
            this.MS_ajouter.Click += new System.EventHandler(this.MS_ajouter_Click);
            // 
            // MS_modifier
            // 
            this.MS_modifier.Name = "MS_modifier";
            this.MS_modifier.Size = new System.Drawing.Size(138, 22);
            this.MS_modifier.Text = "Modifier ";
            this.MS_modifier.Click += new System.EventHandler(this.MS_modifier_Click);
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            this.visualiserToolStripMenuItem.Click += new System.EventHandler(this.visualiserToolStripMenuItem_Click);
            // 
            // MS_Frais
            // 
            this.MS_Frais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheFraisToolStripMenuItem,
            this.modifierFraisToolStripMenuItem});
            this.MS_Frais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.MS_Frais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MS_Frais.Name = "MS_Frais";
            this.MS_Frais.Size = new System.Drawing.Size(51, 20);
            this.MS_Frais.Text = "Frais";
            // 
            // ficheFraisToolStripMenuItem
            // 
            this.ficheFraisToolStripMenuItem.Name = "ficheFraisToolStripMenuItem";
            this.ficheFraisToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ficheFraisToolStripMenuItem.Text = "Saisie frais";
            this.ficheFraisToolStripMenuItem.Click += new System.EventHandler(this.ficheFraisToolStripMenuItem_Click);
            // 
            // modifierFraisToolStripMenuItem
            // 
            this.modifierFraisToolStripMenuItem.Name = "modifierFraisToolStripMenuItem";
            this.modifierFraisToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.modifierFraisToolStripMenuItem.Text = "Modifier frais";
            this.modifierFraisToolStripMenuItem.Click += new System.EventHandler(this.modifierFraisToolStripMenuItem_Click);
            // 
            // dgv_util
            // 
            this.dgv_util.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_util.Location = new System.Drawing.Point(23, 51);
            this.dgv_util.Name = "dgv_util";
            this.dgv_util.Size = new System.Drawing.Size(425, 271);
            this.dgv_util.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::RapportVisite.Properties.Resources.logoGSB_ConvertImage_1;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_logo.Location = new System.Drawing.Point(464, 313);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(69, 50);
            this.pb_logo.TabIndex = 18;
            this.pb_logo.TabStop = false;
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_titre.ForeColor = System.Drawing.Color.White;
            this.lb_titre.Location = new System.Drawing.Point(19, 28);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(49, 18);
            this.lb_titre.TabIndex = 20;
            this.lb_titre.Text = "Menu";
            // 
            // lb_iformation
            // 
            this.lb_iformation.AutoSize = true;
            this.lb_iformation.BackColor = System.Drawing.Color.Transparent;
            this.lb_iformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_iformation.ForeColor = System.Drawing.Color.White;
            this.lb_iformation.Location = new System.Drawing.Point(20, 347);
            this.lb_iformation.Name = "lb_iformation";
            this.lb_iformation.Size = new System.Drawing.Size(112, 16);
            this.lb_iformation.TabIndex = 21;
            this.lb_iformation.Text = "INFORMATION";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(545, 375);
            this.Controls.Add(this.lb_iformation);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.dgv_util);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_util)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Profil;
        private System.Windows.Forms.ToolStripMenuItem MS_VoirD;
        private System.Windows.Forms.ToolStripMenuItem MS_Gestion;
        private System.Windows.Forms.ToolStripMenuItem MS_RapportVisite;
        private System.Windows.Forms.ToolStripMenuItem MS_ajouter;
        private System.Windows.Forms.ToolStripMenuItem MS_modifier;
        private System.Windows.Forms.ToolStripMenuItem MS_Frais;
        private System.Windows.Forms.ToolStripMenuItem MS_Déconnexion;
        private System.Windows.Forms.DataGridView dgv_util;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.Label lb_iformation;
        private System.Windows.Forms.ToolStripMenuItem ficheFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierFraisToolStripMenuItem;
    }
}