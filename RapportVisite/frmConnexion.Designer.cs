namespace RapportVisite
{
    partial class frmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_mdp = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_titre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Location = new System.Drawing.Point(235, 168);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(75, 23);
            this.btn_Connexion.TabIndex = 0;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.BackColor = System.Drawing.Color.Transparent;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Id.ForeColor = System.Drawing.Color.White;
            this.label_Id.Location = new System.Drawing.Point(69, 66);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(83, 16);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "Identifiant :";
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.BackColor = System.Drawing.Color.Transparent;
            this.label_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_mdp.ForeColor = System.Drawing.Color.White;
            this.label_mdp.Location = new System.Drawing.Point(56, 129);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(110, 16);
            this.label_mdp.TabIndex = 2;
            this.label_mdp.Text = "Mot de passe :";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(187, 64);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(123, 20);
            this.tb_Id.TabIndex = 3;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(187, 127);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.PasswordChar = '*';
            this.tb_mdp.Size = new System.Drawing.Size(123, 20);
            this.tb_mdp.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUITTERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qUITTERToolStripMenuItem
            // 
            this.qUITTERToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
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
            this.pb_logo.Location = new System.Drawing.Point(324, 152);
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
            this.lb_titre.Location = new System.Drawing.Point(12, 33);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(88, 18);
            this.lb_titre.TabIndex = 20;
            this.lb_titre.Text = "Connexion";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.ClientSize = new System.Drawing.Size(405, 214);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.btn_Connexion);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_titre;
    }
}