# The Array MazeGame

![](../assets/Aallinone/mazegame/0.jpg)
## Inleiding 

In dit all-in-one tonen we hoe je, stap voor stap, kan komen tot een speelbaar, eenvoudige tekst-gebaseerd spel. We hanteren hierbij de principes van "refactoring": we gaan onze code steeds verbeteren op gebied van leesbaarheid en onderhoudbaarheid. Bij iedere stap zullen we dan ook extra functionaliteit toevoegen.

Het doel is te komen tot een spel waarbij de gebruiker kan wandelen door een kaart. De kaart zelf is dynamisch, bepaalde ruimtes zijn pas toegankelijk wanneer aan bepaalde voorwaarden is voldaan.
![](../assets/Aallinone/mazegame/01.png)


### Vereiste kennis

Deze tutorial gaat er van uit dat je volgende zaken beheerst:

*   Basisprincipes van Arrays, zowel 1D als 2D arrays: aanmaken, waarden toevoegen/uitlezen
*   Werken met de Console-bibliotheek: in het bijzonder Clear(), SetCursorPosition(), ForeGroundColor en BackGroundColor, Write() vs WriteLine()
*   Je kan werken met while en for-loops
*   Je begrijpt de werking van het ``out`` keyword

## Fase 1: Een saai spel 

We gebruiken een array van strings om de opeenvolgende kamers te beschrijven. Door middel van een for-loop doorlopen we de array en tonen we iedere beschrijving van de kamer op het scherm.

Telkens de gebruiker op enter drukt verschijnt de volgende kamer.

Merk op dat de array-lengte geen invloed heeft op de forloop. We kunnen dus eenvoudig kamers toevoegen zonder dat dit invloed heeft op de werking van het programma. We zullen blijven behouden doorheen het hele programma (de speciale kaart uitgezonder in fase 8).

```csharp
string[] Kamers = new string[]
    {
        "Je staat voor de ingang.",
        "Je bent in de hal.",
        "Je bent in het computerlabo",

    };

for (int i = 0; i < Kamers.Length; i++)
{
    Console.WriteLine(Kamers[i]);
    Console.ReadLine();
}
```
![](../assets/Aallinone/mazegame/1.png)

## Fase 2: Een interactief saai spel 

We bieden de mogelijkheid aan aan de gebruiker om zelf te kiezen naar welke kamer er wordt gegaan. De gebruiker kan dus "vooruit’" of "achteruit" gaan in de array. We houden hiervoor een variabele (``huidigekamer``) bij die bijhoudt waar de gebruiker zich momenteel bevindt.

Telkens de gebruiker zich wil verplaatsen controleren we of deze verplaatsen toegestaan is. De ``Huidigekamer`` variabele is dus automatisch ook de index van de te tonen kamer in de string-array.

```csharp
string[] Kamers = new string[]
    {
        "Je staat voor de ingang.",
        "Je bent in de hal.",
        "Je bent in het computerlabo",

    };

int huidigekamer = 0;
string keuze = "";
while (keuze != "q")
{
    Console.WriteLine(Kamers[huidigekamer]);

    Console.WriteLine("Vooruit= V, ACHTERUIT = A, q= quit");
    keuze = Console.ReadLine();
    if (keuze == "V" && huidigekamer != Kamers.Length - 1)
        huidigekamer++;
    else if (keuze == "A" && huidigekamer != 0)
        huidigekamer--;
    else if (keuze == "q")
        Console.WriteLine("Byebye");
    else
    {
        Console.WriteLine("Foute invoer");
    }
}
```
![](../assets/Aallinone/mazegame/2.png)
## Fase 3: Een 2D-wereld met lookup-table

### Stap 1: Kaart maken {#stap-1-kaart-maken}

Vervolgens willen we de mogelijkheid om een 2D wereld aan te bieden. Hierbij gebruiken we een zogenaamde **lookup-table** zodat we onze wereld array eenvoudig kunnen houden én kamers kunnen herbruiken.

Eerste definiëren we de verschillende kamers die er bestaan:

```csharp
string[] Kamers =
    {
        "Onbekend terrein", //0
        "In een gang", //1
        "In de lobby", //2
        "In de bar", //3
        "In de keuken", //4
        "Achtertuin"//5
    };
```

