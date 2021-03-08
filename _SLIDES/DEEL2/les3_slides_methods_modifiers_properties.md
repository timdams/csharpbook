---
marp: true
---
<style>
section {
  padding: 100px;
  padding-left: 140px;
  padding-bottom: 200px;
  background-image: url('background.png');
  background-size: cover;
}
h1 {
    color: rgb(153,35,36)
}
</style>

# OO Programmeren
<style scoped>
section {
  padding-left: 400px;
  color: white;
}
h1 {
  font-size: 60px;
  color: white;
}
a {
  color: white ;
}
h3 {
  font-size: 40px;
  color: white
}
</style>
![bg](background_cover.png)
### Methoden, modifiers en properties

https://apwt.gitbook.io/cursus-pro-oo

---

# Instantie methoden


```c#
class Mens
{
    public void Praat()
    {
        Console.WriteLine("Ik ben een mens!");
    }
}
```

---
# Instantie methoden

```c#
Mens joske = new Mens();
Mens alfons = new Mens();

joske.Praat();
alfons.Praat();
```

---

# Access modifiers

- Geeft aan u zichtbaar een bepaald deel van een klasse is.
- Belangrijk voor encapsulatie.
    - **private**: Niet beschikbaar van buitenaf. 
    - **public**: Wel beschikbaar van buitenaf.

---

# Access modifiers

- Private hoeft niet expliciet vermeld te worden
    &rarr; **wel goede gewoonte om het wel te doen!**
- Volgende twee manieren zijn dus identiek:
```c#
VertelGeheim() {...}  //private impliciet
private  VertelGeheim() {...} //private expliciet
```
---

# Access modifiers

```c#
class Mens
{
    public void Praat()
    {
        Console.WriteLine("Ik ben een mens!");
    }

    void VertelGeheim()
    {
        Console.WriteLine("Mijn geheim is dat ik leef!");
    }
}
```

**Vraag:** kan je de methode VertelGeheim vanuit de Main op joske aanroepen?

---

# Reden van private

```c#
class Mens
{
    public void Praat()
    {
        Console.WriteLine("Ik ben een mens!");
        VertelGeheim();
    }

    void VertelGeheim()
    {
        Console.WriteLine("Mijn geheim is dat ik leef!");
    }
}
```

```
Mens rachid = new Mens();
rachid.Praat();
```
---

**Output:**
```
Ik ben een mens!
Mijn geheim is dat ik leef!
```

---
# Instantie variabelen

```c#
class Mens
{
    private int leeftijd = 1;
    public void VerjaardagVieren()
    {
        Console.WriteLine("Hiphip hoera voor mezelf!");
        leeftijd++;
        Praat();
    }
    public void Praat()
    {
        Console.WriteLine("Ik ben een mens! ");
        Console.WriteLine($"Ik ben {leeftijd} jaar oud");
    }
}
```
---
# Instantie variabelen

```c#
Mens Elvis = new Mens();
Mens Bono = new Mens();

Elvis.VerjaardagVieren();
Elvis.VerjaardagVieren();
Elvis.VerjaardagVieren();
Bono.VerjaardagVieren();
```
**Hoe oud is Bono? Hoe oud is Elvis?**

---
# Properties

- zijn de C# manier om objecten hun interne staat in en uit te lezen. 
- zorgen voor een gecontroleerde toegang tot de interne structuur van je objecten.

---
# In een wereld zonder properties

```c#
class SithLord
{
    private int energy;
    private string sithName;
}
```
Gebruik:
```c#
SithLord vader = new SithLord();
Console.WriteLine($"Vaders energy is {vader.energy}"); // Werkt niet!
```

---
# Full properties
- Hoe toegang geven tot instantie variabelen (private)?

```
class SithLord
{
    private int energy;
    private string sithName;
    public int Energy
    {
        get {
            return energy;
        }
        set {
            energy = value;
        }
    }
}
```

---
# Full properties

```
SithLord vader = new SithLord();
vader.Energy = 20; //set
Console.WriteLine($"Vaders energy is {Vader.Energy}"); //get
```

- Snel property schrijven?
    - propfull <tab> <tab>   

---
# Full property met toegangscontrole

- Properties als 'wachters' van en naar de interne staat van objecten.
- set kan gebruikt worden voor extra controles.

