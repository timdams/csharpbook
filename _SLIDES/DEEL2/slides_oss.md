----
theme: uncover
----

# indentatie in Python (1)
* meeste programmeertalen: geen verschil tussen 1 of 100 spaties (buiten strings)
* Python: spaties bakenen structuur van de code af
  * geen accolades

## juist
```python
if 3 > 2:
    print('hello')
    print('world')
```

## fout
```python
if 3 > 2:
 print('hello')
     print('world')
```

----

# indentatie in Python (2)
* "indentatie" = "hoe ver code naar rechts inspringt"
* gelijke insprong = op zelfde structurele niveau

----

# `for` loops: werking
* doorlopen een reeks elementen
* komt geen index aan te pas

---

# `for` loops: syntax
```python
for <identifier> in <iterable>:
    <iets doen>
```
1: identifier: hoe je tijdelijk naar een element verwijst
2: iterable: een reeks elementen, bv. string als reeks letters
3: iets doen: heeft bijna altijd te maken met <identifier>

---

# `for` loops: voorbeeld (1)
```python
counter = 0
for letter in "abcdefghijklmnopqrstuvwxyz":
    counter = counter + 1
print(counter)
```

---

# `for` loops: voorbeeld (2)
```python
counter = 0
# met een variabele
alphabet = "abcdefghijklmnopqrstuvwxyz"
for letter in alphabet:
    counter = counter + 1
print(counter)
```

---

# lijsten: basisidee
* **geordende** reeks elementen
* dubbels zijn toegestaan
* soort elementen maakt niet uit
  * mogen in het algemeen expressies gebruiken
    * hoeven geen letterlijke waarden te zijn
    * mogen zelfs lijsten zijn

---

# lijsten: syntax
* `[1,2,3]`
* `[1,2,3,2]`
* `[1,2,(2+1),2]`
* `[]`
* `[[1,2],[3,4]]`
* `[een,twee,drie]`

---

# lijsten en `for`: voorbeeld
```python
banaan = "BANAAN!"
appel = "APPEL!"
for elem in [banaan,appel]:
    print(elem)
```

---

# functies: basisidee
* herbruikbare stukjes code
* specifieker dan scripts
  * eigen syntax
  * bieden meer flexibiliteit: kunnen toegekend worden aan variabelen,...

---

# functies: voorbeelden
* `print()`
* `pow()`
* `max()`
* `round()`

---

# functies gebruiken: syntax
* naam
* ronde haakjes
* **argumenten**, gescheiden door komma's
* bv. `print("Hello, World!")` is een **functieoproep**
* bv. `pow(3,3)` is een **functieoproep**
* **functieoproepen zijn expressies**

---

# functies gebruiken: returnwaarden (1)
* functieoproepen zijn expressies
* expressies leveren een resultaat
* dat resultaat: **returnwaarde**

---

# functies gebruiken: returnwaarden (2)
* niet altijd een resultaat
  * functieoproep kan meer een "bevel" zijn dan een "vraag"
* `None` om dit op te vangen

---

# methodes
* +- alternatieve syntax voor functies
* sterk gekoppeld aan een bepaald stukje data (een "object")
* verschil in syntax: "belangrijke" object komt vooraan
* bv. `"aBC".lower()`
* bv. `"aBC".replace("B","d")`

---

# methode: `str.split`
* verdeelt string in lijst substrings
* bv. `"cursus OS Scripting".split(" ")`
  * levert `["cursus","OS","scripting"]`
* handig om betekenisvolle onderdelen te vinden
* **methode** (van de te splitsen string)
  * "separator" is argument
---

# methode: `list.append`
```python
my_list = []
my_list.append(1)
my_list.append(2)
print(my_list)
```

---

# functie: `open`
* levert een "file object"
* kan openen voor lezen, schrijven,...
* default: lezen
* veronderstellen file op zelfde locatie als script
* file object heeft nuttige methodes

---

# `open`: syntax
```python
fh = open('myfile.txt')
# doe hier iets met fh
```

