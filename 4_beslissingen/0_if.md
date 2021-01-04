## If

De ``if`` (*als*) uitdrukking is één van de meest elementaire uitdrukkingen in een programmeertaal en laat ons toe 'vertakkingen' in onze programmaflow in te bouwen. Ze laat toe om "als dit waar is doe dan dat"-beslissingen te maken.

De syntax is als volgt:

```java
if (booleaanse expressie) 
{
    //deze code wordt uitgevoerd indien
    //de booleaanse expressie true is
}

```

Enkel indien de booleaanse expressie waar is, en dus ``true`` als resultaat heeft, zal de code binnen de accolades van het if-blok uitgevoerd worden. Indien de expressie niet waar is (``false``) dan wordt het blok overgeslagen en gaat het programma verder met de code eronder.



Een voorbeeld:
```java
int number = 3;
if ( number < 5 )
{
    Console.WriteLine ("A");
}
Console.WriteLine("B");
```

De uitvoer van dit programma zal zijn:

<!---{line-numbers:false}--->
```text
A
B
```

Indien ``number`` groter of gelijk aan 5 was dan zou er enkel ``B`` op het scherm zijn verschenen. De lijn ``Console.WriteLine("B");`` zal sowieso uitgevoerd worden zoals je ook kan zien aan de flowchart op volgende pagina.

<!---{pagebreak} --->

<!---{ height:90%} --->
![De flowchart van voorgaande code](../assets/2_beslissingen/ifflow.png)

<!---{pagebreak} --->

### if met een block

Het is aangeraden om steeds na de if-expressie met accolades te werken. Dit zorgt ervoor dat alle code tussen het block (de accolades) zal uitgevoerd worden indien de booleaanse expressie waar was. **Gebruik je geen accolades dan zal enkel de eerste lijn na de ``if`` uitgevoerd worden bij ``true``.**

Een voorbeeld:
```java
if ( number < 5 )
{
    Console.WriteLine ("C");
    Console.WriteLine ("D");
}
```

![Accolades zijn duidelijk belangrijk](../assets/2_beslissingen/iffflowblock.png)

<!---{pagebreak} --->

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
**Veelgemaakte fouten**
Voorman hier! Je hebt me gemist. Ik merk het. Het ging goed de laatste tijd. Maar nu wordt het tijd dat ik je weer even wakker schud want de code die je nu gaat bouwen kan érg vreemde gedragingen krijgen als je niet goed oplet. Luister daarom even naar deze lijst van veel gemaakte fouten wanneer je met ``if`` begint te werken: 


**Appelen en peren vergelijken**
De types in je booleaanse expressie moeten steeds vergelijkbaar zijn. Volgende code is dus fout: 

```java
if( "4" > 3)
```
daar we hier een ``string`` met een ``int`` vergelijken.

**Accolades vergeten**
Accolades vergeten plaatsen om een codeblock aan te duiden, maar je code toch zodanig uitlijnen (met tabs of spaties) dat het lijkt of je een heel codeblock hebt. Het gevolg zal zijn dat enkel de eerste lijn na de ``if`` zal uitgevoerd worden indien ``true``. Gebruiken we de ``if`` met block van daarnet maar zonder accolades dan zal de laatste lijn altijd uitgevoerd worden ongeacht de ``if``:

```java
if ( number < 5 )
    Console.WriteLine ("C");
    Console.WriteLine ("D");
```

Merk ook op dat je code anders uitlijnen géén invloed heeft op de uitvoer (wat bijvoorbeeld wel zo is bij de programmeertaal Python).

**Een puntkomma plaatsen na de booleaanse expressie.** 

Dit zal ervoor zorgen dat er eigenlijk geen codeblock bij de ``if`` hoort en je dus een nietszeggende ``if`` hebt geschreven. De code na het puntkomma zal uitgevoerd worden ongeacht de ``if``:

```java
if ( number < 5 );
    Console.WriteLine ("C");
    Console.WriteLine ("D");
```

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

<!---{pagebreak} --->

### Gebruik relationele en logische operators

We kunnen ook meerdere booleaanse expressie combineren zodat we complexere uitdrukkingen kunnen maken. Hierbij kan je gebruik maken van de logische operators (``&&``, ``||``, ``!``) .

Een voorbeeld:

```java
Console.WriteLine("Voer a in");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Voer b in");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Voer c in");
int c = int.Parse(Console.ReadLine());
 
if (a == b)
{
    Console.WriteLine("A en B zijn even groot");
}
 
if ((a > c) || (a == b))
{  
    Console.WriteLine("A is groter dan C en/of gelijk aan B");
}
 
if ((a >= c) && (b <= c))
{
    Console.WriteLine("A is groter dan of gelijk aan C en");
    Console.WriteLine("B is kleiner of gelijk aan C");
}
```

<!---{pagebreak} --->

### If/else

Met ``if``/``else`` kunnen we niet enkel zeggen welke code moet uitgevoerd worden als de conditie waar is **maar ook welke specifieke code moet uitgevoerd indien de conditie niet waar is**. Volgend voorbeeld geeft een typisch gebruik van een ``if``/``else`` structuur om 2 waarden met elkaar te vergelijken:

```java
int nummer = 10;
int max = 5;
 
if ( nummer > max )
{
         Console.WriteLine ($"Nummer is groter dan {max}!");
}
else
{
         Console.WriteLine ($"Nummer is NIET groter dan {max}!");
}
```

