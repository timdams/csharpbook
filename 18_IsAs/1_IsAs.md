## Is en As

We introduceren twee nieuwe C# keywords: ``is`` en ``as``.

### Is keyword
Het ``is`` keyword is een operator die je kan gebruiken om te weten te komen of:
* Een object van een bepaalde type is
* Een object een bepaalde interface bevat

``is`` geeft een bool terug.

#### Is voorbeeld 1
Stel dat we volgende drie klassen hebben:
```java
class Vehicle {}

class Car: Vehicle{}

class Person {}
```
Een Car **is** een Vehicle.
Een Person **is geen** Vehicle.

Stel dat we enkele variabelen hebben als volgt:
```java
Car myCar= new Car();
Person rambo= new Person();
```

We kunnen nu de objecten met ``is`` bevragen of ze van een bepaalde type zijn:
```java
if(myCar is Vehicle)
{
    Console.WriteLine("The first object is a Vehicle");
}
if(rambo is Vehicle)
{
    Console.WriteLine("The second object is a Vehicle");
}
```

De uitvoer zal worden:``The first object is a Vehicle``.

### As keyword met voorbeeld
Wanneer we objecten van het ene naar het andere type willen omzetten dan doen we dit vaak met behulp van [casting](../3_data/4_converteren_casting.md):
```java
Student fritz= new Student();
Mens jos = (Mens)fritz;
```

 Het probleem bij casting is dat dit niet altijd lukt. Indien de conversie niet mogelijk is zal een Exception gegenereerd worden en je programma zal  crashen als  je niet aan [Exception handling doet](https://codevan1001nacht.wordpress.com/2013/11/06/exception-handling/).

 Het ``as`` keyword lost dit op. Het keyword zegt aan de compiler 'probeer dit object te converteren. Als het niet lukt, zet het dan op ``null`` in plaats van een Exception te werpen.
 
 De code van daarnet herschrijven we dan naar:

 ```java
Student fritz= new Student();
Mens jos =fritz as Mens;
```
Indien nu de casting niet lukt (omdat ´´Student´´ misschien geen childklasse van ´´Mens´´ blijkt te zijn) dan zal ``jos`` de waarde ``null`` hebben gekregen.

We kunnen dan vervolgens bijvoorbeeld schrijven:
 ```java
Student fritz= new Student();
Mens jos =fritz as Mens;
if(jos!=null)
{
    //Doe Mens-zaken   
}
```

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)

De ``is`` en ``as`` keywords laten toe om meer dynamische code te schrijven. Mogelijk weet je niet op voorhand wat voor datatype je code zal moeten verwerken en wordt polymorfisme je oplossing. Maar dan? Dan komen ``is`` en ``as`` to the rescue!

Je , dank zij polymorfisme, gevuld lijst van objecten van allerhande typen wordt nu beheersbaarder. Je kan nu , met ``is`` een element bevragen of hij van een bepaald type is. Vervolgens kan je met ``as`` het element even 'omzetten' naar z'n effectieve type (en dus meer doen dan wat hij kan in de vermomming van z'n eigen basistype).

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Is en as keywords](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=aba3bca4-ed3a-4067-a611-ab7d00cc2178)
<!---NOBOOKEND--->