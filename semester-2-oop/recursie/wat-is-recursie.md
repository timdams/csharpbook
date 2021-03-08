# Wat is recursie?

{% hint style="success" %}
[Kennisclip 1](https://youtu.be/nuCd4TZhLTE)
{% endhint %}

{% hint style="warning" %}
Op het einde van dit filmpje zeg ik dat je sommige voorbeelden niet zonder recursie kan afhandelen. Ik bedoel dit in de praktische zin, niet in de technische zin. Technisch kan je elke recursieve oplossing herschrijven zonder recursie, maar de niet-recursieve oplossing kan dan soms **veel** moeilijker te begrijpen zijn.
{% endhint %}

### Recursieve methodes

{% hint style="success" %}
[Kennisclip 2](https://youtu.be/rSBDs1KUTHo)
{% endhint %}

Een recursieve methode is een methode die zichzelf oproept. Dat klinkt eerst erg vreemd, maar het is een idee dat je zeker al vaker gezien hebt. Je kan bijvoorbeeld gehele machtsverheffing als volgt op een recursieve manier definiëren:

* de 0'de macht van om het even welk getal X is 1
* de N'de macht van een getal X, waarbij N groter is dan 0, is X maal de N-1ste macht van dat getal.

Bijvoorbeeld de 5e macht van 2:

* de 5e macht van 2 is 2 keer de 4e macht van 2
* de 4e macht van 2 is 2 keer de 3e macht van 2
* de 3e macht van 2 is 2 keer de 2e macht van 2
* de 2e macht van 2 is 2 keer de 1e macht van 2
* de 1e macht van 2 is 2 keer de 0e macht van 2
* de 0e macht van 2 \(of om het even welk getal\) is 1

Je kan een methode schrijven die deze denkwijze gebruikt om, zonder een lus, de oplossing te berekenen:

```csharp
public static int MachtRecursief(int x, uint n) {
    if (n == 0) {
        return 1;
    }
    else {
        return x * MachtRecursief(x,n-1);
    }
}
```

Het is heel leerrijk om deze methode uit te testen met de debugger.

Je kan ook op een recursieve manier datastructuren doorlopen. Bijvoorbeeld een `List<String>`. Als je elk element van deze lijst op je scherm wil tonen, kan dat met een lus, maar het kan ook als volgt:

```csharp
public static void ToonRecursief(List<string> gegevens) {
    if (gegevens.Count > 0) {
        Console.WriteLine(gegevens[0]);
        gegevens.RemoveAt(0);
        ToonRecursief(gegevens);
    }
}
```

{% hint style="info" %}
Schrijf zelf de calls uit die plaatsvinden voor een oproep met `new List<string>(){"hallo","wereld","hoe gaat het","met jou?"};`

Schrijf steeds de calls uit voor een paar kleine voorbeelden van recursieve functies totdat je vertrouwd bent met het concept!
{% endhint %}

#### Werkwijze

{% hint style="success" %}
[Kennisclip 3](https://youtu.be/-IKMA8eF8qA)
{% endhint %}

Een recursieve methode schrijf je altijd door één of meerdere **basisgevallen** te voorzien waarin het probleem "makkelijk" op niet-recursieve wijze wordt opgelost \(bv. de 0'e macht, het verwerken van een lege lijst,...\). Verder voorzie je een of meerdere **recursieve gevallen**. In deze gevallen wordt het probleem herleid tot een kleiner probleem plus een aantal extra bewerkingen die je kan uitvoeren nadat dit kleiner probleem is opgelost. Bij de machtsverheffing lossen we bijvoorbeeld eerst het probleem van de N-1ste macht op. Dit is een kleiner probleem dan de Nde macht. Daarna verwerken we de oplossing van dat kleinere probleem tot een oplossing voor het volledige probleem.

{% hint style="info" %}
In bovenstaande voorbeelden is recursie vooral een alternatief voor een lus. Vooral wanneer we ook met recursieve data werken, zullen we recursieve code kunnen schrijven die véél eenvoudiger is dan niet-recursieve code die hetzelfde doet.
{% endhint %}

## Recursieve data

{% hint style="success" %}
[Kennisclip 4](https://youtu.be/rSBDs1KUTHo)
{% endhint %}

Recursieve data is data die hetzelfde soort data bevat. In IT wordt voortdurend gebruik gemaakt van boomstructuren:

* het bestandensysteem op je harde schijf bevat mappen, die nog mappen kunnen bevatten, die nog mappen kunnen bevatten,...
* in XML-documenten of HTML-documenten
* het DNS-systeem om adressen van websites om te zetten in IP-adressen werkt met name servers die verwijzen naar name servers die verwijzen naar name servers...
* de syntax van een programmeertaal wordt bijna altijd als een van de eerste stappen van het compilatieproces omgezet naar een boomstructuur

Boomstructuren zijn recursieve data, want ze bevatten andere boomstructuren. Een XML-tag bevat bijvoorbeeld zelf XML-tags.

Wanneer data duidelijk recursief is, is het vaak nuttig om recursieve code te schrijven om te werken met deze data. Bijvoorbeeld: in JavaScript kan je binnenin een tag op zoek gaan naar geneste tags van een bepaald type. Zonder een inleiding tot JavaScript en het Document Object Model te geven, is het idee als volgt:

* als de tag zelf van het gewenste type is, voeg toe aan de lijst met resultaten en zoek ook naar tags van het gevraagde type in elk kind \(recursief geval\)
* als de tag zelf niet van het gewenste type is, zoek gewoon naar tags van het gevraagde type in elk kind \(ook een recursief geval\)
* als het element tekst is zonder tags, doe dan niets \(basisgeval\)

Dit zou al lastiger zijn met een lus. Het is te vroeg om complexe voorbeelden in code te geven, maar [deze post op quora.com](https://www.quora.com/What-are-the-best-examples-of-recursion-in-the-natural-world) bevat een aantal voorbeelden van recursie in het echte leven. Met gewone lussen zou het bijna onmogelijk zijn dergelijke complexe structuren na te tekenen, terwijl het heel doenbaar is met recursieve code. Ook in het labo zullen we kijken naar problemen die makkelijker recursief afgehandeld kunnen worden.

{% hint style="warning" %}
Recursie is niet beperkt tot objectgeoriënteerd programmeren. Er zijn zelfs stijlen van programmeren waarin nog veel meer gebruik gemaakt wordt van recursie. De programmeertaal Prolog heeft standaard zelfs geen lussen en gebruikt alleen recursie!
{% endhint %}

