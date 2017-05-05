namespace RapportVisite
{
    partial class frmInscriptioncs
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
            this.btn_inscription = new System.Windows.Forms.Button();
            this.label_identifiant = new System.Windows.Forms.Label();
            this.textBox_identifiant = new System.Windows.Forms.TextBox();
            this.textBox_mdp = new System.Windows.Forms.TextBox();
            this.label_mdp = new System.Windows.Forms.Label();
            this.label_confirmationMdp = new System.Windows.Forms.Label();
            this.textBox_confirmationMdp = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_droit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Labo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_rue = new System.Windows.Forms.TextBox();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.textBox_cp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inscription
            // 
            this.btn_inscription.Location = new System.Drawing.Point(414, 302);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(75, 23);
            this.btn_inscription.TabIndex = 0;
            this.btn_inscription.Text = "Inscription";
            this.btn_inscription.UseVisualStyleBackColor = true;
            this.btn_inscription.Click += new System.EventHandler(this.btn_inscription_Click);
            // 
            // label_identifiant
            // 
            this.label_identifiant.AutoSize = true;
            this.label_identifiant.BackColor = System.Drawing.Color.Transparent;
            this.label_identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_identifiant.ForeColor = System.Drawing.Color.White;
            this.label_identifiant.Location = new System.Drawing.Point(123, 140);
            this.label_identifiant.Name = "label_identifiant";
            this.label_identifiant.Size = new System.Drawing.Size(83, 16);
            this.label_identifiant.TabIndex = 1;
            this.label_identifiant.Text = "Identifiant :";
            // 
            // textBox_identifiant
            // 
            this.textBox_identifiant.Location = new System.Drawing.Point(213, 133);
            this.textBox_identifiant.Name = "textBox_identifiant";
            this.textBox_identifiant.PasswordChar = '*';
            this.textBox_identifiant.Size = new System.Drawing.Size(100, 20);
            this.textBox_identifiant.TabIndex = 2;
            // 
            // textBox_mdp
            // 
            this.textBox_mdp.Location = new System.Drawing.Point(213, 165);
            this.textBox_mdp.Name = "textBox_mdp";
            this.textBox_mdp.PasswordChar = '*';
            this.textBox_mdp.Size = new System.Drawing.Size(100, 20);
            this.textBox_mdp.TabIndex = 3;
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.BackColor = System.Drawing.Color.Transparent;
            this.label_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_mdp.ForeColor = System.Drawing.Color.White;
            this.label_mdp.Location = new System.Drawing.Point(96, 169);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(110, 16);
            this.label_mdp.TabIndex = 4;
            this.label_mdp.Text = "Mot de passe :";
            // 
            // label_confirmationMdp
            // 
            this.label_confirmationMdp.AutoSize = true;
            this.label_confirmationMdp.BackColor = System.Drawing.Color.Transparent;
            this.label_confirmationMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_confirmationMdp.ForeColor = System.Drawing.Color.White;
            this.label_confirmationMdp.Location = new System.Drawing.Point(7, 208);
            this.label_confirmationMdp.Name = "label_confirmationMdp";
            this.label_confirmationMdp.Size = new System.Drawing.Size(200, 16);
            this.label_confirmationMdp.TabIndex = 5;
            this.label_confirmationMdp.Text = "Confirmation mot de passe :";
            // 
            // textBox_confirmationMdp
            // 
            this.textBox_confirmationMdp.Location = new System.Drawing.Point(213, 204);
            this.textBox_confirmationMdp.Name = "textBox_confirmationMdp";
            this.textBox_confirmationMdp.Size = new System.Drawing.Size(100, 20);
            this.textBox_confirmationMdp.TabIndex = 6;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(213, 96);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_prenom.TabIndex = 7;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(213, 62);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 8;
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.BackColor = System.Drawing.Color.Transparent;
            this.label_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_nom.ForeColor = System.Drawing.Color.White;
            this.label_nom.Location = new System.Drawing.Point(158, 66);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(48, 16);
            this.label_nom.TabIndex = 9;
            this.label_nom.Text = "Nom :";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.BackColor = System.Drawing.Color.Transparent;
            this.label_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_prenom.ForeColor = System.Drawing.Color.White;
            this.label_prenom.Location = new System.Drawing.Point(137, 101);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(69, 16);
            this.label_prenom.TabIndex = 10;
            this.label_prenom.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Droit* : ";
            // 
            // textBox_droit
            // 
            this.textBox_droit.Location = new System.Drawing.Point(420, 165);
            this.textBox_droit.Name = "textBox_droit";
            this.textBox_droit.Size = new System.Drawing.Size(100, 20);
            this.textBox_droit.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Laboratoire :";
            // 
            // textBox_Labo
            // 
            this.textBox_Labo.Location = new System.Drawing.Point(420, 30);
            this.textBox_Labo.Name = "textBox_Labo";
            this.textBox_Labo.Size = new System.Drawing.Size(100, 20);
            this.textBox_Labo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(375, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rue :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(372, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(320, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Code Postal :";
            // 
            // textBox_rue
            // 
            this.textBox_rue.Location = new System.Drawing.Point(420, 62);
            this.textBox_rue.Name = "textBox_rue";
            this.textBox_rue.Size = new System.Drawing.Size(100, 20);
            this.textBox_rue.TabIndex = 20;
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(420, 97);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(100, 20);
            this.textBox_ville.TabIndex = 21;
            // 
            // textBox_cp
            // 
            this.textBox_cp.Location = new System.Drawing.Point(420, 135);
            this.textBox_cp.Name = "textBox_cp";
            this.textBox_cp.Size = new System.Drawing.Size(100, 20);
            this.textBox_cp.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "*Chef secteur: 3. Chef région: 2. Autre: 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(177, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Id :";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(213, 30);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_Labo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_droit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_cp);
            this.panel1.Controls.Add(this.label_prenom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label_nom);
            this.panel1.Controls.Add(this.textBox_ville);
            this.panel1.Controls.Add(this.textBox_nom);
            this.panel1.Controls.Add(this.textBox_rue);
            this.panel1.Controls.Add(this.textBox_prenom);
            this.panel1.Controls.Add(this.label_identifiant);
            this.panel1.Controls.Add(this.textBox_confirmationMdp);
            this.panel1.Controls.Add(this.textBox_identifiant);
            this.panel1.Controls.Add(this.label_confirmationMdp);
            this.panel1.Controls.Add(this.textBox_mdp);
            this.panel1.Controls.Add(this.label_mdp);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 255);
            this.panel1.TabIndex = 26;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUITTERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 27;
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
            this.pb_logo.Location = new System.Drawing.Point(543, 290);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(69, 50);
            this.pb_logo.TabIndex = 28;
            this.pb_logo.TabStop = false;
            // 
            // frmInscriptioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.ClientSize = new System.Drawing.Size(624, 337);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInscriptioncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscriptioncs";
            this.Load += new System.EventHandler(this.frmInscriptioncs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inscription;
        private System.Windows.Forms.Label label_identifiant;
        private System.Windows.Forms.TextBox textBox_identifiant;
        private System.Windows.Forms.TextBox textBox_mdp;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.Label label_confirmationMdp;
        private System.Windows.Forms.TextBox textBox_confirmationMdp;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_droit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Labo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_rue;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.TextBox textBox_cp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}