using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RapportVisite
{
    public partial class frmInscriptioncs : Form
    {

        private GSB_EQ3Entities maConnexion;
        private Visiteur visiteurConnecte;
        private string passwdCrypte;
        private DateTime date = DateTime.Now;

        public frmInscriptioncs(GSB_EQ3Entities MaConnexion, Visiteur LeVisiteur)
        {
            InitializeComponent();
            maConnexion = MaConnexion;
            visiteurConnecte = LeVisiteur;
        }

        private void frmInscriptioncs_Load(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = maConnexion.Visiteur;
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            if(textBox_mdp.Text == textBox_confirmationMdp.Text)
            {
                //instantion d'un nouveau visiteur vide
                Visiteur unVisiteur = new Visiteur();


                using (MD5 md5Hash = MD5.Create())
                {
                    // On crypte le mot de passe saisi en utilisant la méthode GetMD5Hash de la classe CRYPTAGE
                    this.passwdCrypte = CRYPTAGE.GetMD5Hash(md5Hash, Convert.ToString(textBox_mdp.Text));
                } 
                //affecte a chaque champ visiteur la valeur saisie

                unVisiteur.idVisiteur = textBox_id.Text;
                unVisiteur.nom = textBox_nom.Text;
                unVisiteur.prenom = textBox_prenom.Text;
                unVisiteur.identifiant = textBox_identifiant.Text;
                unVisiteur.password = this.passwdCrypte;
                unVisiteur.droit = Convert.ToInt32(textBox_droit.Text);
                unVisiteur.idLabo = Convert.ToInt32(textBox_Labo.Text);
                unVisiteur.rue = textBox_rue.Text;
                unVisiteur.ville = textBox_ville.Text;
                unVisiteur.cp = textBox_cp.Text;
                unVisiteur.dateEmbauche = date.ToString("yyyy-MM-dd"); ;

                try
                {
                    //ajout du visiteur
                    this.maConnexion.AddToVisiteur(unVisiteur);
                    //sauvegarde
                    this.maConnexion.SaveChanges();
                    MessageBox.Show("Visiteur ajouté.");
                    MessageBox.Show(this.passwdCrypte);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
               
            }
            else
                Console.WriteLine("Erreur de mot de passe!");
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
