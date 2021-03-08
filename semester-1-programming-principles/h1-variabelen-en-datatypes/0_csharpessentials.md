# De essentie van C\#

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=b318b7fa-fa9e-427c-81c8-acdd00a45b3d)
{% endhint %}

## Statements en de C\# syntax

Om een werkend C\#-programma te maken moeten we de C\#-taal beheersen. Net zoals iedere taal, bestaat ook C\# uit enerzijds grammatica, in de vorm van de **C\# syntax** en anderzijds vocabulair in de vorm van de te gebruiken **keywords**.

Een C\#-programma bestaat uit een opeenvolging van instructies ook wel **statements** genoemd. **Deze eindigen steeds met een puntkomma \(`;`\)** \(zoals ook in het Nederlands een zin eindigt met een punt\).

De volgorde van de woorden \(keywords, variabelen, etc.\) zijn niet vrijblijvend en moeten aan \(grammaticale\) regels voldoen. Enkel indien alle statements correct zijn zal het programma gecompileerd worden naar een werkend en uitvoerbaar programma \(zoals in een vorige sectie besproken\).

Enkele belangrijke regels van C\#:

* **Hoofdletter-gevoelig**: C\# is hoofdlettergevoelig. Dat wil zeggen dat hoofdletter `T` en kleine letter `t` totaal verschillende zaken zijn voor C\#. `Reinhardt` en `reinhardt` zijn dus ook niet hetzelfde.
* **Statements afsluiten met puntkomma**: Iedere C\# statement wordt afgesloten moet een puntkomma \( **`;`** \). Doe je dat niet dan zal C\# denken dat de regel gewoon op de volgende lijn doorloopt en deze als één \(fout\) geheel proberen te compileren.
* **Witruimtes**: Spaties, tabs en enters worden door de C\# compiler genegeerd. Je kan ze dus gebruiken om de layout van je code  \(_bladspiegel_ zeg maar\) te verbeteren. De enige plek waar witruimtes wél een verschil geven is tussen aanhalingstekens `"      "` die we later \(bij string\) zullen leren gebruiken.
* **Commentaar toevoegen kan**: met behulp van `//` voor een enkele lijn en `/*         */` voor meerdere lijnen commentaar. Alles dat in commentaar staat zal door de compiler genegeerd worden.

## Keywords: de woordenschat

C\# bestaat zoals gezegd niet enkel uit grammaticale regels. Grammatica zonder woordenschat is nutteloos. Er zijn binnen C\# dan ook 80 woorden, zogenaamde **reserved keywords** die de woordenschat voorstellen. In deze cursus zullen we stelselmatig deze keywords leren kennen en gebruiken op een correcte manier om zo werkende code te maken.

Deze keywords zijn:

|  |  |  |  |
| :--- | :--- | :--- | :--- |
| _abstract_ | _as_ | _base_ | **bool** |
| **break** | **byte** | **case** | catch |
| **char** | checked | _class_ | **const** |
| continue | **decimal** | _default_ | delegate |
| **do** | **double** | **else** | **enum** |
| event | explicit | extern | **false** |
| finally | fixed | **float** | **for** |
| _foreach_ | goto | **if** | implicit |
| _in_ | **int** | _interface_ | internal |
| _is_ | lock | **long** | **namespace** |
| _new_ | _null_ | _object_ | _operator_ |
| **out** | _override_ | params | _private_ |
| _protected_ | _public_ | readonly | **ref** |
| **return** | **sbyte** | _sealed_ | **short** |
| sizeof | stackalloc | _static_ | **string** |
| _struct_ | **switch** | _this_ | throw |
| **true** | try | typeof | **uint** |
| **ulong** | unchecked | unsafe | **ushort** |
| using | using static | _virtual_ | **void** |
| volatile | **while** |  |  |

{% hint style="info" %}
De keywords in vet zijn keywords die we dit semester zullen kennen. Die in cursief in het tweede semester. De overige zal je zelf moeten leren ;\).
{% endhint %}

{% hint style="info" %}
Indien je deze tabel in pdf bekijkt zal deze om zeep zijn. Onze gitbook gnomes proberen dit op te lossen maar voorlopig vinden ze helaas geen oplossing, waarvoor onze excuses.
{% endhint %}

## Variabelen, identifiers en naamgeving

We hebben variabelen nodig om \(tijdelijke\) data in op te slaan. Wanneer we een statement schrijven dat bijvoorbeeld input van de gebruiker moet vragen, dan willen we ook die input bewaren zodat we verderop in het programma \(het algoritme\) iets met deze data kunnen doen. We doen hetzelfde in ons hoofd wanneer we bijvoorbeeld zegen "tel 3 en 4 op en vermenigvuldig dat resultaat met 5". Eerst zullen we het resultaat van 3+4 in een variabele moeten bewaren. Vervolgens zullen we de inhoud van die variabele vermenigvuldigen met 5 en dat nieuwe resultaat ook in een nieuwe variabele opslaan \(om vervolgens bijvoorbeeld naar het scherm te sturen\).

