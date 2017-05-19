using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrzewaLab4
{
    public class Wezel
    {
        public Wezel(int val)
        {
            Wartosc = val;
        }

        public int Wartosc;
        public Wezel Lewy = null;
        public Wezel Prawy = null;
    }
}
