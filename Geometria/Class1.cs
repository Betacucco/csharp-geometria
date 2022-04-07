using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoliGeometrici
{
    internal class Geometria
    {
        //ATTRIBUTI
        private int baseRettangolo;
        private int altezzaRettangolo;
        private int areaRettangolo;
        private int perimetroRettangolo;

        //COSTRUTTORE CON BASE E ALTEZZA
        public Geometria(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }
        //COSTRUTTORE CON BASE, ALTEZZA, AREA E PERIMETRO
        public Geometria(int baseRettangolo, int altezzaRettangolo, int areaRettangolo, int perimetroRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            this.areaRettangolo = areaRettangolo;
            this.perimetroRettangolo = perimetroRettangolo;
        }
        //METODO PER IL CALCOLO DELL'AREA
        public int CalcolaArea(int baseRettangolo, int altezzaRettangolo)
        {
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }
        //METODO PER IL CALCOLO DEL PERIMETRO
        public int CalcolaPerimetro(int baseRettangolo, int altezzaRettangolo)
        {
            int perimetroRettangolo = (2 * baseRettangolo) + (2 * altezzaRettangolo);
            return perimetroRettangolo;
        }
        //METODO PER STAMPARE LE VARIE MISURE DEL RETTANGOLO E IL DISEGNO
        public void StampaRettangolo()
        {
            Console.WriteLine("----------RETTANGOLO----------");
            Console.WriteLine("Base: " + baseRettangolo + "cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Perimetro: " + areaRettangolo + "cm");
            Console.WriteLine("Area: " + perimetroRettangolo + "cm^2");
            Disegna(baseRettangolo,altezzaRettangolo);
        }
        //METODO CHE DISEGNA IL RETTANGOLO
        public void Disegna(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;

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
