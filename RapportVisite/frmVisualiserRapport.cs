using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace RapportVisite
{
    public partial class frmVisualiserRapport : Form
    {
        private GSB_EQ3Entities maConnexion;
        private Visiteur levisiteur;
        int ceIdRapport;
      
        public frmVisualiserRapport(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {

            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteur = Levisiteur;
        }

        private void cbo_idRap_SelectedIndexChanged(object sender, EventArgs e)
        {
          RAPPORT ceRapport = (RAPPORT)this.cbo_idRap.SelectedItem;          
          ceIdRapport = ceRapport.idRapport;

            var reqOffrir = from O in maConnexion.OFFRIR
                            join R in maConnexion.RAPPORT on O.idRapport equals R.idRapport
                            join M in maConnexion.MEDICAMENT on O.idMedicament equals M.idMedicament
                            where O.idRapport == ceIdRapport
                            select new {M.nomCommercial,O.quantite };

           
          


            var reqRapport = from R in  maConnexion.RAPPORT
                                   
                                    join M in maConnexion.MEDECIN on R.idMedecin equals M.idMedecin
                                    join Mo in  maConnexion.MOTIF on R.idMotif equals Mo.idMotif
                                    join O in maConnexion.OFFRIR on R.idRapport equals O.idRapport
                                    join Me in maConnexion.MEDICAMENT on O.idMedicament equals Me.idMedicament
                                 
                                    where R.idRapport == ceIdRapport
                                    
                                    orderby R.idRapport
                             select new { R.idRapport, M.nom, M.prenom, Mo.libMotif, R.dateRapport, R.bilan, Me.nomCommercial, O.quantite,R.etatRapport };



            this.cb_medicament.DisplayMember = "nomCommercial";
            cb_medicament.DataSource = ((ObjectQuery)(reqOffrir));
            
            this.dgv_Rap.DataSource = ((ObjectQuery)(reqRapport));

        

            // Appliquer des styles par défaut aux données du dataGridview
            dgv_Rap.DefaultCellStyle.BackColor = Color.Bisque;
            dgv_Rap.DefaultCellStyle.Font = new Font("Calibri", 9);
            dgv_Rap.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // les ajouts et suppressions sont interdits
            dgv_Rap.AllowUserToAddRows = false;
            dgv_Rap.AllowUserToDeleteRows = false;

            dgv_Rap.Columns[0].HeaderText ="idRapport" ;
            dgv_Rap.Columns[1].HeaderText = "nom Medecin";
            dgv_Rap.Columns[2].HeaderText = "prenom Medecin";
            dgv_Rap.Columns[3].HeaderText = "libMotif";
            dgv_Rap.Columns[4].HeaderText = "dateRapport";
            dgv_Rap.Columns[5].HeaderText = "bilan";
            dgv_Rap.Columns[6].HeaderText = "nomCommercial";
            dgv_Rap.Columns[7].HeaderText = "quantite";
            dgv_Rap.Columns[8].HeaderText = "etatRapport";

            // les colonnes sont redimensionnées automatiquement, le nom est mis en gras
            dgv_Rap.AutoResizeColumns();
            dgv_Rap.Columns[1].Width = 120;
            dgv_Rap.Columns[1].DefaultCellStyle.Font = new Font("Calibri", 9, FontStyle.Bold);
            dgv_Rap.Columns[2].Width = 120;

        }

        private void frmVisualiserRapportVisite_Load(object sender, EventArgs e)
        {
            var reqRap = from R in maConnexion.RAPPORT
                           orderby R.idRapport
                           where R.idVisiteur == levisiteur.idVisiteur
                           select R;

            try
            {
                this.cbo_idRap.DisplayMember = "idRapport";
                this.cbo_idRap.DataSource = ((ObjectQuery)(reqRap)).Execute(MergeOption.AppendOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_Rapport(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                   // Sélection pour ceCompositeur de la ligne en cours  
            var ceVisiteur = this.dgv_Rap.CurrentRow;


            int idRapport = (Convert.ToInt32(ceVisiteur.Cells[0].Value));
            string nomMedecin = (Convert.ToString(ceVisiteur.Cells[1].Value).Trim()); // .Trim() = supprime les blancs inutiles
            string prenomMedecin = (Convert.ToString(ceVisiteur.Cells[2].Value).Trim());
            string libMotif = Convert.ToString(ceVisiteur.Cells[3].Value);
            string dateRapport = Convert.ToString(ceVisiteur.Cells[4].Value);
            string bilan = Convert.ToString(ceVisiteur.Cells[5].Value);
            string medicament =  Convert.ToString(ceVisiteur.Cells[6].Value);
            
            string quantite = Convert.ToString(ceVisiteur.Cells[7].Value);
             bool etat = Convert.ToBoolean(ceVisiteur.Cells[8].Value);
            
            
            txtPreMed.Text = prenomMedecin;
            txt_idRap.Text =(Convert.ToString(idRapport));
            txtNomMed.Text = nomMedecin;
            txt_date.Text = dateRapport;
            txt_motif.Text = libMotif;
            txt_bilan.Text = bilan;
            txt_quantite.Text = quantite;
            cb_medicament.Text = medicament;
          
           if (etat)  { txt_etat.Text = " cloturé"; } else { txt_etat.Text = "non cloturé"; }
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_medicament_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        
        
    }
}
