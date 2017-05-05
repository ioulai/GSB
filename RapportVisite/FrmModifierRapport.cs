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
    public partial class FrmModifierRapport : Form
    {
       private GSB_EQ3Entities maConnexion;
        private  Visiteur levisiteur;
        int idMedecin;
        RAPPORT ceRapport;
        int idMotif;
        public FrmModifierRapport(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {

            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteur = Levisiteur;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmModifierRapport_Load(object sender, EventArgs e)
        {
            bsRapport.DataSource = maConnexion.RAPPORT;
            
            Afficher();


        }
        public void modifier() {
            cb_motif.Text = ceRapport.MOTIF.libMotif;
            cb_Nom_Medecin.Text = ceRapport.MEDECIN.nom;
        
        }
        public void Afficher() {

            //requete vers base de donnees 
            var reqRapport = from R in maConnexion.RAPPORT

                             join M in maConnexion.MEDECIN on R.idMedecin equals M.idMedecin
                             join Mo in maConnexion.MOTIF on R.idMotif equals Mo.idMotif
                             join O in maConnexion.OFFRIR on R.idRapport equals O.idRapport
                             join Me in maConnexion.MEDICAMENT on O.idMedicament equals Me.idMedicament
                             where R.idVisiteur == levisiteur.idVisiteur
                             orderby R.idRapport
                             select new { R.idRapport, M.nom, M.prenom, Mo.libMotif, R.dateRapport, R.bilan,R.etatRapport};





            this.dgv_Raport.DataSource = ((ObjectQuery)(reqRapport));

            dgv_Raport.Columns[0].HeaderText = "idRapport";
            dgv_Raport.Columns[1].HeaderText = "nom Medecin";
            dgv_Raport.Columns[2].HeaderText = "prenom Medecin";
            dgv_Raport.Columns[3].HeaderText = "libMotif";
            dgv_Raport.Columns[4].HeaderText = "dateRapport";
            dgv_Raport.Columns[5].HeaderText = "bilan";
            dgv_Raport.Columns[6].HeaderText = "etatRapport";

             ceRapport = (RAPPORT)this.bsRapport.Current;
            
            // on protège certaines zones non modifiables 
             //txtStyle.ReadOnly = true;

           
            var reqRapport2 = from R in maConnexion.RAPPORT
                             where R.idVisiteur == levisiteur.idVisiteur
                             select R;
           


            var reqMedecin = from M in maConnexion.MEDECIN
                             orderby M.nom
                             select M;
            var reqMotif = from Mo in maConnexion.MOTIF
                           
                          
                           select Mo;

            bsRapport.DataSource = ((ObjectQuery)(reqRapport2));
          
            //txt_motif.ReadOnly = true;
            txt_Prenom_Medecin.ReadOnly = true;

            // on charge les infos dans les zones de texte
            this.cb_Nom_Medecin.DisplayMember = "nom";
            cb_Nom_Medecin.DataSource = ((ObjectQuery)(reqMedecin));

            this.cb_motif.DisplayMember = "libMotif";
            cb_motif.DataSource = ((ObjectQuery)(reqMotif));
          
        //    txt_nom.Text = ceRapport.Visiteur.nom;
        //    txt_prenom.Text = ceRapport.Visiteur.prenom;
          //  txt_motif.Text = ceRapport.MOTIF.libMotif;          
       //    txt_bilan.Text = ceRapport.bilan; 


          
        }

    

        private void btn_Maj_Click(object sender, EventArgs e)
        {
            
             Affecter();
             this.maConnexion.SaveChanges();
             Afficher();
             modifier();
        }
        // Méthode pour affecter les valeurs saisies aux champs de l'enregistrement avant son ajout ou sa mise à jour
        public void Affecter()
        {
            


           ceRapport = (RAPPORT)this.bsRapport.Current;

              ceRapport.idMotif = idMotif;
               ceRapport.bilan = txt_bilan.Text;
               ceRapport.idMedecin = idMedecin;
            //  if (chb_cloturer.Checked) { ceRapport.etatRapport = true; }
     
        }

        private void cb_Nom_Medecin_SelectedIndexChanged(object sender, EventArgs e)
        {
                var reqMedecin = from M in maConnexion.MEDECIN
                             where M.idMedecin == ceRapport.idMedecin
                             orderby M.nom    
                             select M;
            
            


            MEDECIN unMedecin = (MEDECIN)this.cb_Nom_Medecin.SelectedItem;
            idMedecin = unMedecin.idMedecin;
            txt_Prenom_Medecin.Text = unMedecin.prenom;
            
            
        }




        private void dgv_Raport_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var ceVisiteur = this.dgv_Raport.CurrentRow;


            int idRapport = (Convert.ToInt32(ceVisiteur.Cells[0].Value));
            string nomMedecin = (Convert.ToString(ceVisiteur.Cells[1].Value).Trim()); // .Trim() = supprime les blancs inutiles
            string prenomMedecin = (Convert.ToString(ceVisiteur.Cells[2].Value).Trim());
            string libMotif = Convert.ToString(ceVisiteur.Cells[3].Value);
            string dateRapport = Convert.ToString(ceVisiteur.Cells[4].Value);
            string bilan = Convert.ToString(ceVisiteur.Cells[5].Value);
            bool cloturer = Convert.ToBoolean(ceVisiteur.Cells[6].Value);
                  

            txt_bilan.Text = bilan;       
            cb_motif.Text = libMotif;
            txt_Prenom_Medecin.Text = prenomMedecin;
            cb_Nom_Medecin.Text = nomMedecin;
           if (cloturer) { chb_cloturer.Checked = true; txt_cloturer.Text = "Vôtre rapport est cloteré impossible \n de modifier  "; } else { chb_cloturer.Checked = false; txt_cloturer.Text = "Non cloturer"; }
            
            
          



        }

        private void cb_motif_SelectedIndexChanged(object sender, EventArgs e)
        {
            MOTIF unMotif = (MOTIF)this.cb_motif.SelectedItem;
            idMotif = unMotif.idMotif;
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
      

       

    }
}
