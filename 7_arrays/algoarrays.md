{% hint style='warning' %}
Het is zéér belangrijk dat je vlot de algoritmen kan schrijven die in dit hoofdstuk aan bod komen, zoals:

* Zoeken van elementpositie in array
* Tellen hoe vaak een element in een array voorkomt
* Elementen in een array 1 of meerdere plaatsen opschuiven
{% endhint %} 

{% hint style='tip' %}
Dit soort algoritmes worden erg vaak bij solicitaties voor een programmeer-functie gevraagd om te maken.
{% endhint %}

# Manueel zoeken in arrays

Het zoeken in arrays kan met behulp van while of for-loops tamelijk snel. Volgend programmatje gaat zoeken of het getal 12 aanwezig is in de array. Indien ja dan wordt de index bewaard van de positie in de array waar het getal staat:

```csharp
int teZoekenGetal = 12;
 
int[] getallen = {5, 10, 12, 25, 16};
 
bool gevonden = false;
int index = -1;
 
for (int i = 0; i < getallen.Length; i++)
{
    if (getallen[i] == teZoekenGetal)
    {
        gevonden = true;
        index = i;
    }
}
```

Voorgaande stukje code is de meest naïeve oplossing. Bedenk echter wat er gebeurt indien het getal dat we zoeken 2 of meerdere keren in de array staat. Index zal dan de positie bevatten van de laatst gevonden 12 in de array.

### Manueel zoeken met for en while

We tonen nu twee voorbeelden van hoe je kan zoeken in een array wanneer we bijvoorbeeld 2 arrays hebben die 'synchroon' zijn. Daarmee bedoel ik: de eerste array bevat producten, de tweede array bevat de prijs van ieder product. De prijs van de producten staat steeds op dezelfde index in de andere array:

```csharp
string[] products = {"apples", "pears", "melons"};
double[] prices = {3.3, 6.2, 2.9};
```

We vragen nu aan de gebruiker van welk product de prijs getoond moet worden:

```csharp
Console.WriteLine("Which price do you need?");
string userchoice = Console.ReadLine();
```

We tonen nu hoe we met ``for`` eerst het juiste product zoeken en dan vervolgens die index bewaren en gebruiken om de prijs te tonen:

```csharp
bool found = false;
int productIndex = -1;

int counter = 0;
while (counter < products.Length && userchoice != products[counter])
{
    counter++;
}

if (counter != products.Length) //product found!
{
    found = true;
    productIndex = counter;
}


if (found == true)
{
    Console.WriteLine($"Price for {userchoice} is {prices[productIndex]}");
}
else
{
    Console.WriteLine("Not found");
}
```

Een nadeel van deze oplossing is dat we steeds de hele ``for`` doorlopen (we gebruiken geen ``break`` vanwege een allergie hiervoor bij de auteur). Bij heel lange arrays is dit dus niet erg performant.

Volgende oplossing met een ``while`` toont een performantere oplossing:

```csharp
bool found = false;
int productIndex = -1;

int counter = 0;
while (counter < products.Length && userchoice != products[counter])
{
    counter++;
}

if (counter != products.Length) //product found!
{
    found = true;
    productIndex = counter;
}

if (found == true)
{
    Console.WriteLine($"Price for {userchoice} is {prices[productIndex]}");
}
else
{
    Console.WriteLine("Not found");
}
```