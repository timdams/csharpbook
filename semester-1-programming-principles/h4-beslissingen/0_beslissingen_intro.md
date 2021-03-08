# Beslissingen intro

{% hint style="success" %}
[Inleiding](https://youtu.be/fflxk0QGu5I)
{% endhint %}

Nu we de elementaire zaken van C\# en Visual Studio kennen is het tijd om onze programma's wat interessanter te maken. De ontwikkelde programma's tot nog toe waren steevast lineair van opbouw, ze werden lijn per lijn uitgevoerd zonder de mogelijkheid om de _flow_ van het programma aan te passen. Het programma doorliep de lijnen braaf na elkaar en wanneer deze aan het einde kwam sloot het programma zich af.

Onze programma's waren met andere woorden niet meer dan een eenvoudige oplijstingen van opdrachten. Je kan het vergelijken met een lijst die je vertelt over hoe je een brood moet kopen:

1. Neem geld uit spaarpot
2. Wandel naar de bakker om de hoek
3. Vraag om een brood
4. Krijg het brood
5. Betaal het geld aan de bakker
6. Keer huiswaarts
7. Smullen maar

Alhoewel dit algoritme redelijk duidelijk en goed zal werken, zal de realiteit echter zelden zo rechtlijnig zijn. Een beter algoritme \(dat foutgevoeliger is én interactiever voor de eindgebruiker\) zal afhankelijk van de omstandigheden \(bakker gesloten, geen geld meer, etc.\) mogelijke andere stappen ondernemen. **Het programma zal beslissingen nemen op basis van aanwezige informatie**.

In het apdotcom project kunnen we beslissingen gebruiken voor tal van zaken:

* als we de voorraad van producten gaan bijhouden en we willen reageren wanneer de voorraad op is
* als we op bepaalde dagen van de week kortingen op bepaalde producten willen geven in plaats van de gebruiker deze zelf te laten kiezen
* als we spaarpunten willen introduceren en de gebruiker deze kan inwisselen

