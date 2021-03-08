# Stack en Heap, value en reference

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/N6f6S9aQukU)
{% endhint %}

{% hint style="danger" %}
De kennisclip bevat dezelfde informatie als de tekst hieronder, maar op een andere manier uitgelegd. Aangeraden wordt om eerst de kennisclip te bekijken, dan de tekst door te nemen, dan verder door dit hoofdstuk te gaan. Als het dan nog niet duidelijk is, moet je herhalen vanaf de kennisclip. Als het na een tweede lezing van het hoofdstuk nog niet duidelijk is, bijt dan je tanden niet stuk, maar contacteer de lector.
{% endhint %}

## Stack en Heap

### Geheugenmanagement in C-Sharp

Tot nog toe lagen we er niet van wakker wat er achter de schermen van een C\# programma gebeurde. We duiken nu dieper in wat er juist gebeurt wanneer we variabelen aanmaken.

#### Twee soorten geheugen

Wanneer een C\# applicatie wordt uitgevoerd krijgt het twee soorten geheugen toegewezen dat het kan gebruiken:

1. Het kleine, maar snelle **stack** geheugen
2. Het grote, maar tragere **heap** geheugen

Afhankelijk van het soort variabele wordt ofwel de stack, ofwel de heap gebruikt. **Het is uitermate belangrijk dat je weet hoe de variabele zal bewaard worden!**

#### Waarom twee geheugens?

Waarom plaatsen we niet alles in de stack? De reden hiervoor is dat bij het compileren van je applicatie er reeds zal vastgelegd worden hoeveel geheugen de stack zal nodig hebben. Wanneer je programma dus later wordt uitgevoerd, wordt die hoeveelheid geheugen gereserveerd. Er is echter een probleem: we kunnen niet alles perfect berekenen/voorspellen. Van een variabele van het type `int` is perfect geweten hoe groot die zal zijn \(32 bit\).Maar wat met een string? Of met een array waarvan we pas tijdens de uitvoer de lengte aan de gebruiker misschien vragen? We zouden op voorhand niet weten hoe veel geheugen we daar voor moeten reserveren.

**Value types**

**Lokale variabelen \(inclusief parameters\) van value types** worden in de stack bewaard. De effectieve waarde van de variabele wordt in de stack bewaard. Dit zijn gekende, "eenvoudige" datatypes die we totnogtoe gezien hebben, inclusief enums:

* `sbyte`, `byte`
* `short`, `ushort`
* `int`, `uint`
* `long`, `ulong`
* `char`
* `float`, `double`, `decimal`
* `bool`
* `enum` types
* `struct`s \(`DateTime` is hier een voorbeeld van\)

{% hint style="warning" %}
Wacht even, was `DateTime` geen klasse? Eigenlijk niet. `struct`s lijken erg op klassen in C\#, maar het zijn value types. Ook de concrete verschijningsvormen van structs noemen we objecten.
{% endhint %}

**= operator bij value types**

Wanneer we een value-type willen kopieren dan kopieren de echte waarde:

```csharp
int getal=3;
int anderGetal= getal;
```

Vanaf nu zal `anderGetal` de waarde `3` hebben. Als we nu een van beide variabelen aanpassen dan zal dit **geen** effect hebben op de andere variabelen.

We zien het zelfde effect wanneer we een methode maken die een parameter van het value type aanvaardt- we geven een kopie van de variabele mee:

```csharp
void DoeIets(int a)
{
    a++;
    Console.WriteLine($"In methode {a}");
}

//Elders:
int getal= 5;
DoeIets(getal);
Console.WriteLine($"Na methode {getal}");
```

De parameter `a` zal de waarde 5 gekopieerd krijgen. Maar wanneer we nu zaken aanpassen in `a` zal dit geen effect hebben op de waarde van `getal`. De output van bovenstaand programma zal zijn:

```text
In methode 6
Na methode 5
```

**Reference types**

**Data van reference types** wordt op de heap bewaard. De effectieve waarde wordt in de heap bewaard, en voor lokale variabelen wordt in de stack enkel een **referentie** of **pointer** naar de data. Een referentie \(of pointer\) is niet meer dan het geheugenadres naar waar verwezen wordt \(bv `0xA3B3163`\) Concreet zijn dit allemaal zaken die vaak redelijk groot zullen zijn of waarvan we de grootte niet op voorhand kunnen begrenzen \(vb.: een string kan weinig karakters of veel karakters bevatten\):

* objecten van klassen \(strings vallen hier ook onder\)
* arrays
* delegate types \(zien we later\)

**= operator bij reference types**

Wanneer we de = operator gebruiken bij een reference type dan kopieren we de referentie naar de waarde, niet de waarde zelf.

Veronderstel dat onderstaande code deel uitmaakt van een methode, dus dat `stud` een lokale variabele is:

```csharp
Student stud = new Student();
```

Wat gebeurt er hier?

1. `new Student()`  : `new` roept de constructor van `Student` aan. Deze zal een constructor in de **heap** aanmaken en vervolgens de geheugenlocatie teruggeven.
2. Een variabele `stud` wordt in de **stack** aangemaakt.
3. De geheugenlocatie uit de eerste stap wordt vervolgens in `stud` opgeslagen in de stack.

**Bij arrays**

Maar ook bij arrays:

```csharp
int[] nummers= {4,5,10};
int[] andereNummers= nummers;
```

In dit voorbeeld zal `andereNummers` dus nu ook verwijzen naar de array in de heap waar de actuele waarden staan.

Als we dus volgende code uitvoeren dan ontdekken we dat beide variabele naar dezelfde array verwijzen:

```csharp
andereNummers[0]=999;
Console.WriteLine(andereNummers[0]);
Console.WriteLine(nummers[0]);
```

We zullen dus als output krijgen:

```text
999
999
```

Hetzelfde gedrag zien we bij objecten:

```csharp
Student a= new Student("Abba");
Student b= new Student("Queen");
a=b;
Console.WriteLine(a.Naam);
```

We zullen in dit geval dus `Queen` op het scherm zien omdat zowel `b` als `a` naar het zelfde object in de heap verwijzen. Het originele "abba"-object zijn we kwijt en zal verdwijnen \(zie Garbage collector verderop\).

**Methoden en reference parameters**

Ook bij methoden geven we de dus de referentie naar de waarde mee. In de methode kunnen we dus zaken aanpassen van de parameter en dan passen we eigenlijk de originele variabele aan:

```csharp
void DoeIets(int[] a)
{
   a[0]++;
   Console.WriteLine($"In methode {a[0]}");
}

//Elders:
int[] getallen= {5,3,2};
DoeIets(getallen);
Console.WriteLine($"Na methode {getallen[0]}");
```

We krijgen als uitvoer:

```text
In methode 6
Na methode 6
```

**Opgelet:** Wanneer we een methode hebben die een value type aanvaardt en we geven één element van de array met dan geven dus een kopie van de actuele waarde mee!

```csharp
void DoeIets(int a)
{
    a++;
    Console.WriteLine($"In methode {a}");
}

//Elders:
int[] getallen= {5,3,2};
DoeIets(getallen[0]); //<= VALUE TYPE!
Console.WriteLine($"Na methode {getallen[0]}");
```

De output bewijst dit:

```text
In methode 6
Na methode 5
```

