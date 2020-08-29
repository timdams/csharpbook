# Dierenrijk

```java
var alleBeestjes = new List<Animal>();
alleBeestjes.Add(new Animal() {NaamBeest="Dodo", IsUitgestorven=true });
alleBeestjes.Add(new Cow() {NaamBeest="Milkakoe", KleurVlekken="Paars" } );
alleBeestjes.Add(new Snake() { NaamBeest = "Cobra", HeeftRattelstaart = false });
alleBeestjes.Add(new Snake() { NaamBeest = "Ratelslang", HeeftRattelstaart = true });

foreach (var beest in alleBeestjes)
{
    beest.ToonInfo();
}
```

```java
class Animal
{
    public string NaamBeest { get; set; }
    public bool IsUitgestorven { get; set; }
    public virtual void ToonInfo()
    {
        Console.WriteLine($"****{NaamBeest}****");
        if (IsUitgestorven)
            Console.WriteLine("Dit dier is uitgestorven");
        else Console.WriteLine("Dit dier is niet uitgestorven");
    }
}

class Mammal : Animal 
{
    public string Biotoop { get; set; }
    public override void ToonInfo()
    {
        base.ToonInfo();
        Console.WriteLine($"En heeft als biotoop:{Biotoop}");
    }
}

class Rabbit : Mammal {
    public int LengteOren { get; set; }
    public override void ToonInfo()
    {
        base.ToonInfo();
        Console.WriteLine($"De lengte van dit konijn z'n oren is {LengteOren}");
    }
}
class Cow : Mammal {
    public string   KleurVlekken { get; set; }
    public override void ToonInfo()
    {
        base.ToonInfo();
        Console.WriteLine($"Deze koe heeft {KleurVlekken} vlekken");
    }
}
class Dog : Mammal { }
class Reptile : Animal { }
class Snake : Reptile 
{
    public bool HeeftRattelstaart { get; set; }
    public override void ToonInfo()
    {
        base.ToonInfo();
        if(HeeftRattelstaart)
            Console.WriteLine("Deze slang heeft een ratelstaart");
        else Console.WriteLine("Deze slang heeft geen ratelstraat");
    }
}
class Iguana : Reptile { }
```

# HiddenBookmark

```java
class HiddenBookMark: BookMark
{
    public override void OpenSite()
    {
        Process.Start("chrome.exe", "-incognito " + URL);
    }
}
```

# Ziekenhuis

## Deel 1

```java
class Patient
{
    public string Naam { get; set; }
    public int UrenInZiekenhuis { get; set; }

    private const int basisKost= 50;
    private const int kostPerUur = 20;
    public virtual double BerekenKost()
    {
        int kost = basisKost + (UrenInZiekenhuis * kostPerUur);
        return kost;
    }

    public void ToonInfo()
    {
        Console.WriteLine($"{Naam} (Kost:{BerekenKost()})");
    }
}
```

## Deel 2

```java
class VerzekerdePatient : Patient
{
    private const double korting = 0.1;
    public override double BerekenKost()
    {
        double totaalBasisKost = base.BerekenKost();
        return totaalBasisKost - (totaalBasisKost * korting);
    }
}
```

Aantonen werking:

Eenvoudig:

```java
Patient JosFromUSA = new Patient() 
    { Naam = "American Jos", UrenInZiekenhuis = 10 };
VerzekerdePatient JosFromBelgium = new VerzekerdePatient() 
    { Naam = "Belgische Jos", UrenInZiekenhuis = 10 };
JosFromUSA.ToonInfo();
JosFromBelgium.ToonInfo();
```

Complexer:

```java
List<Patient> allePatienten = new List<Patient>()
{
    new Patient() { Naam = "American Jos", UrenInZiekenhuis = 10 },
    new VerzekerdePatient() { Naam = "Belgische Jos", UrenInZiekenhuis = 10 },

};

foreach (var patient in allePatienten)
{
    patient.ToonInfo();
}
```

