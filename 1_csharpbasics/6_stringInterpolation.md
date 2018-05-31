# Strings samenvoegen
Je kan strings en variabelen samenvoegen tot een nieuwe string op verschillende manieren:
* +-operator
* $ string interpolation
* String.Format()

Stel dat je 2 variabelen hebt ``int age = 13`` en ``string name = "Finkelstein"`` . We willen de inhoud van deze variabelen samenvoegen in een nieuwe ``string result`` die zal bestaan uit de tekst:
```Ik ben Finkelstein en ik ben 13 jaar oud```

Volgende 3 manieren tonen hoe je steeds tot voorgaande string zal komen.

## Manier 1 String samenvoegen met de +-operator
Je kan string en variabelen eenvoudig 'bij mekaar' optellen. Ze worden dan achter mekaar geplakt als het waren. 
```csharp
string result= "Ik ben " + name + "en ik ben " + age + " jaar oud";
```
Let er op dat je tussen de aanhalingsteken (binnen de strings) spaties zet indien je het volgende deel niet 'tegen het vorige stringstuk' wilt plakken.

## * string interpolation
In de oude dagen van C# gebruiken we String.Format() om meerdere string(s) en variabelen samen te voegen tot een string. Nu kan dat met string interpolation waarbij we het $-teken gebruiken.
Door het $-teken VOOR de string te plaatsen geef je aan dat alle delen in de string die tussen accolades staan { } als code mogen beschouwd worden. Een voorbeeld maakt dit duidelijk:
```csharp
string result = $"Ik ben {name} en ik ben {age} jaar oud";
```
Zoals je kan zien is dit veel leesbaarder dan de eerste manier.

### Berekeningen doen
Je mag eender welk statement tussen de accolades zetten, denk maar aan:
```csharp
string result = $"Ik ben {name} en ik ben {age+4} jaar oud";
```

## String.Format()
String.Format is een methode die string-interpolatie toe laat op een iets minder intuïtieve manier:
```csharp
string result = String.Format("Ik ben {0} en ik ben {1} jaar oud", name, age);
```
Het getal tussen de accolades geeft aan de hoeveelste parameter na de string hier in de plaats moet gezet worden (0= de eerste, 1= de tweede, enz).

Volgende code zal dus ``Ik ben 13 en ik ben 13 jaar oud`` als resultaat geven:
```csharp
string result= String.Format("Ik ben {1} en ik ben {1} jaar oud", name, age);
```

Wens je meer informatie over string.Format, kijk dan [hier](https://codevan1001nacht.wordpress.com/2013/11/05/placeholders-aka-string-formatters/)
