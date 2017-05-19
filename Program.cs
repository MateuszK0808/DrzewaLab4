using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrzewaLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dlugosc;
            int licznik = 1;
            List<int> elementy = new List<int>();
            List<Wezel> wezly = new List<Wezel>();
            Drzewo Tree = new Drzewo();

            Console.WriteLine("Podaj długość drzewa");

            try 
            {
                dlugosc = int.Parse(Console.ReadLine());        
                for (int i = 0; i < dlugosc; i++)
                {
                    elementy.Add(rnd.Next(1, dlugosc * 10));
                }
            }
            catch(System.FormatException error)
            {
                throw error;
            }                                           
            Wezel root = new Wezel(elementy[0]);
            wezly.Add(root);

            Tree.Root = root;
            for (int j = 0; j < wezly.Count; j++)
            {
                if (licznik < elementy.Count)
                {
                    wezly[j].Lewy = new Wezel(elementy[licznik]);
                    if (licznik + 1 < elementy.Count)
                    {
                        wezly[j].Prawy = new Wezel(elementy[licznik + 1]);
                    }
                    wezly.Add(wezly[j].Lewy);
                    wezly.Add(wezly[j].Prawy);
                    licznik += 2;
                }
                else break;
            }
            Tree.PrintTree();
            Console.WriteLine("Przejście po drzewie algorytmem DFS_PreOrder");
            Tree.DFS_PreOrder();
            Console.Clear();
            Tree.PrintTree();
            Console.WriteLine("\nPrzejście po drzewie algorytmem BFS");
            Tree.BFS();

            Console.ReadLine();
        }
    }
}
