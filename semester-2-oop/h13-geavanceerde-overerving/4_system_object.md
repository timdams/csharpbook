# System.Object

## System.Object

**Alle** types in C\# zijn afstammelingen van de `System.Object` klasse. Indien je een klasse schrijft zonder een expliciete parent dan zal deze steeds `System.Object` als rechtstreekse parent hebben. Ook afgeleide klassen stammen dus af van `System.Object`. Concreet wil dit zeggen dat alle klassen `System.Object`-klassen zijn en dus ook de bijhorende functionaliteit ervan hebben.

{% hint style="warning" %}
Merk op dat we hier niet alleen onze eigen klassen bedoelen, maar alle types, dus zelfs `int`, `bool`, `string`,... **Alle** types stammen \(al dan niet rechtstreeks\) af van `System.Object`.
{% endhint %}

Indien je de System namespace in je project gebruikt door bovenaan `using System;` te schrijven dan hoef je dus niet altijd `System.Object` te schrijven maar mag je ook **`Object`** schrijven.

## Hoe ziet System.Object er uit?

Wanneer je een lege klasse maakt dan zal je zien dat instanties van deze klasse reeds een aantal methoden ingebouwd hebben. Dit komt omdat deze methoden gedefinieerd zijn in de `System.Object` klasse en meteen overgeërfd worden door je nieuwe klasse:

| Methode | Beschrijving |
| :--- | :--- |
| `Equals(Object o)` | Gebruikt om te ontdekken of twee instanties "gelijk" zijn. Wat dit betekent kan bepaald worden door de auteur van de klasse. |
| `GetHashCode()` | Geeft een unieke code \(hash\) terug van het object; nuttig om o.a. snel te sorteren. |
| `GetType()` | Geeft het type \(of klasse\) van het object terug. Dit is een object van het type `Type`! |
| `ToString()` | Geeft een string terug die het object voorstelt. |

### GetType\(\)

Stel dat je een klasse Student hebt gemaakt in je project. Je kan dan op een object van deze klasse de GetType\(\) -methode aanroepen om te weten wat het type van dit object is:

```csharp
Student stud1 = new Student();
Console.WriteLine(stud1.GetType());
```

Dit zal als uitvoer de namespace gevolgd door het type op het scherm geven. Als je klasse dus in de namespace `StudentManager` staat, zal er verschijnen: `StudentManager.Student`.

Wil je enkel het type zonder namespace dan is het nuttig te beseffen dat GetType\(\) een object teruggeeft van het type `Type` met meerdere eigenschappen, waaronder `Name`. Volgende code zal dus enkel `Student` op het scherm tonen:

```csharp
Student stud1 = new Student();
Console.WriteLine(stud1.GetType().Name);
```

{% hint style="warning" %}
Deze methode is vooral nuttig in code voor frameworks en dergelijke. Dat wil zeggen: code waaraan je jouw eigen code kan toevoegen. In een meer typische eigen applicatie zou je hier niet te veel gebruik van hoeven te maken, anders schort er waarschijnlijk iets aan je ontwerp.
{% endhint %}

### ToString\(\)

Deze is de nuttigste waar je al direct leuke dingen mee kan doen. Wanneer je schrijft:

```csharp
Console.WriteLine(stud1);
```

wordt je code eigenlijk herschreven naar:

```csharp
Console.WriteLine(stud1.ToString());
```

Op het scherm verschijnt dan `StudentManager.Student`. Waarom? Wel, de methode ToString\(\) wordt in System.Object\(\) ongeveer als volgt beschreven:

```csharp
public virtual string ToString()
 { return GetType(); }
```

Merk twee zaken op:

1. GetType wordt aangeroepen en die output krijg je terug.
2. De methode is **virtual** gedefinieerd.

   **Alle 4 hierboven vermelde methoden in `System.Object` zijn `virtual` , en je kan deze overschrijven!**

**ToString\(\) overriden**

Het zou natuurlijk fijner zijn dat de ToString\(\) van onze student nuttigere info teruggeeft, zoals bv de interne Naam \(string autoprop\) en Leeftijd \(int autoprop\). We kunnen dat eenvoudig krijgen door gewoon `ToString` to overriden:

