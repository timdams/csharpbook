# Herhalingen

## Waarom herhalen? Waarom herhalen? Waarom herhalen?


In het vorige hoofdstuk leerden we hoe we met behulp van beslissingen onze code konden aftakken (**branchen**) zodat andere code werd uitgevoerd afhankelijk van de staat van bepaalde variabelen of invoer van de gebruiker. 

Wat we nog niet konden was **terug naar boven** vertakken. Soms willen we dat een heel stuk code 2 of meerdere keren moet uitgevoerd worden tot aan een bepaalde conditie wordt voldaan. *"Voer volgende code uit tot dat de gebruiker 666 invoert."* 

Herhalingen (**loops** of **iteraties**) creëer je wanneer bepaalde code een aantal keer moet herhaald worden. Hoe vaak de herhaling moet duren is afhankelijk van de conditie die je hebt bepaald. 

**Door herhalende code met loops te schrijven maken we onze code korter en bijgevolg ook minder foutgevoelig en beter onderhoudbaar.**


### Soorten loops

Er zijn verschillende soorten loops:
* **Definite of counted loop**: een loop waar het aantal iteraties vooraf van gekend is (bv. alle getallen van 0 tot en met 100 tonen)
* **Indefinite of sentinel loop**: een loop waarvan op voorhand niet kan gezegd worden hoe vaak deze zal uitgevoerd worden. Input van de gebruiker of een interne test zal bepalen wanneer de loop stopt (bv. "Voer getallen in, voer -1 in om te stoppen" of "Bereken de grootste gemene deler")
* **Oneindige loop**: een loop die nooit stopt. Soms gewenst (bv. de game loop) of, vaker, een bug.

{% hint style='tip' %}
Van zodra je dezelfde lijn(en) code onder elkaar in je code ziet staan (door bijvoorbeeld te copy pasten) is de kans zéér groot dat je dit korter kunt schrijven met behulp van loops.
{% endhint %}


### Loops in C#
Er zijn 3 standaard manieren om zogenaamde loops te maken in C#:
* **``while``**: zal 0 of meerdere keren uitgevoerd worden.
* **`` do while``**: zal minimaal 1 keer uitgevoerd worden.
* **``for``**: een alternatieve iets compactere manier om loops te beschrijven wanneer je exact weet hoe vaak de loop zal moeten herhalen.

Voorts zullen we ook een speciale loop variant zien in het volgende deel wanneer we arrays en objecten leren kennen:
* [**``foreach``**](../11_arraysvanklassen/3_foreach.md)


<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/gotopolice.png)

Aandacht, aandacht! Step away from the keyboard! I repeat. Step away from the keyboard.  Hierbij wil ik u attent maken op een belangrijke, onbeschreven, wet voor C# programmeurs: "**NEVER EVER USE ``goto``**"

Het moet hier alvast even uit m'n systeem. ``goto`` is weliswaar een officieel C# keyword, toch zal je het in dit boek **nooit** zien terugkomen in code. Je kan alle problemen in je algoritmes oplossen zonder ooit ``goto`` nodig te hebben. 

Voel je toch de drang: **don't!** Simpelweg, don't. Het is het niet waard. Geloof me.

**NEVER USE GOTO**.

Oh, en voor je denkt ``continue`` dan maar te gebruiken: let alsjeblieft ook op met dat keyword. Het is niet zo erg als ``goto`` én heeft geregeld z'n nut, maar ik zie het te vaak misbruikt worden. Denk dus dubbel na wanneer je denkt ``continue`` nodig te hebben.
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->






















