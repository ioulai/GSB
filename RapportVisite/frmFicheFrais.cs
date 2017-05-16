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
        private fichefrais uneNewFicheFrais;
        private FraisForfait unFraisForfait;
        private LigneFraisForfait uneLigneFrais;
        private string leMois;
       // private decimal calculTotal;        
        //private string leIdEtat;
        //private decimal montantValide;
        // private int justificatif ;

        public frmFicheFrais(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {

            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteurConnecte = Levisiteur;
            leIdVisiteurConnecte = levisiteurConnecte.idVisiteur;
           
        }

        #region OUVERTURE DU FORMULAIRE
        private void frmFicheFrais_Load_1(object sender, EventArgs e)
        {
            // Le panelLigneFrais est caché
            pnl_ajoutFrais.Visible = false;

            // chargement de l'utilisateur courant 
            lbl_nom.Text = levisiteurConnecte.nom;
            lbl_prenom.Text = levisiteurConnecte.prenom;
          
            //mise en réserve et affiche du id visiteur connecte
            leIdVisiteurConnecte = levisiteurConnecte.idVisiteur;
            

            //date courante avec mise en forme 
            //textBox_Date.Text = Convert.ToString(DateTime.Today).Substring(0,10);
            lbl_date.Text = Convert.ToString(DateTime.Today).Substring(0, 10);

            SaisirUneLigne();
            
        }
        #endregion

        #region Ajout fiche frais
        //SUR CLICK ON INSERE DANS LA BASE DE DONNEES
        private void btn_Ajouter_Click_1(object sender, EventArgs e)
        {
            //recap Mois
            leMois = Convert.ToString(cbMois.SelectedItem);

            

            //creation d'une fiche frais
            uneNewFicheFrais = new fichefrais();  

            uneNewFicheFrais.idVisiteur = leIdVisiteurConnecte ;
            uneNewFicheFrais.mois = leMois;
            uneNewFicheFrais.nbJustificatifs = Convert.ToInt32(textBox_NbJustificatif.Text);
            uneNewFicheFrais.montantValide   = Convert.ToDecimal(textBox_MontantValide.Text);
            uneNewFicheFrais.dateModif = lbl_date.Text;
            // par defauts "fiche céée, saisie en cours
            uneNewFicheFrais.idEtat ="CR" ;

            try
            {
                
                this.maConnexion.AddTofichefrais(uneNewFicheFrais);
                //sauvegarde
                this.maConnexion.SaveChanges();                
                MessageBox.Show("La fiche de frais a été ajoutée");
                //rendre le panel visible
                pnl_ajoutFrais.Visible = true;
            }
            catch 
            {
                              
                MessageBox.Show("Ajout impossible, la fiche existe déja");

                //rendre le panel invisible si ajout impossible
                pnl_ajoutFrais.Visible = false;
            }
        }
        #endregion

        #region Saisie d'une ligne de frais
        private void SaisirUneLigne()
        {
            // On prépare par une requête LINQ pour les des données à afficher concernant les FraisForfaits 
            var reqFraisForfait = from ff in maConnexion.FraisForfait
                                  orderby ff.libelle
                                  select ff;

            try
            {
                this.cb_fraisForfaits.DisplayMember = "libelle";
                this.cb_fraisForfaits.DataSource = ((ObjectQuery)(reqFraisForfait)).Execute(MergeOption.AppendOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Lorsque l'utilisateur sélectionne un type de frais on affiche le tarif
        private void cb_fraisForfaits_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {// affectation à l'objet leFraisForfait de l'enregistrement FraisForfait sélectionné dans le comboBox cbTypeFrais  
                unFraisForfait = (FraisForfait)this.cb_fraisForfaits.SelectedItem;
                txt_tarif.Text = Convert.ToString(unFraisForfait.montant);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // Lorsque l'utilisateur saisit une quantité on calcule le total
        private void txt_montant_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txt_quantité_TextChanged(object sender, EventArgs e)
        {
            
            decimal montantTotal = Convert.ToInt32(txt_quantité.Text) * Convert.ToDecimal(txt_tarif.Text);
                txt_montant.Text = Convert.ToString(montantTotal);
           
        }
        #endregion

        #region Ajout ligne de frais
        private void btn_ajoutFrais_Click(object sender, EventArgs e)
        {
            // On instancie une nouvelle fiche de frais
            uneLigneFrais = new LigneFraisForfait();

            // On prépare l'affectation des valeurs
            uneLigneFrais.idVisiteur = leIdVisiteurConnecte;
            uneLigneFrais.mois = leMois;
            uneLigneFrais.idFraisForfait = unFraisForfait.id;
            uneLigneFrais.quantite = Convert.ToInt32(txt_quantité.Text);

            // On ajoute la ligne
            try
            {
                this.maConnexion.AddToLigneFraisForfait(uneLigneFrais);
                this.maConnexion.SaveChanges();


                recap();

            }
            catch
            {
                // Message d'alerte information pour l'utilisateur
                MessageBox.Show("Ce type de frais a déjà été saisi", "Ajout impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region recapitulatif
        private void recap()
        {
            // préparation d'une requête qui récupère tous les éléments à afficher dans le récapitulatif
            var reqLesLignesFrais = from ll in maConnexion.LigneFraisForfait
                                    join ff in maConnexion.fichefrais on (ll.idVisiteur + ll.mois) equals (ff.idVisiteur + ff.mois)
                                    join tf in maConnexion.FraisForfait on ll.idFraisForfait equals tf.id
                                    where (ff.idVisiteur == levisiteurConnecte.idVisiteur && ff.mois == leMois)
                                    select new { tf.libelle, ll.quantite, tf.montant };

            this.dgv_ligneDeFraisForfait.DataSource = ((ObjectQuery)(reqLesLignesFrais));

            // On formate le contenu du datGriedview dgv_ligneDeFraisForfait pour un affichage correct                
            // L'entête de colonne des autres champs sont modifiés
            dgv_ligneDeFraisForfait.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ligneDeFraisForfait.Columns[0].HeaderText = "Frais";
            dgv_ligneDeFraisForfait.Columns[0].Width = 140;
            dgv_ligneDeFraisForfait.Columns[1].HeaderText = "Quantité";
            dgv_ligneDeFraisForfait.Columns[1].Width = 80;
            dgv_ligneDeFraisForfait.Columns[2].HeaderText = "Montant";
            dgv_ligneDeFraisForfait.Columns[2].Width = 80;
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