```csharp
class Student
{
public int Leeftijd {get;set;}
public string Naam {get;set;}

public override string ToString()
{
   return $"Student genaamd {Naam} (Leeftijd:{Leeftijd})";
}
}
```

Wanneer je nu `Console.WriteLine(stud1);` \(gelet dat hij een Naam en Leeftijd heeft\) zou schrijven dan wordt je output: `Student Tim Dams (Leeftijd:35)`.

### Equals\(\)

Ook deze methode kan je dus overriden om twee objecten met elkaar te vergelijken. Hierbij moet je een applicatiespecifiek antwoord kunnen geven op de vraag "wanneer zijn twee objecten aan elkaar gelijk?"

```csharp
if(stud1.Equals(stud2))
   //...
```

De `Equals` methode heeft dus als signatuur: `public virtual bool Equals(Object o)` .NET maakt volgende afspraken voor een geldige implementatie van `Equals`, maar het is aan jou om te zorgen dat je code deze afspraken volgt:

* Het moet `false` teruggeven indien het argument `o` `null` is
* Het moet `true` teruggeven indien je het object met zichzelf vergelijkt \(bv `stud1.Equals(stud1)`\)
* Het mag enkel `true` teruggeven als volgende statements beide waar zijn:

  ```csharp
  stud1.Equals(stud2);
  stud2.Equals(stud1);
  ```

* Indien `stud1.Equals(stud2)` true teruggeeft en `stud1.Equals(stud3)` ook true is, dan moet `stud2.Equals(stud3)` ook true zijn.

{% hint style="warning" %}
Volgt je eigen code deze afspraken niet, dan krijg je geen compilatiefouten, maar dan kan je wel onverwacht gedrag krijgen van code die gebruik maakt van `Equals` zoals bijvoorbeeld de `IndexOf`-methode van `List<T>`.
{% endhint %}

#### Equals overriden

Stel dat we vinden dat een student gelijk is aan een andere student indien z'n Naam en Leeftijd dezelfde is, we kunnen dan de Equals-methode overriden als volgt:

```csharp
//In de Student class
public override bool Equals(Object o)
{
     bool gelijk;
     if(GetType() != o.GetType()) 
         gelijk=false;
     else
     {
         Student temp = (Student)o; //Zie opmerking na code!
         if(Leeftijd== temp.Leeftijd && Naam== temp.Naam)
            gelijk=true;
         else gelijk=false;
      }
       return gelijk;
}
```

De lijn `Student temp = (Student) o;` zal het `object o` casten naar een `Student`. Doe je dit niet dan kan je niet aan de interne `Student`-variabelen van het `object o`. Het feit dat een object met het statische type \(d.w.z.: zo staat het bij de parameter\) `Object` tijdens de uitvoering ook een object met runtime type `Student` \(d.w.z.: dat is het soort data dat op de heap staat\) kan zijn is een voorbeeld van polymorfisme.

### GetHashcode\(\)

`GetHashCode()` zorgt ervoor dat je een "vingerafdruk" van een object krijgt. Als twee objecten gelijk zijn onder `Equals`, wordt verondersteld dat ze dezelfde vingerafdruk hebben. Omgekeerd geldt niet, maar het is voor de efficiëntie wel beter als verschillende objecten ook verschillende vingerafdrukken leveren. Het is opnieuw aan de programmeur om dit te garanderen.

Een efficiënte hashfunctie voor een type `K` zorgt er bijvoorbeeld voor dat opzoekingen van keys in een `Dictionary<K,V>` erg snel verlopen. Een minder efficiënte hashfunctie zal opzoekingen in datzelfde `Dictionary` trager laten verlopen. Een foute hashfunctie kan er voor zorgen dat je `Dictionary` niet meer werkt zoals verwacht.

Wij behandelen het schrijven van een eigen hashfunctie hier niet. Wanneer we gebruik maken van hashes \(mogelijk impliciet\), dan zullen we hashfuncties aanbieden die je zo mag gebruiken.

