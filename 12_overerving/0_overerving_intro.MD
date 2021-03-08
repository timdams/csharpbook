# Overerving

Overerving (**inheritance**) laat ons toe om klassen te specialiseren vanuit een reeds bestaande basisklasse. Wanneer we een klasse van een andere klasse overerven dan zeggen we dat deze nieuwe klasse een child-klasse of sub-klasse is van de bestaande parent-klasse of super-klasse.

De child-klasse kan alles wat de parent-klasse kan, maar de nieuwe klasse kan nu ook extra specialisatie code krijgen.

## Is-een relatie

Wanneer twee klassen met behulp van een "x is een y"-relatie kunnen beschreven worden dan weet je dat overerving mogelijk.

* Een paard **is een** dier (paard = child-klasse, dier= parent-klasse)
* Een tulp **is een** plant

{% hint style='warning' %}
Opgelet: wanneer we "x heeft een y" zeggen gaat het **niet** over overerving, maar over [compositie](../14_compositie/0_compositie_intro.MD).
{% endhint %}

## Inheritance in CS

Overving duid je aan met behulp van het dubbele punt(:)  bij de klassedefinitie:

Een voorbeeld:

```csharp
class Paard: Dier
{
   public bool KanHinnikken{get;set;}
}

class Dier
{
   public void Eet()
   {
    //...
   }
}
```

Objecten van het type Dier kunnen enkel de Eet-methode aanroepen. Objecten van het type Paard kunnen de Eet-methode aanroepen én ze hebben ook een property KanHinnikken:

```csharp
Dier aDier= new Dier();
Paard bPaard= new Paard();
aDier.Eet();
bPaard.Eet();
bPaard.KanHinnikken=false;
aDier.KanHinnikken=false; //!!! zal niet werken!
```

## Multiple inheritance

In C# is het niet mogelijk om een klasse van meer dan een parent-klasse te laten overerven (zogenaamde multiple inheritance), wat wel mogelijk is in sommige andere object georiënteerde talen.

## Transitive

Overerving in C# is transitief, dit wil zeggen dat de child-klasse niet alleen overerft van haar ouderklasse, maar ook van grootouderklassen enzovoort. Je zou bijvoorbeeld een subklasse `Pony` van de klasse `Paard` kunnen toevoegen. Een `Pony` is een `Paard` en een `Paard` is een `Dier`, dus een `Pony` is ook een `Dier` en heeft bijvoorbeeld een methode `Eet`.

## Protected

Ook al **heeft** een subklasse alle onderdeeltjes van een ouderklasse, hou er rekening mee dat private variabelen en methoden van de parent-klasse NIET rechtsreeks aanroepbaar zijn in de child-klasse. Private betekent namelijk: "enkel toegankelijk binnenin **deze** klasse". Private geeft aan dat het element enkel in de klasse zichtbaar is:

```csharp
class Paard: Dier
{
   public void MaakOuder()
   {
      leeftijd++; //  !!! dit zal error geven!
   }
}

class Dier
{
   private int leeftijd;
}
```

Een `Paard` **heeft** nog wel een leeftijd, maar binnenin de code voor de klasse `Paard` kan je de leeftijd niet zomaar opvragen of aanpassen.

Je kan dit oplossen door de **protected** access modifier ipv private te gebruiken. Met protected geef je aan dat het element enkel zichtbaar is binnen de klasse **en** binnen child-klassen:

```csharp
class Paard: Dier
{
   public void MaakOuder()
   {
      leeftijd++; //  werkt nu wel
   }
}

class Dier
{
   protected int leeftijd;
}
```

## Sealed

Soms wil je niet dat van een klasse nog nieuwe klasse kunnen overgeërfd worden. Je lost dit op door het keyword ``sealed`` voor de klasse te zetten:

```csharp
sealed class DoNotInheritMe
{
   //...
}
```

Als je later dan dit probeert:

```csharp
class ChildClass:DoNotInheritMe
{
   //...
}
```

zal dit resulteren in een foutoodschap, namelijk ``cannot derive from sealed type 'DoNotInheritMe'``.

# Kennisclip
![](../assets/infoclip.png)
* [Overerving overzicht](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=c8b828c5-87c0-4339-a61c-ab7c00aef24d)
