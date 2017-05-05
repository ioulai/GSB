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
    public partial class frmFicheFrais : Form
    {
        private GSB_EQ3Entities maConnexion;
        private Visiteur levisiteurConnecte;
        private string leIdVisiteurConnecte;
        private Etat unEtat;        
        private string leMois;
        private string leIdEtat;
        private fichefrais uneNewFicheFrais;
        private decimal montantValide;
        private int justificatif ;

        public frmFicheFrais(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {

            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteurConnecte = Levisiteur;
        }

        #region OUVERTURE DU FORMULAIRE
        private void frmFicheFrais_Load_1(object sender, EventArgs e)
        {
            // chargement de l'utilisateur courant 
            lbl_nom.Text = levisiteurConnecte.nom;
            lbl_prenom.Text = levisiteurConnecte.prenom;
          
            //mise en réserve et affiche du id visiteur connecte
            leIdVisiteurConnecte = levisiteurConnecte.idVisiteur;
            textBox_recap_idVisiteur.Text = levisiteurConnecte.idVisiteur;

            //date courante avec mise en forme 
            textBox_Date.Text = Convert.ToString(DateTime.Today).Substring(0,10);


            // chargement de cbo Etat
            var reqEtat = from E in maConnexion.Etat
                          orderby E.id
                          select E;
            try
            {
                this.cbEtat.DisplayMember = "libelle";
                this.cbEtat.DataSource = ((ObjectQuery)(reqEtat)).Execute(MergeOption.AppendOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TEXTE BOX
        private void textBox_NbJustificatif_TextChanged_1(object sender, EventArgs e)
        {

            justificatif = Convert.ToInt32(textBox_NbJustificatif.Text);
            //justificatif = int.Parse(textBox_NbJustificatif.Text);

            //recap NBJUSTIFICATIF
            textBox_recap_nbJustificatif.Text = Convert.ToString(justificatif);

            //textBox_recap_nbJustificatif.Text = (textBox_NbJustificatif.Text);
        }

        private void textBox_MontantValide_TextChanged_1(object sender, EventArgs e)
        {
            montantValide = Convert.ToDecimal(textBox_MontantValide.Text);
            //montantValide = int.Parse(textBox_MontantValide.Text);

            //recap MONTANT VALIDE
            textBox_recap_montantValide.Text = Convert.ToString(montantValide);
        }
        

        private void textBox_Date_TextChanged_1(object sender, EventArgs e)
        {
            //recap DATE
            textBox_recap_date.Text = textBox_Date.Text;
        }
        #endregion

        #region COMBO BOX
        private void cbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recap Mois
            leMois = Convert.ToString(cbMois.SelectedItem);
            textBox_recap_mois.Text = Convert.ToString(cbMois.SelectedItem);
        }

        private void cbEtat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //affectation à l'objet un Etat de l'enregistrement selectionner dans la zone de liste cbEtat
            unEtat = (Etat)this.cbEtat.SelectedItem;

            //recap ID ETAT
            leIdEtat = unEtat.id;
            textBox_recap_idEtat.Text = Convert.ToString(unEtat.id);
        }
        #endregion

        #region INSERTION
        //SUR CLICK ON INSERE DANS LA BASE DE DONNEES
        private void btn_Ajouter_Click_1(object sender, EventArgs e)
        {
            uneNewFicheFrais = new fichefrais();  

            uneNewFicheFrais.idVisiteur = leIdVisiteurConnecte ;
            uneNewFicheFrais.mois = leMois;
            uneNewFicheFrais.nbJustificatifs = Convert.ToInt32(textBox_NbJustificatif.Text);
            uneNewFicheFrais.montantValide   = Convert.ToDecimal(textBox_MontantValide.Text);
            uneNewFicheFrais.dateModif = textBox_Date.Text;
            uneNewFicheFrais.idEtat = leIdEtat;

            try
            {
                this.maConnexion.AddTofichefrais(uneNewFicheFrais);
                //sauvegarde
                this.maConnexion.SaveChanges();
                MessageBox.Show("La fiche de frais a été ajoutée");
            }
            catch 
            {
                MessageBox.Show("Ajout impossible");
            }
        }
        #endregion
        
        #region QUITTER
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion
    }
}
