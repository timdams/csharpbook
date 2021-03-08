# Scope van variabelen

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/-2Rgaha0eqM)
{% endhint %}

## Scope van variabelen

De locatie waar je een variabele aanmaakt bepaalt de **scope**, oftewel de gegarandeerde levensduur, van de naam van de variabele. Ruwweg: als je binnen hetzelfde stel accolades werkt waarin een variabele is gedeclareerd, dan is die naam **in scope** en kan je hem gebruiken. Indien je de variabele dus buiten die accolades nodig hebt, dan heb je een probleem: de variabele is enkel bereikbaar binnen de accolades vanaf het punt in de code waarin het werd aangemaakt.

Zeker wanneer je begint met `if`, loops, methoden, etc. zal de scope belangrijk zijn: deze code-constructies gebruiken steeds accolades om codeblocks aan te tonen. Een variabele die je dus binnen een if-blok aanmaakt zal enkel binnen dit blok bestaan, niet erbuiten.

```csharp
if( something == true)
{
    int getal = 0 ;  //Start scope getal
    getal = 6;
} // einde scope getal

Console.WriteLine(getal); // zal niet werken daar de scope van getal al gedaan was
```

Wil je dus getal ook nog buiten de `if` gebruiken zal je je code moeten herschrijven zodat `getal` **voor** de `if` wordt aangemaakt:

```csharp
int getal = 0 ;  //Start scope getal
if( something == true)
{
    getal = 6;
} 

Console.WriteLine(getal);
```

## Variabelen met zelfde naam

Zolang je in de scope van een variabele bent kan je geen nieuwe variabele met dezelfde naam aanmaken:

Volgende code is dus niet toegestaan:

```csharp
{
    int getal = 0;
    {
        int getal = 5; //Deze lijn is niet toegestaan
    }

}
```

Je krijgt de error: `A local variable named 'getal' cannot be declared in this scope because it would give a different meaning to 'getal', which is already used in a 'parent or current' scope to denote something else`

Enkel de tweede variabele een andere naam geven is toegestaan in het voorgaande geval.

Dit is wel geldig, daar de scope van de eerste variabele afgesloten wordt door de accolades:

```csharp
{
    int getal = 0 ;
    //....
}
//Verder in code
{
    int getal = 5;
}
```

