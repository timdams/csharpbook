Volgt nu een voorbeeld (bron: handboek Visual C# 2008, Dirk Louis) waar het gebruik van methoden onmiddellijk duidelijk wordt. 

Stel, je hebt 15000 euro op een spaarrekening vastgezet waarvoor de bank u een rente geeft van 3,5%. Nu wil je natuurlijk weten hoe je kapitaal van jaar tot jaar groeit. Stel dat je aan de verleiding weerstaat en de jaarlijkse rente niet opneemt, maar op de spaarrekening laat staan. Je berekent dan je kapitaal na *n* jaren met de volgende formule:

```csharp
eindkapitaal = startkapitaal x (1 + (rentepercentage/100))^n
```

(^ is tot de macht in pseudocode)

Nu kan je berekenen hoeveel geld je de volgende zeven jaren verdient, het bijhorende programma ziet er zo uit:

```csharp
static void Main(string[] args)
{
    double startKapitaal = 15000;
    double rentepercentage = 3.5;
    double eindkapitaal;
 
    //Berekening eindkapitaal
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 1);
    Console.WriteLine("Na 1 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 2);
    Console.WriteLine("Na 2 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 3);
    Console.WriteLine("Na 3 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 4);
    Console.WriteLine("Na 4 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 5);
    Console.WriteLine("Na 5 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 6);
    Console.WriteLine("Na 6 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 7);
    Console.WriteLine("Na 7 jaar:" + (int)eindkapitaal + "euro");
}
```

Dit geeft als uitvoer:

```text
Na 1 jaar:15524euro
Na 2 jaar:16068euro
Na 3 jaar:16630euro
Na 4 jaar:17212euro
Na 5 jaar:17815euro
Na 6 jaar:18438euro
Na 7 jaar:19084euro
```

Het programma werkt naar behoren, maar zoals je zelf kan zien wordt er aardig wat code herhaalt, op enkele kleine details na. Bij iedere berekening en het tonen van de interest verandert enkel de macht en het aantal jaar. Als er nu een fout in je interestberekening zou staan dan zal je die op 7 plaatsen telkens moeten veranderen.

### Rente berekenen verbeterd, versie 1

We kunnen nu terug naar onze rente-berekenaar en dit programma aanzienlijk vereenvoudigen door gebruik te maken van methoden. Namelijk als volgt:

```csharp
public static void RenteOpRenteBerekenen(double looptijd)
{
    double startKapitaal = 15000;
    double rentepercentage = 3.5;
    double eindkapitaal;
 
    //Berekening eindkapitaal
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), looptijd);
    Console.WriteLine("Na "+ (int)looptijd+"jaar:" + (int)eindkapitaal + "euro");
}
 
static void Main(string[] args)
{
    RenteOpRenteBerekenen(1);
    RenteOpRenteBerekenen(2);
    RenteOpRenteBerekenen(3);
    RenteOpRenteBerekenen(4);
    RenteOpRenteBerekenen(5);
    RenteOpRenteBerekenen(6);
    RenteOpRenteBerekenen(7);
 
}
```
Dit programma zal de zelfde output geven als het originele programma, maar de code is aanzienlijk verkleint en minder foutgevoelig (je moet maar op één plek je interestberekening aanpassen indien nodig). (Merk op dat we uiteraard de main kunnen verbeteren m.b.v. een for-loop: ``for(int i=0;i<8;i++) {RenteOpRenteBerekenen(i);}``

## Rente berekenen verbeterd, versie 2

Je code opdelen in methoden is een zeer goede eerste stap naar modulair programmeren: kleine stukken code die ieder een eigen verantwoordelijkheid hebben. Om perfect modulair te zijn moet een methode zo praktisch en algemeen mogelijk blijven, zodat de methode herbruikbaar is in andere projecten.

In het vorige voorbeeld is de methode van de renteberekening niet perfect modulair. Stel dat je later in het programma opnieuw de rente wil berekening maar niet het resultaat op het scherm wil tonen. Of stel dat je de rente wil berekenen met een andere percentage, dan kunnen we de eerder geschreven methode dus niet gebruiken.

**Modulair programmeren**: indien je modulair wenst te programmeren moet je je aan volgende zaken houden:

* Beperk de methode strikt tot het uitvoeren van de opgedragen taak. Dus in het voorbeeld: alleen de renteberekening en geen verdere verwerking van de resultaten.
* Als de methode een waarde teruggeeft, declareer hiervoor dan een passende returnwaarde.

Geef alle grootheden waarmee je de werkwijze van de methode wilt aanpassen mee aan de methode als parameter. In dit voorbeeld zijn dat dus de variabelen startkapitaal, rentepercentage en looptijd.

De nieuwe algemene, verbeterde methode wordt dan:

```csharp
public static double RenteOpRenteBerekenen(double startkapitaal, double rentepercentage, double looptijd)
{
    double eindkapitaal;
 
    //berekenig eindkapitaal
    eindkapitaal = startkapitaal * Math.Pow((1 + rentepercentage / 100), looptijd);
 
    return eindkapitaal;
}
```

De aanroep van deze methode in de main wordt dan de volgende:

```csharp
double eindkapitaal;
eindkapitaal = RenteOpRenteBerekenen(15000, 3.5, 7);
Console.WriteLine("Het eindbedrag na 7 jaar:" +(int)eindkapitaal);
```