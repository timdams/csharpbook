# Abstract

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/zQB4lDh-4Io)
{% endhint %}

## Abstract

### Abstracte klassen

Soms maken we een parent-klasse waar op zich geen instanties van kunnen gemaakt worden: denk aan de parent-klasse `Dier`. Subklassen van Dier kunnen `Paard`, `Wolf`, etc zijn. Van Paard en Wolf is het logisch dat je instanties kan maken \(echte paardjes en wolfjes\) maar van 'een dier'? Hoe zou dat er uit zien.

Met behulp van het **`abstract`** kunnen we aangeven dat een klasse abstract is: je kan overerven van deze klasse, maar je kan er geen instanties van aanmaken.

We plaatsen `abstract` voor de klasse om dit aan te duiden.

Een voorbeeld:

```csharp
abstract class Dier
{
  public int Name {get;set;}
}
```

Volgende lijn zal een error geven: `Dier hetDier = new Dier();`

We mogen echter wel klassen overerven van deze klasse en instanties van aanmaken:

```csharp
class Paard: Dier
{
//...
}

class Wolf: Dier
{
 //..
}
```

En dan zal dit wel werken: `Wolf wolfje = new Wolf();`

### Abstracte methoden

Het is logisch dat we mogelijk ook bepaalde zaken in de abstracte klasse als abstract kunnen aanduiden. Beeld je in dat je een Methode "WetenschappelijkeNaam" hebt in je klasse Dier. Wetenschappelijke namen zijn eigen aan specifieke dieren. We kunnen dus ook geen implementatie \(code\) geven in de abstracte parent klasse.

Via abstracte methoden geven we dit aan: we hoeven enkel de methode signature te geven, met ervoor `abstract`:

```csharp
abstract class  Dier
{
   public abstract string WetenschappelijkeNaam();
}
```

Merk op dat er geen accolades na de signature komen.

Child-klassen **zijn verplicht deze abstracte methoden te overriden**.

De Paard-klasse wordt dan:

```csharp
class Paard: Dier
{
  public override string WetenschappelijkeNaam()
  { 
      return "equus";
  }
}
```

\(en idem voor de wolf-klasse uiteraard\)

#### Abstracte methoden enkel in abstracte klassen

Van zodra een klasse een abstracte methode of property heeft dan ben je, logischerwijs, verplicht om de klasse ook abstract te maken.

### Abstracte properties

Properties kunnen virtual gemaakt, en dus ook `abstract`. Volgende voorbeeld toont hoe dit werkt:

```csharp
    abstract class Dier
    {
        abstract public int MaxLeeftijd { get;}
    }

    class Olifant : Dier
    {
        public override int MaxLeeftijd {
            get { return 100; }
        }
    }
```

