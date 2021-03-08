# OOP Intro

{% hint style="success" %}
[Kennisclip](https://youtu.be/Wp8EQuQV9UU)
{% endhint %}

## OOP

Object Oriented Programming of korter OOP is een techniek afkomstig van higher level programmeertalen zoals Java, C\#, VB.NET, ... en vindt zijn oorsprong bij de programmeertaal Smalltalk, die het eerst de term Object Oriented Programming introduceerde.

In recentere jaren heeft deze techniek echter ook zijn weg gevonden naar scripting talen zoals Python, Ruby, Perl en zelfs PHP.

OOP streeft ernaar om een project zo structureel mogelijk op te bouwen in objecten. Dit heeft voor de programmeur het grote voordeel dat code vanaf nu in logische componenten wordt opgedeeld en veel makkelijker te hergebruiken is.

Om het concept van objecten te illustreren wordt vaak een voorwerp uit het dagelijks leven als voorbeeld gebruikt. Neem bijvoorbeeld een auto. De auto is het object en dit object heeft zowel geassocieerde data als functionaliteit. Deze data stellen eigenschappen of onderdelen van het object voor. Een eigenschap van de auto kan de kleur, de lengte, het aantal kilometers op de teller, of zelfs zijn huidige locatie of snelheid zijn. Deze zaken worden geïmplementeerd met ofwel instantievariabelen, ofwel _properties_. De functionaliteit is iets dat het object kan doen. Deze wordt geïmplementeerd met instantiemethodes. Als je een auto als object ziet, kunnen deze bijvoorbeeld starten, versnellen of remmen zijn.

Auto's zijn een veelgebruikt voorbeeld, maar eigenlijk schrijf je er zelden objecten voor tenzij je een soort simulator wil maken. Objecten hoeven niet altijd tastbare zaken te zijn. Je kan bijvoorbeeld ook een lening bij de bank voorstellen als een object. Dit object heeft dan onder andere volgende eigenschappen:

* een begunstigde, d.w.z. de persoon die de lening heeft aangegaan
* een restsaldo, d.w.z. het bedrag dat je moet betalen
* een looptijd, d.w.z. de periode waarbinnen de lening afbetaald moet zijn
* een intrestvoet, die uiteindelijk bepaalt hoe veel je bovenop het oorspronkelijke bedrag betaalt

Maar met een lening kunnen we ook bepaalde zaken doen die we wel in een computersysteem zouden implementeren. Deze zaken vormen de functionaliteit, dus de verzameling instantiemethodes, van het lening-object:

* een afbetaling verwerken
* de uiteindelijk af te betalen som berekenen
* het afbetaald kapitaal en de afbetaalde interest na een bepaald aantal maanden berekenen

Dus voor zaken die \(minstens\) zo uiteenlopend zijn als een auto en een lening hebben we een combinatie van data en functionaliteit. Zo zit een object in een programmeertaal er ook uit.

### Black-box principe

Een belangrijk concept bij OOP is het **black-box** principe waarbij we de afzonderlijke objecten en hun werking als "zwarte dozen" gaan beschouwen. Dat wil zeggen dat we \(meestal\) niet gaan kijken hoe ze in elkaar zitten. Neem het voorbeeld van de auto: deze is in de echte wereld ontwikkeld volgens het blackbox-principe. De werking van de auto kennen tot in het kleinste detail is niet nodig om met een auto te kunnen rijden. De auto biedt een aantal zaken aan de buitenwereld aan \(het stuur, pedalen, het dashboard\), wat we de **publieke interface** of gewoonweg **interface** noemen. Deze zaken kan je gebruiken om de interne staat van de auto uit te lezen of te manipuleren. Stel je voor dat je moest weten hoe een auto volledig werkte voor je ermee op de baan kon.

Binnen OOP wordt dit blackbox-concept **encapsulatie** genoemd. Het doel van OOP is andere programmeurs \(en jezelf\) zoveel mogelijk af te schermen van de interne werking van je code. Net als bij een auto, moet je alleen weten wat elk stukje van de interface klaarspeelt, maar hoef je niet te weten hoe dit allemaal is geprogrammeerd.

{% hint style="info" %}
Encapsulatie wordt vaak een van de vier pijlers van objectgeoriënteerd programmeren genoemd. De andere zijn abstractie, overerving en polymorfisme. Deze komen allemaal later in de cursus aan bod.
{% endhint %}

## Klassen en objecten

Een elementair aspect binnen OOP is het verschil beheersen tussen een **klasse** en een **object**.

Wanneer we meerdere objecten gebruiken van dezelfde soort dan kunnen we zeggen dat deze objecten allemaal deel uitmaken van een zelfde klasse. Zo hebben we bijvoorbeeld de klasse van de leningen. Er zijn leningen van €50.000, er zijn leningen van €10.000.000. Er zijn er met een intrestvoet van 0.2% en er zijn er met een intrestvoet van 2%. Er zijn er met een looptijd van 5 jaar en er zijn er met een looptijd van 20 jaar. Het zijn allemaal leningen, maar ze hebben allemaal andere eigenschappen.

{% hint style="info" %}
Als je vertrouwd bent met relationele databanken: een klasse is vergelijkbaar met een tabel of entiteittype, terwijl een object vergelijkbaar is met een record of een entiteit.
{% endhint %}

Objecten van dezelfde soort volgen wel dezelfde regels en hebben in dat opzicht dezelfde functionaliteit. Maar de eigenschappen van object bepalen ook het resultaat van de instantiemethodes. Eerder zagen we dat de uiteindelijk af te betalen som berekend kan worden door een lening. Deze som zal per definitie hoger zijn van een lening met een hoge rentevoet dan voor een lening met een lage rentevoet \(als de andere eigenschappen gelijk zijn\).

Samengevat:

* **Een klasse** is een beschrijving en verzameling van dingen \(objecten\) met soortgelijke eigenschappen en gedrag.
* Een individueel **object** is een **instantie** \(_exemplaar, voorbeeld, verschijningsvorm\)_ van een klasse

