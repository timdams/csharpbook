# Zelf uitzonderingen maken

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/EdiLIhxrgWM)
{% endhint %}

## Zelf exceptions opwerpen

Je kan ook in je eigen code uitzonderingen genereren, zodat deze elders opgevangen worden. Je kan hierbij zelf exceptions maken of gewoon gebruik maken van een bestaande `Exception`-klasse.

Een voorbeeld:

```csharp
static int DoeIets(int getal)
{
    if (getal == 0) {
        // DivideByZeroException is ingebouwd
        throw new DivideByZeroException("Getal is 0. Dit is niet voorzien.");
    }
    else {
        return 100 / getal;
    }
}


static void Main(string[] args)
{
    try
    {
        Console.WriteLine(DoeIets(0));
    }
    catch(DivideByZeroException e)
    {
        Console.WriteLine(e.Message);
    }
}
```

`"Getal is 0. Dit is niet voorzien."` is dus de boodschap die we toevoegen aan onze exception. Ze wordt "opgelost" door de boodschap gewoon te tonen. In een complexer programma zou je bijvoorbeeld de waarde van de input kunnen aanpassen en dan opnieuw de methode aanroepen.

## Een eigen exception ontwerpen

Je kan ook eigen klassen afleiden van `Exception` zodat je eigen uitzonderingen kan maken en gooien in je programma. Je maakt hiervoor gewoon een nieuwe klasse aan die je laat overerven van de `ApplicationException`-klasse. Een voorbeeld:

```csharp
class MyException: ApplicationException
{
    public override string ToString()
    {
        return "Dit is een voorbeeld.";
    }
}
```

Om deze exception nu zelf op te gooien gebruiken we het keyword `throw`. In volgende voorbeeld gooien we onze eigen exception op een bepaald punt in de code en vangen deze dan op:

```csharp
static void Main(string[] args)
{
    try
    {
        TimsMethod();
    }

    catch (ApplicationException e)
    {
       Console.WriteLine(e.ToString());
    }
}
static public void TimsMethod()
{
    // deze methode doet niets interessants
    // ze gooit gewoon een Exception als voorbeeld
    MyException exp = new MyException();
    throw exp;
}
```

{% hint style="warning" %}
Overdrijf niet met eigen Exceptions. Op [de pagina van SystemException](https://docs.microsoft.com/en-us/dotnet/api/system.systemexception?view=netcore-3.1) vind je, onder "Derived", een heleboel kant-en-klare exceptions voor allerlei situaties.
{% endhint %}

{% hint style="warning" %}
Technisch gezien kan je ook rechtstreeks erven van `Exception` en `SystemException`, maar in de documentatie staat uitdrukkelijk dat je eigen klassen best afleidt van `ApplicationException`.
{% endhint %}

