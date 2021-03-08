# Constructors bij overerving

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/ZRIEiekI0tM)
{% endhint %}

## Constructors bij overerving

Wanneer je een object instantieert van een child-klasse dan gebeuren er meerdere zaken na elkaar, in volgende volgorde:

* Eerst wordt een constructor aangeroepen van een voorouderklasse opgeroepen.
* Gevolgd door een constructor van de parent klasse.
* Finaal de constructor van de klasse zelf.

Volgende voorbeeld toont dit in actie:

```csharp
class Soldier
{
   public Soldier() {Console.WriteLine("Soldier reporting in");}
}

class Medic:Soldier
{
   public Medic(){Console.WriteLine("Who needs healing?");}
}
```

Indien je vervolgens een object aanmaakt van het type `Medic`:

```csharp
Medic RexGregor= new Medic();
```

Dan zal zien we de volgorde van constructor-aanroep op het scherm:

```text
Soldier reporting in
Who needs healing?
```

Er wordt dus verondersteld in dit geval dat er een parameterloze constructor in de basisklasse aanwezig is.

### Constructoren met parameters

Indien je klasse Soldier geen parameterloze constructor heeft, dan moeten we uitdrukkelijk zeggen van waar de gebruikte parameters komen. Volgende code zou dus een probleem geven indien je een Medic wilt aanmaken via `new Medic()`:

```csharp
class Soldier
{
   public Soldier(bool canShoot) {//...Do stuff  }
}

class Medic : Soldier
{
   public Medic(){Console.WriteLine("Who needs healing?");}
}
```

Wat je namelijk niet ziet bij child-klassen en hun constructors is dat er eigenlijk een impliciete call naar de basis-constructor wordt gedaan. Bij alle constructors staat eigenlijk `:base()` wat je ook zelf kunt schrijven:

```csharp
class Medic : Soldier
{
    public Medic() : base()
    {
        Console.WriteLine("Who needs healing?");
    }
}
```

`base()` achter de constructor zegt dus eigenlijk "roep de constructor van de parent-klasse aan. Je mag hier echter ook parameters meegeven en de compiler zal dan zoeken naar een constructor in de basis-klasse die deze volgorde van parameters kan accepteren."

We zien hier dus hoe we ervoor moeten zorgen dat we terug Medics via `new Medic()` kunnen aanroepen zonder dat we de constructor\(s\) van Soldier moeten aanpassen:

```csharp
class Soldier
{
   public Soldier(bool canShoot) {//...Do stuff  }
}

class Medic:Soldier
{
    public Medic() : base(true) {
        Console.WriteLine("Who needs healing?");
    }
}
```

De medics zullen de canShoot dus steeds op true zetten. Uiteraard wil je misschien dit kunnen meegeven bij het aanmaken van een object zoals `new Medic(false)`, dit vereist dat je dus een overloaded constructor in Medic aanmaakt, die op zijn beurt de overloaded constructor van Soldier aanroept. Je schrijft dan een overloaded constructor in Medic bij:

```csharp
class Soldier
{
   public Soldier(bool canShoot) {//...Do stuff  }
}

class Medic:Soldier
{
   public Medic(bool canShoot) : base(canShoot) {} 

   public Medic() : base(true) {
       Console.WriteLine("Who needs healing?");
   }
}
```

Uiteraard mag je ook de parameterloze constructor aanroepen vanuit de child-constructor, alle combinaties zijn mogelijk \(zolang de constructor in kwestie maar bestaat in de parent-klasse\).

