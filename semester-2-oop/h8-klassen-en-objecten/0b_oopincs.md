# Klassen en objecten aanmaken

In C\# kunnen we geen objecten aanmaken voor we een klasse hebben gedefinieerd die de algemene eigenschappen \(properties\) en werking \(methoden\) beschrijft.

## Klasse maken

Een heel elementaire klasse heeft de volgende vorm:

```csharp
class ClassName
{
    // hier komen de data en functionaliteit
}
```

We maken hier normaal gebruik van Pascal case. Je kan ook nog enkele toevoegingen doen die niet zuiver data en functionaliteit zijn, maar die houden we voor verder in de cursus.

Volgende code beschrijft de klasse `Auto` in C\#

```csharp
class Auto
{
    // data kan bv. nummerplaat, bouwjaar of kilometerstand zijn
    // gedrag kan bv. bepalen van de verkoopwaarde zijn
}
```

Binnen het codeblock dat bij deze klasse hoort zullen we verderop dan de werking beschrijven.

### Klassen in Visual Studio

Je kan "eender waar" een klasse aanmaken, maar het is een goede gewoonte om per klasse een apart bestand te gebruiken. **Dit is ook de afspraak die wij zullen volgen**.

* In de solution explorer, rechterklik op je project
* Kies _Add_
* Kies _Class..._
* Geef een goede naam voor je klasse

{% hint style="warning" %}
**De naam van je klasse moet voldoen aan de identifier regels die ook gelden voor het aanmaken van variabelen!**
{% endhint %}

![Klasse toevoegen in VS](../../.gitbook/assets/klassadd%20%282%29.png)

## Objecten aanmaken

Je kan nu objecten aanmaken van de klasse die je hebt gedefinieerd. De klasse is een type en je kan dus ook variabelen aanmaken die bedoeld zijn om objecten van deze klasse in bij te houden. Je doet dit door eerst een variabele te definiëren met als type de naam van de klasse en vervolgens een object te **instantiëren** met behulp van het `new` keyword:

```csharp
Auto mijnEerste = new Auto();
Auto mijnAndereAuto = new Auto();
```

We hebben nu **twee objecten aangemaakt van het type Auto**.

Let goed op dat je dus op de juiste plekken dit alles doet \(bekijk de onderstaande screenshot\):

* Klassen maak je aan als aparte files in je project
* Objecten creëer je in je code op de plekken dat je deze nodig hebt, bijvoorbeeld in je `Main` methode bij een Console-applicatie

![basics oop same in vv](../../.gitbook/assets/allessamen%20%282%29.png)

{% hint style="info" %}
Je hebt dus in het verleden ook al objecten aangemaakt met `new`. Telkens je met Random werkt deed je dit al. Dit wil zeggen dat er dus in .NET ergens reeds een voorgeprogrammeerde klasse `Random` bestaat met de interne werking.
{% endhint %}

