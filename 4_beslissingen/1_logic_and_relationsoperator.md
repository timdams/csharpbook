# Relationele operators
Om beslissingen te kunnen nemen in C# hebben we een nieuw soort operators nodig. Operators waarmee we kunnen testen of iets waar of niet waar is. Dit doen we met de zogenaamde **relationele operators**. En guess what, je kent die al van uit het lager! Enkel de "gelijk aan" ziet er iets anders uit dan we gewoon zijn:


| C#-syntax| Betekenis| 
| ---------| ---------
| ``>`` |groter dan| 
| ``<`` |kleiner dan| 
| ``==`` |gelijk aan | 
| ``!=`` |niet gelijk aan| 
| ``<=`` |kleiner dan of gelijk aan| 
| ``>=`` |groter dan of gelijk aan| 

# Logische operator
De logische EN, OF en NIET-operatoren die je kent van de booleaanse algebra kan je ook gebruiken in C#:

| C#-syntax| Betekenis| 
| ---------| ---------| 
| ``&&`` |en-operator| 
| <code>&#124;&#124;</code> |of-operator| 
| ``!``  |niet-operator| 

Je kan de niet-operator voor een expressie zetten om het resultaat hiervan om te draaien. Bijvoorbeeld:
```csharp
!(0==2)  //zal true geven
```
## Booleaanse expressies

Een booleaanse expressie is een stuk C# code dat een ``bool`` als resultaat zal geven. 

De logische operators van hierboven zijn operators die een ``bool`` teruggeven. Ze zijn zogenaamde test-operators: ze testen of iets waar is of niet.
"Is b kleiner dan c?" schrijf je dan als de booleaanse expressie: ``b<c``

Test maar eens wat er op je scherm komt als je in code schrijft: ``Console.WriteLine(45<=55);``. 

Zoals verwacht zal er ``true`` op het scherm verschijnen.


# Test jezelf
Wat zal de uitkomst zijn van volgende expressies? (protip: het zal steeds ``true`` of ``false`` zijn, niets anders)
* ``3>2  ``
* ``4!=4`` 
* ``4<5 && 4<3 ``
* ``"a"=="a" || 4>=3  ``
* ``(3==3 && 2<1) || 5!=4 ``
* ``!(4<=3) ``
* ``true || false ``
* ``!true && false ``

>Voorgaande oefeningen komen uit een kennistoets examen. Het is voornaam dat je dit soort expressies vlot kunt oplossen!

# Kennisclip
![](../assets/infoclip.png)
* [Logische operators en expressies ](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=4602c8f9-1540-427e-8fd8-a91100bc3abb)
