# Overerving intro

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/jEipgofmIHQ)
{% endhint %}

## Overerving

Overerving \(**inheritance**\) laat ons toe om klassen te specialiseren vanuit een reeds bestaande basisklasse. Wanneer we een klasse van een andere klasse overerven dan zeggen we dat deze nieuwe klasse een child-klasse of sub-klasse is van de bestaande parent-klasse of super-klasse.

De child-klasse kan alles wat de parent klasse kan, maar de nieuwe klasse kan nu ook extra specialisatie code krijgen. Deze kan extra methodes voorzien of kan de werking van bestaande methodes aanpassen.

### Is-een relatie

Wanneer twee klassen met behulp van een "x is een y"-relatie kunnen beschreven worden dan weet je dat overerving mogelijk.

* Een paard **is een** dier \(paard = child-klasse, dier= parent-klasse\)
* Een tulp **is een** plant

### Inheritance in C\#

Overving duid je aan met behulp van het dubbele punt bij de klassedefinitie:

Een voorbeeld:

```csharp
class Paard : Dier
{
   public void Hinnik(){
     Console.WriteLine("Hihihihiii");
   }
}

class Dier
{
   public void Eet()
   {
    //...
   }
}
```

Objecten van het type Dier kunnen enkel de Eet-methode aanroepen. Objecten van het type Paard kunnen de Eet-methode aanroepen én ze hebben ook een methode Hinnik\(\):

```csharp
Dier aDier = new Dier();
Paard bPaard = new Paard();
aDier.Eet();
bPaard.Eet();
bPaard.Hinnik();
aDier.Hinnik(); // compilatiefout!
```

### Transitiviteit

Overerving in C\# is transitief, dit wil zeggen dat de child-klasse niet alleen overerft van haar ouderklasse, maar ook van grootouderklassen enzovoort. Je zou bijvoorbeeld een subklasse `Pony` van de klasse `Paard` kunnen toevoegen. Een `Pony` is een `Paard` en een `Paard` is een `Dier`, dus een `Pony` is ook een `Dier` en heeft bijvoorbeeld een methode `Eet`.

