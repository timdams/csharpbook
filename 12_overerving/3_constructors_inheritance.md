## Constructors bij overerving

Wanneer je een object instantiëert van een child-klasse dan gebeuren er meerdere zaken na elkaar, in volgende volgorde:

* Eerst wordt de constructor aangeroepen van de basis-klasse: dus steeds eerst die van ``System.Object``
* Gevolgd door de constructors van alle parent-klassen
* Finaal de constructor van de klasse zelf.

Volgende voorbeeld toont dit in actie:

```java
class Soldier
{
   public Soldier() {Console.WriteLine("Soldier reporting in");}
}

class Medic:Soldier
{
   public Medic(){Console.WriteLine("Who needs healing?");}
}
```

Indien je vervolgens een object aanmaakt van het type Medic:

```java
Medic RexGregor= new Medic();
```

Dan zal zien we de volgorde van constructor-aanroep op het scherm:

<!---{line-numbers:false}--->
```text
Soldier reporting in
Who needs healing?
```

Er wordt dus verondersteld in dit geval dat er een default constructor in de basis-klasse aanwezig is.

### Overloaded constructors

Indien je klasse Soldier een overloaded constructor heeft, dan geeft deze niet automatisch een default constructor. Volgende code zou dus een probleem geven indien je een Medic wilt aanmaken via ``new Medic()``:
```java
class Soldier
{
   public Soldier(bool canShoot) {//...Do stuff  }
}

class Medic:Soldier
{
   public Medic(){Console.WriteLine("Who needs healing?");}
}
```

Wat je namelijk niet ziet bij child-klassen en hun constructors is dat er eigenlijk een impliciete call naar de basis-constructor wordt gedaan. Bij alle constructors staat eigenlijk ``:base()`` wat je ook zelf kunt schrijven:
```java
class Medic:Soldier
{
   public Medic(): base()
   {Console.WriteLine("Who needs healing?");}
}
```
``base()`` achter de constructor zegt dus eigenlijk 'roep de constructor van de parent-klasse aan. Je mag hier echter ook parameters meegeven en de compiler zal dan zoeken naar een constructor in de basis-klasse die deze volgorde van parameters kan accepteren.

We zien hier dus hoe we ervoor moeten zorgen dat we terug Medics via ``new Medic()`` kunnen aanroepen zonder dat we de constructor(s) van Soldier moeten aanpassen:
```java
class Soldier
{
   public Soldier(bool canShoot) {//...Do stuff  }
}

class Medic:Soldier
{
   public Medic():base(true)
    {Console.WriteLine("Who needs healing?");}
}
```

De medics zullen de canShoot dus steeds op true zetten.
Uiteraard wil je misschien dit kunnen meegeven bij het aanmaken van een object zoals ``new Medic(false)``, dit vereist dat je dus een overloaded constructor in Medic aanmaakt, die op zijn beurt de overloaded constructor van Soldier aanroept. Je schrijft dan een overloaded constructor in Medic bij:

```java
class Soldier
{
   public Soldier(bool canShoot) {//...Do stuff  }
}

class Medic:Soldier
{
   public Medic(bool canSh): base(canSh)
   {} 

   public Medic():base(true)  //Default
    {Console.WriteLine("Who needs healing?");}
}
```

Uiteraard mag je ook de default constructor aanroepen vanuit de child-constructor, alle combinaties zijn mogelijk (zolang de constructor in kwestie maar bestaat in de parent-klasse).

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)
*[Constructors bij overerving](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a83a530e-11ff-47eb-b4cf-ab7c00b75401)
<!---NOBOOKEND--->