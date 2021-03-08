# Return waarden

{% hint style="success" %}
[Kennisclip return](https://youtu.be/w2y9vKcs83o)
{% endhint %}

{% hint style="success" %}
[Kennisclip return en parameters samen](https://youtu.be/i_RX5Scb06c)
{% endhint %}

Een stappenplan, en dus een methode, voer je uit met het oog op een bepaald resultaat. Soms moet dat resultaat terugbezorgd worden aan een opdrachtgever. Soms niet. Methodes staan toe beide variaties op een stappenplan te schrijven.

We gebruiken opnieuw een proces uit het echte leven om de interactie te omschrijven voor we de sprong maken naar code.

## Voorbeeld uit het echte leven

Denk aan een ouderwetse bakker. Het stappenplan dat deze bakker volgt is er een om brood te maken. Om brood te maken heb je bloem nodig. Bloem maken is niet echt een onderdeel van het takenpakket van de bakker. Hij laat de molenaar dit voor hem doen. Hij vraagt niet gewoon aan de molenaar om bloem te **maken**, maar ook om deze aan hem te **bezorgen** zodat hij er zelf mee verder kan werken. De bakker heeft er niets aan als de molenaar bloem maakt en er verder niets mee doet.

We vertalen nu deze interactie naar code en verklaren daarna de vertaling:

{% hint style="info" %}
Dit is maar een voorbeeld om de flow te verduidelijken. Er is geen "juiste" manier om een methode te schrijven om brood te bakken \(tenzij je een broodmachine programmeert\).
{% endhint %}

```csharp
public static void Bakker() {
  // we stellen elk ingrediënt voor als string
  string ingredient1 = "water";
  string ingredient2 = "gist";
  string ingredient3 = Molenaar();
  Console.WriteLine($"Ik maak brood met {ingredient1}, {ingredient2} en {ingredient3}");
}

public static string Molenaar() {
  return "bloem";
}
```

Hier vallen twee zaken op: in de signatuur \(d.w.z. alles van het begin van de regel tot en met het gesloten ronde haakje\) van de methode Molenaar staat niet `void`, maar `string`. Dit komt omdat deze methode een resultaat **teruggeeft** aan de opdrachtgever en dat resultaat van het type `string` is. Daarnaast heb je het sleutelwoord `return`, gevolgd door de tekst `"bloem"`. Het woordje `return` betekent: "bezorg dit aan de code die deze methode heeft opgeroepen". Anders gezegd: dit is hoe de molenaar de geproduceerde bloem overhandigt aan zijn opdrachtgever, de bakker. Waar je de call `Molenaar()` schrijft komt tijdens de uitvoering het geproduceerde resultaat dankzij die `return`.

### Het `return` type

Je moet dus noteren wat voor resultaat er achter `return` staat: een string of eventueel iets anders. Als er een string volgt na `return`, zeggen we dat string het **return type** is van die methode. Als een methode een geheel getal produceert, heeft ze het return type `int` of een verwant getaltype.

Maar niet alle methodes bezorgen iets terug aan hun opdrachtgever. Sommige hebben gewoon een effect. Voor deze methodes schrijven we `void` als return type. Als een methode dit return type heeft, kunnen we het resultaat van een call dus niet toekennen aan een variabele, want er is geen resultaat.

{% hint style="warning" %}
"Er is geen resultaat" wil niet zeggen dat een `void` methode niets doet. Console.WriteLine is bijvoorbeeld een methode met return type `void`. Het punt is dat de call je niets terugbezorgt waarmee je verder kan werken. Je kan bijvoorbeeld niet schrijven: `string tekst = Console.WriteLine("Dit is tekst");`

Er is dus een groot verschil tussen `return "tekst";` en `Console.WriteLine("tekst");` Bij de eerste code is er geen garantie dat de geproduceerde tekst ooit op het scherm verschijnt, maar je kan er wel mee verder werken. Bij de tweede verschijnt hij per definitie wel op het scherm, maar kan je hem niet toekennen aan een variabele om later mee verder te werken.
{% endhint %}

We kunnen dus wel doen: `string ingredient3 = Molenaar();` \(want het return type van `Molenaar()` is `string`\) maar we kunnen niet schrijven: `string product = Bakker();` \(want `Bakker()` heeft return type `void` en produceert dus geen resultaat\). Deze code compileert dan ook niet.

### Gekend voorbeeld van een vaak gemaakte fout

Je kent de methode `Replace` van strings. Je gebruikt deze als volgt:

```csharp
string ingevoerdeTekst = Console.ReadLine();
string tekstZonderSpaties = ingevoerdeTekst.Replace(" ","");
Console.WriteLine($"Jouw tekst zonder spaties is: {tekstZonderSpaties}");
```

Veel beginners doen het volgende:

```csharp
string ingevoerdeTekst = Console.ReadLine();
ingevoerdeTekst.Replace(" ","");
Console.WriteLine($"Jouw tekst zonder spaties is: {ingevoerdeTekst}");
```

Dit is fout. `Replace` berekent het resultaat van de aanpassing en geeft dat terug aan de opdrachtgever. Het past de ingevoerde tekst niet aan. In de code van `Replace` staat dus ook een `return`!

## Parameters en returnwaarden samen

Als je parameters en returnwaarden combineert, worden methoden erg flexibel. Dan kan je al echte bouwsteentjes van een programma gaan schrijven.

Een voorbeeld: de stelling van Pythagoras vertelt ons hoe lang de schuine zijde van een driehoek met twee rechte hoeken is:

![](../../.gitbook/assets/getimage.png)

Als we deze berekening regelmatig uitvoeren voor verschillende waarden van `a` en `b`, kunnen we ze als volgt in een methode gieten:

```csharp
public static double Pythagoras(double a, double b) {
  double som = a * a + b * b;
  return Math.Sqrt(som);
}
```

Nu kunnen we heel snel allerlei schuine zijdes uitrekenen, bv.:

```csharp
public static void Main() {
  Console.WriteLine($"De schuine zijde van een driehoek met benen van 4cm en 3cm is {Pythagoras(4,3)}cm");
  Console.WriteLine($"De schuine zijde van een driehoek met benen van 12cm en 2cm is {Pythagoras(12,2)}cm");
}
```

Bovendien maken we gebruik van het feit dat de methode `Sqrt` \(_square root_ is vierkantswortel\) ook een parameter heeft en een resultaat teruggeeft. Eigenlijk verloopt een uitvoering dus zo:

1. de methode `Main` start op
2. we willen bepaalde tekst uitprinten, maar we moeten die eerst nog bepalen met de methode `Pythagoras`
3. de methode `Pythagoras` start op met de argumenten 4 en 3
4. de methode berekent de som van de kwadraten en noemt deze `som`
5. de methode maakt zelf gebruik van nog een methode, `Sqrt`, en geeft daarbij som als argument
6. `Sqrt` rekent de vierkantswortel uit en geeft deze terug aan `Pythagoras`
7. `Pythagoras` geeft deze verder door aan `Main`
8. de zin wordt correct afgeprint

Meestal is het dus een goed idee zo weinig mogelijk informatie te communiceren met `WriteLine` en zo veel mogelijk met `return` te werken. Meerbepaald: gebruik WriteLine wanneer je de uiteindelijke informatie in haar uiteindelijke vorm hebt en deze echt aan de gebruiker moet tonen. Gebruik `return` wanneer je het resultaat van een deeltaak aan een opdrachtgever wil bezorgen.

