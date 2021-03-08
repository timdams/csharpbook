# Orde in .NET

.Net is een object georiënteerde omgeving waarbij functies zijn ondergebracht in klassen. Een klasse is een geheel van methoden en eigenschappen. Je kan programma’s schrijven in C\# zonder ook maar een keer aan object georiënteerd te denken. Het is m.i. echter aangeraden vanaf het begin op een object georiënteerde manier te denken en te programmeren. Zelfs al heb je in het begin nog geen al te goed begrip van wat dat eigenlijk nu juist is.

We gaan het object georiënteerd programmeren stap voor stap bijbrengen. We beginnen hier met één aspect van object georiënteerd programmeren: orde!

![](../.gitbook/assets/image%20%281%29.png)

### 1. Een nieuw .cs bestand maken

Klassenbestand toevoegen aan je project in Visual Studio:

* Klik met de rechtermuisknop op de BeginnenMetCSharp map. In het **Add New Item** dialoogvenster kies je om een klasse toe te voegen en geef die de naam Vormen.cs.
* Het bestand Vormen.cs wordt geopend in de code editor.

### 2. Een betekenisvolle naam voor de namespace kiezen

Er zijn verschillende manieren om de code te organiseren. De keuze moet worden gebaseerd op de afspraken binnen je team en de aard van het project waaraan je werkt. Een manier om code te organiseren is met behulp van namespaces. Namespaces passen in de volgende hiërarchie:

* Namespace
  * Type
    * Type Leden

In deze hiërarchie is de namespace optioneel. Heel veel boeken tutorials besteden weinig aandacht aan namespaces en geven voorbeelden zonder gebruik te maken van namespaces.We raden aan om konsekwent namespaces te gebruiken, net zoals .NET dat zelf doet. Je kan niets in .NET gebruiken zonder eerst de namespace te vermelden waarin het het 'ding' zit dat je nodig hebt.

Wijzig de namespace in een namespace die betekenis heeft. Alle code die we gaan schrijven om C\# te leren en waarbij we de console als UI gebruiken, plaatsen we in de namespace `CSharpLerenViaDeConsole`.

