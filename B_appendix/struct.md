## Structs

TODO

## Records

Sinds C# 9.0 (verschenen eind 2020) is het ook mogelijk om zogenaamde ``record``-klassen te maken. Erg vaak schrijf je klassen die niet meer moeten doen dan wat data eenmalig wegschrijven dat je dan vervolgens via readonly getters kunt uitlezen, zoals:

```java
public class Student
{
    public Student(string naam, int leeftijd, bool isIngeschreven)
    {
        Naam=naam;
        Leeftijd= leeftijd;
        IsIngeschreven= isIngeschreven;
    }

    public string Naam {get;}
    public int Leeftijd {get;}
    public bool IsIngeschreven {get;}
}
```

Wanneer je een dergelijke klasse nodig hebt kan dit in C# 9.0 vereenvoudigd geschreven worden als volgt een ``record``:

```java
public record Student
{
    public string Naam { get; init; }
    public int Leeftijd { get; init; }
    public bool IsIngeschreven { get; init; }
}
```

Het ``init`` keyword geeft aan dat deze autoproperty eenmalig kunnen **ge-set** worden bij het aanmaken van het record via de object initializer syntax:

```java
Student eenNieweStudent = new Student 
            {   Naam="Tim", 
                Leeftijd= 18,   
                IsIngeschreven = false
            };
```

Er zijn nog tal van extra's die je krijgt met ``record``s (o.a. eenvoudig objecten vergelijken) maar die gaan we niet bespreken. 