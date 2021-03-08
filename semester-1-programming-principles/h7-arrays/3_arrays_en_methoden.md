# Arrays en methoden

{% hint style="danger" %}
TODO: aanvullen met info over niet-opgevulde arrays en null references
{% endhint %}

## Methoden met arrays als parameter maken

Zoals alle types kan je ook arrays van eender welk type als parameter gebruiken bij het schrijven van een methode.

**Opgelet:**

Arrays worden altijd ‘by reference’ doorgegeven aan een methode. Dit heeft twee belangrijke gevolgen:

1. Je hoeft het ref keyword niet mee te geven, dit gebeurt impliciet reeds
2. Je werkt steeds met de eigenlijke array, ook in de methode. Als je dus aanpassingen aan de array aanbrengt in de methode, dan zal dit ook gevolgen hebben op de array van de parent-methode \(logisch: het gaat om dezelfde array\).

Stel dat je bijvoorbeeld een methode hebt die als parameter 1 array van ints meekrijgt. De methode zou er dan als volgt uitzien.

```csharp
static void EenVoorbeeldMethode(int[] inArray)
{

}
```

### Array grootte in de methode

Een array als argument meegeven kan dus, maar een ander aspect waar rekening mee gehouden moet worden is dat je niet kan ingeven in de parameterlijst hoe groot de array is! Je zal dus in je methode steeds de grootte van de array moeten uitlezen met de Length-eigenschap.

Volgende methode is dus **FOUT**!

```csharp
static void EenVoorbeeldMethode(int[6] inArray)
{

}
```

En zal volgende error genereren:

![](../../.gitbook/assets/arrays3%20%282%29.png)

## Arraymethode voorbeeld

Volgend voorbeeld toont een methode die alle getallen van de array op het scherm zal tonen:

```csharp
static void ToonArray(int[] getalArray)
{
    Console.WriteLine("Array output:");
    for (int i = 0; i < getalArray.Length; i++)
    {
        Console.WriteLine(getalArray[i]);
    }
}
```

Stel dat je elders volgende array hebt `int[] leeftijden = {2, 5, 1, 6};`. De `ToonArray` methode aanroepen kan dan als volgt:

```csharp
ToonArray(leeftijden);
```

En de output zal dan zijn:

```text
Array output:
2
5
1
6
```

### Voorbeeldprogramma met methoden

Volgend programma toont hoe we verschillende onderdelen van de code in methoden hebben geplaatst zodat: 1. de lezer van de code sneller kan zien wat het programma juist doet 2. zodat code herbruikbaar is

Analyseer de code en denk na hoe eenvoudig het is om een ander programma hiervan te maken \(bijvoorbeeld vermenigvuldigen met 10 en alle veelvouden van 6 tonen: je hoeft enkel de parameters in de methode-aanroep aan te passen\):

```csharp
namespace ArrayMethods
{
    class Program
    {

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
            //Array aanmaken
            int[] getallen = new int[100];

            //Array vullen
            VulArray(getallen);

            //Alle elementen met 3 vermenigvuldigen
            VermenigvuldigArray(getallen, 3);

            //Enkel veelvouden van 4 op het scherm tonen
            ToonVeelvouden(getallen, 4);

        }
    }
}
```

### Array als return-type bij een methode

Ook methoden kun je natuurlijk een array als returntype laten geven. Hiervoor zet je gewoon het type array als returntype zonder grootte in de methode-signature.

Stel bijvoorbeeld dat je een methode hebt die een int-array maakt van een gegeven grootte waarbij ieder element van de array reeds een beginwaarde heeft die je ook als parameter meegeeft:

```csharp
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

