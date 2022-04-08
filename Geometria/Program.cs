using Geometria;

Console.WriteLine("Quanti rettangoli vuoi?");
int numeroDiRettangoli = int.Parse(Console.ReadLine());

for (int i = 0; i < numeroDiRettangoli; i++)
{
    //INSERIAMO DA INPUT BASE E ALTEZZA
    Console.WriteLine("Inserisci la base del rettangolo: ");
    int baseRectangle = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci l'altezza del rettangolo: ");
    int heightRectangle = int.Parse(Console.ReadLine());

    //CHIAMIAMO IL COSTRUTTORE 
    Rettangolo MioRettangolo = new Rettangolo(baseRectangle, heightRectangle);

    //STAMPIAMO I DATI RICAVATI E IL RETTANGOLO
    Console.WriteLine("----------RETTANGOLO " + (i + 1) + "----------");
    MioRettangolo.StampaRettangolo();
}


