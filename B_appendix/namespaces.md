## Klassen herbruiken over projecten heen
### Namespaces
De namespace van een klasse is een eenvoudige manier om ervoor te zorgen dat verschillende ontwikkelaars hun klassen dezelfde naam kunnen geven, zonder dat er conflicten optreden wanneer deze samen in hetzelfde project worden gebruikt.


Wanneer je een bestaande klasse later in een nieuw project zou willen gebruiken dan kan dit op 3 manieren:

### Eerste manier

Je voegt het klasse bestand toe (via Add -> Existing Item.) en laat dit onaangepast.

Op de locatie waar je de klasse wenst te gebruiken voeg je bovenaan een using statement toe gevolgd door de namespace van het (bv using ConsoleApplication1) of
Telkens je de klasse wenst te gebruiken dien je dit via z’n namespace op te roepen (bv ConsoleApplication1.AccountClass eenAccount = new ConsoleApplication1.AccountClass)

### Tweede manier

Je voegt het klasse bestand toe (via Add -> Existing Item.) en verandert de namespace hiervan naar die van je project waarin je aan het werken bent.

### Derde manier

Je maakt een klassenbibliotheek (class library) aan (zie [hier](https://www.youtube.com/watch?v=6n-SL8cp8gM)).