using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrzewaLab4
{
    public class Drzewo
    {
        private static string c192 = "└";
        private static string c179 = "│";
        private static string c195 = "├";
        private static string c196 = "─";
        private static string c218 = "┌";
        private string CR = c218 + c196; //┌-
        private string CL = c192 + c196; //└-
        private string CP = c179 + " ";        //|

        
        public Wezel Root = null;

        public void PrintTree()
        {
            PrintTree("", "", Root);
        }

        public void DFS_PreOrder()
        {
            DFS_PreOrder(Root);
        }

        public void BFS()
        {
            BFS(Root);
        }

        private void DFS_PreOrder(Wezel V)
        {
            if (V == null) return;
            Console.Write(V.Wartosc);
            Console.ReadLine();
            DFS_PreOrder(V.Lewy);
            DFS_PreOrder(V.Prawy);
        }

        FifoL<Wezel> Fifo = new FifoL<Wezel>();
        private void BFS(Wezel V)
        {
            Fifo.Enqueue(V);
            while (!Fifo.IsEmpty())
            {
                
                Wezel w = Fifo.Dequeue();
                Console.Write(w.Wartosc);
                Console.ReadLine();
                if (w.Lewy != null)
                {
                    Fifo.Enqueue(w.Lewy);
                }
                if (w.Prawy != null)
                {
                    Fifo.Enqueue(w.Prawy);
                }
            }
        }

        private void PrintTree(string sp, string sn, Wezel v)
        {
            string s;

            if (v != null)
            {
                s = sp;
                if (sn == CR)
                {
                    StringBuilder sb = new StringBuilder(s);
                    sb[s.Length - 2] = ' ';
                    s = sb.ToString();
                }
                PrintTree(s + CP, CR, v.Prawy);

                if (sp.Length > 1)
                    s = sp.Substring(0, sp.Length - 2);
                Console.WriteLine(s + sn + v.Wartosc);
                //cout << s << sn << v->data << endl;

                s = sp;
                if (sn == CL)
                {
                    StringBuilder sb = new StringBuilder(s);
                    sb[s.Length - 2] = ' ';
                    s = sb.ToString();
                }
                PrintTree(s + CP, CL, v.Lewy);
            }
        }
    }
}

