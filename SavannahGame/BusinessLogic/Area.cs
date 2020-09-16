using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class Area
    {
        //private int num;
        private bool grass;
        //public Animal animal { get; set; }

        //Random r = new Random();

        public Area(int r)
        {
            

            if (r == 1)
            {
                grass = true;
            }
            else grass = false;
            //num = count;
        }

        public bool ContainsGrass()
        {
            return (grass == true) ? true : false;
        }

        public void GrassEaten()
        {
            grass = false;
        }
        public void GrassGrows()
        {
            grass = true;
        }


        public override string ToString()
        {
            if (grass == true)
            {
                return " Der er græs her";
            }
            return "Der er INGEN græs her";
        }
    }
}