Elke console-applicatie heeft een `program.cs` bestand met daarin een klasse met de naam `Program` en daarin een static void `Main(string[] args)` methode. Deze methode is de 'entry point'. Meer info daarover op [Entry Point, Wikipedia](https://en.wikipedia.org/wiki/Entry_point).

En alhoewel dit geen verplichting is, is het een goede gewoonte om deze klasse in een namespace te zetten:

```csharp
using System;

namespace CSharpLerenViaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
```

Afspraken voor het geven van een naam aan namespace:

* gebruik geen onderstrepingstekens zoals \_;
* begin de naam met een hoofdletter;
* als een namespace uit meer woorden is samengesteld, laat je de spaties tussen de woorden weg en begin je vanaf het tweede woord de eerste letter met een hoofdletter te schrijven. We noemen dit Pascal notatie.

### 3. Klassen

#### Een klasse declareren

Een klasse declareer je met het sleutelwoord **class**. Een klasse kan velden, eigenschappen en methoden bevatten. Hier introduceren we alleen maar methoden. In programmeren 1 sprak men van functies. In OOP echter spreekt men van methoden.

```csharp
using System;

namespace CSharpLerenViaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
```

Klassennamen volgen dezelfde notatieafspraken als diegene die gelden voor namespaces.

### 4. Velden in een klasse declareren

Om een veld in een klasse te declareren kan je 4 zaken bepalen

* de naam van het veld
* het gevenstype
* het bereik of de scope
* [static modifier](https://msdn.microsoft.com/nl-be/library/98f28cdx.aspx)

Afspraken voor het geven van een naam aan velden:

* gebruik geen onderstrepingstekens zoals \_;
* begin de naam met een kleine letter;
* als een veld uit meer woorden is samengesteld, laat je de spaties tussen de woorden weg, het eerste woord schrijf je met een kleine letter en de rest van de woorden beginnen met een hoofdletter. We noemen dit camelcasenotatie.

```csharp
using System;

namespace CSharpLerenViaConsole
{
    class Program
    {
        static private string naam;
        static public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        static public void SayHello()
        {
            Console.WriteLine("Hello {0}", Naam);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Naam = "Jef";
            SayHello();
            Console.ReadLine();
        }
    }
}
```

In dit voorbeeld geeft `static` aan dat het veld tot de klasse `Program` behoort en niet tot een instantie of een exemplaar van de klasse `Program`. Dit is nodig omdat de `Program` klasse zelf `static` is.

### 5. Eigenschappen of properties declareren

Om een property in een klasse te declareren kan je 5 zaken bepalen

* de naam van de eigenschap
* het retourgevenstype
* het bereik of de scope
* een impliciete `value` parameter voor de setter
* [static modifier](https://msdn.microsoft.com/nl-be/library/98f28cdx.aspx)

Eigenschapnamen volgen dezelfde notatieafspraken als diegene die gelden voor namespaces.

```csharp
using System;

namespace CSharpLerenViaConsole
{
    class Program
    {
        static private string naam;
        static public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        static public void SayHello()
        {
            Console.WriteLine("Hello {0}", Naam);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Naam = "Jef";
            SayHello();
            Console.ReadLine();
        }
    }
}
```

### 6. Eigenschappen of methoden gebruiken

Je kan de waarde van een veld met een property instellen:

```csharp
Naam = "Jef";
```

Of je kan de waarde van een veld opvragen:

```csharp
Console.WriteLine("Hello {0}", Naam);
```

### 7. Een methode in een klasse declareren

Om een methode in een klasse te declareren kan je minstens 4 zaken bepalen

* de naam van de methode
* het retourgegevenstype
* het bereik of de scope
* [static modifier](https://msdn.microsoft.com/nl-be/library/98f28cdx.aspx)

Een methode heeft net als een functie een gegevenstype. Het gegevenstype geeft aan welk soort gegevenstype door de methode geretourneerd wordt. In ons voorbeeld is dat **void**, omdat de methode niets retourneert.

Als je goed kijkt merk je dat de declaratie van de methode begint met het sleutelwoord **public**. Dit sleutelwoord bepaalt het bereik of de **scope** van de methode. Voorlopig beperken we ons tot twee scopes, namelijk **public** en **private**. **Private** wil zeggen dat de methode slechts gebruikt kan worden binnen de klasse waarin ze gedeclareerd is. **Public** wil zeggen dat andere klassen die methode ook kunnen aanroepen. Vermits we in ons voorbeeld de methode **SayHello** vanuit de **Main** methode willen oproepen moeten we ze als **public** declareren.

```csharp
using System;

namespace CSharpLerenViaConsole
{
    class Program
    {
        static private string naam;
        static public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        static public void SayHello()
        {
            Console.WriteLine("Hello {0}", Naam);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Naam = "Jef";
            SayHello();
            Console.ReadLine();
        }
    }
}
```

### 8. Een methode van een klasse gebruiken

Vooraleer je een reeds gedeclareerde klasse kan gebruiken moet je er eerst een instantie van maken. Je instantieert een klasse met het sleutelwoord **new**. Als je een instantie - ook wel exemplaar of object genoemd - hebt, kan je de publieke methoden ervan oproepen. Later zullen we zien hoe je methoden kan oproepen zonder eerst een instantie van een klasse te maken. Maar dat is nu niet aan de orde.

Methodenamen volgen dezelfde notatieafspraken als diegene die gelden voor namespaces.

In ons voorbeeld roepen we de methode **SayHello** van de klasse **MyHello** op in de **Main** methode. De **Main** methode staat in het bestand Program.cs:

```csharp
using System;

namespace CSharpLerenViaConsole
{
    class Program
    {
        static private string naam;
        static public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        static public void SayHello()
        {
            Console.WriteLine("Hello {0}", Naam);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Naam = "Jef";
            SayHello();
            Console.ReadLine();
        }
    }
}
```

### 9. Notatie afspraken

#### Namespaces, klassen, eigeschappen en methoden

We maken de volgende afspraken voor het geven van een naam aan namespaces, klassen en methoden

* gebruik geen onderstrepingstekens zoals \_;
* begin de naam met een hoofdletter;
* als een klassennaam of een methode uit meer woorden is samengesteld, laat je de spaties tussen de woorden weg en begin je vanaf het tweede woord de eerste letter met een hoofdletter te schrijven. We noemen dit Pascal notatie.

#### Velden

* gebruik geen onderstrepingstekens zoals \_;
* begin de naam met een kleine letter;
* als een veldnaam uit meer woorden is samengesteld, laat je de spaties tussen de woorden weg en begin je vanaf het tweede woord de eerste letter met een hoofdletter te schrijven. We noemen dit Camel notatie.

### Bronnen

#### Boeken

* Anders Hejlsberg, Scott Wiltamuth en Peter Golde, The C\# Programming Language. Addison-Wesley, 2006.
* Charles Petzold, Applications = Code + Markup. Microsoft Press, Redmund, 2006.
* Jeffrey Richter, CLR via C\#. Microsoft Press, Redmund, 2006.
* Sander Gerz, Visual C\# . De basis. Pearson Addison Wesley, 2010.
* Mark J. Price, C\# 7 and .NET Core: Modern Cross-Platform Development - Second Edition 2nd , 24 maart 2017

#### Websites

* Hele mooie icons, die je op Windowsformulieren kan gebruiken, vindt je op [http://www.famfamfam.com/](http://www.famfamfam.com/).

