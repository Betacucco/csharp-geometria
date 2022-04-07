using CalcoliGeometrici;

Console.WriteLine("Quanti rettangoli vuoi?");
int numeroDiRettangoli = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroDiRettangoli; i++)
{
    //INSERIAMO DA INPUT BASE E ALTEZZA
    Console.WriteLine("Inserisci la base del rettangolo: ");
    int baseRectangle = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci l'altezza del rettangolo: ");
    int heightRectangle = int.Parse(Console.ReadLine());

    //CHIAMIAMO IL COSTRUTTORE SENZA AREA E RETTANGOLO
    Geometria MioRettangolo = new Geometria(baseRectangle, heightRectangle);
    int perimetro = MioRettangolo.CalcolaPerimetro(baseRectangle, heightRectangle);
    int area = MioRettangolo.CalcolaArea(baseRectangle, heightRectangle);

    //CHIAMIAMO IL COSTRUTTORE CHE COMPRENDE ANCHE PERIMETRO E AREA
    Geometria MioRettangoloDaStampare = new Geometria(baseRectangle, heightRectangle, perimetro, area);

    //STAMPIAMO I DATI RICAVATI E IL RETTANGOLO
    Console.WriteLine("----------RETTANGOLO " + (i + 1) + "----------");
    MioRettangoloDaStampare.StampaRettangolo();
}


