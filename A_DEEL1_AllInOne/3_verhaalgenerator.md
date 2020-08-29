Een verhaalgenerator is een methode die hulp-methoden gebruikt om zo een "automatisch" verhaal te verzinnen (een beetje zoals [https://pdos.csail.mit.edu/archive/scigen/](dit)). We hanteren een bottom-up approach om dit probleem aan te pakken.

# Naamgenerator

We maken een methode die namen kan genereren. Deze naam gebruiken om het hoofdpersonage voor te stellen.

We maken een methode die steeds een naam generereert met een ingegeven lengte. Een naam bestaat in dit geval uit een reekds willekeurige karakters van a tot en met z.

Een eerste versie kan zijn:

```java
static Random r=new Random();
static string GenerateNameSimple(int namelength)
{
    string name = "";
    for (int i = 0; i < namelength; i++)
    {
        int randomgetal = r.Next(65, 91); 
        name += (char)randomgetal;
    }
    return name;
}
```

De eerste lijn is een klein trukje om ervoor te zorgen dat de variabele ``r`` overal in het programma aangeroepen kan worden en we dus niet in iedere methode deze opnieuw moeten aanmaken.

De bovenstaande methode roepen we aan als volgt:

```java
string result = GenerateNameSimple(10);
Console.WriteLine(result);
```

# Naamgenerator versie 2

Een nadeel van deze eerste versie is dat er soms onuitspreekbare namen gemaakt worden. Een betere methode zou zijn dat medeklinker en klinker afwisselend voorkomen (bv "adilo"). Hier gaan we eerst enkele hulpmethoden genereren:

## IsKlinker

Een methode om te weten of een meegeven karakter (``char``) een klinker (``a,e,u,i en o") is.

Dit doen we snel met een ``switch``:

```java
static bool IsKlinker(char teken)
{
    switch (teken)
    {
        case 'E':
        case 'I':
        case 'O':
        case 'A':
        case 'U':
            return true;
        default:
            return false;

    }

}
```

## GenereerKlinker
We kunnen nu een methode maken die enkel klinkers genereert:

```java
static char GenereerKlinker()
{

    int waarde = r.Next(0, 5);
    switch (waarde)
    {
        case 0: return 'E';
        case 1: return 'O';
        case 2: return 'I';
        case 3: return 'U';
        case 4: return 'A';
    }
    return ' ';
}
```

> We zouden in ``GenerateNameSimple`` een if kunnen plaatsen om te controleren of het gegenereerd karakter een klinker is. Dit heeft als nadeel dat we niet kunnen voorspellen hoe snel de methode zal werken: er is zelfs een eindige kans dat de methode nooit kalar zal zijn indien er telkens weer een medeklinker wordt geworpen.

## GenereerMedeklinker

Deze methode heeft dezelfde werking als ``GenereerKlinker`` maar zal een ``switch`` hebben met daarin enkel de medeklinkers.

Een minder goede oplossing (die ook oneindig lang kan duren als we echt pech hebben) zou zijn:

```java
static char GenereerMedeklinker()
{
    char result = 'E';
    while (IsKlinker(result))
    {
        int randomgetal = r.Next(65, 91);
        result = (char)randomgetal;
    }
    return result;
}
```

## Betere Naamgenerator

Onze nieuwe naamgenerator werkt nu als volgt:

```java
static string GenerateNameBetter(int namelength=6)
{

    string name = "";
    char vorigteken = (char)r.Next(65, 91);
    for (int i = 0; i < namelength; i++)
    {
        if (IsKlinker(vorigteken))
            vorigteken = GenereerMedeklinker();
        else vorigteken = GenereerKlinker();
        name += vorigteken;

    }
    return name;
}

```

# Zinnen genereren

Een zin bestaat minstens uit
* Een onderwerp
* Een werkwoord
* Een leiden voorwerp


Bijvoorbeeld: Tim gooit de bal.

We hebben reeds een methode om onderwerpen te genereren, ``GenerateNameBetter.

We hebben nu nog een methode voor werkwoorden en een voor leidende voorwerpen nodig.

## Werkwoord genereren

Deze is een methode die als een woordenboek een lijst van bestaande werkwoorden (infinitieven) heeft:

```java
static string GenereerWerkwoord()
{
    switch (r.Next(0, 10))
    {
        case 0: return "roept";
        case 1: return "gooit";
        case 2: return "aait";
        case 3: return "eet";
        case 4: return "pakt";
        case 5: return "kijkt naar";
        case 6: return "ledigt";
        case 7: return "vecht met";
        case 8: return "beklimt";
        case 9: return "begraaft";
        default:
            return "IETS ONBEKENDS";
    }
}
```

## Voorwerp genereren

Dit is een zelfde soort methode als de vorige

```java
static string GenereerVoorwerp()
{
    switch (r.Next(0, 10))
    {
        case 0: return "een bal";
        case 1: return "de hond";
        case 2: return "de kat";
        case 3: return "een lepel";
        case 4: return "het kind";
        case 5: return "het boek";
        case 6: return "de computer";
        case 7: return "een vork";
        case 8: return "het scherm";
        case 9: return "een dvd";
        default:
            return "IETS ONBEKENDS";
    }
```

## Zin generator

We combineren nu deze 3 methoden om tot een zinnen generator te komen:

```java
static string GenereerKorteZin()
{
    string onderwerp = GenerateNameBetter(6);
    string werkwoord = GenereerWerkwoord();
    string lv = GenereerVoorwerp();

    string zin = onderwerp + " " + werkwoord + " " + lv;

    return zin;
}
```

# Verhaal generator

Het hek is nu van de dam. Alle puzzelstukjes liggen klaar. 

## Complexere zin

Een zin heeft vaak ook een bijzin die met een voegwoord (bv ``en``) achter de hoofdzin wordt geplakt. Deze methode doet dit en kan even veel bijzinnen achter mekaar plakken als dat er als parameter wordt meegegeven.

```java
static  string GenereerLangeZin(int bijzinlengte)
{
    string hoofdzin = GenereerKorteZin();
    for (int i = 0; i < bijzinlengte; i++)
    {
        hoofdzin += GenereerVoegwoord() + " " + GenereerKorteZin();
    }
    return hoofdzin;
}
```

# Voegwerken genereren

Ook deze methode gebruikt onze gekende methodiek:

```java
static  string GenereerVoegwoord()
{
    switch (r.Next(0, 6))
    {
        case 0: return " en ";
        case 1: return ", maar ";
        case 2: return ", echter ";
        case 3: return ", dus ";
        case 4: return ", of ";
        case 5: return ", doch";

        default:
            return "IETS ONBEKENDS";
    }
        }
```

# Het totaal verhaal maken: dat doe je zelf

Maak nu een methode ``GenereerVerhaal`` die een willekeurig aantal lange zinnen genereert.

Kan je volgende zaken toevoegen?

* De ``GenereerLangeZin`` methode heeft als probleem dat alle bijzinnen steeds met een ander ondwerp werken. Het zou beter zijn als het onderwerp uit de hoofdzin ook in de bijzinnen dezelfde is. Pas daarom ``GenereerKorteZin`` aan zodat deze methode een optionele parameter aanvaardt, namelijk het te gebruiken onderwerp. Indien de method geen parameter meekrijgt (``==null``) dan zal de methode een nieuw onderwerp genereren.
* Het zelfde voor de verhaal generator: zorg ervoor dat ook de ``GenereerLangeZin`` een onderwerp als parameter aanvaardt.
* Kan je hier een daar adjectieven toevoegen aan je zin. Een adjactief is een extra 'beschrijving' van het onderwerp of leidende voorwerp. Bijvoorbeeld "groene bal" of "stomme Eric".