<!---NOBOOKSTART--->
### De oefeningen blijven komen

Een extra grote hoop oefeningen om je loops te drillen ([originele bron](https://codeforwin.org/2015/06/for-do-while-loop-programming-exercises.html)). De oefeningen zijn gerangschikt naar moeilijkheid, je moet deze allemaal met loops oplossen! Hoe ver geraak je?

Probeer niet alle oefeningen met hetzelfde type loop te doen, wissel tussen ``while``, ``do-while`` en ``for``.
<!---NOBOOKEND--->

{% hint style='warning' %}
**Indien er sprake is van *n* in de opgave dan is dit een getal dat je eerst aan de gebruiker moet vragen.**
{% endhint %}

{% hint style='warning' %}
Opgelet: de oplossing van dit soort oefeningen vindt je overal. Weersta hier aan, en probeer ZELF de oplossing te vinden. Dat is de enige manier om dit te leren.
{% endhint %}

{% hint style='tip' %}
Niet zeker van je oplossing? Test of je met minimale aanpassing de grenzen van je programma kunt aanpassen. Als je bijvoorbeeld de getallen van 1 tot 100 moet tonen dan zou je met 2 wijzigingen maximum dit moeten kunnen aanpassen naar de getallen van -1000 tot 21234.
{% endhint %}


#### Drillen

* Toon alle natuurlijke getallen van 1 tot *n*.
* Toon alle natuurlijke getallen van *n* tot 1.
* Toon alle even getallen tussen 1 en 100.
* Toon alle oneven getallen tussen 1 en 100.
* Toon de som van alle getallen van 1 tot *n* (dus 1+2+3+4+...+n).
* Toon de som van alle even getallen van 1 tot *n*.
* Toon de som van alle oneven getallen van 1 tot *n*.
* (PRO) Schrijf een programma dat het aantal digits in een getal telt (het getal 12348 heeft bijvoorbeeld 5 digits).
* Schrijf een programma dat een ingevoerd getal als tekst uitschrijft. Als de gebruiker dus 123 invoert zal de uitvoer zijn: honderd drie en twintig.
* Schrijf een programma dat alle Unicode karakters en hun waarde toont van 10 tot *n* (tip: ``char c = Convert.ToChar(65); `` zal hoofdletter ``A`` tonen).
* Toon het alfabet van a tot z.
* Schrijf een programma dat de macht van een getal toont. De gebruiker voert eerst het getal in, gevolgd door de macht (bv. 2 en 4 zal als resultaat 16 geven (2 tot de 4e macht)). Merk op dat je geen gebruik mag maken van ``Math.Pow``. Je dient zelf de vermenigvuldiging helemaal (m.b.v. loops) uit te voeren.
* Schrijf een programma een getal *n* ontbindt in [factoren](https://nl.wikipedia.org/wiki/Factorisatie). Factoren zijn de getallen waardoor je *n* kan delen zonder rest (van  bijvoorbeeld het getal 100 zijn de factoren 1, 2, 4, 5, 10, 20, 25, 50 en 100).
* Schrijf een programma dat controleert of een getal priem is of niet.
* Toon ale priemgetallen van 1 tot *n*.
* Toon de reeks van [Fibonacci](https://en.wikipedia.org/wiki/Fibonacci_number) tot *n* termen.


#### Cooldown
* Toon alle getallen die een veelvoud van 3 zijn en oneven zijn tot en met 100.
* Toon alle machten tot 5 van *n*.
* Toon de tafels tot 10 van ieder getal van 1 tot en met *n*. Toon iedere tafel horizontaal!
  Als de gebruiker 8 invoert verschijnt er:
    <!---{line-numbers:false}--->
    ```text
    1x1=1,2x1=2,3x1=3,4x1=4,5x1=5,6x1=6,7x1=7,8x1=8, 
    ... 
    1x10=10,2x10=20,3x10=30,4x10=40,5x10=50,6x10=60,7x10=70,8x10=80, 
    ```

* Schrijf een programma om de eerste *n* termen van een harmonische reeks te tonen en bereken vervolgens de som van deze termen. Als de gebruiker bijvoorbeeld 5 invoert  verschijnt er (de laatste plus mag je tonen om geen onnodige ingewikkelde code te moeten schrijven):
    <!---{line-numbers:false}--->
    ```text
    1/1 + 1/2 + 1/3 + 1/4 + 1/5 + 
    Som = 2.283334 
    ```
* Schrijf een programma dat de som van de serie 9+99+999+9999+99999+999999 berekent (mét loop uiteraard).
* Vraag aan de gebruiker getallen tot hij -1 invoert. Toon het gemiddelde van de ingevoerde getallen.
<!---{pagebreak}--->