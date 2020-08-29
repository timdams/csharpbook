
![](../assets/infoclip.png)

* [Bespreking oplossingen hoofdstuk 3](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=0c5972b4-e091-40dc-84dc-a97600d27428)

# Code

## BMI Berekenaar
```java
Console.WriteLine("Geef je gewicht in kg");
double gewicht = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geef je lengte in cm");
double lengte = Convert.ToDouble(Console.ReadLine())/100;

double bmi = gewicht / Math.Pow(lengte, 2);

Console.WriteLine($"Je BMI is {Math.Round(bmi,2)}");
```

## Weerstandsberekenaar

```java
int ring1 = 5;
int ring2 = 7;

int weerstandswaarde = ring1 * 10 + ring2;

Console.WriteLine("╔═══════════════╦═══════════════╦═══════════════╗");
Console.WriteLine("║ Ring 1        ║ Ring 2        ║   Weerstand   ║");
Console.WriteLine("╟───────────────╫───────────────╢───────────────╢");
//De tabs zorgen ervoor dat de volgende ║ steeds op de zelfde plaats komt,
//ongeacht de lengte van de variabelen ring1,ring2 en weerstandswaarde
Console.WriteLine($"║ {ring1}\t\t║{ring2}\t\t║{weerstandswaarde}\t\t║");
Console.WriteLine($"╚═══════════════╩═══════════════╩═══════════════╝");



//PRO
int tolerantie = 4;
double totweerstand = weerstandswaarde * Math.Pow(10, tolerantie);
```