Vervolgens maken we 2D-array die onze kaart voorstelt. De array is van het type ``int``. Iedere cijfer in de array zal de index bevatten van de kamer die op die plek moet komen. Dit is dus een zogenaamde look-up-table of Lut (meer info: [wiki](http://en.wikipedia.org/wiki/Lookup_table)):

```csharp
            int[,] Kaart =
                {
                    {1, 2, 1, 3},
                    {0, 1, 0, 1},
                    {0, 4, 0, 5}
                };
```
Linksboven beginnen we dus met een Gang, met rechts ervan een lobby, etc.

Plaatsen die we met een 0 (onbekend terrein) definiëren gaan we beschouwen als plaatsen waar de gebruiker niet mag komen.

Merk op dat we dus onze *wereld* zo groot of zo klein kunnen maken als we zelf wensen.

### Stap 2: Wandelen op de kaart 
Daar we ons nu op een 2D-kaart bevinden hebben we 2 variabelen nodig om onze huidige positie te onthouden:

```csharp
int posX = 0;
int posY = 0;
```

We spreken af dat de locatie (0,0) zicht linksboven in de array bevindt.

We maken een oneindige loop die steeds de volgende stappen zal doen:

1.  Huidige kamertekst op het scherm tonen
2.  Aan de gebruiker vragen naar waar hij wil wandelen
3.  Positie van gebruiker veranderen
4.  Terug naar 1.

Eerst gebruiken we dus de lut om de huidige kamer beschrijving te tonen. We gebruiker de huidige spelerlocatie als index’s in de Kaart-array en vragen zo de kamerindex op. Die kamerindex gebruiken we om de tekst uit de Kamers-array te tonen.
```csharp
while (true)
{
    int kamerindex = Kaart[posX, posY];
    Console.WriteLine(Kamers[kamerindex]);
```
De gebruiker kan zich naar het noorden, oosten, zuiden of westen begeven (respectievelijk naar boven, links, onder, rechts op de kaart). We vragen dus telkens de gebruiker naar waar hij:

```csharp
Console.WriteLine("NOZW? Naar waar wil je?");
char inp = Convert.ToChar(Console.ReadLine().ToUpper());

```

### Stap 3: Positie aanpassen 

We verwerken de richting in een switch:
```csharp
switch (inp)
{
```
Naargelang de richting die de gebruiker ingeeft moeten we dus telkens 2 zaken contoleren:

1.  Bevindt de gebruiker zich momenteel (VOOR we z’n locatie aanpassen) aan de rand van de array (0 of Length-1)
2.  Probeert de gebruiker zich naar verboden vakje te begeven (een **onbekend terrein** vakje)

Indien aan deze 2 voorwaarden niet is voldaan dan mogen we de huidige locatie van de gebruiker zonder problemen veranderen. Dit behelst dus dat we , naargelang de richting, de posX en posY waarden veranderen, namelijk:

*   Noorden: posX met 1 verlagen
*   Zuiden: posX met 1 verhogen
*   Oosten: posY met 1 verhogen
*   Westen: posY met 1 verlagen

We krijgen in de switch dus:

```csharp
    case 'N':
        if (posX != 0 && Kaart[posX - 1, posY] != 0)
            posX--;
        else Console.WriteLine("Kan niet");
        break;
    case 'O':
        if (posY != Kaart.Length(1)-1 && Kaart[posX, posY + 1] != 0)
            posY++;
        else Console.WriteLine("Kan niet");
        break;
    case 'Z':
        if (posX != Kaart.GetLength(0)-1 && Kaart[posX + 1, posY] != 0)
            posX++;
        else Console.WriteLine("Kan niet");
        break;
    case 'W':
        if (posY != 0 && Kaart[posX, posY - 1] != 0)
            posY--;
        else Console.WriteLine("Kan niet");
        break;
}
```

### Stap 4: Volledige code 

De volledige code van deze fase is dus geworden:

```csharp
int[,] Kaart =
    {
        {1, 2, 1, 3},
        {0, 1, 0, 1},
        {0, 4, 0, 5}
    };

string[] Kamers =
    {
        "Onbekend terrein", //0
        "In een gang", //1
        "In de lobby", //2
        "In de bar", //3
        "In de keuken", //4
        "Achtertuin"//5
    };

int posX = 0;
int posY = 0;

while (true)
{
    int kamerindex = Kaart[posX, posY];
    Console.WriteLine(Kamers[kamerindex]);

    Console.WriteLine("NOZW? Naar waar wil je?");

    char inp = Convert.ToChar(Console.ReadLine().ToUpper());
    switch (inp)
    {
        case 'N':
            if (posX != 0 && Kaart[posX - 1, posY] != 0)
                posX--;
            else Console.WriteLine("Kan niet");
            break;
        case 'O':
            if (posY != Kaart.GetLength(1)-1 && Kaart[posX, posY + 1] != 0)
                posY++;
            else Console.WriteLine("Kan niet");
            break;
        case 'Z':
            if (posX != Kaart.GetLength(0)-1 && Kaart[posX + 1, posY] != 0)
                posX++;
            else Console.WriteLine("Kan niet");
            break;
        case 'W':
            if (posY != 0 && Kaart[posX, posY - 1] != 0)
                posY--;
            else Console.WriteLine("Kan niet");
            break;
    }
}
```

## Fase 4: Tekenen van de kaart op het scherm 

We wensen een visuele indicatie van de kaart te tonen aan de gebruiker (zonder dat hij ziet wat voor kamer het is). We voegen daarom een methode ``DrawMap()`` toe die de kaart iedere keer opnieuw zal tekenen. Deze methode gaat ook de positie van de gebruiker duidelijk maken a.d.h.v. een "X" op de kaart. Onze *game-loop* veranderen we dus naar:

```csharp
while (true)
{
    Console.Clear();
    DrawMap(Kaart, posX, posY);

    int kamerindex = Kaart[posX, posY];
    Console.WriteLine(Kamers[kamerindex]);

    Console.WriteLine("NOZW? Naar waar wil je?")
```

De ``DrawMap()`` methode toont dus de huidige locatie als een "X". Voorts willen we dat enkel bereikbare kamers getoond worden (we gebruiken een "O" hiervoor). Elementen op de kaart die wijzen naar index 0 ("Onbekend terrein") worden niet getoond.

We doorlopen in de ``DrawMap()`` methode de volledige kaart. Lijn per lijn. Hiervoor gebruiken we 2 geneste for-loops. De outer-loop (index ``i``) zal de X-coördinaat aflopen, oftewel lijn per lijn. De inner loop (index j) zal de Y-coördinaat aflopen, oftewel kolom per kolom:

```csharp
private static void DrawMap(int[,] Kaart, int posX, int posY)
{
    for (int i = 0; i < Kaart.GetLength(0); i++)
    {
        for (int j = 0; j < Kaart.GetLength(1); j++)
        {
```

Merk op dat ook deze methode geen *hardcoded* array-grenzen bevat. We kunnen dus eender welke kaart aan deze methode aanbieden.

Binnen de inner-for gaan we nu element per element van 1 rij op het scherm tonen. Eerst controleren we of de speler zich bevindt in het element dat we op het punt staan te tekenen. Als dat zo is dan plaatsen we een "X":
```csharp
if (posX == i & posY == j)
    Console.Write("X");
```

Anders plaatsen we een "o" indien het gaat om gebied waar de speler toegelaten is:
```csharp
else if (Kaart[i, j] != 0)
    Console.Write("o");
```

Niet toegelaten gebied tonen we niet, we zetten dus een spatie in de plaats:
```csharp
else
    Console.Write(" ");
```

Na iedere inner-loop moeten we vervolgens een newline toevoegen, anders worden alle rijen van de kaart naast elkaar gezet. Finaal krijgen we dus:
```csharp
    }
    Console.Write('\n');
}
```

Dit resulteert in volgende finale code voor deze fase:
```csharp
static void Main()
{
    int[,] Kaart ={ {1, 2, 1, 3},{0, 1, 0, 1},{0, 4, 0, 5}};

    string[] Kamers ={"Onbekend terrein",  "In een gang", "In de lobby", "In de bar", "In de keuken", "Achtertuin"};

    int posX = 0;
    int posY = 0;

    while (true)
    {
        Console.Clear();
        DrawMap(Kaart, posX, posY);

        int kamerindex = Kaart[posX, posY];
        Console.WriteLine(Kamers[kamerindex]);
        Console.WriteLine("NOZW? Naar waar wil je?");

        char inp = Convert.ToChar(Console.ReadLine().ToUpper());
        switch (inp)
        {
            case 'N':
                if (posX != 0 && Kaart[posX - 1, posY] != 0)
                    posX--;
                else Console.WriteLine("Kan niet");
                break;
            case 'O':
                if (posY != Kaart.GetLength(1)-1 && Kaart[posX, posY + 1] != 0)
                    posY++;
                else Console.WriteLine("Kan niet");
                break;
            case 'Z':
                if (posX != Kaart.GetLength(0)-1 && Kaart[posX + 1, posY] != 0)
                    posX++;
                else Console.WriteLine("Kan niet");
                break;
            case 'W':
                if (posY != 0 && Kaart[posX, posY - 1] != 0)
                    posY--;
                else Console.WriteLine("Kan niet");
                break;
        }
    }
}
private static void DrawMap(int[,] Kaart, int posX, int posY)
{
    for (int i = 0; i <= Kaart.GetLength(0); i++)
    {
        for (int j = 0; j <= Kaart.GetLength(1); j++)
        {
            if (posX == i & posY == j)
                Console.Write("X");
            else if (Kaart[i, j] != 0)
                Console.Write("o");
            else
                Console.Write(" ");
        }
        Console.Write('\n');
    }
}
```

## Fase 5: Kaart vergroten

Zoals reeds aangehaald staat niets je in de weg om je spel-wereld groter te maken. Hiervoor hoef je enkel (momenteel) de Kamers en Kaart arrays aan te passen. Alle code zal blijven werken.

Bijvoorbeeld:
```csharp
int[,] Kaart =
    {
        {1, 2, 1, 3, 0, 0},
        {0, 1, 0, 1, 0, 0},
        {0, 4, 0, 1, 0, 0},
        {0, 1, 0, 1, 0, 0},
        {0, 7, 0, 6, 1, 8},
    };

string[] Kamers =
    {
        "Onbekend terrein", //0 
        "In een gang", //1
        "In de lobby", //2
        "In de bar", //3
        "In de keuken", //4
        "Achtertuin",//5
        "In de securityroom", //6
        "In de personeelsruimte", //7
        "In de folterkamer" //8
    };
```

![](../assets/Aallinone/mazegame/3.png)

## Fase 6: Een extra look-up-table voor meer wereld-details 

Het principe van een lut verschilt eigenlijk weinig van een eenvoudige database. We zouden dus meerdere look-up-tables (tabellen) kunnen definiëren en deze gebruiken om meer *informatie* in onze spelwereld te plaatsen.

We kunnen bijvoorbeeld per kamer ook een beschrijving tonen van die kamer. Daar we nog niets kennen van ``struct`` en ``class`` (zogenaamde datastructuren) moeten we ons dus behelpen als volgt: we definiëren een nieuwe array ``Beschrijving`` waarbij ieder element de index heeft van de respectievelijke kamer:
```csharp

int[,] Kaart =
    {
        {1, 2, 1, 3, 0, 0},
        {0, 1, 0, 1, 0, 0},
        {0, 4, 0, 1, 0, 0},
        {0, 1, 0, 1, 0, 0},
        {0, 7, 0, 6, 1, 8},

    };

string[] Kamers =
    {
        "Onbekend terrein", //0 
        "In een gang", //1
        "In de lobby", //2
        "In de bar", //3
        "In de keuken", //4
        "Achtertuin",//5
        "In de securityroom", //6
        "In de personeelsruimte", //7
        "In de folterkamer" //8

    };

string[] Beschrijving =
                    {
        "", //0 
        "Een ordinaire saaie gang met een mooie vloer", //1
        "De receptioniste kijkt je verbaast aan. Een plant in de hoek is het enige groen in de purperen ruimte.", //2
        "2 gasten zitten half beschonken aan de toog. Een verliefd koppel is zachtjes aan het praten", //3
        "Overal liggen etensresten, maar verder is hier niets of niemand interessant.", //4
        "Mooie plantjes, enkele bomen en een gezellig terras.",//5
        "De veiligheidsagent houdt je nauwlettend in het oog", //6
        "Overal staan kastjes.Hier en daar is er een personeelslid zich aan het omkleden", //7
        "Wat doet deze vreemde plek in het hotel." //8
    };

```

Door 1 extra lijntje (+ eentje voor een visuele scheiding tussen beschrijving en kamertitel) plaatsen we nu steeds de kamerbeschrijving onder de kamertype:
```csharp
Console.WriteLine(Kamers[kamerindex]);
Console.WriteLine("******");
Console.WriteLine(Beschrijving[kamerindex]);
```
![](../assets/Aallinone/mazegame/4.png)
## Fase 7: Dynamische kaart 

Na iedere actie van de speler verwerken we steeds weer de kaart in zowel de ``DrawMap()``-methode als tijdens het verwerken van de speler-input. We kunnen dus eenvoudig een *dynamische* kaart maken die zich aanpast naargelang bepaalde acties.

Je met de kennis die we zo meteen tonen bijvoorbeeld aan de start van het programma met een lege kaart: naargelang de speler zich verplaatst in de wereld zal de kaart aangevuld worden. (tip: gebruik hiervoor een array ``VolledigeKaart`` en een array ``ReedsOntdekteKaart`` of iets dergelijks. De speler krijgt steeds de ``ReedsOntdekteKaart`` te zien in ``DrawMap()``. Naargelang acties van de speler kopieer je dan bepaalde elementen uit VolledigeKaart naar ReedsOntdekteKaart).

We definiëren onze kaart (merk op dat we de folterkamer en geheime gang verwijderen rechts onderaan):
```csharp
int[,] Kaart =
    {
        {1, 2, 1, 3, 0, 0},
        {0, 1, 0, 1, 0, 0},
        {0, 4, 0, 1, 0, 0},
        {0, 1, 0, 1, 0, 0},
        {0, 7, 0, 6, 0, 0},
    };
```

We willen volgende functionaliteit inbouwen: 
>indien de gebruiker in de kamer met index 6 ("SecurityRoom") een bepaalde actie onderneemt dan zal een *geheime gang en kamer* (folterkamer) op de kaart bij verschijnen, rechts van de securityroom.

De actie gaan we nu even eenvoudig beschouwen als volgt: de gebruiker kan in alle kamers "G" als opdracht doorgeven. Echter, enkel wanneer de gebruiker zich in de kamer met index 6 bevind dan zal de geheime kamer zichtbaar worden.
We voegen daarom een extra case toe aan onze switch:
```csharp
case 'G':
    if (kamerindex != 6)
    {
        Console.WriteLine("Dat zal hier niet werken");
    }
    else
    {
```
Als de speler wél in de securityroom is dan gaan we de kaart-array aanpassen. We voegen rechtsonder in de array de 2 nieuwe kamers toe:
```csharp
Console.WriteLine("Je ontdekt een geheime ruimte");
Kaart[4, 4] = 1;
Kaart[4, 5] = 8;
```

Wanneer we nu de kaart hertekenen dan deze nieuwe ruimte verschijnen en weet de gebruiker dat hij zich daar kan begeven.

De volledige code wordt dan (we laten de DrawMap()-methode even achterwege):
```csharp
static void Main()
{
    int[,] Kaart =
        {
            {1, 2, 1, 3, 0, 0},{0, 1, 0, 1, 0, 0},{0, 4, 0, 1, 0, 0},{0, 1, 0, 1, 0, 0},{0, 7, 0, 6, 0, 0},
        };

    string[] Kamers =
        {
            "Onbekend terrein", //0 
            "In een gang", //1
            "In de lobby", //2
            "In de bar", //3
            "In de keuken", //4
            "Achtertuin",//5
            "In de securityroom", //6
            "In de personeelsruimte", //7
            "In de folterkamer" //8
        };

    string[] Beschrijving =
                        {
            "", //0 
            "Een ordinaire saaie gang met een mooie vloer", //1
            "De receptioniste kijkt je verbaast aan. Een plant in de hoek is het enige groen in de purperen ruimte.", //2
            "2 gasten zitten half beschonken aan de toog. Een verliefd koppel is zachtjes aan het praten", //3
            "Overal liggen etensresten, maar verder is hier niets of niemand interessant.", //4
            "Mooie plantjes, enkele bomen en een gezellig terras.",//5
            "De veiligheidsagent houdt je nauwlettend in het oog. Typ \"G\" om een geheime ruimte te ontdekken", //6
            "Overal staan kastjes.Hier en daar is er een personeelslid zich aan het omkleden.", //7
            "Wat doet deze vreemde plek in het hotel." //8

        };

    int posX = 0;
    int posY = 0;
    char inp='k';
    while (inp != 'Q')
    {
        Console.Clear();
        DrawMap(Kaart, posX, posY);

        int kamerindex = Kaart[posX, posY];
        Console.WriteLine(Kamers[kamerindex]);
        Console.WriteLine("******");
        Console.WriteLine(Beschrijving[kamerindex]);
        Console.WriteLine();
        Console.WriteLine("NOZW? Naar waar wil je?");

        inp = Convert.ToChar(Console.ReadLine().ToUpper());
        switch (inp)
        {
            case 'N':
                if (posX != 0 && Kaart[posX - 1, posY] != 0)
                    posX--;
                else Console.WriteLine("Kan niet");
                break;
            case 'O':
                if (posY != Kaart.GetLength(1)-1 && Kaart[posX, posY + 1] != 0)
                    posY++;
                else Console.WriteLine("Kan niet");
                break;
            case 'Z':
                if (posX != Kaart.GetLength(0)-1 && Kaart[posX + 1, posY] != 0)
                    posX++;
                else Console.WriteLine("Kan niet");
                break;
            case 'W':
                if (posY != 0 && Kaart[posX, posY - 1] != 0)
                    posY--;
                else Console.WriteLine("Kan niet");
                break;
            case 'G':
                if (kamerindex != 6)
                {
                    Console.WriteLine("Dat zal hier niet werken");
                }
                else
                {
                    Console.WriteLine("Je ontdekt een geheime ruimte");
                    Kaart[4, 4] = 1;
                    Kaart[4, 5] = 8;
                    Console.ReadLine();
                }
                break;

        }
    }
}
```
![](../assets/Aallinone/mazegame/5.png)
![](../assets/Aallinone/mazegame/6.png)
## Fase 8: Go nuts

Vanaf dit punt kun je nu al een relatief eenvoudig, toch leuk spel maken, op voorwaarde dat je *verhaal* goed zit. Echter, voor we je hierop loslaten gaan we nog enkele zaken *refactoren* zodat de code wat leesbaarder blijft. In hoofzaak willen we bepaalde stukken code uit de main-body halen en naar aparte methodes extraheren.

### Stap 1: Kaart initialiseren in aparte methode 

Beeld je in dat je de kaart(en) voor je spel uit een bestand laadt. Op zich is dat niet zo moeilijk , maar het vereist natuurlijk extra lijnen code in je, reeds overbevolkte, Main-methode. We verhuizen daarom de code waarin we onze kaarten initialiseren naar een aparte methode. In onze Main schrijven we dan (merk het gebruik van het ``out`` keyword op!):
```csharp
int[,] Kaart;
string[] Kamers;
string[] Beschrijving;

InitialiseerSpel(out Kaart, out Kamers, out Beschrijving);
```

Deze methode bevat dan gewoon de code van daarnet, mooi verpakt en afgeschermd:
```csharp
private static void InitialiseerSpel(
    out int[,] Kaart, 
    out string[] Kamers, 
    out string[] Beschrijving)
{
    Kaart = new int[,]
        {
        {1, 2, 1, 3, 0, 0}, 
        {0, 1, 0, 1, 0, 0}, 
        {0, 4, 0, 1, 0, 0}, 
        {0, 1, 0, 1, 0, 0}, 
        {0, 7, 0, 6, 0, 0}
        };
    //Idem voor Kamers en beschrijving
    //..

```
### Stap 2: Input verwerken in aparte methode 

Het verwerken van de userinput kunnen we ook makkelijk extraheren naar aparte methode zodat onze while-loop overzichtelijker wordt :

```csharp
while (true)
{
    Console.Clear();
    DrawMap(Kaart, posX, posY);

    int kamerindex = Kaart[posX, posY];
    Console.WriteLine(Kamers[kamerindex]);

    Console.WriteLine("******");
    Console.WriteLine(Beschrijving[kamerindex]);
    Console.WriteLine();
    Console.WriteLine("NOZW? Naar waar wil je?");

    VerwerkInput(Kaart, kamerindex, ref posX, ref posY); //NEW
}
```
Merk op dat we zelfs de volledige loop naar een aparte methode op zijn beurt kunnen extraheren. Maar dat laten we aan de lezer over. We dienen de posities van de speler by reference mee te geven, daar we de posities onmiddellijk willen updaten in de ``VerwerkInput()``-methode.

```csharp
private static void VerwerkInput(
    int[,] Kaart, 
    int kamerindex, 
    ref int posX, 
    ref int posY)
{
    char inp = Convert.ToChar(Console.ReadLine().ToUpper());
    switch (inp)
    {
            //etc

```

### Stap 3: Een mooier kaartje tekenen 

Als kers op de taart tonen we snel hoe je het kaartje *sexier* kan tonen op het scherm. Hier zijn echter een paar belangrijke opmerkingen aan de orde:

*   De code bevat enkele *hardcoded* waarden zoals het plaatsen van de cursor m.b.v. ``Console.SetCursorPosition``. Beter zou zijn als deze waarden als Magic numbers worden behandeld of on-the-fly worden berekend.
*   De kaart bevat Unicode-art met vaste grootte. Dit zal bugs geven indien onze kaart-array groter is dan de dimensies van de Unicode-art: de art zal over de randen van de Unicode-art getekend worden. We kunnen dit oplossen door delen van de Unicode-art te *berekenen* (bv het aantal *lege lijnen* en de breedte van een pagina.

We definiëren de nieuwe Methode en voegen als eerste actie Unicode-art toe van een kaart:

```csharp
private static void DrawMapCool(int[,] Kaart, int posX, int posY)
{
    string background =
                        @".-/|~~~~~~~MAP~~~~~~~~~\/~~~~~~~~**~~~~~~~~|\-." + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||___________________ : ___________________||||" + "\n" +
                        @"||/====================\:/====================\||" + "\n" +
                        @"`---------------------~---~--------------------''";
```
Daar we gaan spelen met de kleuren is het aan te raden om steeds volgende acties te ondernemen indien we de kleur van een bepaald karakter of zinnen willen veranderen:
1.	De huidige kleur van de console  bewaren (fore en/of background) in een tijdelijke variabele
2.	Kleur veranderen 
3.	Karakter of zin op scherm plaatsen
4.	Kleur terug naar de huidige kleur aanpassen.
We tonen dit in de volgende code waarin we de background array (die de Unicode-art bevat) op het scherm willen tekenen. Daarbij willen we dat de karakters donker-cyaan zijn en dat enkel karakters die geen spatie of liggenstreepje zijn een donkergele achtergrond hebben. De commentaar toont de zonet beschreven stappen:

```csharp
ConsoleColor oll = Console.ForegroundColor; //1
Console.ForegroundColor = ConsoleColor.DarkCyan; //2
for (int i = 0; i < background.Length; i++)
{
    if (background[i] != ' ' && background[i] != '_')
        Console.Write(background[i]); //3
    else
    {
        ConsoleColor bll = Console.BackgroundColor;//1
        Console.BackgroundColor = ConsoleColor.DarkYellow;//2
        Console.Write(background[i]);//3
        Console.BackgroundColor = bll;//4
    }
}

Console.ForegroundColor = oll;//4

```
Vervolgens gebruiken we SetCursorPosition om onze spelerskaart ‘over’ de Unicode-art te tekenen. Hierbij voegen we nog wat extra kleurtje toe, de speler-X wordt rood gekleurd:
```csharp
ConsoleColor bll2 = Console.BackgroundColor;
Console.BackgroundColor = ConsoleColor.DarkYellow;

for (int i = 0; i <= Kaart.GetLength(0); i++)
{
    Console.SetCursorPosition(7, 3 + i);
    for (int j = 0; j <= Kaart.GetLength(1); j++)
    {
        if (posX == i & posY == j)
        {
            ConsoleColor l = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("X");
            Console.ForegroundColor = l;
        }

        else
            if (Kaart[i, j] != 0)
                Console.Write("o");
            else
                Console.Write(" ");
    }
    Console.Write('\n');

}
Console.SetCursorPosition(1, 15);
Console.BackgroundColor = bll2;
}

```
De while-loop in de Main()-methode passen we nu nog aan zodat:
1.	We de nieuwe DrawCoolMap methode gebruiken
2.	De titel van de kamer steeds op de rechterpagina van de kaart Unicode-art wordt getoond
3.	De beschrijving en andere tekst steeds onder map komt en niet erover


```csharp
while (true)
{
    Console.Clear();
    DrawMapCool(Kaart, posX, posY); //a

    int kamerindex = Kaart[posX, posY];
    Console.SetCursorPosition(26, 6); //b
    Console.WriteLine(Kamers[kamerindex]);

    Console.SetCursorPosition(1, 16);//c
    Console.WriteLine("******");
    Console.WriteLine(Beschrijving[kamerindex]);
    Console.WriteLine();
    Console.WriteLine("NOZW? Naar waar wil je?");

    VerwerkInput(Kaart, kamerindex, ref posX, ref posY);
}

```
## Alle code samen
We zijn er!
![](../assets/Aallinone/mazegame/7.png)
De volledige code voor dit extra-ordinaire spel wordt dan:
### Main-methode
```csharp
static void Main()
{
    int[,] Kaart;
    string[] Kamers;
    string[] Beschrijving;

    InitialiseerSpel(out Kaart, out Kamers, out Beschrijving);

    int posX = 0;
    int posY = 0;

    while (true)
    {
        Console.Clear();
        DrawMapCool(Kaart, posX, posY); //a

        int kamerindex = Kaart[posX, posY];
        Console.SetCursorPosition(26, 6); //b
        Console.WriteLine(Kamers[kamerindex]);

        Console.SetCursorPosition(1, 16);//c
        Console.WriteLine("******");
        Console.WriteLine(Beschrijving[kamerindex]);
        Console.WriteLine();
        Console.WriteLine("NOZW? Naar waar wil je?");

        VerwerkInput(Kaart, kamerindex, ref posX, ref posY);
    }
}
```
### InitialiseerSpel-methode
```csharp
private static void InitialiseerSpel(
    out int[,] Kaart, 
    out string[] Kamers, 
    out string[] Beschrijving)
{
    Kaart = new int[,]
        {
        {1, 2, 1, 3, 0, 0}, 
        {0, 1, 0, 1, 0, 0}, 
        {0, 4, 0, 1, 0, 0}, 
        {0, 1, 0, 1, 0, 0}, 
        {0, 7, 0, 6, 0, 0}
        };

    Kamers = new string[]
        {
            "Onbekend terrein", "In een gang", "In de lobby", "In de bar", "In de keuken", "Achtertuin",
            "In de securityroom", "In de personeelsruimte", "In de folterkamer"
        };

    Beschrijving = new string[]
        {
            "", "Een ordinaire saaie gang met een mooie vloer",
            "De receptioniste kijkt je verbaast aan. Een plant in de hoek is het enige groen in de purperen ruimte.",
            "2 gasten zitten half beschonken aan de toog. Een verliefd koppel is zachtjes aan het praten",
            "Overal liggen etensresten, maar verder is hier niets of niemand interessant.",
            "Mooie plantjes, enkele bomen en een gezellig terras.",
            "De veiligheidsagent houdt je nauwlettend in het oog. Typ \"G\" om een geheime ruimte te ontdekken",
            "Overal staan kastjes.Hier en daar is er een personeelslid zich aan het omkleden.",
            "Wat doet deze vreemde plek in het hotel."
        };
}
```

### VerwerkInput-methode
```csharp
private static void VerwerkInput(
    int[,] Kaart, 
    int kamerindex, 
    ref int posX, 
    ref int posY)
{
    char inp = Convert.ToChar(Console.ReadLine().ToUpper());
    switch (inp)
    {
            //etc
        case 'N':
            if (posX != 0 && Kaart[posX - 1, posY] != 0)
                posX--;
            else Console.WriteLine("Kan niet");
            break;
        case 'O':
            if (posY != Kaart.GetLength(1) && Kaart[posX, posY + 1] != 0)
                posY++;
            else Console.WriteLine("Kan niet");
            break;
        case 'Z':
            if (posX != Kaart.GetLength(0) && Kaart[posX + 1, posY] != 0)
                posX++;
            else Console.WriteLine("Kan niet");
            break;
        case 'W':
            if (posY != 0 && Kaart[posX, posY - 1] != 0)
                posY--;
            else Console.WriteLine("Kan niet");
            break;
        case 'G':
            if (kamerindex == 6)
            {
                Console.WriteLine("Je ontdekt een geheime ruimte");
                Kaart[4, 4] = 1;
                Kaart[4, 5] = 8;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dat zal hier niet werken");
            }
            break;
    }
}
```
### DrawMapCool-methode
```csharp
private static void DrawMapCool(int[,] Kaart, int posX, int posY)
{
    string background =
                        @".-/|~~~~~~~MAP~~~~~~~~~\/~~~~~~~~**~~~~~~~~|\-." + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||                    :                    ||||" + "\n" +
                        @"||||___________________ : ___________________||||" + "\n" +
                        @"||/====================\:/====================\||" + "\n" +
                        @"`---------------------~---~--------------------''";

    ConsoleColor oll = Console.ForegroundColor; //1
    Console.ForegroundColor = ConsoleColor.DarkCyan; //2
    for (int i = 0; i < background.Length; i++)
    {
        if (background[i] != ' ' && background[i] != '_')
            Console.Write(background[i]); //3
        else
        {
            ConsoleColor bll = Console.BackgroundColor;//1
            Console.BackgroundColor = ConsoleColor.DarkYellow;//2
            Console.Write(background[i]);//3
            Console.BackgroundColor = bll;//4

        }
    }

    Console.ForegroundColor = oll;//4

    ConsoleColor bll2 = Console.BackgroundColor;
    Console.BackgroundColor = ConsoleColor.DarkYellow;

    for (int i = 0; i < Kaart.GetLength(0); i++)
    {
        Console.SetCursorPosition(7, 3 + i);
        for (int j = 0; j < Kaart.GetLength(1); j++)
        {
            if (posX == i & posY == j)
            {
                ConsoleColor l = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("X");
                Console.ForegroundColor = l;

            }

            else
                if (Kaart[i, j] != 0)
                    Console.Write("o");
                else
                    Console.Write(" ");
        }
        Console.Write('\n');


    }
    Console.SetCursorPosition(1, 15);
    Console.BackgroundColor = bll2;
}
}

```
