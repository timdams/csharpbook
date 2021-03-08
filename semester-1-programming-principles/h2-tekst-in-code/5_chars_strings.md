# Strings en chars

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/rSsptVzzAhk)
{% endhint %}

## Char

Een **enkel karakter** \(cijfer, letter, leesteken, etc.\) als 'tekst' opslaan kan je doen door het `char`-type te gebruiken. Zo kan je bijvoorbeeld een enkel karakter als volgt tonen:

```csharp
char eenLetter = 'X';
Console.WriteLine(eenLetter);
```

Het is belangrijk dat je de apostrof \(`'` \) niet vergeet voor en na het karakter dat je wenst op te slaan daar dit de literal voorstelling van `char`-literals is \(zie ook [hier](../h1-variabelen-en-datatypes/1_datatypes.md)\).

Je kan alle karakters uit deze [UTF-16](http://www.fileformat.info/info/charset/UTF-16/list.htm) tabel bewaren in een `char`. Merk op dat een `char` altijd het symbool aanduidt en niet de achterliggende waarde. Met andere woorden, `char eenCijfer = '7';` bevat een cijfer, maar dit cijfer is alleen de "tekening" van het getal. Het is niet het _getal_ 7 en je kan er niet mee rekenen op de gewoonlijke manier.

{% hint style="info" %}
De tabel bevat geen emoji of andere speciale karakters die je soms toch op je scherm ziet. Kan je daar dan niet mee werken in C\#? Antwoord: het gaat wel, maar er komt een pak meer achtergrondinfo bij kijken. Dat laten we voor meer gevorderd materiaal.
{% endhint %}

## String

Een string is een reeks van 0, 1 of meerdere `char`-elementen, zoals je ook kan zien als je even met je muis boven een string keyword _hovert_ in je code:

![](../../.gitbook/assets/stringenchars%20%282%29.png)

### Strings declareren

Merk op dat we bij een string literal gebruik maken van aanhalingstekens \(`"`\) terwijl bij chars we een apostrof gebruiken \(`'`\). Dit is de manier om een string van een char te onderscheiden.

Volgende code geeft dus drie keer het cijfer 1 onder elkaar op het scherm, maar de eerste keer gaat het om de weergave van een `char` \(enkelvoudig teken\), dan van een `string` \(reeks van tekens\) en dan van een `int` \(effectief getal\):

```csharp
char eenKarakter = '1'; 
string eenString = "1"; 
int eenGetal = 1;

Console.WriteLine(eenKarakter);
Console.WriteLine(eenString);
Console.WriteLine(eenGetal);
```

De output van dit programma zal dan zijn:

```text
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

