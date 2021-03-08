# Oefeningen deel 1

## De oefeningen

> Indien niet expliciet vermeld mag je kiezen met wat voor loop \(for, while, do while\) je het probleem zal oplossen.

## Opwarmers

{% file src="../../.gitbook/assets/oefeningen-loops.docx" caption="Opwarmers loops" %}

{% hint style="success" %}
[Kennisclip eerste opwarmers 1 en 3](https://youtu.be/wludpSDwCK8)
{% endhint %}

{% hint style="success" %}
[Kennisclip opwarmers opwarmers 5](https://youtu.be/edxhVzol7jA)
{% endhint %}

## Tafels van vermenigvuldigen

Herwerk de oefening[ H2-maaltafels ](../h1-variabelen-en-datatypes/a_practica.md#oefening-h-2-maaltafels)zodat je maar één keer de code voor vermenigvuldiging moet schrijven. Gebruik een `for`-lus. Sla op in de klasse `HoofdstukZes` met de methodenaam `Maaltafels`.

{% hint style="success" %}
[Kennisclip flowchart maaltafels](https://youtu.be/YmOnUvSQShY)
{% endhint %}

## Oefening: H6-RNA

### Leerdoelen

* Input stap voor stap verwerken
* Flowchart gebruiken

### Functionele analyse

DNA heeft steeds een RNA-complement \(DNA is het gevolg van RNA transscriptie\). Schrijf een programma dat een ingevoerde DNA-string omzet naar een RNA-string. De gebruiker voert steeds 1 DNA-nucleotide \(m.a.w. één letter\) in per keer en duwt op enter, de RNA string wordt steeds groter. De omzetting is als volgt:

* G wordt C
* C wordt G
* T wordt A
* A wordt U
* ENTER dan stopt de gebruiker met letters ingeven en wordt her resultaat getoond.
* ANDERE LETTERS of meer dan één letter worden genegeerd

### Technische analyse

Noem de methode voor deze oefening `RNA`.

#### voorbeeldinteractie\(s\)

```text
Geef nucleotiden:
> G
> C
> T
> A
> jfidqojfidosjfiods
> G
>
Je resultaat is: CGAUC
```

### Technische hulp

#### Programmaverloop

Je krijgt een flowchart om het verloop beter in kaart te brengen:

{% file src="../../.gitbook/assets/flowchartrna.pdf" caption="flowchart RNA" %}

#### Testscenario's

* Duw meteen op ENTER
* Schrijf een stuk tekst met elke nucleotide in
* Schrijf een heel lang stuk tekst

