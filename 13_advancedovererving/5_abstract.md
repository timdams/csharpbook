## Abstract

### Abstracte klassen

Soms maken we een parent-klasse waar op zich geen instanties van kunnen gemaakt worden: denk aan de parent-klasse ``Dier``. Subklassen van Dier kunnen ``Paard``, ``Wolf``, etc zijn. Van Paard en Wolf is het logisch dat je instanties kan maken (echte paardjes en wolfjes) maar van 'een dier'? Hoe zou dat er uit zien.

Met behulp van het **``abstract``** kunnen we aangeven dat een klasse abstract is: je kan overerven van deze klasse, maar je kan er geen instanties van aanmaken.

We plaatsen ``abstract`` voor de klasse om dit aan te duiden.

Een voorbeeld:
```java
abstract class Dier
{
  public int Name {get;set;}
}
```

Volgende lijn zal een error geven: ``Dier hetDier = new Dier();``

We mogen echter wel klassen overerven van deze klasse en instanties van aanmaken:
```java
class Paard: Dier
{
//...
}

class Wolf: Dier
{
 //..
}
```
En dan zal dit wel werken: ``Wolf wolfje= new Wolf();``

En als we polymorfisme gebruiken ([zie verder](../15_polymorfisme/11_polymo_intro.MD)) dan mag dit ook: ``Dier paardje= new Paard();`` 

### Abstracte methoden
Het is logisch dat we mogelijk ook bepaalde zaken in de abstracte klasse als abstract kunnen aanduiden. Beeld je in dat je een Methode "MaakGeluid" hebt in je klasse Dier. Wat voor een geluid maakt 'een dier'? We kunnen dus ook geen implementatie (code) geven in de abstracte parent klasse. 

Via abstracte methoden geven we dit aan: we hoeven enkel de methode signature te geven, met ervoor ``abstract``:
```java
abstract class  Dier
{
   public abstract string MaakGeluid();
}
```
Merk op dat er geen accolades na de signature komen.

Child-klassen **zijn verplicht deze abstracte methoden te overriden**.

De Paard-klasse wordt dan:
```java
class Paard: Dier
{
  public override string MaakGeluid()
  { 
      return "Hinnikhinnik";
  }
}
```
(en idem voor de wolf-klasse uiteraard)

#### Abstracte methoden enkel in abstracte klassen
Van zodra een klasse een abstracte methode of property heeft dan ben je, logischerwijs, verplicht om de klasse ook abstract te maken. 

### Abstracte properties

Properties kunnen virtual gemaakt, en dus ook ``abstract``. Volgende voorbeeld toont hoe dit werkt:

```java
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


<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Abstract klassen](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a6f513b8-e299-4118-986d-ab7c00e47861)
* [Uitgewerkt voorbeeld Abstract en System.Object mbv Zoo-dieren](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=e0c0f796-de77-4930-bcb6-ab8d00ce0c24) (compilatie uit hoorcollege 18-19)
<!---NOBOOKEND--->