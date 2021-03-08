# Polymorfisme in de praktijk

{% hint style="success" %}
[Kennisclip](https://www.youtube.com/watch?v=CeApHLGuYUg)
{% endhint %}

Beeld je in dat je een klasse `President` hebt met een methode `RunTheCountry` \(voorbeeld van [StackOverflow](https://stackoverflow.com/questions/1031273/what-is-polymorphism-what-is-it-for-and-how-is-it-used) \). De president heeft toegang tot tal van adviseurs die hem kunnen helpen \(inzake miltair, binnenlands beleid, economie\). Zonder de voordelen van polymorfisme zou de klasse `President` er zo kunnen uitzien, **slechte manier**:

```csharp
public class President
{
    MilitaryMinister general = new MilitaryMinister();
    ForeignSecretary secretary = new ForeignSecretary();
    HealthOfficial doctor = new HealthOfficial();

    public void RunTheCountry()
    {
        // people walk into the Presidents office and he tells them what to do
        // depending on who they are.
        general.IncreaseTroopNumbers();
        general.ImproveSecurity();
        general.PayContractors();

        secretary.StallNegotiations();
        secretary.LowBallFigure();
        secretary.FireDemocraticallyElectedIraqiLeaderBecauseIDontLikeHim();

        doctor.IncreasePremiums();
        doctor.AddPreexistingConditions();
    }
}
```

De `MilitaryMinister` zou er zo kunnen uitzien:

```csharp
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

De `HealthOfficial`-klasse heeft dan weer heel andere publieke methoden. En die `ForeignSecretary` ook weer totaal andere.

Je merkt dat de president \(of de programmeur van deze klasse\) aardig wat specifieke kennis moet hebben van de vele verschillende departementen van het land. De verschillende ministers kunnen zelf geen initiatief nemen en moeten alle instructies voorgekauwd krijgen. Bovenstaande code is dus zeer slecht. Telkens er zaken binnen het takenpakket van een bepaalde minister wijzigen moet dit ook in de klasse `President` aangepast worden.

Dankzij polymorfisme kunnen we dit alles veel mooier oplossen:

1. We verplichten alle adviseurs dat ze overerven van de abstracte klasse `Advisor` die maar 1 abstracte methode heeft `Advise`:

```csharp
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

Het leven van de president wordt veel makkelijker:

```csharp
public class President
{
    public void RunTheCountry()
    {
        Advisor general = new MilitaryAdvisor();
        Advisor secretary = new ForeignSecretary();
        Advisor doctor = new HealthOfficial();
        general.Advise(); // # Petraeus says send 100,000 troops to Fallujah
        secretary.Advise(); // # she says negotiate trade deal with Iran
        doctor.Advise(); // # they say we need to spend $50 billion on ObamaCare
    }
}
```

We kunnen ook nog meer flexibiliteit bieden door één lijst adviseurs op te stellen, zodat er op een bepaald moment meer of minder adviseurs kunnen zijn:

```csharp
public class President
{
    public void RunTheCountry()
    {   
        List<Advisor> allMinisters= new List<Advisor>();
        allMinisters.Add(new MilitaryAdvisor());
        allMinisters.Add(new ForeignSecretary());
        allMinisters.Add(new HealthOfficial());

        // Ask advice from each:
        foreach (Advisor minister in allMinisters)
        {
            minister.Advise();
        }
    }
}
```

De president moet nu gewoon de juiste adviseurs kunnen kiezen. We kunnen veranderen hoe elk van deze adviseurs zijn taak vervult, zonder de code van `President` aan te passen. We kunnen ook makkelijk nieuwe types adviseurs toevoegen \(bv. voor landbouw, cyberbeveiliging,...\).

