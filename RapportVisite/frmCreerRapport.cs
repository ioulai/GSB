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
   
    public partial class frmCreerRapport : Form
    {

        private GSB_EQ3Entities maConnexion;
        private Visiteur levisiteur;
        // creation des proprieter nessecaire a la création d'un Rapport 
        MOTIF leMotif;
        RAPPORT leRapport;
        MEDECIN leMedecin;
        OFFRIR lOffre;
        MEDICAMENT leMedicament;


        public frmCreerRapport(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
             maConnexion = MaConnexion;
            levisiteur = Levisiteur;

            // requete  de recuperation  d'element dans la base de donnée
            var reqMedecin = from M in maConnexion.MEDECIN
                             select M;

        
            var reqMotif = from Mo in maConnexion.MOTIF
                             select Mo;


            var reqmedi = from M in maConnexion.MEDICAMENT
                          select M;
            // recuperation des requete effectuer et affectation du champ selectionner dans la combobox
            this.cb_medecin.DisplayMember = "Patronyme";
            cb_medecin.DataSource = ((ObjectQuery)(reqMedecin));

            this.cb_med.DisplayMember = "nomCommercial";
            cb_med.DataSource = ((ObjectQuery)(reqmedi));
            
            this.cb_motif.DisplayMember = "libMotif";
            cb_motif.DataSource = ((ObjectQuery)(reqMotif));


        }


        private void frmCreerRapport_Load(object sender, EventArgs e)
        {
            lb_iformation.Text = "Utilisateur Connecté  : "+levisiteur.nom+"  "+levisiteur.prenom;

        }




        private void cb_motif_SelectedIndexChanged(object sender, EventArgs e)
        {
            // recuperation du motif actuellement selectionner par  l'utilisateur
            MOTIF unMotif = (MOTIF)this.cb_motif.SelectedItem;
            leMotif = unMotif;

        }

        private void cb_medecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // recuperation du medeci, actuellement selectionner par  l'utilisateur
            MEDECIN unMedecin = (MEDECIN)this.cb_medecin.SelectedItem;
            leMedecin = unMedecin;
        }

        private void cb_med_SelectedIndexChanged(object sender, EventArgs e)
        {
            MEDICAMENT unMedicament = (MEDICAMENT)this.cb_med.SelectedItem;
            leMedicament = unMedicament;
        }



        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment enregistrer ?";
            string caption = "Vôtre enregistrestrement à été pris en compte  fermeture de fenêtre";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Affichage de la boîte de dialogue 
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Affecter();
                maConnexion.AddObject("RAPPORT", leRapport);
                maConnexion.AddObject("OFFRIR", lOffre);// ajout a la base de donnes
                this.maConnexion.SaveChanges();                 // sauvegarde l'ajout dans la base de donnees
                /* Si l'utilisateur confirme en cliquant sur Yes */
                /* fermeture de l'application, libération des ressources */
                this.Close();// Pour quitter l'application
            }
        }

        public void Affecter()
        {
            leRapport = new RAPPORT();
            lOffre = new OFFRIR();
            
            // affectatoion des proprieter a l'objet rapport et offrir
            leRapport.dateRapport = dtp_dateRapport.Value;
            leRapport.idMotif = leMotif.idMotif;
            leRapport.bilan = txt_bilan.Text;
            leRapport.idVisiteur = levisiteur.idVisiteur;
            leRapport.idMedecin = leMedecin.idMedecin;           
            lOffre.idRapport = leRapport.idRapport;
            lOffre.idMedicament = leMedicament.idMedicament;         
            lOffre.quantite =Convert.ToInt32(txt_quant.Text);
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_titre_Click(object sender, EventArgs e)
        {

        }
    }
}
