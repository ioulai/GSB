using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RapportVisite
{
    public partial class frmRapportVisite : Form
    {
        public frmRapportVisite()
        {
            InitializeComponent();
        }

        private void btn_terminer_Click(object sender, EventArgs e)
        {
            string numRapport = tb_numRapport.Text;
            string motif = tb_Motif.Text;
            string bilan = lb_bilan.Text;
            string ptarticien = cb_praticien.Text;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
