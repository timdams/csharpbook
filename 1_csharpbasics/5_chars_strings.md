# Char
Een enkele letter of getal als ‘tekst’ opslaan kan je doen door het char-type te gebruiken. Zo kan je bijvoorbeeld een enkel karakter als volgt tonen:

```csharp
char eenLetter = 'X';
Console.WriteLine("eenLetter=" + eenLetter);
```
Het is belangrijk dat je de apostrof (') niet vergeet voor en na het karakter dat je wenst op te slaan!

Je kan eender welk ASCII-teken in een char-bewaren, namelijk letters, cijfers en speciale tekens (%, $, * , #, etc.) Merk dus op dat volgende lijn: ``
char eenGetal = '7';`` Weliswaar een getal als teken opslaan, maar dat intern de compiler deze variabele steeds als een character zal gebruiken. Als je dit cijfer zou willen gebruiken als effectief cijfer om wiskundige bewerkingen op uit te voeren, dan zal je dit eerst moeten converteren naar een getal ([zie Convert en Casting](1_csharpbasics/4_converteren_casting.md)).

# String
Een string is een reeks van 0, 1 of meerdere chars, zoals je ook kan zien als je even met je muis boven een string keyword *hovert* in je code:

![](/assets/1_csharpbasics/stringenchars.png)


Alles van het type string uitleggen zou ons voorlopig te ver nemen; het is belangrijk om te beseffen nu wat het verschil is tussen een string en een karakter.

## Strings declareren
Merk op dat we bij een string literal gebruik maken van aanhalingstekens (") terwijl bij chars we een apostrof gebruiken ('). Dit is de manier om een string van een char te herkennen.

Volgende code geeft dus drie keer het cijfer 1 onder mekaar op het scherm, maar de eerste keer behelst het een char (enkelvoudig teken), dan een een string (reeks van tekens) en dan een int (effectief getal):

```csharp
char eenKarakter = '1';
string eenString = "1";
int eenGetal = 1;
 
Console.WriteLine(eenKarakter);
Console.WriteLine(eenString);
Console.WriteLine(eenGetal);
```
Fout gebruik van strings en chars: Volgende code zal dus niet compileren!

```csharp
char eenKarakter = "1";
string eenString = '1';
int eenGetal = '1';
 
Console.WriteLine(eenKarakter);
Console.WriteLine(eenString);
Console.WriteLine(eenGetal);
```
In de eerste toekenning proberen we dus een literal van het type string toe te kennen een variabele van het type char.
In de tweede toekenning proberen we een literal van het type char toe te kennen een variabele van het type string.
En in de laatste toekenning proberen we een literal van het type char toe te kennen een variabele van het type int.

# Escape characters
Naast letters en tekens mogen in string en chars ook escape characters staan. Escape characters worden met een backslash (\) gestart, gevolgd door het karakter dat we wensen te tonen. In C# hebben bepaalde tekens namelijk een speciale functie, zoals de dubbele aanhalingstekens (") om het begin of einde van een string-literal aan te geven .

Zonder aan te geven dat we letterlijk dat teken willen tonen, en het niet in z’n C# functie gebruiken, zouden we problemen krijgen.

Denk bijvoorbeeld aan de apostrof…
Volgende code zou de compiler verkeerd interpreteren, daar hij denkt dat we een leeg karakter wensen op te slaan:

```csharp
char apostrof= ''';
```
De juiste manier is om het teken dus door een backslash vooraf te laten gaan:

```csharp
char apostrof= '\'';
```
Er zijn echter nog een heleboel andere escape characters die je geregeld zal moeten gebruiken, waaronder `` \n``  om een nieuwe lijn aan te geven en \t om een tab in de tekst te plaatsen.

Bekijk deze tabel voor alle toegelaten escape characters in C#

## Escape characters in strings
We gebruiken vooral escape characters in strings, om bijvoorbeeld witregels en tabulaties aan te geven. Test bijvoorbeeld volgende lijn eens:

```csharp
string eenString = "Eerst een zin.\t dan een zin na een tab \n Dan eentje op een nieuwe regel";
```
Het is belangrijk dat je vlot kan werken met escape characters in string, daar we dit geregeld zullen nodig hebben.

## Optellen van char 
Stel dat we volgende char-variabele aanmaken. Bij string mogen we de +-operator gebruiken om 2 strings aan mekaar te plakken. Bij char mag dat niet!

```csharp
char a = 'A';
char b = 'B';
Console.WriteLine(a + b);
```
**Wanneer je deze code uitvoert dan krijg je een getal te zien?!**

Had je dit verwacht? Herinner je  dat het char-type z’n waarde als getallen bijhoudt, de zogenaamde UNICODE voorstelling van het karakter. Als de compiler het volgende ziet staan:

``eenTab + eenLetter`` 

dan zal de compiler deze twee waarden letterlijk optellen en het nieuw verkregen getal als resultaat geven. 
