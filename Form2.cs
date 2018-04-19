using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MembreSTE;

namespace STE
{
    public partial class Form2 : Form
    {
        GestionnaireSTE gste;
        public Form2()
        {
            gste = new GestionnaireSTE();
            InitializeComponent();
        }

        private void btnAjouterDon_Click(object sender, EventArgs e)
        {
            string iDDon = txtIDDon.Text;
            DateTime ahjourdui = DateTime.Now;
            string dateDuDon = ahjourdui.ToString("dd/MM/yyyy");
            string iDDonateur = txtIDDonneur.Text;
            double montantDuDon = Double.Parse(txtMontantDon.Text);
            string iDPrix = txtIDPrixDonneurs.Text;
            if (!String.IsNullOrEmpty(iDDon) && !String.IsNullOrEmpty(iDDonateur) && montantDuDon > 0 && !String.IsNullOrEmpty(iDPrix))
            {
                gste.AjouterDon(iDDon, dateDuDon, iDDonateur, montantDuDon, iDPrix);
                txtIDDon.Text = String.Empty;
                txtIDDonneur.Text = String.Empty;
                txtMontantDon.Text = String.Empty;
                txtIDPrixDonneurs.Text = String.Empty;
                txtIDDon.Focus();
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Vous devez remplir tous les donnes",
            "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAfficherDon_Click(object sender, EventArgs e)
        {
            rtbArea.Text = gste.AfficherDons();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            gste.Exporter();
            Application.Exit();

        }

        private void btnAjouterDonneur_Click(object sender, EventArgs e)
        {
            string iDDonateur = txtIDDonneur.Text.Trim();
            string prenom = txtPrenomDonneur.Text.Trim();
            string surnom = txtNomDonneur.Text.Trim();
            string adresse = txtAdresseDonneur.Text.Trim();
            string telephone = txtTelDonneur.Text.Trim();
            char typeDeCarte;
            if (rbVisa.Checked)
            {
                typeDeCarte = 'V';
            }
            else if (rbMasterCard.Checked)
            {
                typeDeCarte = 'M';
            }
            else
            {
                typeDeCarte = 'A';
            }
            string numeroDeCarte = txtNumeroCarte.Text.Trim();
            string dateExpiration = txtDateExpirationCarte.Text.Trim();
            if (!String.IsNullOrEmpty(iDDonateur) && !String.IsNullOrEmpty(prenom) && !String.IsNullOrEmpty(surnom) && !String.IsNullOrEmpty(adresse) &&
                !String.IsNullOrEmpty(telephone) && !String.IsNullOrEmpty(numeroDeCarte) && !String.IsNullOrEmpty(dateExpiration))
            {
                if (rbVisa.Checked || rbMasterCard.Checked || rbAmex.Checked)
                {
                    gste.AjouterDonnateur(iDDonateur, prenom, surnom, adresse, telephone, typeDeCarte, numeroDeCarte, dateExpiration);
                    txtIDDonneur.Text = String.Empty;
                    txtPrenomDonneur.Text = String.Empty;
                    txtNomDonneur.Text = String.Empty;
                    txtAdresseDonneur.Text = String.Empty;
                    txtTelDonneur.Text = String.Empty;
                    rbVisa.Checked = false;
                    rbMasterCard.Checked = false;
                    rbAmex.Checked = false;
                    txtNumeroCarte.Text = String.Empty;
                    txtDateExpirationCarte.Text = String.Empty;
                    txtIDDonneur.Focus();
                }
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Vous devez remplir tous les donnes et choisir le type de votre carte: ",
            "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAfficherDonneur_Click(object sender, EventArgs e)
        {
            rtbArea.Text = gste.AfficherDonnateur();
        }

        private void btnAjouterCommanditaire_Click(object sender, EventArgs e)
        {
            string iDCommanditaire = txtIDCommanditaire.Text.Trim();
            string prenom = txtPrenomCommanditaire.Text.Trim();
            string surnom = txtNomCommanditaire.Text.Trim();
            if (!String.IsNullOrEmpty(iDCommanditaire) && !String.IsNullOrEmpty(prenom) && !String.IsNullOrEmpty(surnom))
            {
                gste.AjouterCommanditaire(iDCommanditaire, prenom, surnom);
                txtIDCommanditaire.Text = String.Empty;
                txtPrenomCommanditaire.Text = String.Empty;
                txtNomCommanditaire.Text = String.Empty;
                txtIDCommanditaire.Focus();
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Vous devez remplir tous les donnes! ",
            "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            rtbArea.Text = gste.AfficherCommanditaires();

        }

        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            //string iDPrix, string description, double valeur, double donMinimum, int qnte_Originale, string iDCommanditaire
            string iDPrix = txtIDPrixCommanditaire.Text.Trim();
            string description = txtDescriptionPrix.Text.Trim();
            double valeur = Double.Parse(txtValeurPrix.Text.Trim());
            double donMinimum = Double.Parse(txtDonMinimumPrix.Text.Trim());
            int qnte_Originale = Int32.Parse(txtQuantitePrix.Text.Trim());
            string iDCommanditaire = txtIDCommanditaire.Text.Trim();
            if (!String.IsNullOrEmpty(iDPrix) && !String.IsNullOrEmpty(description) && valeur > 0 && donMinimum > 0 && qnte_Originale > 0)
            {
                gste.AjouterPrix(iDPrix, description, valeur, donMinimum, qnte_Originale, iDCommanditaire);
                txtIDPrixCommanditaire.Text = String.Empty;
                txtDescriptionPrix.Text = String.Empty;
                txtValeurPrix.Text = String.Empty;
                txtDonMinimumPrix.Text = String.Empty;
                txtQuantitePrix.Text = String.Empty;
                txtIDCommanditaire.Text = String.Empty;
                txtIDPrixCommanditaire.Focus();
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Vous devez remplir tous les donnes! ",
           "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAfficherPrix_Click(object sender, EventArgs e)
        {
            rtbArea.Text = gste.AfficherPrix();
        }

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomFichier = openFileDialog1.FileName;
                gste.Importer(nomFichier);
            }*/
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "Txt files |*.txt| all files|*.*";
            //saveFileDialog1.AddExtension = true;
            //saveFileDialog1.Title = "resultsd";
            //saveFileDialog1.CheckFileExists = false;
            //saveFileDialog1.CheckPathExists = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomFichier = saveFileDialog1.FileName;
                // gste.Importer(nomFichier);
                gste.Exporter();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult response = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.No)
            {
                e.Cancel = true;

            }
        }
    }
}
