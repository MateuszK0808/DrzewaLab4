using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrzewaLab4
{
    class FifoL<E> where E : class
    {
        FifoElem Head = null;
        FifoElem Tail = null;
        int numItems = 0;

        public void Enqueue(E wartosc)
        {
            FifoElem newElem = new FifoElem(wartosc);
            if (IsEmpty()) Tail = Head = newElem;    
            else
            {
                newElem.NextPtr = null;
                Tail.NextPtr = newElem;
                Tail = newElem;
            }
            numItems++;
        }

        public E Dequeue()
        {
            if (IsEmpty())
            {
                return null;
            }
            else
            {
                object toReturn = Head.Wartosc;
                Head = Head.NextPtr;
                numItems--;
                if (Head == null) Tail = null;
                return (E)toReturn;
            }
        }

        public bool IsEmpty()
        {
            if (Head == null) return true;
            else return false;
        }
    }
}
