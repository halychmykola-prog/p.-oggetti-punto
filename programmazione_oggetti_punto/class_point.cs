using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmazione_oggetti_punto
{
    internal class Punto
    {
        //attributi
        private float x;
        private float y;

        //costruttore 
        public Punto()
        {
            x = 0;
            y = 0;
        }

        // cstruttore con parametri
        public Punto(float a, float b)
        {
            x = a;
            y = b;
        }

        // Distruttore  
        ~Punto()
        {
        }

        // Metodi Set e Get
        public void SetX(float cx)
        {
            x = cx;
        }

        public void SetY(float cy)
        {
            y = cy;
        }

        public float GetX()
        {
            return x;
        }

        public float GetY()
        {
            return y;
        }

        // Metodo per specificare il quadrante
        public int Quadrante()
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x < 0 && y > 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else if (x > 0 && y < 0)
                return 4;
            else
                return 0;
        }

        // Distanza dall'origine (0,0)
        public float DistanzaDaO()
        {
            float d;
            d = (float)Math.Sqrt(x * x + y * y);
            return d;
        }

        // metodo per stampare le coordinate del punto
        public string Stampa()
        {
            string s;
            s = "Carta di identita' del punto\n";
            s = s + "x: " + x + "\n";
            s = s + "y: " + y + "\n";
            return s;
        }

        // metodo 
        public void Ribalta()
        {
            x = -x;
            y = -y;
        }

        // metodi per traslazione
        public void TraslaX(float spostamentoX)
        {
            x = x + spostamentoX;
        }

        public void TraslaY(float spostamentoY)
        {
            y = y + spostamentoY;
        }

        // Metodo per controllare ugualianza
        public bool Uguale(Punto altro)
        {
            if (x == altro.GetX() && y == altro.GetY())
                return true;
            else
                return false;
        }

        // Metodo per calcolare la distanza tra due punti
        public float DistanzaDa(Punto altro)
        {
            float dx = x - altro.GetX();
            float dy = y - altro.GetY();
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }




    };

}

