### Werken met data

{% hint style='warning' %}
**Gebruik je kennis van debuggen om vanaf dit hoofstuk problemen op te lossen. Gebruik niet ``Console.WriteLine()`` om de waarde van een variabele te controleren at-runtime, maar gebruik daarentegen breakpoints!**
{% endhint %}

#### Supercomputer

{% hint style='tip' %}
Vanaf dit punt zullen  de meeste oefeningen iets "vragen" aan de gebruiker. Hiermee wordt bedoeld dat je de gebruikerinput via ``ReadLine`` moet inlezen en indien nodig moet converteren naar het gewenste type.
{% endhint %}

Vraag aan de gebruiker 3 kommagetallen. Bereken het gemiddelde van deze 3 getallen.

#### Vierkant
Schrijf een programma om de omtrek en de oppervlakte van een vierkant te bepalen. De zijde wordt ingelezen. Zorg ervoor dat de uitvoer er als volgt uitziet:

<!---{line-numbers:false}--->
```text
zijde: … 
omtrek: … 
oppervlakte: …
```

#### Balk

Bereken de oppervlakte en de inhoud van een balk . De gegevens (hoogte, breedte, lengte) worden ingelezen. Zorg ervoor dat de uitvoer er als volgt uitziet:

<!---{line-numbers:false}--->
```text
lengte: … 
breedte: … 
hoogte: … 
oppervlakte: … 
inhoud: … 
```

#### Geometric-fun
Vraag aan de gebruiker een hoek in graden. Zet deze om naar radialen , gebruik ``Math.PI`` voor Pi (``π``). Gebruik vervolgens de verschillende geometrische functies in de ``Math.`` bibliotheek om de sinus (``.Sin``), cosinus (``.Cos``) en tangens (``.Tan``) van de hoek aan de gebruiker te tonen 

{% hint style='tip' %}
Denk eraan: de methoden die met hoeken werken, werken in radialen, daarom moeten we deze eerst omzetten.
1 rad = hoekingraden * (π/180°)
{% endhint %}

#### BMI berekenaar
Maak een programma dat aan de gebruiker z'n lengte en gewicht vraagt en vervolgens de berekende BMI (Body Mass Index) toont.
Gebruik ``Math.Round`` om de uitkomst tot maximum 2 cijfers na de komma te tonen.

Reken na met je rekenmachine of je uitkomst wel degelijk klopt!

#### Op-de-poef
Een vaste klant in je café besteld altijd "op-de-poef". Dat wil zeggen dat hij niet onmiddellijk betaald en dat z'n rekeningen worden neergeschreven. Ooit zal de klant dan gevraagd worden de hele som te betalen.

Schrijf een programma dat 5 keer na elkaar aan de barman vraagt om een bedrag in te voeren. Het ingevoerde bedrag wordt opgeteld bij wat er reeds op de rekening staat. Na 5 keer wordt de totale som getoond alsook hoeveel weken het duurt indien de klant wekelijks 10 euro afbetaald.

Voorbeeldwerking:

<!---{line-numbers:false}--->
```text
Voer bedrag in?
12
De poef staat op 12 euro.
Voer bedrag in?
14
De poef staat op 26 euro.
Voer bedrag in?
3
De poef staat op 29 euro.
Voer bedrag in?
8
De poef staat op 37 euro.
Voer bedrag in?
2
De poef staat op 39 euro.
*************************
Het totaal van  de poef is 39 en zal 4 weken duren om volledig afbetaald te worden.
```


#### Feestkassa
De plaatselijke voetbalclub organiseert een mosselfestijn. Naast mosselen met frietjes (20 EUR) bieden ze voor de kinderen de mogelijkheid om een koninginnenhapje (10 EUR) te kiezen. Verder is er een ijsje als nagerecht voorzien (3 EUR). Om het gemakkelijk te maken kosten alle dranken 2 EUR.


Ontwerp een applicatie zodat de vrijwilliger aan de kassa alleen maar de juiste aantallen moet ingeven, lijn per lijn. (frietjes, koninginnenhapje, ijsje, drank) om de totaal te betalen prijs te berekenen. 

Het resultaat wordt als volgt weergegeven: ``Het totaal te betalen bedrag is x EURO``.

Voorbeeld:
```
Frietjes?
3   
Tussenprijs= 60 euro
koninginnenhapje?
5
Tussenprijs= 60 euro + 50 euro
Ijsjes?
2
Tussenprijs= 60 euro + 50 euro + 6 euro
Dranken?
5
Tussenprijs= 60 euro + 50 euro + 6 euro + 10 euro

Het totaal te betalen bedrag is 126 EURO.
```

#### Het Orakeltje van Delphi
Gebruik een random generator om een orakel (een duur woord voor waarzegger) te maken, namelijk de kleine broer of zus van het [Orakel van Delphi](https://nl.wikipedia.org/wiki/Orakel_van_Delphi). Het programma zal aan de gebruiker vertellen hoe lang deze nog zal leven. Bijvoorbeeld: "Je zal nog 15 jaar leven.".
 
Het orakel zal enkel realistische getallen geven. M.a.w., getallen tussen de 5 en 125 jaar.

<!---NOBOOKSTART--->
{% hint style='tip' %}
We gaan geregeld een oefening in een later hoofdstuk verder uitbreiden. Het orakeltje van Delphi is er zo eentje. **Bewaar je oefeningen dus goed!**
{% endhint %}
<!---NOBOOKEND--->

<!---{pagebreak}--->