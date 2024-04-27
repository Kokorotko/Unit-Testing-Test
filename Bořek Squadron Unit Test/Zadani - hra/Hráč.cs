using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadani___hra
{
    public class Hráč : Herni_Postava
    {
        public enum Obličej
        {
            VelkyNos,
            Ušoplesk,
            MakeUp
        }

        public enum Vlasy
        {
            Drdol,
            Culík,
            Pleška
        }

        public enum BarvaVlasu
        {
            Kaštanová,
            Blond,
            Červená
        }

        protected string specializace;
        public Obličej obličej;
        public Vlasy vlasy;
        public BarvaVlasu barvaVlasu;
        public double xp = 0;

        public string Specializace
        {
            get { return specializace; }
            set
            {
                string[] hodnoty = new string[] { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
                for (int i = 0; i < hodnoty.Length; i++)
                {
                    if (value == hodnoty[i])
                    {
                        specializace = value;
                        break;
                    }
                }
            }
        }
        public Hráč(string jmeno, string specializace, Obličej face, Vlasy hair, BarvaVlasu haircolour) : base(jmeno)
        {
            this.Specializace = specializace;
            this.obličej = face;
            this.vlasy = hair;
            this.barvaVlasu = haircolour;
        }

        public void PridejXP(double expierence)
        {
            xp += expierence;
            double neededXP = 100;           
            for (int i = 1; expierence >= neededXP; i++) //přepočítání Levelu podle XP
            {
                if (i > level) level++;
                neededXP += (i + 1) * 100;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSpecializace: " + specializace + "\nObličej: " + obličej + "\nVlasy: " + vlasy + "\nBarva Vlasu: " + barvaVlasu + "\nXP: " + xp; ;
        }
    }
}

