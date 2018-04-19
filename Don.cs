using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembreSTE
{
    public class Don 
    {
        private string IDDon;
        private string DateDuDon;
        private string IDDonateur;
        private double MontantDuDon;
        private string IDPrix;

        public string IDDon1
        {
            get
            {
                return IDDon;
            }

            set
            {
                IDDon = value;
            }
        }

        public string DateDuDon1
        {
            get
            {
                return DateDuDon;
            }

            set
            {
                DateDuDon = value;
            }
        }

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

        public double MontantDuDon1
        {
            get
            {
                return MontantDuDon;
            }

            set
            {
                MontantDuDon = value;
            }
        }

        public string IDPrix1
        {
            get
            {
                return IDPrix;
            }

            set
            {
                IDPrix = value;
            }
        }

        public Don(string iDDon, string dateDuDon, string iDDonateur, double montantDuDon, string iDPrix)
        {
            IDDon = iDDon;
            DateDuDon = dateDuDon;
            IDDonateur = iDDonateur;
            MontantDuDon = montantDuDon;
            IDPrix = iDPrix;//???
        }

        public Don(string[] rawInput)
        {
            IDDon = rawInput[rawInput.Length - 5].Trim();
            DateDuDon = rawInput[rawInput.Length - 4].Trim();
            IDDonateur = rawInput[rawInput.Length - 3].Trim();
            MontantDuDon = double.Parse(rawInput[rawInput.Length - 2]);
            IDPrix = rawInput[rawInput.Length - 1].Trim();//???
        }

        public override string ToString()
        {
            return "ID don: " + IDDon1 + ", Date du don: " + DateDuDon1 + ", ID donnateur: " + IDDonateur1 + ", Montant du don: " + MontantDuDon1 + ", ID Prix: " + IDPrix1;
        }

        public string ToFile()
        {
            return IDDon1 + ", " + DateDuDon1 + ", " + IDDonateur1 + ", " + MontantDuDon1 + ", " + IDPrix1;
        }

    }
}
