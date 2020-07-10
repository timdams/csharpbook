## String en arrays

Het type ``string`` is niet meer dan een arrays van karakters, ``char[]``. Het is dan ook logisch dat we dit erg belangrijke datatype even apart toelichten.

### String naar char array

 Om een ``string`` per karakter te bewerken is het aanbevolen om deze naar een *char-array* om te zetten en nadien terug naar een string. Dit kan gebruikmakend van ``.ToCharArray()`` als volgt:

```csharp
string origineleZin = "Ik ben Tom";
char[] karakters = origineleZin.ToCharArray();
karakters[8] = 'i';
```

De uitvoer zal worden:``Ik ben Tim``.

### Char array naar string

Ook de omgekeerde weg is mogelijk.  De werking is iets anders en maakt gebruikt van ``new string()``, let vooral op hoe we de char array doorgeven als argument bij het aanmaken van een nieuwe ``string`` in lijn 3:

```csharp
char[] arrayOfLetters = {'h', 'a', 'l', 'l', 'o'};
arrayOfLetters[2] = 'x';
string word = new string(arrayOfLetters);
Console.WriteLine(word);
```

De uitvoer van deze code zal zijn: ``haxlo``.
