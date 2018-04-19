using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ",
            "Attention",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string utilisateur = txtUtilisateur.Text.Trim().ToLower();
            string motPasse = txtMotPasse.Text.Trim().ToLower();
            if (!String.IsNullOrEmpty(utilisateur) && !String.IsNullOrEmpty(motPasse))
            {
                if (utilisateur == "moi" && motPasse == "moi")
                {
                    MessageBox.Show("Bienvenue !", "Bienvenue",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 formulaire = new Form2();
                    formulaire.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Les informations saisies ne sont pas valides.",
                    "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    txtUtilisateur.Text = String.Empty;
                    txtMotPasse.Text = String.Empty;
                    txtUtilisateur.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir votre nom d'utilisateur et votre mot de passe.",
                "Attention",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtUtilisateur.Focus();
            }
        }
    }
}
