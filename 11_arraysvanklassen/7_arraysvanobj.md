# Object arrays

We vallen in herhaling: ook arrays van objecten zijn mogelijk, net zoals je arrays van valuetypes al kon maken. Ook hier is de werking grotendeels dezelfde. Maar ook hier moet je er rekening mee houden dat de individuele objecten in je array **reference** values hebben en dus mogelijk ``null`` zijn.

## Array van objecten aanmaken

Een array van objecten gebeurt als volgt:

```java
Student[] mijnKlas = new Student[20];
```

**Maar: er staan nog géén objecten in deze array. Alle elementen in deze array zijn nu nog ``null``.**
Je zou kunnen zeggen dat we enkel nog maar de parkeerlijnen hebben aangemaakt.

![Een parking, klaar om gevuld te worden](../assets/6_klassen/legearray.png)

Willen we nu elementen in deze array plaatsen dan moeten dit ook expliciet doen:

```java
mijnKlas[0]= new Student();
mijnKlas[7]= new Student();
```

Uiteraard kan dit ook in een loop indien relevant voor de opgave.

Probeer je objecten te benaderen die nog niet bestaan dan zal je uiteraard een ``NullReferenceException`` krijgen.

### Array initializer syntax

Je kan ook een variant op de object initializer syntax gebruiken waarbij de objecten reeds van bij de start in de array worden aangemaakt. Als extra'tje zorgt dit er ook voor dat we geen lengte moeten meegeven, de compiler zal deze zelf bepalen. Volgende voorbeeld maakt een nieuwe array aan die bestaat uit 2 nieuwe studenten, alsook 1 bestaande (``jos``):

```java
Student jos=new Student();
Student[] mijnKlas = new Student[]
    {
        new Student(),
        new Student(),
        jos,
        new Student()
    };
```

Let op de puntkomma helemaal achteraan. Die wordt als eens vergeten.

## Individueel object benaderen

Van zodra een object in de array staat kan je deze vanuit de array aanspreken d.m.v. de index :

```java
mijnKlas[3].Name= "Vincent Lagasse";
```

### Null check met ?

Ook hier kan je met ``?`` een null check schrijven:

```java
mijnKlas?[3]?.Name= "Romeo Montague ";
```
Merk op dat het eerste vraagteken controleer of de array niet ``null``is. Het tweede vraagteken, na de index, is om te controleren of het element op die index niet ``null`` is.

# Arrays als parameters en return

Ook arrays mag je als parameters en returntype gebruiken in methoden. De werking hiervan is identiek aan die van value-types.