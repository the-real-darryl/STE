using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreSTE
{
    public class Personne 
    {
        private string Prenom;
        private string Surnom;

        public Personne(string prenom, string surnom)
        {
            Prenom = prenom;
            Surnom = surnom;
        }

        public Personne(string[] rawInput)
        {
            Prenom = rawInput[rawInput.Length - 2].Trim();
            Surnom = rawInput[rawInput.Length - 1].Trim();
        }

        public string Prenom1
        {
            get
            {
                return Prenom;
            }

            set
            {
                Prenom = value;
            }
        }

        public string Surnom1
        {
            get
            {
                return Surnom;
            }

            set
            {
                Surnom = value;
            }
        }

        public override string ToString()
        {
            return " Nom: " + Prenom1 + ", " + Surnom1;
        }

        public string ToFile()
        {
            return Prenom1 + ", " + Surnom;
        }
    }
}