---

# methode: `close`
* **methode** (in tegenstelling tot `open`)
  * uit te voeren op file object
* niet sluiten is soms riskant

---

# `close`: syntax
```python
fh = open('myfile.txt')
# doe hier iets met fh
fh.close()
```

---

# `with`: syntax
```python
with open('myfile.txt') as fh:
    # doe hier iets met fh
```

---

# `with`: voordelen
* kan niet vergeten sluiten
* betere foutmeldingen

---

# methode: `readlines`
* methode van een file object
* syntax: `lines = fh.readlines()`
* **opgelet**: lines bevatten `"\n"`!
* heel handig voor verwerken file

---

# data omzetten
* bv. `float("1")` is `1.0`
* bv. `bool("1")` is `True`
* bv. `bool(1)` is `True`
* ...

---

# data omzetten: **functies**
* `float`, `bool`,... zijn functies
* **returnwaarde**: de omgezette waarde

---

# tekst naar getal en vice versa
* via `int`
* via `str`

---

# zelf functies schrijven
* zelf herbruikbare stukjes code maken
* gaat om **definitie**, niet om **oproep**
  * definitie: zoals omschrijving in woordenboek
  * oproep: zoals een bevel of een vraag

---

# zelf functies schrijven: syntax

```python
def <functie_naam>(<parameter_lijst>):
    # acties
```

---

# zelf functies schrijven: voorbeeld

```python
def say_hello(name):
    print("Hello, " + name + "!")
```

---

# functie oproepen: voorbeeld

```python
def say_hello(name):
    print("Hello, " + name + "!")
say_hello("Vincent")
```
---

# returnwaarde

```python
def double_number(number):
    return number * 2
```

---

# None

```python
def print_double_number(number):
    print(number * 2)
a = print_double_number(4)
print(a)
```

---

# IP-adressen inlezen
* openen van een file op de juiste manier
* inlezen van de regels
* opdelen in nuttige onderdelen
* omzetten naar getallen
* formuleren als een "vraag" die beantwoord kan worden

---

# Installatie virtualenv en virtualenvwrapper
* indien nog niet gebeurd
* commando's
  * `mkvirtualenv`
  * `lsvirtualenv`
  * `workon`

---

# modules vs. scripts
* algemeen: `.py` files
* geen technisch verschil
* scripts zijn bedoeld om uit te voeren
  * file kan module én script zijn
  * file kan niet **alleen** script zijn

---

# modules vs. packages
* module: 1 file
* package: map met verwante modules (en eventueel andere packages) in

---

# packages installeren
* opzoeken op Python package index
* virtualenv activeren (`workon`)
* `pip install package-name`

---

# modules importeren
* module `my_other_module` bevat nuttige functionaliteit
* module `my_main_module` wil deze gebruiken
* `import my_other_module` (typisch bovenaan) in `my_main_module.py`
  * kunnen nu aan nuttige functies / variabelen

---

# doorzochte locaties modules
1. map waarin `python` is gestart
2. in ingebouwde of geïnstalleerde packages

Opgelet: map waarin `python` is gestart is **niet noodzakelijk** map waarin script staat!

---

# importeren van identifiers
## syntax
`from my_other_module import useful_function`

---

# circulaire imports
Mag niet:
![](circular-import.png)

---

# `os.path`
* module voor alles wat met bestandslocaties,... te maken heeft
* gebruik ook om locaties **op te bouwen**
  * levert code die bv. op OSX en Windows werkt, ondanks verschillen

---

# `input`
* voor interactie met gebruiker
* parameter voor bericht ("prompt")
* returnwaarde: wat is ingetypt
* `raw_input()` is **Python 2**, gebruiken we niet!

---

# spam filter
* `os.listdir(path)` toont **relatieve** bestandsnamen in folder `path`
* veronderstel alleen `.txt`-bestanden
* `os.path.join` om directorynaam en bestandsnaam te koppelen
* toon of een "verboden" woord minstens één keer voorkomt in tekst
