using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Zadani___hra
{
    public class Hra
    {
        private string jmeno;
        public int level = 1;
        private double poziceX;
        private double poziceY;


        public string Jmeno
        {
            get 
            { 
                return jmeno; 
            }
            set
            {
                jmeno = value;
            }
        }

        public double PoziceX
        {
            get
            {
                return poziceX;
            }
            set
            {
                poziceX = value;
            }
        }

        public double PoziceY
        {
            get
            {
                return poziceY;
            }
            set
            {
                poziceY = value;
            }
        }


        public void NastaveniJmena(string jmeno)
        {
            this.jmeno = jmeno;
        }

        //******************************************************

        //Hrac 
        private string specializace;
        public int oblicej;
        public int vlasy;
        public int barvaVlasu;
        public int XP;


        public string Specializace
        {
            get
            {
                return specializace;
            }
            set
            {
                specializace = value;
            }
        }

        public void PridejXP(int pocetXP)
        {
            XP += pocetXP;
            level = XP / 100;
            level++;
        }

        //******************************************************
        //NPC

        public int prace;
        public int sila = 20;
        public int poziceNPCX;
        public int poziceNPCY;

    }
}
