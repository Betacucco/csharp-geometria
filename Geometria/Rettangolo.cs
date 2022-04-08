using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        //ATTRIBUTI
        private int baseRettangolo;
        private int altezzaRettangolo;

        //COSTRUTTORE CON BASE E ALTEZZA
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        //METODO PER IL CALCOLO DELL'AREA
        public int CalcolaArea()
        {
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }

        //METODO PER IL CALCOLO DEL PERIMETRO
        public int CalcolaPerimetro()
        {
            int perimetroRettangolo = (2 * baseRettangolo) + (2 * altezzaRettangolo);
            return perimetroRettangolo;
        }

        //METODO PER STAMPARE LE VARIE MISURE DEL RETTANGOLO E IL DISEGNO
        public void StampaRettangolo()
        {
            Console.WriteLine("Base: " + baseRettangolo + "cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Perimetro: " + CalcolaPerimetro() + "cm");
            Console.WriteLine("Area: " + CalcolaArea() + "cm^2");
            Disegna();
        }

        //METODO CHE DISEGNA IL RETTANGOLO
        public void Disegna()
        {

            for(int i = 0; i < baseRettangolo; i++)
            {
                if (i == 0)
                    Console.Write(" ");
                Console.Write("__");
            }
            Console.Write("\n");

            for (int i = 0; i < altezzaRettangolo; i++)
            {
                Console.Write("|");
                for(int j = 0; j < baseRettangolo; j++)
                {
                    Console.Write("  ");
                }
                if (i != altezzaRettangolo - 1)
                    Console.WriteLine("|");
                else
                    Console.Write("|");
            }
            Console.Write("\r");

            for (int i = 0; i < baseRettangolo; i++)
            {
                if (i == 0)
                    Console.Write("|");
                Console.Write("__");
            }
            Console.WriteLine();
        }

    }
}
