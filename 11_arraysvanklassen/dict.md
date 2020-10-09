## Dictionary<TKey,TValue> collectie

Naast de generieke ``List`` collectie, zijn er nog enkele andere nuttige generieke 'collectie-klassen' die je geregeld in je projecten kan gebruiken. We lichten enkel hier de ``Dictionary`` toe, maar bekijk zeker ook eens de werking van de ``Queue`` en ``Stack``-collecties.



In een **dictionary** wordt ieder element voorgesteld door een sleutel (**key** of index) en de waarde (**value**) van het element. 

De sleutel moet een unieke waarde zijn zodat het element kan opgevraagd worden uit de dictionary aan de hand van deze sleutel zonder dat er dupplicaten zijn.



{% hint style='tip' %}
De Dictionary-klasse emuleert dus letterlijk de werking van een woordenboek waarbij ieder woord uniek is en een bijhorende uitleg heeft (het woord is de sleutel, de bijhorende uitleg de waarde). Geen enkel woord komt dubbel voor in een woordenboek (als het meerdere definities heeft dan worden deze allemaal bij dat ene woord als waarde geplaatst).
{% endhint %}

Bij de declaratie van de ``Dictionary`` dien je op te geven wat het datatype van de key zal zijn , alsook het type van de waarde (value). 


### Gebruik Dictionary
In het volgende voorbeeld maken we een ``Dictionary`` van klanten aan. Iedere klant heeft een unieke ID (de key, die we als ``int`` gebruiken) alsook een naam (die niet noodzakelijk uniek is en de waarde voorstelt):

```java
Dictionary<int, string> customers = new Dictionary<int, string>();
customers.Add(123, "Tim Dams");
customers.Add(6463, "James Bond");
customers.Add(666, "The beast");
customers.Add(700, "James Bond");
``` 

Bij de declaratie van ``customers`` plaatsen we dus tussen de ``< >`` twee datatypes: het eerste duidt het datatype van de key aan, het tweede dat van de values.



{% hint style='tip' %}
Merk op dat je niet verplicht bent om een int als key te gebruiken, dit mag eender wat zijn, zelfs een klasse.

```java
Dictionary<int,Pokemon> pokedex;
Dictionary<Student,PuntenLijst> schoolAdministratie;
```
{% endhint %}


We kunnen nu met behulp van bijvoorbeeld een ``foreach``-loop alle elementen tonen. Hier kunnen we de key met de ``.Key``-property uitlezen en het achterliggende object of waarde met ``.Value``. ``Value`` en ``Key`` hebben daarbij ieder het type dat we hebben gedefinieerd toen we het ``Dictionary``-object aanmaakten, in het volgende geval is de ``Key`` dus van het type ``int`` en ``Value`` van het type ``string``:

```java
foreach (var item in customers)
{
    Console.WriteLine(item.Key+ "\t:"+item.Value);
}
```

We kunnen echter ook een specifiek element opvragen aan de hand van de key. Stel dat we de waarde (naam) van de klant met key (id) gelijk aan 123 willen tonen:

```java
Console.WriteLine(customers[123]);
```

De key werkt dus net als de index bij gewone arrays, alleen heeft de key nu geen relatie meer met de positie van het element in de collectie.

### Eender welk type voor key en value

De key kan zelfs een string zijn en de waarde een ander type. In het volgende voorbeeld hebben we eerder een klasse Student aangemaakt. We maken nu een student aan en voegen deze toe aan de studentenLijst. Vervolgens willen we de leeftijd van een bepaalde student tonen op het scherm en vervolgens verwijderen we deze student:

```java
Dictionary<string, Student> studentenLijst = new Dictionary<string, Student>();
Student stud= new Student();
stud.Naam= "Tim";stud.Leeftijd=24;
studentenLijst.Add("AB12",stud);
Console.WriteLine(studentenLijst["AB12"].Leeftijd);
studentenLijst.Remove("AB12");
```

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Werken met dictionary](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=43e5eb65-6b40-4539-892e-ab9f0093b774)
<!---NOBOOKEND--->