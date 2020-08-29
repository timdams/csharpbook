# Client-server chat programma

We maken een klein , eenvoudige applicatie zodat meerdere clients berichten naar de server kunnen sturen.
We gaan hiervoor gebruik maken van een bestaande Nuget-Bibliotheek ``SimpleTcp``

Voer volgende stappen uit:

1. Maak een nieuwe solution aan en voeg 2 projecten toe, 1 voor de client, 1 voor de server.
2. Voeg aan ieder project de SimpleTc Nuget-bibliotheek toe als volgt:
   1. Rechterklik op je project (in solution explorer)
   2. Kies "Manage nuget packages..."
   3. Klik op "Browse" in het nieuw verschenen scherm
   4. Zoek naar ``SimpleTcp``
   5. Klik op de eerste hit (die van BrandonPotter) en kies rechts op "Install"
3. Als alles goed is verlopen zie je bij de references in beide projecten nu ook ``SimpleTcp`` staan.
4. Voeg in iedere Program.cs bovenaan ``using SimpleTCP;`` toe
5. Profit!

# Beide projecten starten

Om je programma de komende tijd te testen wil je uiteraard steeds dat er minstens 1 server en 1 client loopt. We gaan dit als volgt doen:

1. Rechterklik op je solution (in solution explorer) 
2. Kies "Properties"
3. Ga naar "Startup Project" onder de "Common properties"
4. Selecteer "Multiple starup project"
5. Verander de action van beide projecten naar "Start"
6. Zorg ervoor dat je server-project eerst start: indien nodig klik je op het pijltje omhoog zodat die bovenaan staat

Als je nu je programma start (F5) of debugt dan zullen steeds beide projecten uitgevoerd worden.

# Server-code

Telkens de server een string krijgt die eindigt op een enter zal de server deze boodschap op het scherm tonen. Om te voorkomen dat de server afsluit van zodra hij lijn 2 heeft uitgevoerd plaatsen we een ``ReadLine```achteraan. Op die manier zal de server blijven reageren op events tot de gebruiker op enter duwt om alles af te sluiten:

```java

static void Main(string[] args)
{
    var server = new SimpleTCP.SimpleTcpServer().Start(1111);
    server.DelimiterDataReceived += Server_DelimiterDataReceived;
    Console.ReadLine();
}

private static void Server_DelimiterDataReceived(object sender, SimpleTCP.Message e)
{
    Console.WriteLine( e.MessageString);
}
```

# Client-code

```java
static void Main(string[] args)
{
    var client = new SimpleTcpClient().Connect("127.0.0.1", 1111);
    while (true)
    {
        string msg = Console.ReadLine();
        client.WriteLine(msg);
    }
}
```

Je kan nu meerdere clients tegelijk starten. Zolang ze allemaal maar op dezelfde poort (1111 in dit geval) verbinden kunnen ze berichten naar de server sturen.

# En nu jij

SimpleTcp is een leuke bibliotheek, die veel meer kan. [Hier](https://github.com/BrandonPotter/SimpleTCP) zie je enkele ideeën. Het grootste probleem van deze bibliotheek is het gebrek aan deftige documentatie. Kan je zelf een eenvoudig chat programma maken waarbij meerdere clients alle berichten van mekaar zien die ze naar de server sturen (een soort [IRC](https://en.wikipedia.org/wiki/Internet_Relay_Chat)).
