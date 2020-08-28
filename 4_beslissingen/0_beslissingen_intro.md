# Beslissingen
Nu we de elementaire zaken van C# en Visual Studio kennen is het tijd om onze programma's wat interessanter te maken. De ontwikkelde programma's tot nog toe waren steevast lineair van opbouw, ze werden lijn per lijn uitgevoerd zonder de mogelijkheid om de *flow* van het programma aan te passen. Het programma doorliep de lijnen braaf na elkaar en wanneer deze aan het einde kwam sloot het programma zich af.

Onze programma's waren met andere woorden niet meer dan een eenvoudige oplijsting van opdrachten. Je kan het vergelijken met een lijst die je vertelt over hoe je een brood moet kopen:

<!---{line-numbers:false}--->
```text
Neem geld uit spaarpot
Wandel naar de bakker om de hoek
Vraag om een brood
Krijg het brood
Betaal het geld aan de bakker
Keer huiswaarts
Smullen maar
```


Alhoewel dit algoritme redelijk duidelijk en goed zal werken, zal de realiteit echter zelden zo goed zijn. Een beter algoritme (dat foutgevoeliger én interactief voor de eindgebruiker) zal afhankelijk van de omstandigheden (bakker gesloten, geen geld meer, etc.) mogelijke andere stappen ondernemen. **Het programma zal beslissingen maken** gebaseerd op keuzes doorheen het programma.