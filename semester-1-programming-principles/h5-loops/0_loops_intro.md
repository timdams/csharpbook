# Loops intro

{% hint style="success" %}
[Kennisclip](https://youtu.be/kD1QJfVSXwM)
{% endhint %}

Herhalingen \(**loops**\) creëer je wanneer bepaalde code een aantal keer moet herhaald worden. Hoe vaak de herhaling moet duren is afhankelijk van de conditie die je hebt bepaald. Deze conditie is een booleaanse expressie, net zoals de conditie van `if`. 

In het vorige hoofdstuk leerden we hoe we met behulp van beslissingen onze code konden _branchen_, aftakken zodat andere code werd uitgevoerd afhankelijk van de staat van bepaalde variabelen of invoer van de gebruiker. Wat we nog niet konden was **terug naar boven** vertakken. Soms willen we dat een heel stuk code 2 of meerdere keren moet uitgevoerd worden zo lang als of totdat aan een bepaalde conditie wordt voldaan. "Voer volgende code uit tot dat de gebruiker een bepaalde waarde invoert." Dit zal bijna net hetzelfde werken als bij `if`, maar nadat je code is uitgevoerd, wordt de conditie \(opnieuw\) gecontroleerd om na te gaan of de code \(opnieuw\) moet worden uitgevoerd.

**Door herhalende code met loops te schrijven maken we onze code korter en bijgevolg ook minder foutgevoelig en beter onderhoudbaar.**

{% hint style="info" %}
Van zodra je dezelfde lijn\(en\) code onder elkaar in je code ziet staan \(door bijvoorbeeld te copy pasten\) is de kans zéér groot dat je dit korter kunt schrijven met loops.
{% endhint %}

### Soorten loops

Er zijn verschillende soorten loops:

* **Definite of counted loop**: een loop waar het aantal iteraties vooraf van gekend is. \(Bijvoorbeeld 100 keer of een aantal keer gelijk aan de waarde van de variabele `x`\).
* **Indefinite of sentinel loop**: een loop waarvan op voorhand niet kan gezegd worden hoe vaak deze zal uitgevoerd worden. Input van de gebruiker of een interne test zal bepalen wanneer de loop stopt \(bv. "Voer getallen in, voer -1 in om te stoppen"\)
* **Oneindige loop**: een loop die nooit stopt. Soms gewenst, vaak een bug.

### Loops in C\#

Er zijn 3 manieren om zogenaamde loops te maken in C\#:

* **`while`**: zal 0 of meerdere keren uitgevoerd worden
* **`do while`**: zal minimaal 1 keer uitgevoerd worden
* **`for`**: een alternatieve iets compactere manier om loops te beschrijven

