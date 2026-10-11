using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmazione_oggetti_punto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Istanzio un array di oggetti della classe Punto
            Punto[] punti;
            punti = new Punto[3];
            punti[0] = new Punto(2, 3);
            punti[1] = new Punto(-2, 3);
            punti[2] = new Punto(-2, -3);

            //Istanzio un oggetto p1 della classe Punto
            Punto p1;
            p1 = new Punto(-2, -3);
            Console.WriteLine(p1.Stampa());
            Console.WriteLine("");

            //Istanzio un oggetto p2 della classe Punto
            Punto p2 = new Punto();
            p2.SetX(-2);
            p2.SetY(-3);
            Console.WriteLine("Metodi set eseguiti");
            Console.WriteLine(p2.Stampa());
            Console.WriteLine("");

            bool coincidono;
            coincidono = p2.Uguale(p1);

            if (coincidono == true)
            {
                Console.WriteLine("P1 e P2 sono uguali");
            }
            else
            {
                Console.WriteLine("P1 e P2 non sono uguali");
            }
            Console.WriteLine("\n\n");


            float lunghezzaPoligonale = 0;
            for (int i = 0; i < punti.Length - 1; i++)
            {
                
                lunghezzaPoligonale += punti[i].DistanzaDa(punti[i + 1]);
            }
            Console.WriteLine("La lunghezza della poligonale è: " + lunghezzaPoligonale);

        }
    }
}
