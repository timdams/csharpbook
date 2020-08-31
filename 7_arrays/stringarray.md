## String en arrays

Het type ``string`` is niet meer dan een arrays van karakters, ``char[]``. Het is dan ook logisch dat we dit erg belangrijke datatype even apart toelichten en enkele nuttige methoden tonen om strings te manipuleren.

### String naar char array

 Om een ``string`` per karakter te bewerken is het aanbevolen om deze naar een *char-array* om te zetten en nadien terug naar een string. Dit kan gebruikmakend van ``.ToCharArray()`` als volgt:

```java
string origineleZin = "Ik ben Tom";
char[] karakters = origineleZin.ToCharArray();
karakters[8] = 'i';
```

De uitvoer zal worden:``Ik ben Tim``.

### Char array naar string

Ook de omgekeerde weg is mogelijk.  De werking is iets anders en maakt gebruikt van ``new string()``, let vooral op hoe we de char array doorgeven als argument bij het aanmaken van een nieuwe ``string`` in lijn 3:

```java
char[] arrayOfLetters = {'h', 'a', 'l', 'l', 'o'};
arrayOfLetters[2] = 'x';
string word = new string(arrayOfLetters);
Console.WriteLine(word);
```

De uitvoer van deze code zal zijn: ``haxlo``.

### Andere nuttige methoden met strings

Volgende methoden kan je rechtstreeks op string-variabelen oproepen:

#### Length
Geeft  het totaal aantal karakters in de string wat logisch is, daar het om een arrays gaat:

```java
string myName="Tim";
Console.WriteLine(myName.Length); //er verschijnt 3 op het scherm
```

<!---{pagebreak} --->

#### IndexOf

Deze methode geeft  een ``int`` terug die de index bevat waar de string die je als parameter meegaf begint. Kan je gebruiken om te ontdekken of een bepaald woord bijvoorbeeld in een grote lap tekst voorkomt zoals volgende voorbeeld toont:

```java
string boek="Ik ben Reinhardt";
int index= boek.IndexOf("ben");
Console.WriteLine(index); 
```
Er zal ``3`` verschijnen, daar "ben" start op positie 3 ("ik" staat op positie 0 en 1, gevolgd door een spatie op positie 2). Indien de string niet gevonden werd, zal ``index`` de waarde -1 krijgen.

#### Trim

``Trim()`` verwijderd alle onnodige spaties vooraan en achteraan de string en geeft de opgekuiste string terug. Deze methode geeft de opgekuiste string terug als resultaat, je moet deze dus bewaren. In het volgende voorbeeld overschrijven we de originele string met z'n opgekuiste versie:

```java
string boek="   Ik ben Reinhardt   ";
Console.WriteLine(boek);
boek=boek.Trim();
Console.WriteLine(boek);
```

Dit zal de output op het scherm zijn (de spaties achteraan op lijn 1 zie je niet, maar zijn er dus wel):

<!---{line-numbers:false}--->
```text
   Ik ben Reinhardt   
Ik ben Reinhardt
```

#### ToUpper en ToLower

``ToUpper`` zal de meegegeven string naar ALLCAPS omzetten en geeft de nieuwe string als resultaat terug. ``ToLower()``doet het omgekeerde.

```java
string boek="Ik ben Reinhardt";
Console.WriteLine(boek.ToUpper());
Console.WriteLine(boek.ToLower());
```

Output op het scherm:

<!---{line-numbers:false}--->
```java
IK BEN REINHARDT
ik ben reinhardt
```

#### Replace

``Replace(string old, string news)`` zal in de string alle substrings die gelijk zijn aan ``old`` vervangen door de meegegeven ``news`` string en deze nieuwe string als resultaat teruggeven. 

Volgende voorbeeld toont dit en zal dus "Mercy" vervangen door "Reinhardt":

```java
string boek="Ik ben Mercy";
boek=boek.Replace("Mercy","Reinhardt");
Console.WriteLine(boek);
```

{% hint style='tip' %}
``Replace`` kan je ook misbruiken om bijvoorbeeld alle woorden uit een stuk tekst te verwijderen door deze te vervangen door een lege ``string`` met de waarde ``""``. Volgende code zal alle ``"e"``'s uit de tekst verwijderen:

```java
string boek="Ik ben Mercy";
boek=boek.Replace("e", "");
Console.WriteLine(boek);
```

Waardoor we ``Ik bn Mrcy`` op het scherm krijgen.
{% endhint %}

#### Remove

``Remove(int start, int lengte)`` zal op de index ``start`` alle ``lengte`` volgende karakters in de ``string`` verwijderen en een nieuwe, kortere ``string`` als resultaat geven.

Volgende voorbeeld zal het stukje "ben " uit de ``string`` weghalen:

```java
string boek="Ik ben Mercy";
boek=boek.Remove(3,4);
Console.WriteLine(boek);
```

Output op het scherm:

<!---{line-numbers:false}--->
```java
Ik Mercy
```
