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
    public partial class frmModifierFrais : Form
    {

        private GSB_EQ3Entities maConnexion;
        private Visiteur levisiteurConnecte;
        fichefrais ceFrais;
        private int montantValide, justificatif;
        private string idEtat;
        private Etat unEtat;
        private string ceIdVisiteur;

        public frmModifierFrais(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteurConnecte = Levisiteur;
            ceIdVisiteur = levisiteurConnecte.idVisiteur;
        }

# region Au chargement du formulaire
        private void frmModifierFrais_Load(object sender, EventArgs e)
        {
           // bsModifierFrais.DataSource = maConnexion.fichefrais;

            afficheRecap();   
        }
#endregion

        #region Au chargement du formulaire On affiche toutes les fiches de frais du visiteur connecté
        public void afficheRecap()
        {
            panelDetail.Visible = false;
            try
            {
                var reqFicheFrais = from f in maConnexion.fichefrais
                                join e in maConnexion.Etat on f.idEtat equals e.id
                                where f.idVisiteur == ceIdVisiteur
                                orderby f.dateModif
                                select new { f.mois, e.libelle, f.nbJustificatifs, f.montantValide, f.dateModif, f.idEtat };
            //chargement de fiche frais avec le visiteur lié à cette fiche frais 
            this.dgv_modifier.DataSource = ((ObjectQuery)(reqFicheFrais));

            // Appliquer des styles par défaut aux données du dataGridview
            dgv_modifier.DefaultCellStyle.Font = new Font("Calibri", 9);
            dgv_modifier.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // les ajouts et suppressions sont interdits
            dgv_modifier.AllowUserToAddRows = false;
            dgv_modifier.AllowUserToDeleteRows = false;

            dgv_modifier.Columns[0].HeaderText = "mois";
            dgv_modifier.Columns[0].Width = 60;
            dgv_modifier.Columns[1].HeaderText = "Etat";
            dgv_modifier.Columns[1].Width = 180;
            dgv_modifier.Columns[1].DefaultCellStyle.Font = new Font("Calibri", 9, FontStyle.Bold);
            dgv_modifier.Columns[2].Visible = false;
            dgv_modifier.Columns[3].Visible = false;
            dgv_modifier.Columns[4].Visible = false;
            dgv_modifier.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Sur clic sur une ligne des lignes de frais du dataGriedView
        private void dgv_modifier_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // chargement de cbo Etat
            var reqEtat = from E in maConnexion.Etat
                          orderby E.id
                          select E;
            try
            {
                this.cbEtat_modif.DisplayMember = "libelle";
                this.cbEtat_modif.DataSource = ((ObjectQuery)(reqEtat)).Execute(MergeOption.AppendOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // L'utilisateur ne peut sélectionner qu'une seule ligne à la fois
            dgv_modifier.MultiSelect = false;
            // on rend visible le panel et on active la ligne du dgv courante
            panelDetail.Visible = true;
            var laFicheFrais = this.dgv_modifier.CurrentRow;
            // Utile de connaitre le mois de la fiche de frais à modifier si appel de modification
           string leMois = Convert.ToString(laFicheFrais.Cells[0].Value);
            string idEtatFiche = Convert.ToString(laFicheFrais.Cells[5].Value);
            txtNbJustificatifs.Text = Convert.ToString(laFicheFrais.Cells[2].Value);
            txtMontantValide.Text = Convert.ToString(laFicheFrais.Cells[3].Value);
            // On format la date pour qu'elle apparaisse sous le format aaaa/mm/jj sans les heures
            txtDate.Text = Convert.ToString(laFicheFrais.Cells[4].Value).Substring(0, 10);

            cbMois_modif.Text = Convert.ToString(laFicheFrais.Cells[0].Value);
            txtMontantValide_modif.Text = Convert.ToString(laFicheFrais.Cells[3].Value);
            txtNbJustificatif_modif.Text = Convert.ToString(laFicheFrais.Cells[2].Value);
            cbEtat_modif.Text = Convert.ToString(laFicheFrais.Cells[1].Value);
        }
        #endregion


        // Méthode pour affecter les valeurs saisies aux champs de l'enregistrement avant son ajout ou sa mise à jour
        public void Affecter()
        {
            justificatif = Convert.ToInt32(txtNbJustificatif_modif.Text);
            justificatif = int.Parse(txtNbJustificatif_modif.Text);

            montantValide = Convert.ToInt32(txtMontantValide_modif.Text);
            montantValide = int.Parse(txtMontantValide_modif.Text);



            ceFrais = (fichefrais)this.bsModifierFrais.Current;
            ceFrais.idVisiteur = levisiteurConnecte.idVisiteur;
            ceFrais.mois = cbMois_modif.Text;
            ceFrais.montantValide = montantValide;
            ceFrais.nbJustificatifs = justificatif;
            // ceFrais.Etat = idEtat;


        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            this.maConnexion.SaveChanges();
        }

        

        private void cbEtat_SelectedIndexChanged(object sender, EventArgs e)
        {
            unEtat = (Etat)this.cbEtat_modif.SelectedItem;
            idEtat = Convert.ToString( unEtat.id);
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
