## Relationele en logische operators

Om beslissingen te kunnen nemen in C# hebben we een nieuw soort operators nodig. Operators waarmee we kunnen testen of iets waar of niet waar is. Dit doen we met de zogenaamde **relationele operators** en **logische operators**

### Booleaanse expressies

Een booleaanse expressie is een stuk C# code dat een ``bool`` als resultaat zal geven. 

De logische en relationele operators die we hierna bespreken zijn operators die een ``bool`` teruggeven. Ze zijn zogenaamde test-operators: ze testen of iets waar is of niet.

### Relationele operators

Relationele operators zijn het hart van booleanse expressies. En guess what, je kent die al van uit het lager onderwijs! Enkel de "gelijk aan" ziet er iets anders uit dan we gewoon zijn:

| Operator| Betekenis| 
| ---------| ---------|
| ``>`` |groter dan| 
| ``<`` |kleiner dan| 
| ``==`` |gelijk aan | 
| ``!=`` |niet gelijk aan| 
| ``<=`` |kleiner dan of gelijk aan| 
| ``>=`` |groter dan of gelijk aan| 

Deze operators hebben steeds twee operands nodig en geven **een bool als resultaat terug**. Beide operanden links en rechts van de operator **moeten van hetzelfde datatype zijn** (je kan geen appelen met peren vergelijken).

Het resultaat van de expressie ``12 > 6`` zal dus ``true`` als resultaat hebben. Eenvoudig toch.

{% hint style='tip' %}
We weten al dat je het resultaat van een expressie altijd in een variabele kunt bewaren. Ook bij het gebruik van relationele operators kan dat dus:

```csharp
bool isKleiner = 65 > 67 ;
Console.WriteLine(isKleiner);
```

Er zal `false` als output op het scherm verschijnen.
{% endhint %}

### Logische operators

De logische EN, OF en NIET-operatoren die je kent van de booleaanse algebra kan je ook gebruiken in C#:

| Operator| Betekenis| 
| ---------| ---------| 
| ``&&`` |logische AND| 
| ``||`` |logische OR| 
| ``!``  |NOT| 

De logische operators geven ook steeds een ``bool`` terug maar verwachten enkel operanden van het type **``bool``**. Als je dus schrijft ``true||false``  ("true OR false") zal het resultaat ``true`` zijn.

Aangezien onze relationele operators ``bool`` als resultaat geven, kunnen we dus de uitvoer van deze operators gebruiken als operanden voor de logische operators. We gebruiken hierbij haakjes om zeker de volgorde juist te krijgen:

```csharp
bool result= (4 < 6) && ("ja" == "nee");
```
In voorgaande code zal het achterste deel ``false`` teruggeven( "ja is niet gelijk aan nee") , het eerste deel zal ``true`` geven (4 is kleiner dan 6 ). De &&-operator wordt dan: `` true && false`` wat ``false`` zal geven.

Je kan de niet-operator voor een expressie zetten om het resultaat hiervan om te draaien. Bijvoorbeeld:

```csharp
bool result = !(0==2)  //zal true geven
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
