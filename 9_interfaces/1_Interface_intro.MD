# Interfaces
> Delen van deze sectie komen uit het voortreffelijke handboek "Programmeren in C#" (2nd Edition door Douglas Bell en Mike Parr, ISBN:9789043032421)

In C# worden interfaces gebruikt om de uitwendige verschijningsvorm van een klasse te beschrijven. Vaak zijn klassen grote, complexe stukken code bestaande uit tientallen tot honderden methoden en properties. Wanneer we een dergelijke klasse moeten gebruiken boeit meestal enkel de uitwendige, of publieke, vorm: dit zijn de enige zaken waar je als externe gebruiker van de klasse mee kunt praten. Interfaces zijn als het ware stempels die we op een klasse kunnen plakken om zo te zeggen "deze klasse gebruikt interface xyz". Gebruikers van de klasse hoeven dan niet de hele klasse uit te spitten en weten dat alle klassen met interface xyz dezelfde publieke properties en methoden hebben. 

**Merk op dat dit niets met grafische user interfaces te maken heeft in dit geval.**

Een interface is niet meer dan een belofte: het zegt enkel welke publieke methoden en properties de klassen bezit. Het zegt echter niets over de effectieve code/implementatie van deze methoden en properties.

Volgende code toont hoe we een interface definiëren:
```csharp
interface ISuperHeld
{
    void SchietLasers();
    int VerlaagKracht(bool isZwak);
    int Power{get;set;}
}
```
Enkele opmerkingen:
* Het woord ``class`` wordt niet gebruikt, in de plaats daarvan gebruiken we ``interface``.
*  Het is een goede gewoonte om interfaces met een I te laten starten in hun naamgeving
*  Methoden en properties gaan niet vooraf van ``public``: interfaces zijn van nature net publiek, dus alle methoden en properties van de interface zijn dat bijgevolg ook.
*  Er wordt geen code/implementatie gegeven: iedere methode eindigt ogenblikkelijk met een kommapunt.


Het is in de klassen dat we nu vervolgens verplicht zijn deze methode en properties te implementeren.

>**Een interface is een beschrijving hoe een component een andere component kan gebruiken, zonder te zeggen hoe dit moet gebeuren. De interface is met andere woorden 100% scheiding tussen de methode/Property-signatuur en de eigenlijke implementatie ervan.**

![](/assets/9_interfaces/scuminterface.jpg)

## Interface regels
* Je kan geen  membervariabelen (fields) declareren in een interface (dat hoort bij de implementatie)
* Je kan geen constructor declareren
* Je kan geen access specificeren (public, protected, etc): alles is public
* Je kan nieuwe types (bv enum, struct) in een interface declareren.
* Een interface kan niet overerven van een klasse, wel van een andere interface.


## Interfaces en klassen
We kunnen nu aan klassen de stempel ISuperHeld geven zodat programmeurs weten dat die klasse geagarandeert de methoden ``SchietLasers``, ``VerlaagKracht`` en de property ``Power`` zal hebben.

Volgende code toont dit:
```csharp
class Zorro: ISuperHeld
{
    public void RoepPaard(){...}
    public bool HeeftSnor{get;set;}
    public void SchietLasers() //interface ISuperHeld
    {
        Console.WriteLine("pewpew");
    }
    int VerlaagKracht(bool isZwak)//interface ISuperHeld
    {
        if(isZwak) return 5;
        return 10;
    }
    int Power{get;set;} //interface ISuperHeld
}
```
Zolang de klasse Zorro niet exact de interface inhoud implementeert zal deze klasse niet gecompileerd kunnen worden.

## Meerder interfaces
Een nadeel van overerving is dat een klasse maar van 1 klasse kan overerven. Een klasse mag echter wel meerdere interfaces met zich meedragen:
```csharp
interface ISuperHeld{...}
interface ICoureur{...} 
class Man {...}

class Zorro:Man, ISuperHeld
{...}

class Batman:Man, ISuperHeld, ICoureur 
{...}
```

Ook mogen interfaces van mekaar overerven:
```csharp
interface IGod:ISuperHeld
{...}
```

## Voorbeeld: Presidenten en interfaces
In het hoofdstuk Polymorfisme bespraken we een voorbeeld van een klasse ``President`` die enkele ``Advisor``-klassen gebruikt om hem te helpen ([lees hier na](../11_polymorfisme#polymorfisme-in-de-praktijk-presidenten)).

Een nadeel van die voorgaande aanpak is dat al onze Advisors maar 1 "job" kunnen hebben: ze erven allemaal over van ``Advisor`` en kunnen nergens anders van overerven (geen multiple inheritance is toegestaan in C#). Via interfaces kunnen we dit oplossen. Een advisor gaan we dan eerder als een "bij-job" beschouwen en niet de hoofdreden van een klasse.

We definiëren daarom eerst een nieuwe interface ``IAdvisor``:
```csharp
interface IAdvisor
{
    void Advise();
}
```

Vanaf nu kan eender *wie* die deze interface implementeert de President advies geven.Hoera! En daarnaast kan die klasse echter ook nog tal van andere zaken doen. Beeld je bijvoorbeeld een CEO van een bedrijf in die ook adviseur van de President wilt zijn. De bestaande klasse is bijvoorbeeld:
```csharp
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
```csharp
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
```csharp
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

De eerder beschreven ``MilitaryAdvisor``,``ScienceAdvisor`` en ``EconomyAdvisor`` dienen ook niet meer van de abstracte klasse ``Àdvisor``(deze zou je kunnen verwijderen) over te erven en kunnen gewoon de interface implementeren:

```csharp
class MilitaryMinistor:IAdvisor
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
