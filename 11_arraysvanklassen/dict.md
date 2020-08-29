## Dictionary<TKey,TValue> collectie

In een dictionary wordt ieder element voorgesteld door een index en de waarde van het element. De sleutel moet een unieke waarde zijn zodat het element kan opgevraagd worden uit de dictionary aan de hand van deze sleutel.

Bij de declaratie van de dictionary dien je op te geven wat het type van de key zal zijn , alsook het type van de waarde (value). In het volgende voorbeeld maken we een dictionary van klanten, iedere klant heeft een unieke ID (de key) alsook een naam (die niet noodzakelijk uniek is):

```java
Dictionary<int, string> customers = new Dictionary<int, string>();
customers.Add(123, "Tim Dams");
customers.Add(6463, "James Bond");
customers.Add(666, "The beast");
customers.Add(700, "James Bond");
``` 

Merk op dat je niet verplicht bent om een int als key te gebruiken, dit mag eender wat zijn, zelfs een klasse.

We kunnen nu met behulp van een foreach-loop alle elementen tonen (merk op dat de foreach-constructie voor eender welke type collectie kan gebruikt worden om doorheen een array te lopen):

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