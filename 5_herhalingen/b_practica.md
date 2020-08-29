<!---NOBOOKSTART--->
## Nog meer oefeningen
{% hint style='tip' %}
Begin pas aan deze oefeningen wanneer je voldoende geoefend hebt door de vorige 2 delen oefeningen op te lossen.
{% endhint %}
<!---NOBOOKEND--->

#### Grootste getal
Vervolledig deze code zodat ook getoond wordt welke de grootste waarde is die werd ingevoerd.

```java
int x= 0;
int y= 0;
do
{
    y = y + x;
    Console.WriteLine("Voer gehele waarden in (32767=stop)");
    string instring= Console.ReadLine();
    x = Convert.ToInt32(instring);
    //....

}while (x != 32767);
Console.WriteLine($"Som is {y}");
```

#### Boekhouder
Maak een 'boekhoud-programma': de gebruiker kan continu positieve en negatieve getallen invoeren. Telkens hij op enter duwt wordt de huidige invoer aan de balans bijgevoegd.
Je houdt volgende zaken bij:

* De balans van alle ingevoerde getallen: dit is gewoon de som van de getallen. Als de gebruiker dus de getallen 4, -10 en 8 invoerde dan zal de balans op +2 staan  (4 -10 + 8).
* De som van alle negatieve invoeren. Als de gebruiker dus 4, -10, 8 en -6 invoerde dan zal dit getal op -16 staan (= -10 -6).
* De som van alle positieve invoeren. Als de gebruiker dus 4, -10, 8 en -6 invoerde dan zal dit getal op +12 staan (= 4 + 8). 
* Het gemiddelde van alle ingevoerde getallen.

Deze 4 getallen worden steeds geüpdatet en getoond wanneer de gebruiker een nieuw getal invoert en op enter duwt.

#### Hoger Lager

Simulatie van het "hoger-lager" spel. Het programma kiest een random-getal tussen 1 en 100 (telkens inbegrepen). Vervolgens wordt de gebruiker gevraagd om een gok te doen en toont het programma of de gok juist was, te laag was ("hoger") of te hoog ("lager"). Het programma blijft gokken van de gebruiker accepteren tot de gok juist is of de gebruiker besluit te stoppen. Het aantal beurten wordt op het einde van het spel getoond en de mogelijkheid om opnieuw te spelen.

##### Limiet
Pas het Hoger Lager programma aan zodat er een maximum aantal pogingen is toegestaan.

#### Tekenen

Twee getallen tussen 2 en 20 worden ingelezen (invoercontrole!). Er moet een open rechthoek afgedrukt worden bestaande uit `*`en waarbij de ingelezen getallen respectievelijk de breedte en de hoogte van de rechthoek voorstellen. Als bijvoorbeeld 10 en 4 werden ingelezen, wordt de volgende rechthoek getoond:

<!---{line-numbers:false}--->
```text
* * * * * * * * * *
*                 *
*                 *
* * * * * * * * * *
```

#### Steen schaar papier
Maak een applicatie waarbij de gebruiker steen-schaar-papier met de computer kan spelen. De gebruiker kiest telkens steen, schaar of papier en drukt op enter. Vervolgens kiest de computer willekeurig steen, schaar of papier (gebruik de Random.Next() methode, waarbij je deze tussen 1 en 3 laat varieren). 
Vervolgens krijgt de winnaar 1 punt:
* Steen wint van schaar, verliest van papier.
* Papier wint van steen, verliest van schaar.
* Schaar wint van papier, verliest van steen.
* Indien beide hetzelfde hebben wint niemand een punt.

Op het scherm wordt telkens getoond wie de huidige ronde heeft gewonnen en hoeveel de tussenscore is. De eerste (pc of gebruiker) die 10 punten haalt wint.

Teken een flowchart van je applicatie.

{% hint style='tip' %}
Los dit op met ``enum`` : je code zal een pak leesbaarder worden
{% endhint %}

#### Become Neo

![Neo Tim](../assets/neotim.png)

Volgende code genereert een beeld zoals dat ook in de cultfilm The Matrix (1999) plaatsvindt. 
```java
Random rangen = new Random();
Console.ForegroundColor = ConsoleColor.Green;
while (true)
{
    //Genereer nieuw random teken:
    char teken = Convert.ToChar(rangen.Next(62, 400));
    //Zet teken op scherm
    Console.Write(teken);
    
    //10 ms pauze tussen ieder frame (pas gerust aan)
    System.Threading.Thread.Sleep(10); 
    
    //Af en toe donker kleurtje
    if(rangen.Next(0, 3) == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
}
```

Vul de code aan zodat de karakters random kleuren krijgen. Kan je het nog cooler maken?

#### BeerSong
Schrijf een BeerSong-generator zoals onderstaande output. Merk op dat de laatste 5 zinnen anders zijn:

```
99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.

98 bottles of beer on the wall, 98 bottles of beer.
Take one down and pass it around, 97 bottles of beer on the wall.

97 bottles of beer on the wall, 97 bottles of beer.
Take one down and pass it around, 96 bottles of beer on the wall.

96 bottles of beer on the wall, 96 bottles of beer.
Take one down and pass it around, 95 bottles of beer on the wall.

95 bottles of beer on the wall, 95 bottles of beer.
Take one down and pass it around, 94 bottles of beer on the wall.

...

4 bottles of beer on the wall, 4 bottles of beer.
Take one down and pass it around, 3 bottles of beer on the wall.

3 bottles of beer on the wall, 3 bottles of beer.
Take one down and pass it around, 2 bottles of beer on the wall.

2 bottles of beer on the wall, 2 bottles of beer.
Take one down and pass it around, 1 bottle of beer on the wall.

1 bottle of beer on the wall, 1 bottle of beer.
Take it down and pass it around, no more bottles of beer on the wall.

No more bottles of beer on the wall, no more bottles of beer.
Go to the store and buy some more, 99 bottles of beer on the wall.
```
