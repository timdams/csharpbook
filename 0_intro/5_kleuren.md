## Kleuren in console

Je kan in console-applicaties zelf bepalen in welke kleur nieuwe tekst op het scherm verschijnt. Je kan zowel de kleur van het lettertype instellen (via ``ForegroundColor``) als de achtergrondkleur (``BackgroundColor``).

Je kan met de volgende expressies de console-kleur veranderen, bijvoorbeeld de achtergrond in blauw en de letters in groen:

```java
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Green;
```

Vanaf dan zal alle tekst die je na deze 2 expressies via ``WriteLine`` naar het scherm stuurt met deze kleuren werken. Merk op dat we **bestaande tekst op het scherm niét van kleur kunnen veranderen zonder deze eerst te verwijderen en dan opnieuw, met andere kleurinstellingen, naar het scherm te sturen.**

{% hint style='tip' %}
Alle kleuren die beschikbaar zijn staan beschreven in ``ConsoleColor`` deze zijn: Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow.

Wens je dus de kleur Red dan zal je deze moeten aanroepen door er ``ConsoleColor.`` voor te zetten: ``ConsoleColor.Red``.

Waarom is dit? ``ConsoleColor is een zogenaamd ``enum``-type, een concept dat we verderop in dit boek zullen bespreken.
{% endhint %}

Een voorbeeld:

```java
Console.WriteLine("Tekst in de standaard kleur");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Groen met blauwe achtergrond");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Rood met blauwe achtergrond");
```

Als je deze code uitvoert krijg je als resultaat:

![Resultaat voorgaande code](../assets/0_intro/kleuren.PNG)

{% hint style='tip' %}
Kleur in console gebruiken is nuttig om je gebruikers een minder eentonig en meer informatieve applicatie aan te bieden. Je zou bijvoorbeeld alle foutmeldingen in het rood kunnen laten verschijnen. Let er wel op dat je applicatie geen aartslelijk, op psychedelische producten geschreven programma lijkt.
{% endhint %}

### Kleur resetten

Soms wil je terug de originele applicatie-kleuren hebben. Je zou manueel dit kunnen instellen, maar wat als de gebruiker slechtziend is en in z'n besturingssysteem andere kleuren als standaard heeft ingesteld?!

De veiligste manier is daarom de kleuren te resetten door de ``Console.ResetColor()`` methode aan te roepen zoals volgend voorbeeld toont:

```java
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Error!!!! Contacteer de helpdesk");
Console.ResetColor();
Console.WriteLine("Het programma sluit nu af");
```



<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)

* [Werken met kleuren in console](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a0446be7-b8f2-4ce7-ba76-abe30094107e)
<!---NOBOOKEND--->