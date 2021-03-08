# Value types en reference types

{% hint style="success" %}
[Kennisclip](https://youtu.be/lbL1i2E_4DM)
{% endhint %}

## Herinnering: gedrag van argumenten van methoden

Herinner je wat volgende code doet. Als je niet meer met absolute zekerheid kan voorspellen wat er gebeurt, herlees dan [deze pagina](../h6-methoden/parameters.md#de-verbinding-van-definitie-en-oproep). Volg alles ook nog eens met de debugger indien nodig.

```csharp
public static void VeranderGetal(int getal) {
  getal = getal - 1;
  Console.WriteLine($"Het getal is {getal}");
}

public static void Main() {
  int mijnGetal = 4;
  Console.WriteLine($"Het getal is {mijnGetal}");
  VeranderGetal(mijnGetal);
  Console.WriteLine($"Het getal is {mijnGetal}");
}
```

## Gedrag van arrays als argumenten van methoden

Voor arrays lijken de regels op het eerste zicht anders. Probeer volgende code eens uit:

```csharp
public static void VeranderArray(int[] getallen) {
  for(int i = 0; i < getallen.Length; i++) {
    getallen[i] -= 1;
  }
  for(int i = 0; i < getallen.Length; i++) {
    Console.WriteLine($"Het getal is {getallen[i]}");
  }
}

public static void Main() {
  int[] mijnGetallen = {4,3,2};
  for(int i = 0; i < mijnGetallen.Length; i++) {
    Console.WriteLine($"Het getal is {mijnGetallen[i]}");
  }
  VeranderArray(mijnGetallen);
  for(int i = 0; i < mijnGetallen.Length; i++) {
    Console.WriteLine($"Het getal is {mijnGetallen[i]}");
  }
}
```

Zoals je merkt, is het **niet** zo dat methoden geen waarden kunnen aanpassen. Er zit een uitgebreider systeem achter. Om dit te begrijpen, moeten we wat onder de motorkap van C\# kijken.

## stack, heap, value en reference

{% hint style="info" %}
Deze uitleg vereenvoudigt de zaken wat tegenover de werkelijkheid, maar hij volstaat om het gedrag van arrays te begrijpen.
{% endhint %}

We zullen dit gedrag stap voor stap uitleggen aan de hand van een voorbeeld. Dit gebeurt in de kennisclip bovenaan de pagina, maar hier zijn ook de nodige bestanden om alles zonder het filmpje zelf te herhalen en te controleren:

{% file src="../../.gitbook/assets/valuereferencedemo.zip" caption="Voorbeeldprogramma" %}

{% hint style="warning" %}
Als je programma niet uitvoert: pas in de .csproj file de tekst netcoreapp3.1 aan naargelang de versie van .NET Core die op jouw machine staat.
{% endhint %}

{% file src="../../.gitbook/assets/screenshots-voorbeeldprogramma-value-reference.zip" caption="Screenshots actieve breakpoints voorbeeldprogramma" %}

{% file src="../../.gitbook/assets/voorstelling-stack-heap-value-reference.zip" caption="Voorstelling stack en heap voor ieder actief breakpoint" %}

### Samengevat:

{% hint style="danger" %}
Hier moet je echt de kennisclip voor volgen. Normaal zijn de uitleg en de tekst evenwaardig, maar deze samenvatting staat er alleen om achteraf snel op te frissen.
{% endhint %}

* voor elke lokale variabele van een methode wordt een cel van een of meerdere bytes voorzien op de **stack**
* de grootte van een cel hangt af van het type van de variabele, dus we kunnen geen arrays \(of strings\) bijhouden in een cel
  * dit komt omdat `int[]` of `string` ons niet vertelt hoe veel data er zal zijn, het kan gaan om `{1}` en `"a"` of om `{1,2,3,4,5,6,7,8}` en `"the quick brown fox jumps over the lazy dog"`
* om deze reden houden we soms adressen bij in cellen
  * de soorten data waarvan we adressen bijhouden, heten **reference types**
  * de data zelf bevindt zich ergens anders, namelijk op de **heap**
  * datatypes waarvan lokale variabelen van methoden wel op stack kunnen, heten **value types**
* wijzigingen in een methode aan de waarde van een reference type zijn achteraf wel zichtbaar
* wijzigingen in een methode aan de waarde van een value type zijn achteraf niet meer zichtbaar
* ook arrays bestaan uit cellen en kunnen dus waarden bevatten of referenties naar waarden die zich ergens anders bevinden
  * **als je online leest dat value types op de stack horen en reference types op heap, is dat dus niet helemaal juist!**

## Defaultwaarden

Tijdens het debuggen zal je merken dat variabelen ook waarden hebben voor je ze initialiseert. Een variabele `int getal` zal starten met de waarde 0. Een geïnitialiseerde variabele voor een lege array, bijvoorbeeld `int[] getallen = new int[10]`, zal opgevuld zijn met nullen. Een variabele voor een niet-geïnitialiseerde array, bijvoorbeeld `int[] getallen;` zal de waarde `null` hebben. Dit is niet het getal `0`, maar drukt uit dat er geen waarde is.

De defaultwaarde van een variabele hangt af van het type. Onderstaande tabel geeft een overzicht:

| Type | Defaultwaarde |
| :--- | :--- |
| Elk reference type \(`string`, array,...\) | `null` |
| Elk getaltype | 0 |
| `bool` | `false` |

{% hint style="info" %}
We hebben de tabel wat ingekort. Als je hier later naar terug kijkt, gebruik dan [het volledige overzicht van Microsoft](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values).
{% endhint %}

## Reference types als returnwaarden

Eigenlijk weet je al dat je ook reference types kan teruggeven met `return`. Het type `string` is immers een reference type. Maar ook hier moet je dus in het achterhoofd houden dat je het adres van de interessante waarde doorgeeft.

Als je een reference type als return type hebt, maar je kan geen resultaat teruggeven, kan je `null` teruggeven. Je schrijft dan gewoonweg `return null`.

