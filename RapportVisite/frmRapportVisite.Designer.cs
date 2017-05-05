namespace RapportVisite
{
    partial class frmRapportVisite
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_terminer = new System.Windows.Forms.Button();
            this.tb_Motif = new System.Windows.Forms.TextBox();
            this.label_dateVisite = new System.Windows.Forms.Label();
            this.lable_motif = new System.Windows.Forms.Label();
            this.dateTimePicker_dateVisite = new System.Windows.Forms.DateTimePicker();
            this.label_bilan = new System.Windows.Forms.Label();
            this.lb_bilan = new System.Windows.Forms.ListBox();
            this.label_numRapport = new System.Windows.Forms.Label();
            this.tb_numRapport = new System.Windows.Forms.TextBox();
            this.label_praticien = new System.Windows.Forms.Label();
            this.cb_praticien = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_terminer
            // 
            this.btn_terminer.Location = new System.Drawing.Point(49, 297);
            this.btn_terminer.Name = "btn_terminer";
            this.btn_terminer.Size = new System.Drawing.Size(75, 23);
            this.btn_terminer.TabIndex = 0;
            this.btn_terminer.Text = "Terminer";
            this.btn_terminer.UseVisualStyleBackColor = true;
            this.btn_terminer.Click += new System.EventHandler(this.btn_terminer_Click);
            // 
            // tb_Motif
            // 
            this.tb_Motif.Location = new System.Drawing.Point(151, 148);
            this.tb_Motif.Name = "tb_Motif";
            this.tb_Motif.Size = new System.Drawing.Size(100, 20);
            this.tb_Motif.TabIndex = 1;
            // 
            // label_dateVisite
            // 
            this.label_dateVisite.AutoSize = true;
            this.label_dateVisite.BackColor = System.Drawing.Color.Transparent;
            this.label_dateVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_dateVisite.Location = new System.Drawing.Point(14, 79);
            this.label_dateVisite.Name = "label_dateVisite";
            this.label_dateVisite.Size = new System.Drawing.Size(110, 16);
            this.label_dateVisite.TabIndex = 2;
            this.label_dateVisite.Text = "Date de la visite :";
            // 
            // lable_motif
            // 
            this.lable_motif.AutoSize = true;
            this.lable_motif.BackColor = System.Drawing.Color.Transparent;
            this.lable_motif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lable_motif.Location = new System.Drawing.Point(16, 152);
            this.lable_motif.Name = "lable_motif";
            this.lable_motif.Size = new System.Drawing.Size(42, 16);
            this.lable_motif.TabIndex = 3;
            this.lable_motif.Text = "Motif :";
            // 
            // dateTimePicker_dateVisite
            // 
            this.dateTimePicker_dateVisite.Location = new System.Drawing.Point(151, 79);
            this.dateTimePicker_dateVisite.Name = "dateTimePicker_dateVisite";
            this.dateTimePicker_dateVisite.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_dateVisite.TabIndex = 4;
            // 
            // label_bilan
            // 
            this.label_bilan.AutoSize = true;
            this.label_bilan.BackColor = System.Drawing.Color.Transparent;
            this.label_bilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_bilan.Location = new System.Drawing.Point(14, 187);
            this.label_bilan.Name = "label_bilan";
            this.label_bilan.Size = new System.Drawing.Size(44, 16);
            this.label_bilan.TabIndex = 5;
            this.label_bilan.Text = "Bilan :";
            // 
            // lb_bilan
            // 
            this.lb_bilan.FormattingEnabled = true;
            this.lb_bilan.Location = new System.Drawing.Point(151, 187);
            this.lb_bilan.Name = "lb_bilan";
            this.lb_bilan.Size = new System.Drawing.Size(120, 95);
            this.lb_bilan.TabIndex = 6;
            // 
            // label_numRapport
            // 
            this.label_numRapport.AutoSize = true;
            this.label_numRapport.BackColor = System.Drawing.Color.Transparent;
            this.label_numRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_numRapport.Location = new System.Drawing.Point(16, 46);
            this.label_numRapport.Name = "label_numRapport";
            this.label_numRapport.Size = new System.Drawing.Size(108, 16);
            this.label_numRapport.TabIndex = 8;
            this.label_numRapport.Text = "Numéro Rapport";
            // 
            // tb_numRapport
            // 
            this.tb_numRapport.Location = new System.Drawing.Point(151, 46);
            this.tb_numRapport.Name = "tb_numRapport";
            this.tb_numRapport.Size = new System.Drawing.Size(100, 20);
            this.tb_numRapport.TabIndex = 9;
            // 
            // label_praticien
            // 
            this.label_praticien.AutoSize = true;
            this.label_praticien.BackColor = System.Drawing.Color.Transparent;
            this.label_praticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_praticien.Location = new System.Drawing.Point(19, 117);
            this.label_praticien.Name = "label_praticien";
            this.label_praticien.Size = new System.Drawing.Size(66, 16);
            this.label_praticien.TabIndex = 10;
            this.label_praticien.Text = "Praticien :";
            // 
            // cb_praticien
            // 
            this.cb_praticien.FormattingEnabled = true;
            this.cb_praticien.Location = new System.Drawing.Point(151, 111);
            this.cb_praticien.Name = "cb_praticien";
            this.cb_praticien.Size = new System.Drawing.Size(121, 21);
            this.cb_praticien.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(161, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Frais de dossier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 13;
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
            // frmRapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_praticien);
            this.Controls.Add(this.label_praticien);
            this.Controls.Add(this.tb_numRapport);
            this.Controls.Add(this.label_numRapport);
            this.Controls.Add(this.lb_bilan);
            this.Controls.Add(this.label_bilan);
            this.Controls.Add(this.dateTimePicker_dateVisite);
            this.Controls.Add(this.lable_motif);
            this.Controls.Add(this.label_dateVisite);
            this.Controls.Add(this.tb_Motif);
            this.Controls.Add(this.btn_terminer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRapportVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rapport des visites";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_terminer;
        private System.Windows.Forms.TextBox tb_Motif;
        private System.Windows.Forms.Label label_dateVisite;
        private System.Windows.Forms.Label lable_motif;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateVisite;
        private System.Windows.Forms.Label label_bilan;
        private System.Windows.Forms.ListBox lb_bilan;
        private System.Windows.Forms.Label label_numRapport;
        private System.Windows.Forms.TextBox tb_numRapport;
        private System.Windows.Forms.Label label_praticien;
        private System.Windows.Forms.ComboBox cb_praticien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

