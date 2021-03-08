# Char
Een **enkel karakter** (cijfer, letter, leesteken, etc.) als 'tekst' opslaan kan je doen door het `char`-type te gebruiken. Zo kan je bijvoorbeeld een enkel karakter als volgt tonen:

```csharp
char eenLetter = 'X';
Console.WriteLine("eenLetter=" + eenLetter);
```

Het is belangrijk dat je de apostrof (``'`` ) niet vergeet voor en na het karakter dat je wenst op te slaan daar dit de literal voorstelling van `char`-literals is (zie ook [hier](../1_csharpbasics/1_datatypes.md)).

Je kan eender welk [UNICODE-teken](https://en.wikipedia.org/wiki/Unicode) in een `char` bewaren, namelijk letters, cijfers en speciale tekens zoals `%`, `$`, `*`, `#`, etc. Merk dus op dat volgende lijn: ``char eenGetal = '7';`` weliswaar een getal als teken opslaat, maar dat intern de compiler deze variabele steeds als een character zal gebruiken. Als je dit cijfer zou willen gebruiken als effectief cijfer om wiskundige bewerkingen op uit te voeren, dan zal je dit eerst moeten converteren naar een getal (zie [Convert en Casting](../3_data/4_converteren_casting.md)).


# String
Een string is een reeks van 0, 1 of meerdere `char`-elementen, zoals je ook kan zien als je even met je muis boven een string keyword *hovert* in je code:

![](../assets/1_csharpbasics/stringenchars.png)

## Strings declareren
Merk op dat we bij een string literal gebruik maken van aanhalingstekens (`"`) terwijl bij chars we een apostrof gebruiken (`'`). Dit is de manier om een string van een char te onderscheiden.

Volgende code geeft dus drie keer het cijfer 1 onder elkaar op het scherm, maar de eerste keer behelst het een char (enkelvoudig teken), dan een een string (reeks van tekens) en dan een int (effectief getal):

```csharp
char eenKarakter = '1'; 
string eenString = "1"; 
int eenGetal = 1;
 
Console.WriteLine(eenKarakter);
Console.WriteLine(eenString);
Console.WriteLine(eenGetal);
```
De output van dit programma zal dan zijn:
```
1
1
1
```


Fout gebruik van strings en chars zal code geven die niet zal gecompileerd worden:

```csharp
char eenKarakter = "1"; //fout
string eenString = '1'; //fout
int eenGetal = '1'; //fout
```

1. In de eerste toekenning proberen we dus een literal van het type **string** toe te kennen een variabele van het type **char**.
2. In de tweede toekenning proberen we een literal van het type **char** toe te kennen een variabele van het type **string**.
3. In de laatste toekenning proberen we een literal van het type **char** toe te kennen aan een variabele van het type **int**.