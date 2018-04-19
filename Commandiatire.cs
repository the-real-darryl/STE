using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreSTE
{
    public class Commandiatire : Personne
    {
        private string IDCommanditaire;

        public Commandiatire(string iDCommanditaire, string prenom, string surnom) : base(prenom, surnom)
        {
            IDCommanditaire = iDCommanditaire;
        }

        public Commandiatire(string[] rawInput) : base(rawInput)
        {
            IDCommanditaire = rawInput[rawInput.Length - 3].Trim();
        }

        public string IDCommanditaire1
        {
            get
            {
                return IDCommanditaire;
            }

            set
            {
                IDCommanditaire = value;
            }
        }

        public override string ToString()
        {
            return "ID Commanditaire: " + IDCommanditaire1 + ", " + base.ToString();
        }

        public string ToFile()
        {
            return IDCommanditaire1 + ", " + base.ToFile();
        }
    }

}
