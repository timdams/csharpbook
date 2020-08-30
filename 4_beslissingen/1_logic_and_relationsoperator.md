## Relationele en logische operators

Om beslissingen te kunnen nemen in C# hebben we een nieuw soort operators nodig. Operators waarmee we kunnen testen of iets waar of niet waar is. C# kan dan bij waar de ene actie doen, en bij niet waar iets anders (of een bepaalde stap overslaan). 

Dit doen we met de zogenaamde **relationele operators** en **logische operators**.

### Booleaanse expressies

**Een booleaanse expressie is een stuk C# code dat een ``bool`` als resultaat zal geven.**  De logische en relationele operators die we hierna bespreken zijn operators die een ``bool`` teruggeven. Ze zijn zogenaamde test-operators: ze testen of iets waar is of niet.

### Relationele operators

Relationele operators zijn het hart van booleaanse expressies. En guess what, je kent die al van uit het lager onderwijs ("de mond van holle bolle Gijs"). Enkel de "gelijk aan" ziet er iets anders uit dan we gewoon zijn:

| Operator| Betekenis| 
| ---------| ---------|
| ``>`` |groter dan| 
| ``<`` |kleiner dan| 
| ``==`` |gelijk aan | 
| ``!=`` |niet gelijk aan| 
| ``<=`` |kleiner dan of gelijk aan| 
| ``>=`` |groter dan of gelijk aan| 

Deze operators hebben steeds twee operands nodig en geven **een bool als resultaat terug**. Beide operands links en rechts van de operator **moeten van hetzelfde datatype zijn** (je kan geen appelen met peren vergelijken).

Daar dit operators zijn kan je deze dus gebruiken in eender welke expressie. Het resultaat van de expressie ``12 > 6`` zal ``true`` als resultaat hebben daar 12 inderdaad groter is dan 6. Eenvoudig toch.

{% hint style='tip' %}
We weten al dat je het resultaat van een expressie altijd in een variabele kunt bewaren. Ook bij het gebruik van relationele operators kan dat dus:

```java
bool isKleiner = 65 > 67 ;
Console.WriteLine(isKleiner);
```

Er zal `false` als output op het scherm verschijnen.
{% endhint %}

{% hint style='warning' %}
Er is een groot verschil tussen de ``=``-operator en de ``==`` operator. De eerste is de toekenningsoperator en zal de rechtse operand aan de linkse operand toewijzen. De tweede zal de linkse met de rechtse operand op gelijkheid vergelijken en een ``bool`` teruggeven.
{% endhint %}

### Logische operators

Vaak wil je meer complexe keuzes maken ("ga verder indien ik honger heb EN genoeg geld bij heb). Dit doen we met de zogenaamde  **logische operators**. Er zijn 3 operators die je hiervoor kunt gebruiken: de EN-, OF- en NIET-operators (*and, or, not*). Deze ken je mogelijk ook nog van de booleaanse algebra:

* ``&&`` (*En*) : Geeft enkel ``true`` als beide operands ``true`` zijn
* ``||`` (*Of*) :  Geeft  ``true`` indien minstens 1 operand ``true`` is
* ``!``  (*Niet*) : Inverteert de waarde van de expressie (``true`` wordt ``false en omgekeerd)

De logische operators geven ook steeds een ``bool`` terug maar verwachten enkel operanden van het type **``bool``**. Als je dus schrijft ``true||false``  ("true OF false") zal het resultaat ``true`` zijn.

Aangezien onze relationele operators ``bool`` als resultaat geven, kunnen we dus de uitvoer van deze operators gebruiken als operanden voor de logische operators. We gebruiken hierbij haakjes om zeker de volgorde juist te krijgen:

```java
bool result= (4 < 6) && ("ja" == "nee");
```

In voorgaande code zal het achterste deel ``false`` teruggeven( "ja is niet gelijk aan nee") , het eerste deel zal ``true`` geven (4 is kleiner dan 6 ). De &&-operator wordt dan: `` true && false`` wat ``false`` zal geven.

Je kan de niet-operator voor een expressie zetten om het resultaat hiervan om te draaien. Bijvoorbeeld:

```java
bool result = !(0==2)  //zal true geven in result
```

### Test jezelf
Wat zal de uitkomst zijn van volgende expressies?

* ``3>2 ``
* ``4!=4`` 
* ``4<5 && 4<3``
* ``"a"=="A" || 4>=3``
* ``(3==3 && 2<1) || 5!=4``
* ``!(4<=3)``
* ``true || false``
* ``!true && false``

<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)
* [Logische operators en expressies ](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=4602c8f9-1540-427e-8fd8-a91100bc3abb)
<!---NOBOOKEND--->
