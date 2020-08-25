# Herhalingen, herhalingen, herhaling

In het vorige hoofdstuk leerden we hoe we met behulp van beslissingen onze code konden aftakken (**branchen**) zodat andere code werd uitgevoerd afhankelijk van de staat van bepaalde variabelen of invoer van de gebruiker. 

Wat we nog niet konden was **terug naar boven** vertakken. Soms willen we dat een heel stuk code 2 of meerdere keren moet uitgevoerd worden tot aan een bepaalde conditie wordt voldaan. *"Voer volgende code uit tot dat de gebruiker 666 invoert."* 

Herhalingen (**loops** of **iteraties**) creëer je wanneer bepaalde code een aantal keer moet herhaald worden. Hoe vaak de herhaling moet duren is afhankelijk van de conditie die je hebt bepaald. 

**Door herhalende code met loops te schrijven maken we onze code korter en bijgevolg ook minder foutgevoelig en beter onderhoudbaar.**


## Soorten loops

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

Wie we daar hebben. Ik merk dat u ``goto`` flink links laat liggen. Maar uw blik op die ``continue`` baart me zorgen. Probeer dat keyword ook maar te vergeten. Het is een nuttig iets, maar kan ook verdomd misbruikt worden en ``goto``-achtige bugs genereren. Denk dus dubbel na wanneer je denkt ``continue`` nodig te hebben.
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->






















