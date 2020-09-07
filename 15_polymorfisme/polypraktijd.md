## Polymorfisme in de praktijk: Presidenten

{% hint style='tip' %}
![Gezocht: wie weet waar deze still vandaan komt? We hebben geen flauw benul. We zien Robert Redford en Bush Senior, uit een film ofzo?](../assets/9_interfaces/president.jpg)
{% endhint %}

Beeld je in dat je een klasse President hebt met een methode "RunTheCountry" (voorbeeld van [StackOverflow](https://stackoverflow.com/questions/1031273/what-is-polymorphism-what-is-it-for-and-how-is-it-used) ). De President heeft toegang tot tal van adviseurs die hem kunnen helpen (inzake miltair, binnenlands beleid, economie). Zonder de voordelen van polymorfisme zou de klasse President er zo kunnen uitzien, **slechte manier**:

```java
public class President
{
    MilitaryMinister Petraeus= new MilitaryMinister();
    ForeignSecretary Condi = new ForeignSecretary();
    HealthOfficial MrX = new HealthOfficial();

    public void RunTheCountry()
    {
        // people walk into the Presidents office and he tells them what to do
        // depending on who they are.

        // Fallujah Advice - Mr Prez tells his military exactly what to do.
        Petraeus.IncreaseTroopNumbers();
        Petraeus.ImproveSecurity();
        Petraeus.PayContractors();

        // Condi diplomacy advice - Prez tells Condi how to negotiate

        Condi.StallNegotiations();
        Condi.LowBallFigure();
        Condi.FireDemocraticallyElectedIraqiLeaderBecauseIDontLikeHim();

        // Health care mr X

        MrX.IncreasePremiums();
        MrX.AddPreexistingConditions();
    }
}
```

De MilitaryMinister zou er zo kunnen uitzien:
```java
class MilitaryMinister
{
  public void IncreaseTroopNumbers()
  {
    //..
  }
  public void ImproveSecurity()
  {
    //..
  }
  etc
}
```

De HealthOfficial-klasse heeft dan weer heel andere publieke methoden. En die Foreignminister ook weer totaal andere.

Je merkt dat de President (of de programmeur van deze klasse) aardig wat specifieke kennis moet hebben van de vele verschillende departementen van het land. Uiteraard is dat onmogelijk (een fictief voorbeeld: stel je Trump voor...Denk je echt dat die zo veel weet?) . Bovenstaande code is dus zeer slecht. Telkens er zaken binnen een specifiek landsonderdeel wijzigen moet dit ook in de klasse President aangepast worden. 

Dankzij polymorfisme kunnen we dit alles veel mooier oplossen:

1. We verplichten alle adviseurs dat ze overerven van de abstracte klasse ``Advisor`` die maar 1 abstracte methode heeft ``Advise``:

```java
abstract class Advisor
{
  abstract public void Advise();
}

class MilitaryMinister:Advisor
{
  public override void Advise()
  {
       increaseTroopNumbers();
       improveSecurity();
       payContractors();
  }
  private void increaseTroopNumbers(){ ... }
  private void improveSecurity(){ ... }
  private void payContractors(){ ... }
  }
}

class ForeignSecretary:Advisor
{
  //...
}
class HealthOfficial:Advisor
{
  //...
}
```

2° Het leven van de President wordt plots véél makkelijker:

```java
public class MisterPresident
{
    public void RunTheCountry()
    {
        Advisor Petraeus = new MilitaryAdvisor();
        Advisor Condi = new ForeignSecretary();
        Advisor mrX= new HealthOfficial();
        Petraeus.Advise(); // # Petraeus says send 100,000 troops to Fallujah
        Condi.Advise(); // # she says negotiate trade deal with Iran
        mrX.Advise(); // # they say we need to spend $50 billion on ObamaCare
    }
}
```

3° En we kunnen hem nog helpen door met een array of ``List<Advisor>`` te werken zodat hij ook niet steeds de "namen" van z'n adviseurs moet kennen:

```java
public class MisterPresident
{
    public void RunTheCountry()
    {   
        List<Advisor> allMinisters= new List<Advisor>();
        allMinisters.Add(new MilitaryAdvisor());
        allMinisters.Add(new ForeignSecretary());
        allMinisters.Add(new HealthOfficial());

        //Ask advise from each:
        foreach (Advisor minister in allMinisters)
        {
            minister.Advise();
        }
    }
}
```

En wie zei dat het presidentsschap moeilijk was?!

{% hint style='tip' %}
## Nog voorbeelden van polymorfisme nodig?

Volgende tekst heeft een leuke insteek om polymorfisme uit te leggen... aan de hand van...wait for it... Zeemeerminnen! :) [Lezen maar!](http://www.techoschool.com/Technology/Dotnet/Csharp-for-Beginners_Csharp-Polymorphism)

Volgende voorbeeld is iets praktischer: [Arena with a mage in C# .NET (inheritance and polymorphism)](https://www.ict.social/csharp/oop/arena-with-mage-in-csharp-net-inheritance-and-polymorphism)
{% endhint %}

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Polymorfisme in de praktijk](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=06305096-bee1-466a-9b70-aba700860b64)
<!---NOBOOKEND--->