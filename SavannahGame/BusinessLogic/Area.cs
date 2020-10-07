using Common;
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
        private bool grass;

        public Area(int r)
        {
            
            if (r == 1)
            {
                grass = true;
            }
            else grass = false;
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


        //public override string ToString()
        //{
        //    if (grass == true)
        //    {
        //        return " Der er græs her";
        //    }
        //    return "Der er INGEN græs her";
        //}
    }
}
