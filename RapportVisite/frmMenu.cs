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
    public partial class frmMenu : Form
    {
        private GSB_EQ3Entities maConnexion;
        private  Visiteur levisiteur;
        public frmMenu(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteur = Levisiteur;
        }

        #region PARTIE DU RESTE DU GROUPE     

        private void MS_Déconnexion_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment quitter ?";
            string caption = "Fermeture de l'application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Affichage de la boîte de dialogue 
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                 maConnexion.Dispose();  // Pour libérer la connexion à la base de données */
                Application.Exit();     // Pour quitter l'application           }
            }  
        }

        private void MS_VoirD_Click(object sender, EventArgs e)
        {
            var req = from v in maConnexion.Visiteur    
                               
                      select v;
            this.dgv_util.DataSource = ((ObjectQuery)(req));

            // les ajouts et suppressions sont interdits
            dgv_util.AllowUserToAddRows = false;
            dgv_util.AllowUserToDeleteRows = false;

            // On formate le contenu du datGriedview dgvCompositeurs pour un affichage du nom et du prénom seulement          
            // L'entête de colonne des autres champs sont modifiés
            if (levisiteur.droit == 3 )
            {
                dgv_util.Columns[0].HeaderText = "CodeVisiteur";
                dgv_util.Columns[1].HeaderText = "CodeLabo";
                dgv_util.Columns[2].HeaderText = "Nom";
                dgv_util.Columns[3].HeaderText = "Prenom";
                dgv_util.Columns[4].HeaderText = "Rue";
                dgv_util.Columns[5].HeaderText = "Code Postal";

                dgv_util.Show();                
            }
            if (levisiteur.droit == 1 || levisiteur.droit == null)
            {
                var requete = from v in maConnexion.Visiteur
                              orderby v.nom
                              where v.idVisiteur == levisiteur.idVisiteur
                              select v;
                this.dgv_util.DataSource = ((ObjectQuery)(requete));
                              
                dgv_util.Columns[0].HeaderText = "CodeVisiteur";
                dgv_util.Columns[1].HeaderText = "CodeLabo";
                dgv_util.Columns[2].HeaderText = "Nom";
                dgv_util.Columns[3].HeaderText = "Prenom";
                dgv_util.Columns[4].HeaderText = "Rue";
                dgv_util.Columns[5].HeaderText = "Code Postal";
                dgv_util.Show();              
            }

            if (levisiteur.droit == 2)
            {
                var requete = from v in maConnexion.Visiteur
                              orderby v.nom
                              where v.droit <= 2
                              select v;
                this.dgv_util.DataSource = ((ObjectQuery)(requete));

                dgv_util.Columns[0].HeaderText = "CodeVisiteur";
                dgv_util.Columns[1].HeaderText = "CodeLabo";
                dgv_util.Columns[2].HeaderText = "Nom";
                dgv_util.Columns[3].HeaderText = "Prenom";
                dgv_util.Columns[4].HeaderText = "Rue";
                dgv_util.Columns[5].HeaderText = "Code Postal";
                dgv_util.Show();               
            }           
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // information utilisateur 
            lb_iformation.Text = "Utilisateur Connecté  : " + levisiteur.nom + "  " + levisiteur.prenom;
            // On cache le menu gestion utilisateur si l'utilisateur a le DROIT a 1
            if (levisiteur.droit == 1)
            {
                MS_Gestion.Visible = false;
            }

            dgv_util.Hide();
            MS_RapportVisite.Visible = false;
            MS_Profil.Visible = false;
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            FrmModifierRapport fmodifier = new FrmModifierRapport(maConnexion, levisiteur);
            fmodifier.ShowDialog();
        }

        private void visualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualiserRapport frmVisualiser = new frmVisualiserRapport(maConnexion, levisiteur);
            frmVisualiser.ShowDialog();
            

        }

        private void MS_modifier_Click(object sender, EventArgs e)
        {
            FrmModifierRapport frmModifierRapport = new FrmModifierRapport(maConnexion, levisiteur);
            frmModifierRapport.ShowDialog();
        }

        private void MS_ajouter_Click(object sender, EventArgs e)
        {
            frmCreerRapport frmCreerRapport = new frmCreerRapport(maConnexion, levisiteur);
            frmCreerRapport.ShowDialog();
        }

        private void MS_Gestion_Click(object sender, EventArgs e)
        {
            frmInscriptioncs fInscrire = new frmInscriptioncs(maConnexion, levisiteur);
            fInscrire.ShowDialog();
        }
        #endregion

        #region PARTIE OULAI ISAAC
        //instanciation vue saisie frais
        private void ficheFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFicheFrais fFicheFrais = new frmFicheFrais(maConnexion, levisiteur) ;

            fFicheFrais.ShowDialog();

            fFicheFrais.Refresh();

        }
        //instanciation vue midification frais
        private void modifierFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifierFrais fModifier = new frmModifierFrais(maConnexion, levisiteur);
            fModifier.ShowDialog();
        }
        #endregion
    }
}
