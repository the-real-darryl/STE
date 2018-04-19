using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreSTE 
{
    public class Donnateur : Personne
    {
        private string IDDonateur;
        private string Adresse;
        private string Telephone;
        private char TypeDeCarte;
        private string NumeroDeCarte;
        private string DateExpiration;

        public string IDDonateur1
        {
            get
            {
                return IDDonateur;
            }

            set
            {
                IDDonateur = value;
            }
        }

        public string Adresse1
        {
            get
            {
                return Adresse;
            }

            set
            {
                Adresse = value;
            }
        }

        public string Telephone1
        {
            get
            {
                return Telephone;
            }

            set
            {
                Telephone = value;
            }
        }

        public char TypeDeCarte1
        {
            get
            {
                return TypeDeCarte;
            }

            set
            {
                TypeDeCarte = value;
            }
        }

        public string NumeroDeCarte1
        {
            get
            {
                return NumeroDeCarte;
            }

            set
            {
                NumeroDeCarte = value;
            }
        }

        public string DateExpiration1
        {
            get
            {
                return DateExpiration;
            }

            set
            {
                DateExpiration = value;
            }
        }

        public Donnateur(string iDDonateur, string prenom, string surnom, string adresse, string telephone, char typeDeCarte, string numeroDeCarte, string dateExpiration) : base(prenom, surnom)
        {
            IDDonateur = iDDonateur;
            Adresse = adresse;
            Telephone = telephone;
            TypeDeCarte = typeDeCarte;
            NumeroDeCarte = numeroDeCarte;
            DateExpiration = dateExpiration;
        }

        public Donnateur(string[] rawInput) : base(rawInput)
        {
            IDDonateur = rawInput[rawInput.Length - 8].Trim();
            Adresse = rawInput[rawInput.Length - 7].Trim();
            Telephone = rawInput[rawInput.Length - 6].Trim();
            TypeDeCarte = char.Parse(rawInput[rawInput.Length - 5].Trim());
            NumeroDeCarte = rawInput[rawInput.Length - 4].Trim();
            DateExpiration = rawInput[rawInput.Length - 3].Trim();
        }



        public override string ToString()
        {
            return "ID Donnateur: " + IDDonateur + " " + base.ToString() + ", Adresse: " + Adresse + ", telephone: " + Telephone +
                        ",\n Carte: " + TypeDeCarte.ToString() + ", Numero: " + NumeroDeCarte + ", Date d'expiration: " + DateExpiration;
        }

        public string ToFile()
        {
            return IDDonateur + ", " + Adresse + ", " + Telephone + ", " + TypeDeCarte.ToString() + ", " + NumeroDeCarte +
                ", " + DateExpiration + ", " + base.ToFile();
        }
    }
}
