# Indexen in het echte leven
* achteraan in een boek (op basis van begrippen)
* telefoonboek (op basis van locatie, familienaam, voornaam)
* gouden gids (op basis van locatie, beroep, bedrijfsnaam)

---

# Voorbeeld
* tabel `Personen` met `Id`, `Voornaam`, `Familienaam`
* zoeken persoon met familienaam `Dupont`
* moet records één voor één controleren: rij 1 kan een Dupont zijn maar ook rij 1.000.000 kan een Dupont zijn

---

# Voorbeeld met indexen
* index met 1000 verschillende familienamen
* zoeken familienaam `Dupont`
* krijgen alle schijflocaties waar zich een record van een Dupont bevindt
* vereist wel dat index al is opgebouwd

---

# (Benaderde) cijfers
- 1.000.000 rijen
- 10.000 Duponts
- 1000 verschillende familienamen

## zoek alle Duponts
- zonder index: ? zoekopdrachten
- met index: ? zoekopdrachten

---

# (Benaderde) cijfers
- 1.000.000 rijen
- 10.000 Duponts
- 1000 verschillende familienamen

## zoek alle Duponts
- zonder index: 1.000.000 zoekopdrachten
- met index: < 1000 + 10.000 zoekopdrachten → minder dan 11.000
- +- factor 100
  - snelheidsverschil zal nog hoger liggen voor zeldzamere achternamen

---

# Belangrijke eigenschappen van indexen
* versnellen leesoperaties
* kunnen over meerdere kolommen van één tabel gaan
* vertragen schrijfoperaties
* moeten aangemaakt worden voor bestaande data
* moeten **strategisch** toegevoegd worden

---

# Verklaring schrijfoperaties
1) persoon gaat in stad (bv. Brussel) wonen
2) persoon wordt gedomicilieerd in Brussel
3) gegevens persoon worden opgenomen in Brussels telefoonboek
  * deze stap valt weg als er geen telefoonboek wordt uitgegeven
---

# Verklaring opstellen index voor bestaande tabel
* zoeken alle Duponts
* willen alfabetische lijst met alle achternamen raadplegen
* lijst bestaat nog niet
* **moeten** alle records doorlopen om de lijst aan te maken

---

# Voorbeeld 2: `HAVING MAX(...) ...`
```sql
select COUNT(Familienaam)
from Personen
group by Familienaam
having MAX(Leeftijd) >= 130
```
* hoeven zelfs niet in de data te kijken!

---

# Voorbeeld 3: `... JOIN ... ON ...`
* `CROSS JOIN` is erg duur
* `CROSS JOIN` met selectieve `WHERE` is goedkoper
* `JOIN` met geïndexeerde kolommen is nog beter

---

# Voorbeeld 3a: alle combinaties
* 1.000 rijen in tabel `Personen`
* 1.000 rijen in tabel `Verfsoorten`
* 1.000.000 combinaties

---

# Voorbeeld 3b: specifieker zoeken

```sql
select Personen.Naam, Verfsoorten.SpecifiekeKleur AS 'voorgestelde kleur'
from Personen
cross join Verfsoorten
where A.Lievelingskleur = 'blauw' and A.Lievelingskleur = B.BredeKleur;
```

---

## goed scenario
* maar 10 rijen in tabel `Personen` met lievelingskleur `blauw`
* maar 50 rijen in tabel `Verfsoorten` met brede kleur `blauw`
* 1000 records `Personen` doorzoeken
  * 10 records overhouden
* 1000 records `Verfsoorten` doorzoeken
  * 50 records overhouden
* 500 combinaties vormen
* totaal: +- 2500 operaties

---

# Typische indexen in MySQL
## Primaire sleutels
* fysieke ordening van de gegevens
* vaak `INT AUTO_INCREMENT`
  * record met `Id` `1` komt op schijf voor record met `Id` `2`

---

# Typische indexen in MySQL
## Unieke indexen
* geen fysieke ordening
  * is al ingenomen door primaire index
* bijkomende datastructuur die vlot doorzoekbaar wordt gehouden
  * bv. door hem te sorteren en nieuwe data meteen te sorteren
* in MySQL: `NULL` is toegelaten in een kolom met unieke index
* bv. database met planeten: unieke wetenschappelijke naam
* bv. bij ???: max. 1 X per Y, per Z

TODO: uittekenen figuur

---

# Typische indexen in MySQL
## Gewone indexen
* waarden in kolommen zijn niet noodzakelijk uniek
  * bv. familienamen

TODO: uittekenen figuur

---

# Typische indexen in MySQL
## Dalende indexen
* zoals gewone, maar gesorteerd van achter naar voor
  * bv. als we blog posts van nieuw naar oud willen doorzoeken
  * gewone zouden ook wel snelheidswinst opleveren

TODO: uittekenen figuur

---

# Typische indexen in MySQL
## Fulltext indexen
* voor kolommen met veel tekst
* elk woord wordt geïndexeerd

TODO: uittekenen figuur

---

# Welke heb ik nodig?
* hangt af van de typische gebruikspatronen voor je database
* trage queries opmeten, die optimaliseren

---

# Creëren van een gewone index
## Basis
TODO: overnemen cursus

---

# Creëren van een gewone index
## Met beperkte prefixlengte

---

# Creëren van een fulltext index

---

# Creëren van een aflopende index

---

# Verwijderen van een index
## secundaire index

## primaire index (i.e. sleutel)

---

# Verwijderen van een index
## demonstratie
### secundaire index

### primaire index (i.e. sleutel)
- let op: referentiële integriteit!

---

# Unieke indexen
## basis: de constraint
- laat mogelijk `NULL` toe! (TODO: checken)

---

# Unieke indexen
## bij aanmaak van een nieuwe tabel

---

# Unieke indexen
## voor een bestaande tabel
---

# Unieke indexen
## demonstratie

---

# Trage queries opvolgen
## stap 1: bijhouden
- `my.cnf` aanpassen
  - `slow_query_log` op `On`
  - `long_query_time` in seconden (kommagetal)
  - `slow_query_log_file`: padstring invullen
- database een tijdje op een typische manier gebruiken

---

# Trage queries opvolgen
## stap 2: uitpluizen
- sleutelwoordje `EXPLAIN` voor query plaatsen
- gedeeltelijk voorbeeld output:

| table | key | rows |
|---|---|---|
| naam van een doorzochte tabel | eventueel gebruikte index | aantal rijen doorzocht |
| naam van een andere doorzochte tabel | eventueel gebruikte index | aantal rijen doorzocht |

---

# Trage queries opvolgen
## demonstratie
TODO: voorbeeldje
