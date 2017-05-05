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
using System.Security.Cryptography;

namespace RapportVisite
{
    public partial class frmConnexion : Form
    {
        private GSB_EQ3Entities maConnexion;
        private Visiteur levisiteur;
        
        public frmConnexion()
        {
            InitializeComponent();
            maConnexion = new GSB_EQ3Entities();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            string identifiant = tb_Id.Text;
            string mdp = tb_mdp.Text;
         
            string leIdentifiant = Convert.ToString(tb_Id.Text);
            string lePasswd = Convert.ToString(tb_mdp.Text);
            
            using (MD5 md5Hash = MD5.Create())
            {
                string motCrypte2 = GetMd5Hash(md5Hash, mdp);
                try
                {
                    var reqConnexion = from v in maConnexion.Visiteur
                                       where v.identifiant == identifiant && v.password == motCrypte2
                                       select v;
             
                    
                    Visiteur unVisiteur = reqConnexion.FirstOrDefault();
                    if (unVisiteur != null)
                    {
                        this.levisiteur = unVisiteur;
                        //lblConnexion.Visible = true;
                        //btnValider.Visible = false;
                        //btnOK.Visible = true;

                        this.Hide();
                        frmMenu fMenu = new frmMenu(maConnexion, levisiteur);
                        fMenu.ShowDialog();

                    }
                    else
                    {
                        string message = "Erreur de saisie. Recommencez !";
                        string caption = "Vous n'êtes pas autorisé à vous connecter";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            tb_Id.Clear();
                            tb_mdp.Clear();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string Lepasswd)
        {
            // à faire
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(Lepasswd));
            // Création d'une chaine 
            StringBuilder MotCrypte = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            { MotCrypte.Append(data[i].ToString("x2")); }
            // Return the hexadecimal string.
            return MotCrypte.ToString();
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
