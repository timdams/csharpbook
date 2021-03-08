# Polymorfisme

**Polymorfisme** oftewel "meerdere vormen" is een programmeertechniek waarbij je code met één algemene noemer op meerdere manieren implementeert. Hierdoor kan je algemene code schrijven die verschillende specifieke effecten kan vertonen naargelang de configuratie. Samen met encapsulatie, abstractie en overerving is polymorfisme een vierde belangrijke eigenschap van object georiënteerd programmeren.

{% hint style="info" %}
Nog eens samengevat:

* encapsulatie betekent dat je de gebruiker niet laat sleutelen aan de interne werking van data \(bv. door access modifiers te gebruiken\)
* overerving betekent dat je code uitspaart door code van een andere klasse te "recycleren"
* abstractie betekent dat je data zo algemeen mogelijk behandelt en irrelevante verschillen tussen data verbergt \(bv. door variabelen met het type van een ouderklasse te declareren\)
* polymorfisme betekent dat je werkt met een algemene voorstelling van data, maar dat de eigenlijke data bij uitvoering van het programma specifieker kan zijn en specifieker kan werken; het is eigenlijk de keerzijde van abstractie
{% endhint %}

We tonen de werking van polymorfisme aan de hand van een voorbeeld:

### Polymorfisme in de praktijk: Dieren <a id="polymorfisme-in-de-praktijk-dieren"></a>

Een voorbeeld maakt veel duidelijk. Stel dat we een een aantal Dier-gerelateerde klassen hebben die allemaal op hun eigen manier een geluid voortbrengen. We hanteren de klasse `Dier`:

```csharp
abstract class Dier{
  public abstract string MaakGeluid();
}
```

Twee child-klassen:

```csharp
class Paard : Dier {
  public override string MaakGeluid() {
    return "Hinnikhinnik";
  }
}
​class Varken : Dier {
  public override string MaakGeluid() {
    return "Oinkoink";
  }
}
```

Dankzij polymorfisme kunnen we nu elders objecten van Paard en Varken in een `Dier` bewaren, maar toch hun eigen geluid laten reproduceren:

```text
Dier someAnimal = new Varken();
Dier anotherAnimal = new Paard();
Console.WriteLine(someAnimal.MaakGeluid()); //Oinkoink
Console.WriteLine(anotherAnimal.MaakGeluid()); //Hinnikhinnik
```

Het is belangrijk te beseffen dat `someAnimal` en `anotherAnimal` van het type `Dier` zijn en dus enkel die dingen kunnen die in `Dier` beschreven staan. Dit is het gevolg van de abstractie van beide soorten dieren tot één algemeen datatype `Dier`. Je kan `someAnimal` en `anotherAnimal` wel declareren als `Varken` en `Paard` respectievelijk, maar dat doe je best alleen als je die specificiteit nodig hebt.

### Datastructuren en polymorfisme <a id="arrays-en-polymorfisme"></a>

Datastructuren zoals arrays, lijsten, dictionaries,... bieden heel veel mogelijkheden in combinatie met abstractie en polymorfisme. Je kan een lijst van de basis-klasse maken en deze vullen met allerlei objecten van de basis-klasse **én de child-klassen**.

Een voorbeeld:

```csharp
List<Dier> zoo = new List<Dier>();
zoo.Add(new Varken());
zoo.Add(new Paard());
foreach(Dier dier in zoo){
  Console.WriteLine(dier.MaakGeluid());
}
```

