##  Voorbeeld: Presidenten en interfaces

In het hoofdstuk Polymorfisme bespraken we een voorbeeld van een klasse ``President`` die enkele ``Advisor``-klassen gebruikt om hem te helpen ([lees hier na](../15_polymorfisme/polypraktijd.md)).

Een nadeel van die voorgaande aanpak is dat al onze Advisors maar 1 "job" kunnen hebben: ze erven allemaal over van ``Advisor`` en kunnen nergens anders van overerven (geen multiple inheritance is toegestaan in C#). Via interfaces kunnen we dit oplossen. Een advisor gaan we dan eerder als een "bij-job" beschouwen en niet de hoofdreden van een klasse.

We definiëren daarom eerst een nieuwe interface ``IAdvisor``:
```java
interface IAdvisor
{
    void Advise();
}
```

Vanaf nu kan eender *wie* die deze interface implementeert de President advies geven.Hoera! En daarnaast kan die klasse echter ook nog tal van andere zaken doen. Beeld je bijvoorbeeld een CEO van een bedrijf in die ook adviseur van de President wilt zijn. De bestaande klasse is bijvoorbeeld:
```java
class MicrosoftCEO: CEO   //CEO kan een parentklasse zijn die elders bijvoorbeeld algemene CEO-concepten beschrijft
{
    public void EarnBigBucks()
    { 
       Console.WriteLine("I'm getting rich!!!");       
    }
    public void FireDepartement()
     { 
       Console.WriteLine("You're all fired!");       
    }
}
```
Nu we de interface ``IAdvisor`` hebben kunnen we deze klasse aanvullen met deze interface:
```java
class MicrosoftCEO: CEO, IAdvisor
{
     
    public void Advise()
    { 
        Console.WriteLine("I think you should allow our monopoly. *Grin*");
    }
    
    public void EarnBigBucks()
    { 
       Console.WriteLine("I'm getting rich!!!");       
    }
    public void FireDepartement()
     { 
       Console.WriteLine("You're all fired!");       
    }
}
```
De CEO kan dus z'n bestaande job blijven uitoefenen maar ook als adviseur optreden. 

Ook de ``President`` moet aangepast worden om nu met een lijst van ``IAdvisor`` ipv ``Advisor`` te werken:
```java
public class MisterPresident
{
    public void RunTheCountry()
    {
    
        List<IAdvisor> allMinisters= new List<IAdvisor>();
        allMinisters.Add(new MicrosoftCEO);
        //Ask advise from each:
        foreach (IAdvisor minister in allMinisters)
        {
            minister.Advise();
        }
    }
}
```

De eerder beschreven ``MilitaryAdvisor``,``ScienceAdvisor`` en ``EconomyAdvisor`` dienen ook niet meer van de abstracte klasse ``Advisor``(deze zou je kunnen verwijderen) over te erven en kunnen gewoon de interface implementeren:

```java
class MilitaryAdvisor:IAdvisor
{
    public void Advise()
    {
        increaseTroopNumbers();
        improveSecurity();
        payContractors();
    }

    private void increaseTroopNumbers() 
    {
      //...
    }
    private void improveSecurity() 
    {
       //...
    }
    private void improveSecurity() 
    {
      //...
 }
}
```

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Interfaces in de praktijk met presidenten, deel 2](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=1df92edd-ba85-42f4-bdd0-abac0149cc10)
<!---NOBOOKEND--->
