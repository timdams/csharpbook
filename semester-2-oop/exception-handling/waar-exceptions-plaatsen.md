# Wanneer exceptions en handling gebruiken

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/wim_3RRnx7U)
{% endhint %}

In het begin kan het onduidelijk zijn wanneer je problemen best afhandelt met klassieke conditionele code \(met andere woorden, `if` en verwanten\) en wanneer met exceptions. Je vertrekt best van uit twee vragen:

1. Welke code kan het probleem tijdig vaststellen?
2. Welke code kan het probleem oplossen?

Als de code die het probleem kan vaststellen het probleem ook kan oplossen, heb je geen exception handling nodig. Volgende code bevat twee problemen die de code wel kan vaststellen en één probleem dat ze niet tijdig kan vaststellen:

```csharp
public static void WensGelukkigeVerjaardag() {
    bool gewenst = false;
    byte leeftijd;
    while(!gewenst) {
        try {
            leeftijd = Convert.ToByte(Console.ReadLine());
        }
        catch (FormatException e) {
            Console.WriteLine("Dat was geen (geheel) getal tussen 0 en 255.");
            continue;
        }
        if (leeftijd < 1) {
            Console.WriteLine("Een nulde verjaardag? Dat heet een geboorte.");
        }
        else if (leeftijd > 125) {
            Console.WriteLine("Sorry, dat geloof ik niet.");
        }
        else {
            Console.WriteLine($"Gelukkige {leeftijd}e verjaardag!");
            gewenst = true;
        }
    }
}
```

De nulde verjaardag en de verjaardagen vanaf 126 kan onze code tijdig zelf detecteren. Dat is gewoon een vergelijking met een getal. Een probleem met het formaat doet zich pas voor wanneer de conversie plaatsvindt. Dan is het al te laat. Dan kunnen we alleen het probleem nog oplossen.

{% hint style="info" %}
Kan je een fout goed oplossen met `if`? Doe dat dan. Maar gebruik een exception als de code die het probleem tijdig kan vaststellen niet dezelfde is die het probleem kan oplossen.
{% endhint %}



