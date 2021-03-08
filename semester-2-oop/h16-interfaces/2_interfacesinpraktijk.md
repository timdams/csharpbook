# Bestaande interfaces in .NET
De bestaande .NET klassen gebruiken vaak interfaces om bepaalde zaken uit te voeren. Zo heeft .NET tal van interfaces gedefinieerd waar je zelfgemaakte klassen mogelijk aan moeten voldoen indien ze bepaalde bestaande methoden wensen te gebruiken. Een typisch voorbeeld is het gebruik van de ``Array.Sort`` methode. We tonen dit in een voorbeeld zo meteen.

Enkele veelgebruikte interfaces binnen .NET (louter ter info):

> * IEnumerable (and IEnumerable): for use with foreach and LINQ
> * IDisposable: for resources requiring cleanup, used with using
> * IQueryable: lets you execute requests against queriable data sources.
> * INotifyPropertyChange : For data binding to UI classes in WPF, winforms and silverlight
> * IComparable and IComparer: for generalized sorting
> *IEquatable and IEqualityComparer: for generalized equality
> * IList and ICollection: for mutable collections
> * IDictionary: for lookup collections

# Sorteren met Array.Sort en de IComparable interface

## Stap 1: Het probleem
Indien je een array van objecten hebt en je wenst deze te sorteren via ``Array.Sort`` dan dienen de objecten de IComparable interface te hebben. 

We willen een array van landen kunnen sorteren op grootte van oppervlakte.

Stel dat we de klasse ``Land`` hebben:
```csharp
class Land
{
    public string Naam {get;set;}
    public int Oppervlakte {get;set;}
    public int Inwoners{get;set;}
}
```
We plaatsen 3 landen in een array:
```csharp
Land[] eurolanden = new Land[3];
eurolanden[0]= new Land() {Naam="Belgie", Oppervlakte= 5, Inwoners=2000};
eurolanden[1]= new Land() {Naam="France", Oppervlakte= 7, Inwoners=2500};
eurolanden[2]= new Land() {Naam="Nederland", Oppervlakte= 6, Inwoners=1800};
```
Wanneer we nu proberen:
```csharp
Array.Sort(eurolanden);
```
Dan treedt er een uitzondering op:``InvalidOperationException: Failed to compare two elements in the array`` 

![](../assets/9_interfaces/interfaceexep.png)

## Stap 2: IComparable onderzoeken
We kunnen dit oplossen door de ``IComparable`` interface in de klasse ``Land`` te implementeren. We bekijken daarom eerst de documentatie van deze interface ([hier](https://msdn.microsoft.com/en-us/library/system.icomparable.aspx)).

De interface is beschreven als:

```csharp
interface IComparable
{
    int CompareTo(Object obj);
}
```

{% hint style='warning' %}
**OPGELET: Deze interface bestaat al in .NET en mag je dus niet opnieuw in code schrijven!**
{% endhint %}


Daarbij moet de methode een int  teruggeven als volgt:

| Waarde        | Betekenis           |
|:------------- |:-------------|
| Getal kleiner dan 0      | Huidig object komt **voor** het ``obj`` dat als parameter werd meegegeven |
|  0      | Huidig object komt op **dezelfde** positie als  ``obj``  werd meegegeven |
| Getal groter dan 0      | Huidig object komt **na** het ``obj`` dat als parameter werd meegegeven |

## Stap 3: IComparable in Land implementeren
We zorgen er nu voor dat ``Land`` deze interface implementeert. Daarbij willen we dat de landen volgens oppervlakte worden gesorteerd :
```csharp
class Land: IComparable
{
    //....

    public int CompareTo(object obj)
    {
        Land temp= (Land)obj; //Zetten de parameter om naar land

        if(Oppervlakte > temp.Oppervlakte) return 1;
        if(Oppervlakte < temp.Oppervlakte) return -1;
    
        return 0;
    }
}
```

Nu zal de Sort werken! ``Array.Sort(eurolanden);``

Stel dat vervolgens nog beter willen sorteren: we willen dat landen met een gelijke oppervlakte, op hun inwoners gesorteerd worden:
```csharp
public int CompareTo(object obj)
{
    Land temp= (Land)obj; //Zetten de parameter om naar land

    if(Oppervlakte > temp.Oppervlakte) return 1;
    if(Oppervlakte < temp.Oppervlakte) return -1;
    if(this.Inwoners > temp.Inwoners) return 1;
    if(this.Inwoners < temp.Inwoners) return -1;
    
    return 0;
}
```

# Why should I care?

![](../assets/care.jpg)

Als ik niet overtuigend genoeg was over het nut van interfaces in het vorige hoofdstuk, dan hoop ik dat bovenstaande voorbeelden je al een beetje hebben kunnen doen proeven van de kracht van interfaces. Gedaan met ons druk te maken wat er allemaal in een klasse gebeurt. Werk gewoon 'tegen' de interfaces van een klasse en we krijgen de ultieme black-box revelatie (see what I did there? :p )!

# Kennisclip

![](../assets/infoclip.png)



* [Interfaces in de praktijk- een meme-detective verhaal](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=2ace92d8-27c8-4b3a-9a3d-abac014a15a9)
