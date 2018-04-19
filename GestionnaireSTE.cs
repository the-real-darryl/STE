using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreSTE
{
    public class GestionnaireSTE
    {
        List<Donnateur> donnateurs;
        List<Commandiatire> commanditaires;
        List<Don> dons;
        List<Prix> prix;

        private readonly string[] nom_fichiers = { "commanditaires.txt", "prix.txt", "donnateurs.txt", "dons.txt" };

        public List<Donnateur> Donnateurs
        {
            get
            {
                return donnateurs;
            }

            set
            {
                donnateurs = value;
            }
        }

        public List<Commandiatire> Commanditaires
        {
            get
            {
                return commanditaires;
            }

            set
            {
                commanditaires = value;
            }
        }

        public List<Don> Dons
        {
            get
            {
                return dons;
            }

            set
            {
                dons = value;
            }
        }

        public List<Prix> Prix
        {
            get
            {
                return prix;
            }

            set
            {
                prix = value;
            }
        }

        public GestionnaireSTE()
        {
            commanditaires = new List<Commandiatire>();
            prix = new List<Prix>();
            donnateurs = new List<Donnateur>();
            dons = new List<Don>();

            string ligne;
            string[] donne;
            ArrayList objet_pour_lecture = new ArrayList();
            objet_pour_lecture.Add(commanditaires);
            objet_pour_lecture.Add(prix);
            objet_pour_lecture.Add(donnateurs);
            objet_pour_lecture.Add(dons);

            for (byte lecteur_ = 0; lecteur_ < 4; lecteur_++)
            {
                if (File.Exists(nom_fichiers[lecteur_]))
                {
                    StreamReader lecteur = new StreamReader(nom_fichiers[lecteur_]);

                    switch (lecteur_)
                    {
                        case 0:
                            while ((ligne = lecteur.ReadLine()) != null)
                            {
                                donne = ligne.Split(',');
                                ((List<Commandiatire>)objet_pour_lecture[lecteur_]).Add(new Commandiatire(donne));
                            }
                            break;

                        case 1:
                            while ((ligne = lecteur.ReadLine()) != null)
                            {
                                donne = ligne.Split(',');
                                ((List<Prix>)objet_pour_lecture[lecteur_]).Add(new Prix(donne));
                            }
                            break;

                        case 2:
                            while ((ligne = lecteur.ReadLine()) != null)
                            {
                                donne = ligne.Split(',');
                                ((List<Donnateur>)objet_pour_lecture[lecteur_]).Add(new Donnateur(donne));
                            }
                            break;

                        case 3:
                            while ((ligne = lecteur.ReadLine()) != null)
                            {
                                donne = ligne.Split(',');
                                ((List<Don>)objet_pour_lecture[lecteur_]).Add(new Don(donne));
                            }
                            break;
                    }

                    lecteur.Close();
                }

                donne = null;
            }

        }

        public void AjouterDonnateur(string iDDonateur, string prenom, string surnom, string adresse, string telephone, char typeDeCarte, string numeroDeCarte, string dateExpiration)
        {
            donnateurs.Add(new Donnateur(iDDonateur, prenom, surnom, adresse, telephone, typeDeCarte, numeroDeCarte, dateExpiration));
        }

        public void AjouterCommanditaire(string iDCommanditaire, string prenom, string surnom)
        {
            commanditaires.Add(new Commandiatire(iDCommanditaire, prenom, surnom));
        }

        public void AjouterPrix(string iDPrix, string description, double valeur, double donMinimum, int qnte_Originale, string iDCommanditaire)
        {
            prix.Add(new Prix(iDPrix, description, valeur, donMinimum, qnte_Originale, iDCommanditaire));
        }

        public void AjouterDon(string iDDon, string dateDuDon, string iDDonateur, double montantDuDon, string iDPrix)
        {
            dons.Add(new Don(iDDon, dateDuDon, iDDonateur, montantDuDon, iDPrix));
        }

        public string AfficherDonnateur()
        {
            string ds = "";
            foreach (Donnateur d in Donnateurs)
            {
                ds += d.ToString() + "\n";
            }
            return ds;
        }

        public string AfficherCommanditaires()
        {
            string cs = "";
            foreach (Commandiatire c in Commanditaires)
            {
                cs += c.ToString() + "\n";
            }
            return cs;
        }

        public string AfficherPrix()
        {
            string ps = "";
            foreach (Prix p in Prix)
            {
                ps += p.ToString() + "\n";
            }
            return ps;
        }

        public string AfficherDons()
        {
            string ds = "";
            foreach (Don d in Dons)
            {
                ds += d.ToString() + "\n";
            }
            return ds;
        }

        public bool AttribuerPrix(double a)
        {
            if (a > 50 && a <= 199)
            {
                //dons// idprix
            }
            else if (a <= 349)
            {

            }
            else if (a <= 500)
            {

            }
            else
            {

            }
            return false;
        }

        /*public void Importer(string nomFichier)
        {
            string ligne;
            string[] donnats;
            if (!File.Exists(nomFichier))
            {
                throw new Exception($" Le fichier { nomFichier} n’existe pas dans mon répertoire.");
            }
            else
            {
                StreamReader lecteur = new StreamReader(nomFichier);
                while ((ligne = lecteur.ReadLine()) != null)
                {
                    donnats = ligne.Split(',');
                    donnateurs.Add(new Donnateur(donnats[0], donnats[1], donnats[2], donnats[3], donnats[4], (donnats[5])[0], donnats[6], donnats[7]));
                }
                lecteur.Close();
            }

        }*/

        public void Exporter()
        {
            StreamWriter commanditaires_flux = new StreamWriter(nom_fichiers[0]);
            foreach (Commandiatire commandiatire_ in commanditaires)
            {
                commanditaires_flux.WriteLine(commandiatire_.ToFile());
            }
            commanditaires_flux.Close();

            StreamWriter prix_flux = new StreamWriter(nom_fichiers[1]);
            foreach (Prix prix_ in prix)
            {
                prix_flux.WriteLine(prix_.ToFile());
            }
            prix_flux.Close();

            StreamWriter donnateurs_flux = new StreamWriter(nom_fichiers[2]);
            foreach (Donnateur donnateurs_ in donnateurs)
            {
                donnateurs_flux.WriteLine(donnateurs_.ToFile());
            }
            donnateurs_flux.Close();

            StreamWriter dons_flux = new StreamWriter(nom_fichiers[3]);
            foreach (Don dons_ in dons)
            {
                dons_flux.WriteLine(dons_.ToFile());
            }
            dons_flux.Close();
        }
    }
}
