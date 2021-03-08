# Booleanse logica en operators

{% hint style="success" %}
[Kennisclip voor deze pagina](https://youtu.be/xmyvYqZYRTQ)
{% endhint %}

## Relationele operators

Om beslissingen te kunnen nemen in C\# moeten we kunnen nagaan of een bepaalde uitspraak waar of niet waar is. Anders gezegd: we moeten stukjes code kunnen schrijven waarvan we achteraf kunnen zeggen of ze "waar" of "niet waar" zijn. Zo'n stukjes code noemen we **booleaanse expressies**. De meest typische booleaanse expressies schrijf je met de **relationele operatoren**. Deze stellen vergelijkingen tussen stukjes data voor. Gelukkig ken je deze al uit het lager onderwijs en moet je alleen de notatie hieronder leren:

| C\#-syntax | Betekenis |
| :--- | :--- |
| `>` | groter dan |
| `<` | kleiner dan |
| `==` | gelijk aan |
| `!=` | niet gelijk aan |
| `<=` | kleiner dan of gelijk aan |
| `>=` | groter dan of gelijk aan |

{% hint style="warning" %}
"Gelijk aan" noteren we met twee symbolen, omdat één symbool gebruikt wordt voor een toekenning.
{% endhint %}

Deze operatoren leveren je altijd één van twee mogelijkheden als uitkomst: `true` of `false`. Je kan dit ook uittesten: `Console.WriteLine(4 < 7);` of `Console.WriteLine(4 < 2);` toont je het verwachte resultaat.

Er bestaan nog simpelere booleaanse expressies dan die met de relationele operatoren: `true` en `false` zelf zijn hun eigen resultaat en zijn dus technisch gesproken ook booleaanse expressies. Je mag dus bv. ook `true` schrijven in plaats van `4 > 2`.

## Logische operatoren

De logische EN, OF en NIET-operatoren die je misschien kent uit de lessen technologie of elektronica kan je ook gebruiken in C\#:

| C\#-syntax | Betekenis |
| :--- | :--- |
| `&&` | en-operator |
| `||` | of-operator |
| `!` | niet-operator |

Je kan de `&&`-operator tussen twee booleaanse expressies zetten om een nieuwe, grote expressie te schrijven die afhangt van de kleinere expressies aan beide kanten. Idem voor de `||`-operator. Je kan de niet-operator voor een booleaanse expressie zetten om het resultaat hiervan om te draaien. Bijvoorbeeld:

```csharp
!(0==2)  //zal true geven
	
```

Hieronder krijg je nog eens het overzicht van de werking van de AND en OR operatoren:

| AND | niet waar | waar |
| :--- | :--- | :--- |
| niet waar | niet waar | niet waar |
| waar | niet waar | waar |

| OR | niet waar | waar |
| :--- | :--- | :--- |
| niet waar | niet waar | waar |
| waar | waar | waar |

## Test jezelf

Wat zal de uitkomst zijn van volgende expressies? \(protip: het zal steeds `true` of `false` zijn, niets anders\)

* `3>2`
* `4!=4` 
* `4<5 && 4<3`
* `"a"=="a" || 4>=3`
* `(3==3 && 2<1) || 5!=4`
* `!(4<=3)`
* `true || false`
* `!true && false`

