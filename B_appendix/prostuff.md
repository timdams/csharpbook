# Handige Visual Studio code snippets

Bepaalde code zal je vaak opnieuw schrijven. Er zitten in VS tal van shortcuts om deze typische lijnen code sneller te schrijven. Schrijf een van volgende stukken code en druk dan 2x op de [tab]-toets
* ``cw`` : schrijft ``Console.WriteLine()``;
* ``for``
* ``while``
* ``dowhile``
* ``switch``
* ``///``: automatisch methode commentaar blok
* propfull: full property  (semester 2)
* prop: auto-property (semester 2)

# Regions
Je kan delen van je code in handige inklapbare secties zetten door deze als regions aan te duiden, als volgt:
```java
#region My Epic code
Console.WriteLine("I am the greatest!");
Console.WriteLine("Echt waar!");
#endregion
```

Je zal vanaf dan in Visual Studio rechts van de start van de region een minnetje zien waar je op kunt klikken om de hele region tot aan ``#endregion`` in te klappen. De code zal nog steeds gecompileerd worden, maar je bladspiegel is weer wat ordelijker geworden. 

# Bereik in code weten (Pro-kennis)
Het bereik van  datatypen is weliswaar opgegeven. Maar het is belangrijk om weten dat deze ook in de compiler gekend is. Het volgende voorbeeld toont dit aan:

```java
string zinnetje = "Het bereik van het type double is:";
Console.WriteLine(zinnetje + double.MinValue + " en " + double.MaxValue);
```

Je kan met andere woorden met `int.MaxValue` en `int.MinValue` het minimum- en maximumbereik van het type int verkrijgen. Wil je dit van een double, dan gebruik je `double.MaxValue` etc.