<!--- {width:60%} --->
![Flowchart van bovenstaande code](../assets/2_beslissingen/ifelseflow.png)

{% hint style='warning' %}
Een veel gemaakte fout is bij de ``else`` sectie ook een booleaanse expressie plaatsen. Dit kan niet: de ``else`` sectie zal gewoon uitgevoerd worden indien de ``if`` sectie NIET uitgevoerd werd. Volgende code MAG DUS NIET:
```java
if(a > b) 
{...}
else (a <= b)   //<FOUT!
{...}
```

{% endhint %}

### If/else if

Met een ``if``/``else if`` constructie kunnen we meerdere criteria opgeven die waar/niet waar moeten zijn voor een bepaald stukje code kan uitgevoerd worden. 
Sowieso begint men steeds met een ``if``. Als men vervolgens een ``else if`` plaatst dan zal de expressie van deze ``else if`` getest worden enkel en alleen als de eerste expressie (van de ``if``) niet waar was. Als de expressie van deze ``else if`` wel waar is zal de bijhorende code uitgevoerd worden, zo niet wordt deze overgeslagen.

Een voorbeeld:

```java
int x = 9;
 
if (x == 10)
{
     Console.WriteLine ("x is 10");
}
else if (x == 9)
{
     Console.WriteLine ("x is 9");
}
else if (x == 8)
{
     Console.WriteLine ("x is 8");
}
```

Voorts mag men ook steeds nog afsluiten met een finale ``else`` die zal uitgevoerd worden indien geen enkele andere expressie ervoor waar bleek te zijn:

```java
if(x>100)
{
    Console.WriteLine("Groter dan 100");
}
else if(x>10)
{
    Console.WriteLine("Groter dan 10");
}
else
{
    Console.WriteLine("Getal kleiner dan of gelijk 10");
}

```


{% hint style='warning' %}
De volgorde van opeenvolgende if/if-else tests is uiterst belangrijk. Als we in voorgaande code de twee tests omdraaien dan zal er nooit in het tweede block (``x>100``) gekomen worden. Logisch: neem een getal groter dan 100 en laat het door volgende code lopen. Stel, we nemen 110. Al bij de eerste test (``x>10``) is deze ``true`` en verschijnt er dus "Groter dan 10". Alle andere tests worden daarna niet meer gedaan en de code gaat verder na het ``else``-blok.
```java

if(x>10)
{
    Console.WriteLine("Groter dan 10");
}
else if(x>100)
{
    Console.WriteLine("Groter dan 100");
}
else
//...

```
{% endhint %}

{% hint style='tip' %}
Hoe minder tests de computer moet doen, hoe meer performant de code zal uitgevoerd worden. Voor complexe applicaties die bijvoorbeeld in realtime veel berekeningen moeten doen kan het dus een gigantische invloed hebben of een reeks ``if/if-else`` testen vlot wordt doorlopen. Het is dan ook een goede gewoonte, indien de logica van het algoritme het toelaat, om de meest voorkomende test bovenaan te plaatsen. 

Dit zelfde geldt ook binnen een test zelf wanneer we met logische operators werken. Deze worden altijd volgens de regels van de volgorde van berekeningen uitgevoerd.  Volgende test wordt van bijvoorbeeld van links naar rechts uitgevoerd:

```java
x > 100 && a != "stop"
```

Omdat beide operanden van de EN-operatie ``true`` moeten zijn om een juiste test te krijgen, zal de computer de test automatisch stoppen indien reeds de linkse operand (``x > 100``) niet waar is. Bij dit soort tests probeer je dus ervoor te zorgen dat de tests die het minste kans op slagen hebben  (of beter: het vaakst niét zal slagen) eerst te laten testen, zodat de computer geen onnodige extra tests doet.
{% endhint %}


### Nesting
We kunnen met behulp van nesting ook complexere programma flows maken. Hierbij gebruiken we de accolades om het blok code aan te duiden dat bij een ``if``/``else if``/``else`` hoort. Binnen dit blok kunnen nu echter opnieuw ``if``/``else if``/``else`` structuren worden aangemaakt.

Volgende voorbeeld toont dit aan (bekijk wat er gebeurt als je emergencyValve aan ``closed`` gelijkstelt):

```java
int reactorTemp = 1500;
string emergencyValve = " ";
 
if (reactorTemp < 1000)
{
    Console.WriteLine("Reactor temperature normal");
}
else
{
    Console.WriteLine("Reactor temperature too high!");
    if (emergencyValve == "closed")
    {
        Console.WriteLine("Reactor meltdown in progress!");
    }
}
```

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)

Laat deze tiental bladzijden uitleg je niet de indruk geven dat code schrijven met ``if``-structuren een eenvoudige job is. Vergelijk het met van je pa leren hoe je met pijl en boog moet jagen, wat vlekkeloos gaat op een stilstaande schijf, tot je in het bos voor een mammoet staat die op je komt afgestormd. *Da's andere kak hé?*

Het is dan ook aangeraden om, zeker in het begin, om steeds een flowchart te tekenen van wat je juist wilt bereiken. Dit zal je helpen om je code op een juiste manier op te bouwen (denk maar aan nesting en het plaatsen van meerdere ``if\else`` structuren in of na elkaar). *Bezint eer ge begint.*
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)

* [If](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=e1565009-be4b-4fed-a1fa-ac46009522dc)

<!---NOBOOKEND--->