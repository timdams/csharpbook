# Oefeningen deel 2

Een extra grote hoop oefeningen om je loops te drillen \([originele bron](https://codeforwin.org/2015/06/for-do-while-loop-programming-exercises.html)\). De oefeningen zijn gerangschikt naar moeilijkheid, je moet deze allemaal met loops oplossen! Hoe ver geraak je?

Probeer niet alle oefeningen met hetzelfde type loop te doen, wissel tussen `while`, `do...while` en `for`.

**Indien er sprake is van** _**n**_ **in de opgave dan is dit een getal dat je eerst aan de gebruiker moet vragen.**

> Opgelet: de oplossing van dit soort oefeningen vind je overal. Weersta hier aan, en probeer ZELF de oplossing te vinden. Dat is de enige manier om dit te leren.

Noem de methodes `OpwarmerPlusEen`, `OpwarmerPlusTwee`,...

1. Toon alle natuurlijke getallen van 1 tot _n_.
2. Toon alle natuurlijke getallen van _n_ tot 1.
3. Toon alle even getallen tussen 1 en 100.
4. Toon alle oneven getallen tussen 1 en 100.
5. Toon de som van alle getallen van 1 tot _n_ \(dus 1+2+3+4+...+n\).
6. Toon de som van alle even getallen van 1 tot _n_.
7. Toon de som van alle oneven getallen van 1 tot _n_.
8. Schrijf een programma dat het aantal digits in een getal telt \(het getal 12348 heeft bijvoorbeeld 5 digits\). Het is de bedoeling dat je dit doet met een loop, dus niet door het getal als tekst te behandelen. Hint: flowchart onder deze reeks oefeningen.
9. \(PRO\) Schrijf een programma dat een ingevoerd getal als tekst uitschrijft. Als de gebruiker dus 123 invoert zal de uitvoer zijn: honderd drie en twintig.
10. Schrijf een programma dat alle ascii karakters en hun waarde toont van 10 tot _n_ \(tip: `char c = Convert.ToChar(65);` zal hoofdletter `A` tonen\) 
11. Toon het alfabet van a tot z.
12. Schrijf een programma dat de macht van een getal toont. De gebruiker voor eerst het getal in, gevolgd door de macht \(bv 2 en 4 zal als resultaat 16 geven \(2 tot de 4e\)\).
13. Schrijf een programma een getal _n_ ontbindt in [factoren](https://nl.wikipedia.org/wiki/Factorisatie). Factoren zijn de getallen waardoor je _n_ kan delen zonder rest \(van  bijvoorbeeld het getal 100 zijn de factoren 1,2,4,5,10,20,25,50,100  \).
14. Toon de reeks van [Fibonacci](https://en.wikipedia.org/wiki/Fibonacci_number) tot _n_ termen.

{% file src="../../.gitbook/assets/flowchartaantalcijfers.pdf" caption="flowchart aantal cijfers" %}

## Oefening: H6-priem-checker

### Leerdoelen

* lussen gebruiken om een resultaat op te bouwen
* flowchart gebruiken

### Functionele analyse

Je krijgt een getal van de gebruiker. Je moet nagaan of dit een priemgetal is, d.w.z. of het precies 2 gehele delers heeft.

### Technische analyse

Elk geheel getal vanaf 2 heeft minstens 2 gehele delers: 1 en zichzelf. Als dat de enige delers van het gegeven getal zijn, is het priem. Je kan dus nagaan of een getal een priemgetal is door alle getallen vanaf 2 tot het getal zelf te overlopen en na te gaan of deze delers zijn van het getal. \(Eigenlijk volstaat het minder getallen te checken maar daar draait het hier niet om.\) Noem je methode `PriemChecker`. **Je mag veronderstellen dat de gebruiker minstens 2 intypt.**

Je krijgt een flowchart om te helpen.

{% file src="../../.gitbook/assets/flowchartpriem.pdf" caption="flowchart priemchecker" %}

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Geef een getal
> 1
Het getal is geen priemgetal!
```

```text
Geef een getal
> 2
Het getal is een priemgetal!
```

```text
Geef een getal
> 6
Het getal is geen priemgetal!
```

```text
Geef een getal
> 7
Het getal is een priemgetal!
```

## Oefening: H6-priem-generator

### Leerdoelen

* geneste lussen gebruiken om een meerdere resultaten te laten zien

### Functionele analyse

Je krijgt een getal van de gebruiker. Je moet alle priemgetallen kleiner of gelijk aan dit getal laten zien.

### Technische analyse

Je kan het idee uit de vorige oefening herbruiken, maar nu zijn de getallen die je controleert niet afgeleverd door de gebruiker. Je moet ze zelf genereren in een `for`-lus. Als je in de vorige oefening een `for`-lus hebt gebruikt, zal je dus twee `for`-lussen moeten nesten.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Geef een getal
> 11
Alle priemgetallen kleiner dan of gelijk aan 11 zijn:
2
3
5
7
11
```