Wanneer we een variabele aanmaken zal deze moeten voldoen aan enkele afspraken. Zo moeten we minstens 2 zaken meegeven:

* Het type van de variabele: het **datatype**  dat aangeeft wat voor data we wensen op te slaan \(tekst, getal, afbeelding, etc.\).
* De naam van de variabele: de **identifier** waarmee we snel aan de variabele-waarde kunnen.

De verschillende datatypes bespreken we in een volgend [hoofdstuk](1_datatypes.md).

### Regels voor identifiers

De code die we gaan schrijven moet voldoen aan een hoop regels. Wanneer we in onze code zelf namen \(**identifiers**\) moeten geven aan **variabelen** \(en later ook methoden, objecten, etc.\) dan moeten we een aantal regels volgen:

* **Hoofdlettergevoelig**: de identifiers `tim` en `Tim` zijn verschillend zoals reeds vermeld.
* **Geen keywords**: identifiers mogen geen gereserveerde C\# keywords zijn. De keywords van hierboven mogen dus niet. Varianten waarbij de hoofdletters anders zijn mogen wel, bijvoorbeeld: `gOTO` en `stRINg` mogen dus wel, maar niet `goto` of `string` daar beide een gereserveerd keyword zijn maar dankzij de hoofdlettergevoelig-regel is dit dus toegelaten. `INT` mag ook ook, maar niet `int`.
* **Eerste karakter-regel**: het eerste karakter van de identifier mag enkel zijn:
  * kleine of grote letter
  * liggend streepje \(`_`\)
* **Alle andere karakters-regels**: de overige karakters mogen enkel zijn:
  * kleine of grote letter
  * liggend streepje
  * een cijfer \(`0` tot en met `9`\)
* **Lengte**: Een legale identifier mag zo lang zijn als je wenst, maar je houdt het best leesbaar.

#### Enkele voorbeelden

Enkele voorbeelden van toegelaten en niet toegelaten identifiers:

| identifier | toegelaten? | uitleg indien niet toegelaten |
| :--- | :--- | :--- |
| werknemer | ja |  |
| kerst2018 | ja |  |
| pippo de clown | neen | geen spaties toegestaan |
| 4dPlaats | neen | mag niet starten met getal |
| \_ILOVE2019 | ja |  |
| Tor+Bjorn | neen | enkel cijfers, letters en liggende streepjes toegestaan |
| ALLCAPSMAN | ja |  |
| B\_A\_L | ja |  |
| class | neen | gereserveerd keyword |
| WriteLine | ja |  |

### Naamgeving afspraken

Er zijn geen vaste afspraken over hoe je je variabelen moet noemen toch hanteren we enkele **coding guidelines** die doorheen je opleiding moeten gevolgd worden. Naarmate we meer C\# leren zullen er extra guidelines bijkomen \(zie [deze pagina met richtlijnen](../../inleiding/afsprakencode.md)\).

* **Duidelijke naam**: de identifier moet duidelijk maken waarvoor de identifier dient. Schrijf dus liever `gewicht` of `leeftijd` in plaats van `a` of `meuh`.
* **Camel casing**: gebruik camel casing indien je meerdere woorden in je identifier wenst te gebruiken. Camel casing wil zeggen dat ieder nieuw woord terug met een hoofdletter begint. Een goed voorbeeld kan dus zijn `leeftijdTimDams` of `aantalLeerlingenKlas1EA`. Merk op dat we liefst het eerste woord met kleine letter starten. Uiteraard zijn er geen spaties toegelaten.
* **Pascal casing**: Zoals camel casing, maar ook de eerste letter is een hoofdletter. Gebruik dit voor namespaces, klassen en voor methodes waarbij je `public` zet.

## Commentaar

Soms wil je misschien extra commentaar bij je code zetten. Als je dat gewoon zou doen \(bv `Dit deel zal alles verwijderen`\) dan zal je compiler niet begrijpen wat die zin doet. Hij verwacht namelijk C\# en niet een Nederlandstalige zin. Om dit op te lossen kan je in je code op twee manieren aangeven dat een stuk tekst gewoon commentaar is en mag genegeerd worden door de compiler:

### Enkele lijn commentaar

Eén lijn commentaar geef je aan door de lijn te starten met twee voorwaartse slashes `//`. Uiteraard mag je ook meerdere lijnen op deze manier in commentaar zetten. Zo wordt dit ook vaak gebruikt om tijdelijk een stuk code "uit te schakelen". Ook mogen we commentaar _achter_ een stuk C\# code plaatsen \(zie voorbeeld hieronder\).

```csharp
//De start van het programma
int getal=3;
//Nu gaan we rekenen
int result = getal * 5;
// result= 3*5;
Console.WriteLine(result); //We tonen resultaat op scherm: 15
```

### Blok commentaar

We kunnen een stuk tekst als commentaar aangeven door voor de tekst `/*` te plaatsen en `*/` achteraan. Een voorbeeld:

```csharp
/*
    Veel commentaar.
    Een heel verhaal
    Mooi he.
    Is dit een haiku?
*/
int leeftijd= 0;
leeftijd++;
```

