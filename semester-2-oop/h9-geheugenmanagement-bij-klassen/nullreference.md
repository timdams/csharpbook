# Defaultwaarden en NullReferenceException

## Defaultwaarden van value types

Elk type heeft een eigen defaultwaarde. Dit is de waarde van niet-geïnitialiseerde variabelen, inclusief niet-geïnitialiseerde array elementen. Onderstaande tabel geeft ze weer voor de soorten types die wij kennen:

| type | waarde |
| :--- | :--- |
| elk getaltype \(`int`, `float`,...\) | 0 |
| `char` | 0 \(= symbool met nummer 0\) |
| `bool` | `false` |
| `enum` types | de eerste waarde van dat type |
| `DateTime` | een tijdstip met 0 ticks |
| alle reference types | `null` |

## Null en NullReferenceException

Zoals nu duidelijk is bevatten variabelen steeds een referentie naar een object. Maar wat als we dit schrijven:

```csharp
Student stud1;
stud1.Naam= "Test";
```

Dit zal een fout geven. `stud1` bevat namelijk nog geen referentie. Maar wat dan wel?

Deze variabele bevat de waarde **`null`** . Dit is de defaultwaarde voor reference types. Met andere woorden, als je een reference type declareert en niet initialiseert, zal de waarde `null` zijn.

{% hint style="info" %}
Visual Studio voorkomt sommige voorkomens van niet-geïnitialiseerde variabelen. Maar niet allemaal. Bovendien is het Visual Studio dat dit voorkomt, niet C\#. Dus je moet er echt wel op letten.
{% endhint %}

### NullReferenceException

Een veel voorkomende foutboodschap tijdens de uitvoer van je applicatie is de zogenaamde `NullReferenceException` . Deze zal optreden wanneer je code een member \(attribuut, methode of property\) van `null` probeert op te vragen.

Laten we dit eens simuleren:

```csharp
Student stud1 = null;
Console.WriteLine(stud1.Name);
```

Dit zal resulteren in volgende foutboodschap:

![NullReferenceException error in VS](../../.gitbook/assets/nullref%20%282%29.png)

> We moeten in dit voorbeeld expliciet `=null` plaatsen daar Visual Studio slim genoeg is om je te waarschuwen voor eenvoudige potentiele NullReference fouten en je code anders niet zal compileren.

### NullReferenceException voorkomen

Objecten die niet bestaan zullen altijd `null`. Uiteraard kan je niet altijd al je code uitvlooien waar je misschien `=new SomeObject();` bent vergeten.

Voorts kan het ook soms by design zijn dat een object `null` is. Gelukkig kan je controleren of een object `null` is als volgt:

```csharp
if(stud1 is null)
    Console.WriteLine("oei. object bestaat niet")
```

{% hint style="warning" %}
Waarom `is null` en niet `== null`? Die vraag leidt ons te ver. Meestal zal `== null` ook werken, maar `==` kan aangepast worden om anders te werken dan gewoonlijk. `is` is dus betrouwbaarder.
{% endhint %}

### Return null

Uiteraard mag je dus ook expliciet soms `null` teruggeven als resultaat van een methode. Stel dat je een methode hebt die in een array een bepaald object moet zoeken. Wat moet de methode teruggeven als deze niet gevonden wordt? Inderdaad, we geven dan `null` terug.

Volgende methode zoekt in een array van studenten naar een student met een specifieke naam en geeft deze terug als resultaat. Enkel als de hele array werd doorlopen en er geen match is wordt er `null` teruggegeven \(de werking van arrays van objecten worden later besproken\):

```csharp
static Student ZoekStudent(Student[] array, string naam)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Name == naam)
            return array[i];
    }

    return null;
}
```

