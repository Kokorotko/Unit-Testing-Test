using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadani___hra
{
    public class NPC : Hráč
    {
        public Práce prace;
        public enum Práce
        {
            obchodník,
            nepřítel,
            obyvatel
        }
        public int sila;
        public bool boss = false;

        public NPC(string jmeno, string specializace, Obličej face, Vlasy hair, BarvaVlasu haircolour, Práce práce, int síla, bool boss) : base(jmeno, specializace, face, hair, haircolour)
        {
            this.prace = práce;
            this.sila = síla;
            this.boss = boss;
        }

        public NPC(string jmeno, string specializace, Obličej face, Vlasy hair, BarvaVlasu haircolour, Práce práce) : base(jmeno, specializace, face, hair, haircolour)
        {
            this.prace = práce;
            this.boss = false;
        }

        public void PoziceNPCX(float x)
        {
            PoziceX = x;
        }

        public void PoziceNPCY(float y)
        {
            PoziceY = y;
        }

        public override string ToString()
        {
            return base.ToString() + "\nPráce: " + prace + "\nsíla: " + sila + "\nBoss: " + boss;
        }
    }
}
