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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMois = new System.Windows.Forms.ComboBox();
            this.textBox_NbJustificatif = new System.Windows.Forms.TextBox();
            this.textBox_MontantValide = new System.Windows.Forms.TextBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.dgv_ligneDeFraisForfait = new System.Windows.Forms.DataGridView();
            this.gSBEQ3EntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_ajoutFrais = new System.Windows.Forms.Panel();
            this.btn_ajoutFrais = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_montant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tarif = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_quantité = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_fraisForfaits = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ligneDeFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSBEQ3EntitiesBindingSource)).BeginInit();
            this.pnl_ajoutFrais.SuspendLayout();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(279, 101);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 13);
            label5.TabIndex = 55;
            label5.Text = "Montant validé";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
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
            // 
            // textBox_NbJustificatif
            // 
            this.textBox_NbJustificatif.Location = new System.Drawing.Point(171, 118);
            this.textBox_NbJustificatif.Name = "textBox_NbJustificatif";
            this.textBox_NbJustificatif.Size = new System.Drawing.Size(66, 20);
            this.textBox_NbJustificatif.TabIndex = 34;
            // 
            // textBox_MontantValide
            // 
            this.textBox_MontantValide.Location = new System.Drawing.Point(282, 118);
            this.textBox_MontantValide.Name = "textBox_MontantValide";
            this.textBox_MontantValide.Size = new System.Drawing.Size(100, 20);
            this.textBox_MontantValide.TabIndex = 37;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(441, 263);
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
            // dgv_ligneDeFraisForfait
            // 
            this.dgv_ligneDeFraisForfait.AllowUserToAddRows = false;
            this.dgv_ligneDeFraisForfait.AllowUserToDeleteRows = false;
            this.dgv_ligneDeFraisForfait.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_ligneDeFraisForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ligneDeFraisForfait.Location = new System.Drawing.Point(19, 153);
            this.dgv_ligneDeFraisForfait.Name = "dgv_ligneDeFraisForfait";
            this.dgv_ligneDeFraisForfait.ReadOnly = true;
            this.dgv_ligneDeFraisForfait.Size = new System.Drawing.Size(500, 104);
            this.dgv_ligneDeFraisForfait.TabIndex = 57;
            // 
            // gSBEQ3EntitiesBindingSource
            // 
            this.gSBEQ3EntitiesBindingSource.DataSource = typeof(RapportVisite.GSB_EQ3Entities);
            // 
            // pnl_ajoutFrais
            // 
            this.pnl_ajoutFrais.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_ajoutFrais.Controls.Add(this.btn_ajoutFrais);
            this.pnl_ajoutFrais.Controls.Add(this.label10);
            this.pnl_ajoutFrais.Controls.Add(this.txt_montant);
            this.pnl_ajoutFrais.Controls.Add(this.label9);
            this.pnl_ajoutFrais.Controls.Add(this.txt_tarif);
            this.pnl_ajoutFrais.Controls.Add(this.label8);
            this.pnl_ajoutFrais.Controls.Add(this.txt_quantité);
            this.pnl_ajoutFrais.Controls.Add(this.label4);
            this.pnl_ajoutFrais.Controls.Add(this.cb_fraisForfaits);
            this.pnl_ajoutFrais.Controls.Add(this.label11);
            this.pnl_ajoutFrais.Location = new System.Drawing.Point(19, 321);
            this.pnl_ajoutFrais.Name = "pnl_ajoutFrais";
            this.pnl_ajoutFrais.Size = new System.Drawing.Size(500, 134);
            this.pnl_ajoutFrais.TabIndex = 58;
            // 
            // btn_ajoutFrais
            // 
            this.btn_ajoutFrais.Location = new System.Drawing.Point(422, 99);
            this.btn_ajoutFrais.Name = "btn_ajoutFrais";
            this.btn_ajoutFrais.Size = new System.Drawing.Size(72, 21);
            this.btn_ajoutFrais.TabIndex = 34;
            this.btn_ajoutFrais.Text = "Ajouter frais";
            this.btn_ajoutFrais.UseVisualStyleBackColor = true;
            this.btn_ajoutFrais.Click += new System.EventHandler(this.btn_ajoutFrais_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Total";
            // 
            // txt_montant
            // 
            this.txt_montant.Location = new System.Drawing.Point(413, 58);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.Size = new System.Drawing.Size(81, 20);
            this.txt_montant.TabIndex = 32;
            this.txt_montant.TextChanged += new System.EventHandler(this.txt_montant_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tarif";
            // 
            // txt_tarif
            // 
            this.txt_tarif.Location = new System.Drawing.Point(263, 58);
            this.txt_tarif.Name = "txt_tarif";
            this.txt_tarif.Size = new System.Drawing.Size(64, 20);
            this.txt_tarif.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Quantité";
            // 
            // txt_quantité
            // 
            this.txt_quantité.Location = new System.Drawing.Point(173, 58);
            this.txt_quantité.Name = "txt_quantité";
            this.txt_quantité.Size = new System.Drawing.Size(64, 20);
            this.txt_quantité.TabIndex = 28;
            this.txt_quantité.TextChanged += new System.EventHandler(this.txt_quantité_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sélectionner un type de frais";
            // 
            // cb_fraisForfaits
            // 
            this.cb_fraisForfaits.FormattingEnabled = true;
            this.cb_fraisForfaits.Location = new System.Drawing.Point(6, 58);
            this.cb_fraisForfaits.Name = "cb_fraisForfaits";
            this.cb_fraisForfaits.Size = new System.Drawing.Size(138, 21);
            this.cb_fraisForfaits.TabIndex = 26;
            this.cb_fraisForfaits.SelectedIndexChanged += new System.EventHandler(this.cb_fraisForfaits_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Saisir une ligne de frais";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(452, 38);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(43, 18);
            this.lbl_date.TabIndex = 59;
            this.lbl_date.Text = "Date";
            // 
            // frmFicheFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.ClientSize = new System.Drawing.Size(559, 464);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.pnl_ajoutFrais);
            this.Controls.Add(this.dgv_ligneDeFraisForfait);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(label2);
            this.Controls.Add(this.btn_Ajouter);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ligneDeFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSBEQ3EntitiesBindingSource)).EndInit();
            this.pnl_ajoutFrais.ResumeLayout(false);
            this.pnl_ajoutFrais.PerformLayout();
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
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.DataGridView dgv_ligneDeFraisForfait;
        private System.Windows.Forms.BindingSource gSBEQ3EntitiesBindingSource;
        private System.Windows.Forms.Panel pnl_ajoutFrais;
        private System.Windows.Forms.Button btn_ajoutFrais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_montant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tarif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_quantité;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_fraisForfaits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_date;
    }
}