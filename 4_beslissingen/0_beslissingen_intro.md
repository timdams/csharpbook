# Beslissingen
Nu we de elementaire zaken van C# en Visual Studio kennen is het tijd om onze programma's wat interessanter te maken. De ontwikkelde programma's tot nog toe waren steevast lineair van opbouw, ze werden lijn per lijn uitgevoerd, van start tot einde, zonder de mogelijkheid om de **program flow** van het programma aan te passen. Het programma doorliep de lijnen code braaf na elkaar en wanneer deze aan het einde kwam sloot het programma zich af.

Onze programma's waren met andere woorden niet meer dan een eenvoudige lijst van opdrachten. Je kan het vergelijken met een lijst die je vertelt over hoe je een brood moet kopen:

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


Alhoewel dit algoritme redelijk duidelijk is en goed zal werken, zal de realiteit echter zelden zo goed zijn. Van zodra 1 van de stappen echter faalt (bijvoorbeeld omdat de bakker toe is) zal ook de rest van het algoritme niet meer werken. 

Een beter algoritme, dat foutgevoeliger én interactief voor de eindgebruiker is, zal afhankelijk van de omstandigheden (bakker gesloten, geen geld meer, etc.) mogelijke andere stappen ondernemen. **Het programma zal beslissingen maken gebaseerd op keuzes** doorheen het programma:

<!---{line-numbers:false}--->
```text
Neem geld uit spaarpot
Als het geld op is stop dan hier, anders: ga verder
Wandel naar de bakker om de hoek
Als de bakker toe is stop dan hier, anders: ga verder
Vraag om een brood
Krijg het brood
Betaal het geld aan de bakker
Als je honger hebt, sla dan volgende lijn over, anders: ga verder
Keer huiswaarts
Smullen maar
```