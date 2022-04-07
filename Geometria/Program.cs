using CalcoliGeometrici;

Console.WriteLine("Inserisci la base del rettangolo: ");
int baseRectangle = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'altezza del rettangolo: ");
int heightRectangle = int.Parse(Console.ReadLine());

Geometria MioRettangolo = new Geometria(baseRectangle, heightRectangle);
int perimetro = MioRettangolo.CalcolaPerimetro(baseRectangle, heightRectangle);
int area = MioRettangolo.CalcolaArea(baseRectangle, heightRectangle);

Geometria MioRettangoloDaStampare = new Geometria(baseRectangle, heightRectangle, perimetro, area);
MioRettangoloDaStampare.StampaRettangolo();



