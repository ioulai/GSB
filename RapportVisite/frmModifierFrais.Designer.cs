namespace RapportVisite
{
    partial class frmModifierFrais
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_modifier = new System.Windows.Forms.DataGridView();
            this.bsModifierFrais = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.cbMois = new System.Windows.Forms.ComboBox();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtMontantValide = new System.Windows.Forms.TextBox();
            this.txtNbJustificatifs = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModifierFrais)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 46;
            label2.Text = "Mois";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(6, 149);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(26, 13);
            label3.TabIndex = 50;
            label3.Text = "Etat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
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
            // dgv_modifier
            // 
            this.dgv_modifier.AllowUserToAddRows = false;
            this.dgv_modifier.AllowUserToDeleteRows = false;
            this.dgv_modifier.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_modifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modifier.Location = new System.Drawing.Point(43, 102);
            this.dgv_modifier.Name = "dgv_modifier";
            this.dgv_modifier.Size = new System.Drawing.Size(315, 153);
            this.dgv_modifier.TabIndex = 1;
            this.dgv_modifier.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_modifier_CellMouseClick);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modifier.Location = new System.Drawing.Point(600, 337);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(98, 31);
            this.btn_Modifier.TabIndex = 2;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = false;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
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
            this.cbMois.Location = new System.Drawing.Point(93, 119);
            this.cbMois.Name = "cbMois";
            this.cbMois.Size = new System.Drawing.Size(114, 21);
            this.cbMois.TabIndex = 34;
            // 
            // cbEtat
            // 
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Location = new System.Drawing.Point(77, 146);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(130, 21);
            this.cbEtat.TabIndex = 49;
            this.cbEtat.SelectedIndexChanged += new System.EventHandler(this.cbEtat_SelectedIndexChanged);
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.Transparent;
            this.panelDetail.Controls.Add(this.label8);
            this.panelDetail.Controls.Add(this.label7);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.txtDate);
            this.panelDetail.Controls.Add(this.txtMontantValide);
            this.panelDetail.Controls.Add(label3);
            this.panelDetail.Controls.Add(this.txtNbJustificatifs);
            this.panelDetail.Controls.Add(label2);
            this.panelDetail.Controls.Add(this.cbEtat);
            this.panelDetail.Controls.Add(this.cbMois);
            this.panelDetail.Location = new System.Drawing.Point(472, 98);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(226, 187);
            this.panelDetail.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Détail de la fiche de frais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Montant validé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nb justificatifs fournis";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(108, 93);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(99, 20);
            this.txtDate.TabIndex = 2;
            // 
            // txtMontantValide
            // 
            this.txtMontantValide.Location = new System.Drawing.Point(108, 67);
            this.txtMontantValide.Name = "txtMontantValide";
            this.txtMontantValide.Size = new System.Drawing.Size(99, 20);
            this.txtMontantValide.TabIndex = 1;
            // 
            // txtNbJustificatifs
            // 
            this.txtNbJustificatifs.Location = new System.Drawing.Point(140, 41);
            this.txtNbJustificatifs.Name = "txtNbJustificatifs";
            this.txtNbJustificatifs.Size = new System.Drawing.Size(67, 20);
            this.txtNbJustificatifs.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(32, 288);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(520, 15);
            this.lblMessage.TabIndex = 54;
            this.lblMessage.Text = "Pour visualiser le détail d\'une fiche de frais, sélectionner la ligne corresponda" +
    "nt";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(40, 68);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(270, 16);
            this.lblTitre.TabIndex = 55;
            this.lblTitre.Text = "Liste de vos fiches de frais et leur état";
            // 
            // frmModifierFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.ClientSize = new System.Drawing.Size(746, 389);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.dgv_modifier);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmModifierFrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmModifierFrais";
            this.Load += new System.EventHandler(this.frmModifierFrais_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModifierFrais)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_modifier;
        private System.Windows.Forms.BindingSource bsModifierFrais;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.ComboBox cbMois;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtMontantValide;
        private System.Windows.Forms.TextBox txtNbJustificatifs;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitre;
    }
}