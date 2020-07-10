## Nuttige array methoden

Net zoals we hebben gezien dat de Math-klasse een heleboel nuttige methoden in zich heeft, zo heeft ook iedere array een aantal methoden waar handig gebruik van gemaakt kan worden.

{% hint style='tip' %}
Om deze methoden te kunnen gebruiken moet je bovenaan je file de volgende lijn toevoegen: ``using System.Linq;``:
{% endhint %}

```csharp
Console.WriteLine(getallen.Sum());
```


Wanneer je een array hebt gemaakt kan je met de IntelliSense van Visual Studio bekijken wat je allemaal kan doen met de array:

![](../assets/5_arrays/arrays2.png)


Al deze methoden hier beschrijven zal ons te ver nemen. De volgende methoden zijn echter zeer handig om te gebruiken:

``Max()``, ``Min()``, ``Sum()`` en ``Average()``.

Volgende code geeft bijvoorbeeld het grootste getal terug uit een array genaamd "leeftijden":
```csharp
int oudsteleeftijd = leeftijden.Max();
```