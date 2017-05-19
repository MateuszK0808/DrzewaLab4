using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrzewaLab4
{
    class FifoElem
    {
        public FifoElem(object wartosc)
        {
            Wartosc = wartosc;
            NextPtr = null;
        }
        public object Wartosc;
        public FifoElem NextPtr;
    }
}
