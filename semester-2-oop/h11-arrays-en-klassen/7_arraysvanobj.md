# Arrays van objecten

## Object arrays

We vallen in herhaling: ook arrays van objecten zijn mogelijk, net zoals je arrays van valuetypes al kon maken. Ook hier is de werking grotendeels dezelfde. Maar ook hier moet je er rekening mee houden dat de individuele objecten in je array **reference** values hebben en dus mogelijk `null` zijn.

### Array van objecten aanmaken

Een array van objecten gebeurt als volgt:

```csharp
Student[] mijnKlas = new Student[20];
```

**Maar: er staan nog géén objecten in deze array. Alle elementen in deze array zijn nu nog `null`.** Je zou kunnen zeggen dat we enkel nog maar de parkeerlijnen hebben aangemaakt.

![](../../.gitbook/assets/legearray%20%281%29.png)

Willen we nu elementen in deze array plaatsen dan moeten dit ook expliciet doen:

```csharp
mijnKlas[0]= new Student();
mijnKlas[7]= new Student();
```

Uiteraard kan dit ook in een loop indien relevant voor de opgave.

Probeer je objecten te benaderen die nog niet bestaan dan zal je uiteraard een `NullReferenceException` krijgen.

#### Array initializer syntax

Je kan ook een variant op de object initializer syntax gebruiken waarbij de objecten reeds van bij de start in de array worden aangemaakt. Als extra'tje zorgt dit er ook voor dat we geen lengte moeten meegeven, de compiler zal deze zelf bepalen. Volgende voorbeeld maakt een nieuwe array aan die bestaat uit 2 nieuwe studenten, alsook 1 bestaande \(`jos`\):

```csharp
Student jos=new Student();
Student[] mijnKlas = new Student[]
    {
        new Student(),
        new Student(),
        jos,
        new Student()
    };
```

Let op de kommapunt helemaal achteraan. Die wordt als eens vergeten.

### Individueel object benaderen

Van zodra een object in de array staat kan je deze vanuit de array aanspreken d.m.v. de index :

```csharp
mijnKlas[3].Name= "Vincent Lagasse";
```

## Arrays als parameters en return

Ook arrays mag je als parameters en returntype gebruiken in methoden. De werking hiervan is identiek aan die van value-types.

