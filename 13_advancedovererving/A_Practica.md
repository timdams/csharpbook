# Extra ToString aan bestaande projecten
Voeg ToString toe aan bestaande van volgende projecten. Ik raad aan dat je dit even test in een nieuwe applicatie waarin je de bestaande klasse even toevoegt en niet de hele main overneemt.

## Pokémon extra

Implementeer de ToString() methode in je ``Pokemon`` klasse zodat deze z'n full stats toont wanneer je schrijft:
```java
Console.WriteLine(myPokemon);
```

## Bookmark extra

Implementeer de ToString() methode in zowel de ``Bookmark`` als de ``HiddenBookmark`` klasse. Bij bookmark moet de output bestaan uit de titel van de site, gevolgd door de url tussen haakjes, bv:

```text
Google (www.google.com)
```

Bij ``HiddenBookmark`` wordt er achteraan nog "---HIDDEN---" gezet:

<!---{line-numbers:false}--->
```text
Google (www.google.com)  ---HIDDEN---
```

Zorg ervoor dat er géén dubbele code in HiddenBookmark staat (tip: ``base()``).

Test door volgende code in een eenvoudig programma uit te voeren:

```java
HiddenBookmark hbm=new HiddenBookmark();
//extra props invullen
Bookmark bm = new Bookmark();
//extra props invullen
Console.WriteLine(hbm);
Console.WriteLine(bm);
```

# Book
## Deel 1
Maak een klasse ``Book``  en gebruik auto-properties voor de velden:

* ISBN (int)
* Title (string)
* Author (string)
 
Maak voorts een full property voor Price (double)

Maak een child-klasse die van Book overerft genaamd ‘TextBook. Een textbook heeft één extra property:

* GradeLevel (int)

Maak een child-klasse die van Book overerft genaamd ‘CoffeeTableBook’. Deze klasse heeft geen extra velden.

Voorts kunnen boeken "opgeteld" worden om als omnibus uitgebracht te worden. De titel wordt dan "Omnibus van [X]". waarbij X de Authors bevat, gescheiden met een komma. De prijs van een Omnibus is steeds de som van beide boeken gedeeld door 2. **Schrijf een ``static`` methode ``TelOp`` die twee ``Book`` objecten als parameter aanvaardt en als returntype een nieuw ``Book`` teruggeeft.** 

In beide child-klassen, override de Price-setter zodat:
a)	Bij Textbook de prijs enkel tussen 20 en 80 kan liggen
b)	Bij CoffeeTableBooks de prijs enkel tussen 35 en 100 kan liggen

## Deel 2

* Zorg ervoor dat boeken de ToString overriden zodat je boekobjecten eenvoudig via Console.WriteLine(myBoek) hun info op het scherm tonen. Ze tonen deze info als volgt: "Title - Auteur (ISBN) _ Price"  (bv The Shining - Stephen King (05848152) _ 50)
* (PRO) Zorg ervoor dat de equals methode werkt op alle boeken. Boeken zijn gelijk indien ze hetzelfde ISBN nummer hebben.

**Toon de werking aan van je 3 klassen:**
Maak boeken aan van de 3 klassen, toon dat de prijs niet altijd zomaar ingesteld kan worden en (PRO) toon aan dat je Equals –methode werkt (ook wanneer je bijvoorbeeld een Book en TextBook wil vergelijken).

# Money, money, money
Maak enkele klassen die een bank kan gebruiken.

1. Abstracte klasse ``Rekening``: deze bevat een methode ``VoegGeldToe``  en ``HaalGeldAf``. Het saldo van de rekening wordt in een private variabele bijgehouden (en via de voorgaande methoden aangepast) die enkel via een read-only property kan uitgelezen worden. Voorts is er een abstracte methode ``BerekenRente`` de rente als double teruggeeft.
2. Een klasse ``BankRekening`` die een Rekening is. De rente van een BankRekening is 5% wanneer het saldo hoger is dan 100 euro, zoniet is deze 0%. 
3. Een klasse ``SpaarRekening`` die een Rekening is. De rente van een SpaarRekening bedraagt steeds 2%.
4. Een klasse ``ProRekening`` die een SpaarRekening is. De ProRekening hanteert de Rente-berekening van een SpaarRekening (``base.BerekenRente``) maar zal per 1000 euro saldo nog eens 10 euro verhogen. 

Schrijf deze klassen en toon de werking ervan in je main.

# Geometric figures

Maak een abstracte klasse ``GeometricFigure``. Iedere figuur heeft een hoogte, breedte en oppervlakte. Maak autoproperties voor van ``Hoogte`` en ``Breedte``. De ``Oppervlakte`` is een read-only property want deze wordt berekend gebaseerd op de hoogte en breedte. Deze berekening gebeurt in de methode ``BerekenOppervlakte``: deze roep je met andere woorden aan in de getter van ``Oppervlakte`` en dat resultaat geeft de getter terug 

{% hint style='warning' %}
Let er dus op dat ``Oppervlakte`` enkel een getter heeft. Een Setter schrijven zou vreemde bugs geven: wat als de gebruiker de Oppervlakte van de figuur zo aanpast, maar wel andere hoogte en breedte heeft ingesteld? Je zou dan een foute oppervlakte krijgen daar die niet berekend wordt.
{% endhint %}

Voorzie een abstracte methode ``BerekenOppervlakte`` die een int teruggeeft.

Maak 3 klassen:

* Rechthoek: erft over van GeometricFigure. Oppervlakte is gedefinieerd als ``breedte * hoogte``.
* Vierkant: erft over van Rechthoek. Voorzie een constructor die lengte en breedte als parameter aanvaard: deze moeten gelijk zijn, indien niet zet je deze tijdens de constructie gelijk. Voorzie een 2e constructor die één parameter aanvaardt dat dan geldt als zowel de lengte als breedte. Deze klasse gebruikt de methode BerekenOppervlakte van de Rechthoek-klasse.
* Driehoek: erft over van GeometricFigure. Oppervlakte is gedefinieerd als ``breedte*hoogte/2``.

Maak een applicatie waarin je de werking van deze klassen aantoont


# Dierentuin
Maak een console-applicatie waarin je een zelfverzonnen abstract klasse Dier in een List<Dier> kunt plaatsen. Ieder dier heeft een gewicht en een methode ``Zegt`` (die abstract is) die het geluid van het dier in kwestie op het scherm zal tonen. Maak enkele childklassen die overerven van Dier en uiteraard de ``Zegt`` methode overriden.

Plaats enkele dieren in de nieuw aangemaakt lijst.
Vervolgens verschijnt er een menu Wanneer de gebruiker 'q' kiest stopt het programma.Het keuze menu heeft volgende opties:

1. Dier verwijderen , gevolgd door de gebruiker die invoert het hoeveelste dier weg moet uit de List.
2. Diergewicht gemiddelde: het gemiddelde van alle dieren hun gewicht wordt getoond
3. Dier praten: alle dieren hun Zegt() methode wordt aangeroepen en via WriteLine getoond
4. Opnieuw beginnen: de List wordt leeggemaakt en het programma zal terug van voor af aan beginnen. Waarbij de lijst terug gevuld wordt met enkele start dieren.

Probeer zo modulair mogelijk te werken.