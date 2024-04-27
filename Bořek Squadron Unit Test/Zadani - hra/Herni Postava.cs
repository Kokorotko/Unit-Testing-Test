using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadani___hra
{
    public class Herni_Postava
    {
        protected string jmeno;
        public int level = 1;
        protected float poziceX = 0;
        protected float poziceY = 0;

        public string Jmeno
        {
            get { return jmeno; }
            set 
            {
                if (value.Length <= 10) jmeno = value;
                else MessageBox.Show("Moc Dlouhe More");
            }
        }

        public float PoziceX
        {
            get { return poziceX; }
            set { this.poziceX = value; }
        }

        public float PoziceY
        {
            get { return poziceY; }
            set { this.poziceY = value; }
        }

        public Herni_Postava(string jmeno)
        {
            this.Jmeno = jmeno;
        }

        virtual public void ZmenaPozice()
        {
            PoziceX = Cursor.Position.X;
            PoziceY = Cursor.Position.Y;
        }

        public override string ToString()
        {
            return "Jmeno: " + jmeno + "\nLevel: " + level + "\nPozice X: " + poziceX + "\nPozice Y: " + poziceY;
        }
    }
}
