## Methoden en arrays

Zoals alle datatypes kan je ook arrays van eender welk datatype als parameter gebruiken bij het schrijven van een methode.

{% hint style='warning' %}
**Opgelet:**
Herinner je dat arrays *by reference* werken. Je werkt dus steeds met de origineel meegegeven array (of beter, de referentie er naar), ook in de methode. Als je dus aanpassingen aan de array aanbrengt in de methode, dan zal dit ook gevolgen hebben op de array van de parent-methode (logisch: het gaat om dezelfde array).
{% endhint %}

Stel dat je bijvoorbeeld een methode hebt die als parameter 1 array van ints meekrijgt. De methode zou er dan als volgt uitzien.

```java
static void EenVoorbeeldMethode(int[] inArray)
{
 
}
```

Om deze methode aan te roepen volstaat het om een bestaande array als parameter mee te geven:

```java
int[] getallen = {1, 2, 3};
EenVoorbeeldMethode(getallen);
```

### Array grootte in de methode
Een array als parameter meegeven kan dus, maar een ander aspect waar rekening mee gehouden moet worden is dat je niet kan ingeven in de parameterlijst hoe groot de array is. Je zal dus in je methode steeds de grootte van de array moeten uitlezen met de ``.Length``-eigenschap.

Volgende methodesignatuur is dus **FOUT**!

```java 
static void EenVoorbeeldMethode(ref int[6] inArray)
{
 
}
```
En zal volgende error genereren:

![Duidelijk toch!](../assets/5_arrays/arrays3.png)

### Arraymethode voorbeeld

Volgend voorbeeld toont een methode die alle getallen van de meegegeven array op het scherm zal tonen:

```java
static void ToonArray(int[] getalArray)
{
    Console.WriteLine("Array output:");
    for (int i = 0; i < getalArray.Length; i++)
    {
        Console.WriteLine(getalArray[i]);
    }
}
```


De ``ToonArray`` methode aanroepen kan dan als volgt:

```java
int[] leeftijden = {2, 5, 1, 6};
ToonArray(leeftijden);
``` 
En de output zal dan zijn:

<!---{line-numbers:false}--->
```
Array output:
2
5
1
6
```

<!---{pagebreak} --->

### Voorbeeldprogramma met methoden
Volgend programma toont hoe we verschillende onderdelen van de code in methoden hebben geplaatst zodat:

1. de lezer van de code sneller kan zien wat het programma juist doet
2. zodat code herbruikbaar is

Begrijp je wat dit programma doet? En kan je voorspellen wat er op het scherm zal komen? 

```java
static void VulArray(int[] getalArray)
{
    for (int i = 0; i < getalArray.Length; i++)
    {
        getalArray[i] = i;
    }
}

static void VermenigvuldigArray(int[] getalArray, int multiplier)
{
    for (int i = 0; i < getalArray.Length; i++)
    {
        getalArray[i] = getalArray[i] * multiplier;
    }
}

static void ToonVeelvouden(int[] getalArray, int veelvoudenvan)
{
    for (int i = 0; i < getalArray.Length; i++)
    {
        if (getalArray[i] % veelvoudenvan == 0)
            Console.WriteLine(getalArray[i]);
    }
}

static void Main(string[] args)
{
    int[] getallen = new int[100];
    VulArray(getallen);
    VermenigvuldigArray(getallen, 3);
    ToonVeelvouden(getallen, 4);
} 
```

<!---{pagebreak} --->

### Array als return-type bij een methode

Een array kan ook gebruikt worden als het returntype van een array. Hiervoor zet je gewoon het type array als returntype (wederom zonder de grootte) in de methode-signature.

Stel bijvoorbeeld dat je een methode hebt die een int-array aanmaakt van een gegeven grootte waarbij ieder element van de array reeds een beginwaarde heeft die je ook als parameter meegeeft:

```java
static int[] MaakArray(int lengte, int beginwaarde)
{
    int[] resultArray = new int[lengte];
    for (int i = 0; i < lengte; i++)
    {
        resultArray[i] = beginwaarde;
    }
    return resultArray;
}
```
De aanroep van deze methode vereist dan dat je het resultaat opvangt in een nieuwe variabele, als volgt:

```java
int[] mijnNieuweArray= MaakArray(4,666);
```

{% hint style='warning' %}
Onthoud dat arrays altijd **by reference** naar en van methoden komen. Je werkt dus op de originele array, niet op een kopie er van!
{% endhint %}

<!---{pagebreak} --->

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Snel, zet je helm op, voor er ongelukken gebeuren! We hadden al enkele keren gezegd dat arrays *by reference* worden meegegeven, maar wat is daar nu het gevolg van? Wel, laten we eens naar volgende programma'tje kijken dat ik heb geschreven om de nummering van de appartementen in een flatgebouw aan te passen. Zoals je weet is het gelijkvloers in sommige landen 0, terwijl in andere dit 1 is. Volgende programma past het nummer van het gelijkvloers aan:

```java
public static void Main()
{
    int[] verdiepnummers= {1,2,3};
    Console.WriteLine($"VOOR:{verdiepnummers[0]}"); // VOOR:1
    PasAan(verdiepnummers);
    Console.WriteLine($"NA:{verdiepnummers[0]}"); // NA:-1
}

static void PasAan(int[] inarr)
{
        inarr[0]= -1;
}
```

Dankzij het feit dat we aan ``PasAan`` een array meegeven *by reference* zal de methode werken op de originele array en is deze code dus mogelijk. 

Vergelijk dit met volgende voorbeeld waar we een ``int`` als parameter meegeven die *by value* en niét *by reference* wordt meegegeven:

```java
	public static void Main()
	{
		int[] getallen= {1,2,3};
		PasAan(getallen[0]);
		Console.WriteLine(getallen[0]); // NA:1
	}
	
	static void PasAan(int inarr)
	{
	      inarr= -1; //inarr wordt -1
	}
```

Daar de methode nu werkt met een kopie, zal de aanpassing in de methode dus geen invloed hebben op de origineel meegegeven ``int`` (ongeacht dat die deel uitmaakt van een array).
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->