## Algoritmes en arrays

Omdat arrays ongelooflijk groot kunnen worden, is het nuttig dat je algoritmes kunt schrijven die vlot met arrays kunnen werken. Je wilt niet dat je programma er 3 minuten over doet om gewoon te ontdekken of een bepaalde waarde in een array voorkomt of niet.

{% hint style='tip' %}
Bij jobsollicaties voor programmeurs wordt je vaak gevraagd om dergelijke algoritmes zonder hulp uit te schrijven.
{% endhint %}

#### Manueel zoeken in arrays

Het nadeel van BinarySearch is dat deze vereist dat je array-elementen gesorteerd staan. Uiteraard is dit niet altijd gewenst. Stel je voor dat je een simulatie maakt voor een fietswedstrijd en wilt weten of een bepaalde wielrenner in de top 5 staat.

Het zoeken in arrays kan met behulp van while of for-loops tamelijk snel. Volgend programmatje gaat zoeken of het getal 12 aanwezig is in de array (de wielrenners werken met rugnummers). Indien ja dan wordt de index bewaard van de positie in de array waar het getal staat:

```java
int teZoekenGetal = 12;
int[] top5 = {5, 10, 12, 25, 16};
bool gevonden = false;
int index = -1;
for (int i = 0; i < top5.Length; i++)
{
    if (top5[i] == teZoekenGetal)
    {
        gevonden = true;
        index = i;
    }
}
if(gevonden = true)
{
    Console.WriteLine($"Rugnummer {teZoekenGetal} eindigde op plek {index+1}");
    // +1 omdat de indexering vanaf 0 telt, wat de gebruiker niet moet weten. 
}
```

Voorgaande stukje code is de meest naïeve oplossing. Bedenk echter wat er gebeurt indien het getal dat we zoeken 2 of meerdere keren in de array staat. Index zal dan de positie bevatten van de laatst gevonden 12 in de array. Uiteraard kan je het algoritme aanpassen om hier rekening mee te houden.

#### Manueel zoeken met for en while

We tonen nu twee voorbeelden van hoe je kan zoeken in een array wanneer we bijvoorbeeld 2 arrays hebben die 'synchroon' zijn. Daarmee bedoelen we: de eerste array bevat producten, de tweede array bevat de prijs van ieder product. De prijs van de producten staat steeds op dezelfde index in de andere array:

```java
string[] producten = {"appelen", "peren", "meloenen"};
double[] prijzen = {3.3, 6.2, 2.9};
```

We vragen nu aan de gebruiker van welk product de prijs getoond moet worden:

```java
Console.WriteLine("Welke productprijs wenst u?");
string keuzeGebruiker = Console.ReadLine();
```

We tonen nu hoe we met ``for`` eerst het juiste product zoeken en dan vervolgens die index bewaren en gebruiken om de prijs te tonen:

```java
bool gevonden = false;
int productIndex = -1;
int teller = 0;
while (teller < producten.Length && keuzeGebruiker != producten[teller])
{
    teller++;
}
if (teller != producten.Length) //product gevonden!
{
    gevonden = true;
    productIndex = teller;
}
if (gevonden == true)
{
    Console.WriteLine($"Prijs van {keuzeGebruiker} is {prijzen[productIndex]}");
}
else
{
    Console.WriteLine("Niet gevonden");
}
```

Een nadeel van deze oplossing is dat we steeds de hele ``for`` doorlopen (we gebruiken geen ``break`` vanwege een allergie hiervoor bij de auteur). Bij heel lange arrays is dit dus niet erg performant.

<!---{pagebreak} --->

Volgende oplossing met een ``while`` toont een performantere oplossing:

```java
bool gevonden = false;
int productIndex = -1;
int teller = 0;
while (teller < producten.Length && keuzeGebruiker != producten[teller])
{
    teller++;
}
if (teller != producten.Length) //product gevonden!
{
    gevonden = true;
    productIndex = teller;
}
if (gevonden == true)
{
    Console.WriteLine($"Prijs van {keuzeGebruiker} is {prijzen[productIndex]}");
}
else
{
    Console.WriteLine("Niet gevonden");
}
```

{% hint style='tip' %}
Dat was het? Er zijn tal van andere algoritmes. Denk maar aan de verschillende manieren om arrays te sorteren (bijvoorbeeld de fameuze ``bubblesort`` en ``quicksort`` algoritmes). Al deze algoritmes hier bespreken zou een boek apart vereisen. We toonden daarom enkele ter illustratie.
{% endhint %}