```c#
    public int Energy
    {
        get
        {
            return energy;
        }
        set
        {
            if(value >= 0)
                energy = value;
        }
    }
```
---
# Write-only properties

- We kunnen alleen van buitenaf een waarde geven.
- Niet van buitenaf uitlezen.

```c#
   public int Energy
    {
        set
        {
            if(value >= 0)
                energy = value;
        }
    }
```
---
# Read-only properties

- We kunnen alleen van buitenaf uitlezen.
- Niet van buitenaf aanpassen.

```c#
    public int Energy
    {
        get
        {
            return energy;
        }
    }
```
---
# Read-only property met private set

- We kunnen alleen van buitenaf uitlezen.
- Niet van buitenaf aanpassen. 
- Wel van in de klasse zelf aanpassen.

```c#
   public int Energy
    {
        get {
            return energy;
        }
        private set {
            if(value >= 0)
                energy = value;
        }
    }
```
**Let op:** Gebruik de properties anders worden de toegangscontroles niet gebruikt.

---
<style scoped>
    pre {
            font-size:70%
    }
</style>
# Slechte code!

```c#
class SithLord
{
    private int energy;
    private string sithName;
    public void ResetLord()
    {
        energy = -1;
    }
    public int Energy
    {
        get {
            return energy;
        }
        private set {
            if(value >= 0)
                energy = value;
        }
    }
}
```
---
# Gebruik properties!
```
public void ResetLord()
{
    Energy = -1; // Energy i.p.v. energy
}
```

Het is een goede gewoonte om zo vaak mogelijk via de properties je interne variabele aan te passen en niet rechtstreeks het dataveld zelf.

---
# Read-only Get-omvormers
<style scoped>
    pre {
            font-size:70%
    }
</style>
- Niet verplicht om voor iedere instance variabele een property te schrijven.
- Niet elke property komt overeen met een instance variabele.

```c#
class Persoon
{
    private string voornaam;
    private string achternaam;
    public string FullName
    {
        get { return $"{voornaam} {achternaam}"; }
    }
    public string Email
    {
        get
        {
            return $"{voornaam}.{achternaam}@ap.be";
        }
    }
}
```

---
# Read-only Get-omvormers: nog een voorbeeld

```c#
class Aarde
{
    public double ZwaarteKracht
    {
        get
        {
            return 9.81;
        }
    }
}
```

---
# Read-only Get-omvormers: nog een voorbeeld

```c#
class Persoon
{
    private int age;

    public bool IsWaarschijnlijkNogLevend
    {
        get
        {
            if(age > 120) return false;
            return true;
        }
    }
}
```
---

###
# Read-only Get-omvormers: Data transformeren

```c#
class Persoon
{
    private int age; //in jaren

    public int  LeeftijdInMaanden
    {
        get
        {
            return age * 12;
        }
    }
}
```

---
# Auto properties

- Verkorte notatie voor properties die enkel private variable lezen en schrijven
- Alleen mogelijk indien geen extra logica in de property.

---
# zonder auto properties
<style scoped>
    pre {
            font-size:70%
    }
</style>
```
public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }

    //... etc
    }
```
---

# met auto properties
**Exact dezelfde functionaliteit als hiervoor!**

```
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
```

---
# Auto Properties: Beginwaarden

**autoproperties beginwaarden geven**

```c#
public int Age { get; set;} = 45;
```

---
# Altijd auto-properties?

```c#
set
{
    if( value > 0)
        _age = value;
}
```

**Kan niet herschreven worden met een automatic property.**

---
# Auto Properties: Read-only

```c#
public string FirstName
{
    get
    {
        return firstName;
    }
}
```
**met autoprops:**
```c#
public string FirstName { get; private set;}
```
**of nog korter:**
```c#
public string FirstName { get; }
```

---
# Snel autoproperties typen in Visual Studio
- prop <tab> <tab>
- Je hoeft dan enkel nog volgende zaken in orde te brengen:
    - Het type van de property
    - De naam van de property (identifier) 
    - De toegankelijkheid van get/set (public, private)
- auto property met private setter? **propg <tab> <tab>**

---
# Methode of een property?

**"Moet dit in een property of in een methode gestoken worden?"**

- Betreft het een actie, iets dat het object moet doen (tekst tonen, iets berekenen, etc) dan plaats je het in een methode
- Betreft het een eigenschap die een bepaalde waarde heeft, dan gebruik je een property












