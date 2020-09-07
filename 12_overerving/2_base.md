## Base keyword
Het **base** keyword laat ons toe om bij een overriden methode of property in de child-klasse toch te verplichten om de parent-implementatie toe te passen.

Stel dat we volgende 2 klassen hebben:
```java
class Restaurant
{
     protected int kosten=0;
     public virtual void PoetsAlles()
     {
           kosten+=1000;
     }
}

class Frituur:Restaurant
{
     public override void PoetsAlles()
     {
           kosten+= (1000 + 500);
     }
 
}
```

Het poetsen van een Frituur is duurder (1000 basis + 500 voor ontsmetting) dan een gewoon restaurant. Als we echter later beslissen dat de basisprijs (in Restaurant) moet veranderen dan moet je ook in alle child-klassen doen.
Base lost dit voor ons. De Frituur-klasse herschrijven we naar:

```java
class Frituur:Restaurant
{
     public override void PoetsAlles()
     {
           base.PoetsAlles(); //eerste basiskost wordt opgeteld
           kosten+=500;  //kosten eigen aan frituur worden bijgeteld.
     }
 
}
```
