# Oefeningen

## Oefening: H0-eerste-programma

### Leerdoelen

* een eigen programma kunnen uitvoeren
* input en output via `Console.ReadLine` en `Console.WriteLine`

### Functionele analyse

Binnen een zgn. dos-box wordt een titel weergegeven, nl. dit is mijn eerste c\# programma.

Vervolgens wordt gevraagd je naam te noteren.

Wanneer je je naam hebt genoteerd en op enter hebt gedrukt, verschijnt de tekst “hallo \[en je ingegeven naam\]”.

### Technische analyse

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

![](../../.gitbook/assets/image%20%283%29.png)

### Technische hulp

#### Programmaverloop

Wat het lezen en schrijven van tekst betreft moet gebruik gemaakt worden `Console.WriteLine` en `Console.ReadLine`.

#### Testscenario's

* Probeer meer dan 200 tekens in te voeren
* Probeer geen tekst in te voeren

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H0-eerste-programma-pro

### Leerdoelen

* een eigen programma kunnen uitvoeren
* input en output via `Console.ReadLine` en `Console.WriteLine`
* herhaling van de leerdoelen uit H0-eerste-programma

### Functionele analyse

Binnen een zgn. dos-box wordt een titel weergegeven, nl. dit is mijn eerste c\# programma.

Vervolgens wordt gevraagd je voornaam te noteren. Wanneer je je voornaam hebt genoteerd en op enter hebt gedrukt, wordt gevraagd je achternaam te noteren.

Wanneer je je achternaam hebt genoteerd en op enter hebt gedrukt, verschijnt de tekst “dus je naam is: \[en je ingegeven achternaam en voornaam\]”. Op de regel daaronder verschijnt dan de tekst “of: \[en je ingegeven voornaam en achternaam\]”.

Het is dus duidelijk dat we de naam zowel beginnend met de voor- als de achternaam kunnen tonen.

### Technische analyse

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

![](../../.gitbook/assets/image%20%284%29.png)

### Technische hulp

#### Programmaverloop

Wat het lezen en schrijven van tekst betreft moet gebruik gemaakt worden `Console.WriteLinea` en `Console.ReadLine`.

#### Testscenario's

* Probeer meer dan 200 tekens in te voeren
* Probeer geen tekst in te voeren

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H0-rommelzin

### Leerdoelen

* een eigen programma kunnen uitvoeren
* input en output via `Console.ReadLine` en `Console.WriteLine`
* de computer leren zien als "domme verwerker"

### Functionele analyse

Dit programma verwerkt tekst die door de gebruiker wordt ingetypt. Het print nieuwe berichten die deze tekst bevatten uit. Het print niet de berichten die je verwacht: het zal de antwoorden door elkaar halen en je favoriete kleur tonen wanneer het beweert je favoriete eten te tonen, enzovoort. De verbanden worden duidelijk uit de voorbeeldinteractie.

### Technische analyse

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Wat is je favoriete kleur?
> blauw
Wat is je favoriete eten?
> spaghetti
Wat is je favoriete auto?
> Toyota Aygo
Wat is je favoriete film?
> Robocop 2
Wat is je favoriete boek?
> The Gone-Away World
Je favoriete kleur is spaghetti. Je eet graag Toyota Aygo. Je lievelingsfilm is The Gone-Away World en je favoriete boek is Robocop 2.
```

### Technische hulp

#### Programmaverloop

Per regel die getoond wordt op het scherm, maak je gebruik van `Console.WriteLine`. Per regel die je zelf intypt, maak je gebruik van `Console.ReadLine`. Zorg zelf voor de juiste ondersteunende code.

#### Testscenario's

* Test uit met een héél lang stuk tekst \(meer dan 200 tekens\) voor je favoriete kleur.
* Test uit met tekst met internationale karakters, bijvoorbeeld de ç.
* Ga na wat er gebeurt als je een lege regel invoert, dus als je meteen op ENTER duwt wanneer gevraagd wordt om invoer.

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H0-gekleurde-rommelzin

### Leerdoelen

* de kleur van tekst in de console aanpassen
* herhaling van de leerdoelen uit H0-rommelzin

### Functionele analyse

Dit programma werkt net als H0-rommelzin, maar elke regel die aan de gebruiker wordt getoond, krijgt een andere kleur. De namen van de kleuren die je gebruikt \(in deze volgorde\) zijn:

1. `DarkGreen`
2. `DarkRed`
3. `DarkYellow`
4. `Blue`
5. `Cyan`
6. `Red`

### Technische analyse

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

![De eerste regel behoort niet tot het programma. De rest moet er bij jou hetzelfde uitzien.](../../.gitbook/assets/gekleurde-rommelzin.png)

### Technische hulp

#### Programmaverloop

Voor elke regel die in kleur getoond wordt, wissel je de voorgrondkleur. Op de juiste plaatsen in de code herstel je de oorspronkelijke kleuren van de terminal.

#### Testscenario's

* Test opnieuw uit met een kleur, maaltijd, auto, film en boek naar keuze.

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

