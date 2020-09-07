# Polymorfisme

**Polymorfisme** oftewel "meerdere vormen" is een programmeertechniek waarbij je code schrijft die door objecten van verschillende klasse, kan gebruikt worden. Hierdoor kan je dus compactere code schrijven en hoef je niet voor iedere klasse apart (deel)code te schrijven. Samen met encapsulatie en overerving is polymorfisme een derde belangrijke eigenschap van object georiënteerd programmeren.

We tonen het nut van polymorfisme aan de hand van drie voorbeelden:


## Polymorfisme in de praktijk: Dieren
Een voorbeeld maakt veel duidelijk. Stel dat we een een aantal Dier-gerelateerde klassen hebben die allemaal op hun eigen manier een geluid voortbrengen. We hanteren de klasse dier uit een eerder hoofdstuk ([abstracte klassen in overerving](../13_advancedovererving/5_abstract.md)):
```java
abstract class  Dier
{
   public abstract string MaakGeluid();
}
```
Twee child-klassen:
```java
class Paard: Dier
{
  public override string MaakGeluid()
  { 
      return "Hinnikhinnik";
  }
}

class Varken: Dier
{
  public override string MaakGeluid()
  { 
      return "Oinkoink";
  }
}
```

Dankzij polymorfisme kunnen we nu elders objecten van Paard en Varken in een ``Dier`` bewaren, maar toch hun eigen geluid laten reproduceren:
```java
Dier someAnimal = new Varken();
Dier anotherAnimal = new Paard();
Console.WriteLine(someAnimal.MaakGeluid()); //Oinkoink
Console.WriteLine(anotherAnimal.MaakGeluid()); //Hinnikhinnik
```

Het is belangrijk te beseffen dat  ``someAnimal`` en ``anotherAnimal`` van het type ``Dier`` zijn en dus enkel die dingen kunnen die in ``Dier`` beschreven staan. Enkel zaken die ``override`` zijn in de child-klasse zullen met de specialisatie-code werken.

## Arrays en polymorfisme

Arrays en lijsten laten heel krachtige code toe. Je kan een lijst van de basis-klasse maken en deze vullen met allerlei objecten van de basis-klasse **én de child-klassen**. 

Een voorbeeld:

```java
List<Dier> zoo = new List<Dier>();
zoo.Add(new Varken());
zoo.Add(new Paard());
foreach(var dier in zoo)
{
  Console.WriteLine(dier.MaakGeluid());
}
```


<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)

Polymorfisme is een heel krachtig concept. Door objecten te bewaren in hun basistype en , wanneer nodig, ze als 'zichzelf' te gebruiken wordt je code een pak eenvoudiger.
Vaak weet je niet op voorhand wat voor elementen je in je lijst wilt plaatsen. Via polymorfisme lossen we dit op. Stel bijvoorbeeld dat je een lijst van Personen hebt (``List<Person>``) waar echter elementen van subklassen in terecht kunnen komen (``Bakker``, ``Student``, etc) , dan laat polymorfisme dit gewoon toe om ook deze elementen in die lijst te plaatsen.

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Polymorfisme](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=6bc13cf3-83d0-449d-9d8f-ab7d00c5a021)

* [Polymorfisme in praktijk "demo met kaartspel dee2"](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a1009330-272d-4978-a078-aba2012ab2b8)
<!---NOBOOKEND--->