# Maak een "voortplantings-simulator".

# Klasse mens

## Properties
Maak een klasse ``Mens`` met volgende eigenschappen:
* geslacht (enum) : voorlopig enkel Man en Vrouw
* kleur_ogen (enum): blauw, bruin, groen, rood
* maxlengte (in cm): een getal dat niet onder 30 kan gaan. Dit getal geeft aan hoe groot de persoon ooit zal kunnen worden.

## Constructors
Voorzie volgende constructors:
* Een default constructor die bovenstaande eigenschappen op willekeurige waarden instelt. Bij maxlengte is deze waarde 90% van de tijd tussen 150 en 210. 5% van de tijd is deze een getal tussen 40 en 150. 5% van de tijd een getal tussen 210 en 240.
* Een overloaded constructor waarbij de 3 eigenschappen als parameter kunnen doorgegeven worden.

## Methoden
### Toonmens
Voorzie een methode ``ToonMens``. Deze vat de informatie van een Mens-object in één lang samen, hierbij zal de achtergrond van de tekst de kleur van de ogen zijn.
De tekst die verschijnt is: ``maxlengte [in meter], geslacht``

Bijvoorbeeld:

```
1.78 m, man  
```

### Plantvoort
Enkel vrouwen kunnen nieuwe mensen maken. 

* Iedere mens heeft een methode '`Plantvoort`' die als parameter een andere mens vereist.
* Enkel bij vrouwen zal deze methode iets doen. Indien deze op mannen wordt aangeroepen geeft de methode ``null`` terug.
* De methode geeft een nieuw mens object terug. De nieuwe mens heeft als lengte de gemiddelde lengte van de man en vrouw. De oogkleur is 50% van de tijd die van de man en 50%van de tijd die van de vrouw. Het geslacht is willekeurig.

# Eerste voortplantingen testen

Maak 12 willekeurige mensen en plaats deze in een List. De eerste 6 mensen zijn vrouwen, de laatste 6 mensen zijn mannen. Alle mensen hebben willekeurige eigenschappen, enkel het geslacht is dus al bepaald.

Laat nu de mensen voortplanten.
* De eerste helft mensen in de List zoeken een willekeurige partner van het andere geslacht in de andere helft lijst. En maakt hier een nieuwe mens mee. De man wordt meegegeven als parameter aan de Plantvoort methode van de vrouw.
* Plaats deze nieuwe mens in de lijst achteraan.

# Generatie bijhouden
Voeg een propertie ``Generatie`` toe aan je MEns die toelaat om te onthouden wanneer Mens is aangemaakt. Je kan deze via de constructor instellen.

# Simulatie
Herhaal bovenstaande voor 10 generaties (merk op dat ouders dus vermoedelijk kinderen zullen maken met hun eigen kinderen/kleinkinderen. Niet over nadenken) en bekijk wat de resultaten zijn. Plaats deze simulatie in een static methode ``Simuleer`` die een List van mensen als parameter aanvaardt, alsook een getal dat aangeeft hoeveel generaties moet getest worden. Houdt bij iedere Mens die je aanmaakt om welke generatie het gaat.

Toon aan de gebruiker hoeveel de gemiddelde lengte is, hoeveel percent welke kleur ogen heeft, etc.

Maak een applicatie waarbij de gebruiker experimenten kan doen om te zien wat er gebeurt na x generaties.
Bijvoorbeeld:
* Wat als mannen erg klein zijn, vrouwen erg lang
* Wat als mensen met blauwe ogen steeds die kleur aan hun kinderen doorgeven, na hoeveel generaties heeft iedereen blauwe ogen

# Mutaties

Introduceer mutaties tijdens de voortplanting. Iedere keer als er een nieuwe mens wordt aangemaakt tijdens Plantvoort bestaat er 10% kans dat een van de "regels" overtreden wordt (bv i.p.v. gemiddelde lengte wordt lengte van de mama genomen, of i.p.v. kleur van een van ouder krijgt kind bij mutatie altijd groene ogen, etc). Verzin zelf enkele mutatie regels.

Test je mutaties en verzin extra regels en pas toe in de Simulatiemethode.

Voeg een ``bool`` parameter toe aan de simulatiemethode om aan te geven of mutaties zijn toegestaan of niet, aslsook een int parameter om de kans van mutatie mee te geven (bijvoorbeeld 10 = 10%)

# Extra properties

Voeg extra eigenschappen aan je ``Mens`` toe die je ook betrekt als genetische eigenschappen tijdens het voortplanten (denk aan haarkleur, allergieën of aantal armen).

{% hint style='tip' %}

**Ter info**

Volgende code toont hoe je je lijst kunt sorteren op Geslacht, veronderstellende dat de lijst ``mensen`` heet:

```java
 //using System.Linq  (toevoegen bovenaan)
 mensen = mensen.OrderBy(p => (int)p.Geslacht).ToList();
```
{% endhint %}