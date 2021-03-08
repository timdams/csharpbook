# Oefening

## Methode maken

De methode `SayHello` maken.  
We hebben al gezien dat alleen de statements die in de `Main` methode staan worden uitgevoerd. We gaan in deze cursus heel wat code schrijven en dus is het geen goed idee al die code in de `Main` te plaatsen of voor elke voorbeeld of oefening, die we gaan maken, een eigen project te creëren. Vandaar dat we vanaf de eerste les met methoden leren werken. Later in de cursus gaan we dieper in op methoden \(functies\) maar nu zien we al één van de belangrijkste voordelen van het gebruik van methoden, namelijk de code ordenen in kleinere stukjes.

![SayHello methode](../../.gitbook/assets/image%20%2829%29.png)

1. We halen dus het statement uit de `Main` methode en plaatsen die in een eigen methode. Een methode moet in een klasse staan. We plaatsen voorlopig de `SayHello` methode in dezelfde klasse als de `Main` methode, namelijk de `Program` klasse.
2. We roepen de `SayHello` methode op in de `Main` methode.

## Nog een methode maken

De `Say` methode maken en oproepen.  
We gaan nu nog een stap verder en lichten een ander voordeel toe van het gebruik van functies, namelijk het kunnen parametriseren. Daarmee bedoel ik dat we een functie gaan schrijven doe niet alleen _Hello World_ kan zeggen maar om het even wat.

![Say input-function-output](../../.gitbook/assets/image%20%2838%29.png)

1. De methode is `static` omdat we alleen met klassen werken en niet met objecten of exemplaren van klassen. Met objecten werken we pas later.
2. Het gegevenstype van de methode is `void` omdat die methode niets retourneert. Deze methode toont een tekst op het scherm.
3. We voegen aan de `Say` methode een parameter toe. We plaatsen die parameter tussen de ronde haken na de naam van de methode.
4. De naam van de parameter is `tekst`. Parameternamen schrijven we in camelcase. Bedrijven gaan meestal namen voor parameters in het Engels schrijven. Dat gaan we ook doen. Maar in het begin gebruik ik Nederlandse namen om duidelijk aan te geven dat dit namen \(identifiers\) zijn die je zelf kiest. Op die manier is er een duidelijk onderscheid tussen eigen gekozen namen en sleutelwoorden en namen uit bibliotheken.
5. In C\# moet je opgeven welk soort gegevens je aan de parameter wilt meegeven. Je moet je afvragen of je een getal of een tekst wilt meegeven. In de `Say` methode geven we een tekst mee. Daarvoor beschikt C\# over het `string` gegevenstype. In een volgende les gaan we dieper in op gegevenstypes.
6. De statements in een methode staan tussen accolades { }. Dat heet een codeblok.
7. Het statement die de tekst weergeeft in de console. Een statement eindigt met een ; \(puntkomma\)!
8. We roepen de eerste keer de `Say` methode op in de `Main` methode en geven als argument de naam van een filosoof mee. De tekst is een string en moet tussen dubbele haken staan.
9. We roepen die nogmaals op en geven als argument de naam van een zanger mee. De tekst is een string en moet tussen dubbele haken staan.
10. En om het af te leren, nog een derde keer met als argument de naam van de school. De tekst is een string en moet tussen dubbele haken staan.

