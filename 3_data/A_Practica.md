# Oefeningen

**Gebruik je kennis van debuggen om vanaf dit hoofstuk problemen op te lossen. Gebruik niet `Console.WriteLine()` om de waarde van een variabele te controleren at-runtime, maar gebruik daarentegen breakpoints!**

## Oefening: H3-geometric-fun

### Leerdoelen

* gebruik van de `Math` namespace

### Functionele analyse

Je moet verschillende vaakgebruikte meetkundige berekeningen uitvoeren. Vraag aan de gebruiker een hoek in graden. Zet deze om naar radialen. Gebruik vervolgens de verschillende geometrische functies in de `Math` namespace om de sinus, cosinus en tangens van de hoek aan de gebruiker te tonen. Je moet eerst omzetten naar radialen omdat deze functies dat formaat verwachten. Toon alle resultaten tot twee cijfers na de komma.

### Technische analyse

Omzetting van graden naar radialen werkt als volgt, als `rad` een aantal radialen is en `deg` een aantal graden: rad=deg \* \(Π/180\). De verschillende wiskundige functies die je nodig hebt, vind je [hier](https://docs.microsoft.com/en-us/dotnet/api/system.math.sin?view=netcore-3.0) \(zie "Methods" in de linkerbalk\). Het getal Π vind je \(bij benadering\) onder `Math.PI`. Zie het hoofdstuk rond werken met tekst om twee cijfers na de komma te tonen.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Geef een hoek, uitgedrukt in graden.
> 45
45 graden is 0.79 radialen.
De sinus is 0.71.
De cosinus is 0.71.
De tangens is 1.00.
```

## H3-BMI-berekenaar

### Leerdoelen

* gebruik van de `Math` namespace
* je programma's delen met anderen
* kommagetallen parsen
* stringinterpolatie en formattering

### Functionele analyse

Maak een programma dat aan de gebruiker z'n lengte en gewicht vraagt en vervolgens z'n berekende BMI \(Body Mass Index\) toont.

### Technische analyse

De formule voor de BMI is BMI = kg / m², waarbij kg het de massa van een persoon voorstelt en m zijn lengte in meter \(dus typisch als kommagetal tussen 1 en 2\). Je vindt een functie om getallen af te ronden in de `Math` namespace. Je kan hieraan als eerste waarde aan getal meegeven dat je wil afronden en als tweede een aantal cijfers na de komma.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Hoe veel weeg je in kg?
> 69.0
Hoe groot ben je in m?
> 1.78
Je BMI bedraagt 21.78.
```

> Bekijk de volgende [kennisclip](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=6381a023-ae87-4662-91ed-a969006d3d9b) en geef je uitvoerbaar bestand van het programma aan een klasgenoot. Kijk of hij het kan uitvoeren.

## Oefening: H3-op-de-poef

### Leerdoelen

* tussenresultaten bijhouden
* werken met de `Math` namespace

### Functionele analyse

Een vaste klant in je café bestelt altijd "op de poef". Dat wil zeggen dat hij niet betaalt en dat z'n rekeningen worden neergeschreven. Ooit zal de klant dan gevraagd worden de hele som te betalen. Schrijf een programma dat 5 keer na elkaar aan de barman vraagt om een bedrag in te voeren. Het ingevoerde bedrag wordt opgeteld bij wat er reeds op de rekening staat. Na 5 keer wordt de totale som getoond alsook hoeveel weken het duurt indien de klant wekelijks 10 euro afbetaalt.

### Technische analyse

Gebruik een variabele om de totale som van de rekeningen bij te houden. De bedragen zullen "vrij klein" zijn, dus nooit meer dan €100. Het zijn ook gehele getallen. Je hoeft geen interest aan te rekenen.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Voer bedrag in?
> 12
De poef staat op 12 euro
Voer bedrag in?
> 14
De poef staat op 26 euro
Voer bedrag in?
> 3
De poef staat op 29 euro
Voer bedrag in?
> 8
De poef staat op 37 euro
Voer bedrag in?
> 2
De poef staat op 39 euro
*************************
Het totaal van  de poef is 39 euro.
Dit zal 4 afbetalingen vragen.
```

## Oefening: H3-feestkassa

### Leerdoelen

* tussenresultaten bijhouden

### Functionele analyse

De plaatselijke voetbalclub organiseert een mosselfestijn. Naast mosselen met frietjes \(20 EUR\) bieden ze voor de kinderen de mogelijkheid om een koninginnehapje \(10 EUR\) te kiezen. Verder is er een ijsje als nagerecht voorzien \(3 EUR\). Om het gemakkelijk te maken kosten alle dranken 2 EUR.

Ontwerp een applicatie zodat de vrijwilliger aan de kassa alleen maar de juiste aantallen moet ingeven ,lijn per lijn. \(frietjes, koninginenhapje, ijsje, drank\) om de totaal te betalen prijs te berekenen.

Het resultaat wordt als volgt weergegeven: `Het totaal te betalen bedrag is x EURO`.

### Technische analyse

Je gebruikt best een variabele om de voorlopig som bij te houden. Zo moet je minder code herhalen.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Mosselen met frietjes?
> 3
Koninginnenhapjes?
> 5
Ijsjes?
> 2
Dranken?
> 5
Het totaal te betalen bedrag is 126 EURO
```

## H3-orakeltje

### Leerdoelen

* werken met willekeurige getallen

### Functionele analyse

Maak een orakel/waarzegger, namelijk de kleine broer of zus van het [Orakel van Delphi](https://nl.wikipedia.org/wiki/Orakel_van_Delphi). Het programma zal aan de gebruiker vertellen hoe lang deze nog zal leven. Bijvoorbeeld: "Je zal nog 15 jaar leven.".

Het orakel zal enkel realistische getallen geven. Maw, getallen tussen de 5 en 125 jaar \(onder de 5 zou grof zijn\).

> We gaan geregeld een oefening in een later hoofdstuk verder uitbreiden. Het orakeltje van Delphi is er zo eentje.

### Technische analyse

Je moet hier een willekeurig getal bepalen en dat dan in een mooie vorm presenteren aan de gebruiker. Gebruik hiervoor de klasse `Random`.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Je zal nog 7 jaar leven.
```

```text
Je zal nog 64 jaar leven.
```

## Oefening: H3-random-invoer

Pas oefening H3-op-de-poef aan zodat de gebruiker vervangen wordt door een randomgenerator en de gebruiker op de hoogte brengt van de gegenereerde getallen \(tussen 1 en 50 inclusief\). Dit levert een output als volgt:

```text
Voer bedrag in?
Automatisch gegenereerd: 12
De poef staat op 12 euro
Voer bedrag in?
Automatisch gegenereerd: 14
De poef staat op 26 euro
Voer bedrag in?
Automatisch gegenereerd: 3
De poef staat op 29 euro
Voer bedrag in?
Automatisch gegenereerd: 8
De poef staat op 37 euro
Voer bedrag in?
Automatisch gegenereerd: 2
De poef staat op 39 euro
*************************
Het totaal van  de poef is 39 euro.
Dit zal 4 afbetalingen vragen.
```

