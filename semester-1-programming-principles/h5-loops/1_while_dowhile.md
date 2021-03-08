# While en Do While

{% hint style="success" %}
[Kennisclip standaard while](https://youtu.be/PjUbLsvAFtk)
{% endhint %}

### While

De syntax van een while loop is eenvoudig:

```csharp
while (booleaanse expressie) 
{
  // C# die zal uitgevoegd worden zolang de booleaanse expressie waar is
}
```

Waarbij, net als bij een `if` statement, de conditie uitgedrukt wordt als een booleaanse expressie.

Zolang de conditie `true` is zal de code binnen de accolades uitgevoerd worden. Indien dus de conditie reeds vanaf het begin `false` is dan zal de code binnen de `while`-loop niet worden uitgevoerd.

Telkens wanneer het programma aan het einde van het `while` codeblock komt springt het terug naar de conditie bovenaan en zal de test wederom uitvoeren. Is deze weer `true` dan wordt de code weer uitgevoerd. Van zodra de test `false` is zal de code voorbij het codeblock springen en na het `while` codeblok doorgaan.

{% hint style="info" %}
De `while` is dus bijna identiek aan de `if` zonder `else`.  Het **enige** verschil: nadat het block is uitgevoerd, wordt de voorwaarde opnieuw getest en wordt het block eventueel opnieuw uitgevoerd.
{% endhint %}

Het diagramma is duidelijk:

![](../../.gitbook/assets/while%20%283%29.png)

Een voorbeeld van een eenvoudige while loop:

```csharp
int myCount = 0;

while (myCount < 100)
{
    myCount++;
    Console.WriteLine(myCount);
}
```

Zolang `myCount` kleiner is dan 100 \(`myCount < 100`\) zal myCount met 1 verhoogd worden en zal de huidige waarde van myCount getoond worden. We krijgen met dit programma dus alle getallen van 1 tot en met 100 op het scherm onder elkaar te zien.

Daar de test gebeurt aan het begin van de loop wil dit zeggen dat het getal 100 nog wel getoond zal worden. **Begrijp je waarom?** Test dit zelf!

### Do while

{% hint style="success" %}
[Kennisclip do while](https://youtu.be/X_wMRX_fFiA)
{% endhint %}

In tegenstelling tot een while loop, zal een do-while loop sowieso **minstens 1 keer uitgevoerd worden**. Ongeacht de opgegeven conditie zal de do-while loop zijn code 1 keer uitvoeren. We herhalen deze zin uitdrukkelijk twee keer zodat het verschil tussen beide type loops duidelijk blijft.

Vergelijk volgende diagramma van de `do while` met dat van de `while` hierboven:

![](../../.gitbook/assets/dowhile%20%282%29.png)

De syntax van een do-while is eveneens verraderlijk eenvoudig:

```csharp
do{
      // C# die uitgevoerd zal worden zolang de booleaanse expressie waar is
} while (booleaanse expressie);
```

{% hint style="warning" %}
Merk op dat achteraan de conditie een puntkomma na het ronde haakje staat. **Dit is een véél voorkomende fout. Bij een while is dit niet zo!** Daar de test van een do-while achteraan de code van de loop gebeurt is het logisch dat een do-while dus minstens 1 keer wordt uitgevoerd. Het volgende eenvoudige aftelprogramma toont de werking van de do-while loop.
{% endhint %}

```csharp
string antwoord;
do {
    antwoord = Console.ReadLine();
} while (antwoord != "ja" && antwoord != "nee");
```

Begrijp je waarom een gewone `while` hier niet geschikt is?

{% hint style="warning" %}
Dit is niet om te zeggen dat je dit niet kan schrijven met een gewone `while`. Maar deze werkwijze levert de eenvoudigste code.
{% endhint %}

### Complexe condities

{% hint style="success" %}
[Kennisclip booleaanse voorwaarden](https://youtu.be/0e56QIzX_nQ)
{% endhint %}

Uiteraard mag de conditie waaraan een loop moet voldoen complexer zijn door middel van de relationele operatoren.

Volgende `while` bijvoorbeeld zal uitgevoerd worden zolang `teller` groter is dan 5 en de variabele `naam` van het type `string` niet gelijk is aan "tim":

```csharp
while(teller > 5 && naam != "tim")
{
  //Keep repeating
}
```

### Oneindige loops

Indien de loop-conditie nooit `false` wordt, dan heb je een oneindige loop gemaakt. Soms is dit gewenst gedrag \(bijvoorbeeld in een programma dat constant je scherm moet updaten, zoals in een game\), soms is dit een bug.

Volgende twee voorbeelden tonen dit:

* Een bewust oneindige loop:

  ```csharp
  while(true)
  {
  //See you in infinity
  }
  ```

* Een bug die een oneindige loop veroorzaakt:

  ```csharp
  int teller = 0; 
  while(teller<10)
  {
      Console.WriteLine(teller);
  }
  ```

{% hint style="info" %}
Probeer er altijd zeker van te zijn dat de variabele\(n\) die je gebruikt in je test-conditie ook in de loop aangepast worden. Als deze in de loop constant blijft dan zal ook de test-conditie dezelfde blijven en heb je dus een oneindige loop gemaakt.
{% endhint %}

### Scope van variabelen in loops

{% hint style="success" %}
[Kennisclip scope](https://youtu.be/qRyfmvO6XPE)
{% endhint %}

Let er op dat de [scope](../h4-beslissingen/3_scope.md) van variabelen bij loops zeer belangrijk is. Indien je een variabelen binnen de loop definieert dan zal deze steeds terug "gereset" worden wanneer de volgende cyclus van de loop start. Volgende code toont bijvoorbeeld **foutief** hoe je de som van de eerste 10 getallen \(1+2+3+...+10\) zou maken:

```csharp
int teller= 1;
while(teller <= 10)
{
   int som= 0;
   som = som+teller;
   teller++;
}
Console.WriteLine(som); //deze lijn zal fout genereren
```

De **correcte** manier om dit op te lossen is te beseffen dat de variabele som enkel binnen de accolades van de while-loop gekend is. Op de koop toe wordt deze steeds terug op 0 gezet en er kan dus geen som van alle teller-waarden bijgehouden worden:

```csharp
int teller= 1;
int som=0;  
while(teller <= 10)
{

   som = som+teller;
   teller++
}
Console.WriteLine(som);
```

