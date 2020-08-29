# DateTime

## Klokje

```java
while (true)
{
    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    System.Threading.Thread.Sleep(1000);
    Console.Clear();
}
```

## Verjaardag

```java
Console.WriteLine("Geef je verjaardag (formaat: d/m . Bv 18/3)");
DateTime verj = DateTime.Parse(Console.ReadLine());


if (verj < DateTime.Today)
    verj = verj.AddYears(1);

TimeSpan dagenover = verj - DateTime.Today;

Console.WriteLine($"Je verjaart over {dagenover.Days} dagen");
```

# Oefeningen

## RapportModule

```java
class Rapport
{
    public int Percentage {get;set;}
    public void PrintGraad()
    {
        if(Percentage < 50)
            Console.WriteLine("Niet geslaagd");
        else if(Percentage < 68)
            Console.WriteLine("Voldoende");
        else if(Percentage < 75)
            Console.WriteLine("Onderscheiding");
        else if(Percentage < 85)
            Console.WriteLine("Grote onderscheiding");
        else Console.WriteLine("Grootste onderscheiding");
    }
}
```

Gebruik/test:

```java
Rapport tim =new Rapport();
tim.Percentage = 78;
tim.PrintGraad();
```

## Nummers

```java
class Nummers
{
    public int Getal1 { get; set; }
    public int Getal2 { get; set; }

    public int Som() { return Getal1 + Getal2; }
    public int Verschil() { return Getal1 - Getal2; }
    public int Product() { return Getal1 * Getal2; }

    public double Quotient()
    {
        if(Getal2==0)
        {
            Console.WriteLine("Error");
            return 0;
        }
        return Getal1 / Getal2;
    }
}
```

## Figure

```java
class Rechthoek
{
    private int lengte = 1;
    public int Lengte
    {
        get { return lengte; }
        set { if (value >= 1) lengte = value; }
    }

    private int breedte = 1;

    public int Breedte
    {
        get { return  breedte; }
        set { if (value >= 1) breedte = value; }
        }

    public void ToonOppervlakte()
    {
        Console.WriteLine($"Oppervlakte is= {Lengte*Breedte}"  );
    }
}
```

Driehoek is quasi hetzelfde, met uiteraard een andere berekening van de oppervlakte.

## Studentklasse

```java
enum Klassen { EA1, EA2, EA3}

class Student
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }
    public Klassen Klas { get; set; }

    public int PuntenCommunicatie { get; set; }
    public int PuntenProgrammingPrinciples { get; set; }
    public int PuntenWebTech { get; set; }

    public double BerekenTotaalCijfer()
    {
        return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
    }

    public void GeefOverzicht()
    {
        Console.WriteLine($"{Naam}, {Leeftijd} jaar");
        Console.WriteLine($"Klas: {Klas}");
        Console.WriteLine();
        Console.WriteLine("Cijferrapport");
        Console.WriteLine("*************");
        Console.WriteLine($"Communicatie:\t\t{PuntenCommunicatie}");
        Console.WriteLine($"Programming Principles:\t{PuntenProgrammingPrinciples}");
        Console.WriteLine($"Web Technology:\t\t{PuntenWebTech}");
        Console.WriteLine($"Gemiddelde:\t\t{BerekenTotaalCijfer():0.0}");
    }
}
```

## PizzaTime

```java
    class Pizza
    {
		private string toppings;

		public string Toppings
		{
			get 
			{			
				return toppings; 
			}
			set 
			{
				if (value != "")
				{
					toppings = value;
				}		
			}
		}
		private int diameter;

		public int Diameter
		{
			get { return diameter; }
			set 
			{
				if (value > 0)
				{
					diameter = value;
				}
			}
		}

		private double prijs;

		public double Prijs
		{
			get { return prijs; }
			set 
			{
				if (value >0)
				{
					prijs = value;
				}			 
			}
		}
	}
```