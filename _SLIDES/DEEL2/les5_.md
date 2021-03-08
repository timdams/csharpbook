---
marp: true
paginate: true
---
<style>
section {
  padding: 100px;
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
### Geavanceerde klassen en objecten

https://apwt.gitbook.io/cursus-pro-oo

---

# Constructor

- Constructor is een speciale methode om een nieuwe instantie (=object) van een class aan te maken
- **Doel:** Een nieuw object initialiseren
- **Syntax:**
    - Naam is steeds gelijk aan de class naam
    - Geen return type


---

# Constructor

```c#
public class BankAccount
    {
        private decimal balance;

        public BankAccount()
        {
            balance = 0;
        }
    }
```

---    


# Constructor: new operator

```c#
BankAccount bankAccount = new BankAccount();
```

De new operator doet 2 dingen:
- Het maakt een object aan in het geheugen.
- Het roept de **constructor** methode van het object aan voor eventuele extra initialisatie
---

# Constructor
- Bevat code die uitgevoerd moet worden bij instantie aanmaken.
- Speciale methode die wordt aangeroepen bij het aanmaken van een object. 
    - Daarom ronde haakjes bij new Student()

---

# Default Constructor

- Indien je geen constructor definieert dan maakt .NET compiler er een voor jou.
    - **Default constructor**
- Compiler voegt volgende (onzichtbare) code aan klasse toe:
    ```C#
    public BankAccount()
    {
    }
    ```
     (merk public keyword op)

---

# Eigen constructor maken zonder argumenten

```c#
public class BankAccount
{
    private decimal balance;

    public BankAccount()
    {
        Console.WriteLine("We just made an account.")
    }
}
```

**Ideaal om bepaalde instantievariabelen (eventueel via properties) op begin waarde te initialiseren**

---

# Intermezzo-herhaling: method overloading

**Een methode met dezelfde naam maar ander aantal parameters:**

```c#
public int TelOp(int getal1, int getal2, int getal3)
{
    return getal1 + getal2 + getal3;
}

public int TelOp(int getal1, int getal2)
{
    return getal1 + getal2;
}
```

---

# Intermezzo-herhaling: method overloading

**Een methode met dezelfde naam en hetzelfde aantal parameters. Maar met ander type:**
```c#
public int TelOp(int getal1, int getal2)
{
    return getal1 + getal2;
}

public int TelOp(double getal1, double getal2)
{
    return (int) (getal1 + getal2);
}
```

- Compiler zal best passende methode uitkiezen bij aanroep methode.

---

# Constructor overloading

- Een constructor is een method
    => Een constructor kan je overloaden


- **Regels overloaden:**
    - Return type moet gelijk zijn 	=> geen probleem, constructor heeft dit niet
    - Method naam is gelijk => steeds class naam
    - Argumenten verschillen in type en/of aantal

---

# Constructor overloading

```c#
public class BankAccount
{
    private decimal balance;

    public BankAccount()
    {
        balance = 0;
    }

    public BankAccount(int beginAmount)
    {
        balance = beginAmount;
    }
}
```

```c#
BankAccount bankAccount = new BankAccount(30);
```

---

# Constructor overloading
<style scoped>
    pre {
            font-size:60%
    }
</style>
```c#
public class BankAccount
{
    private decimal balance;
    private string name;

    public BankAccount()
    {
        balance = 0;
    }

    public BankAccount(int beginAmount)
    {
        balance = beginAmount;
    }

    public BankAccount(string inName, int beginAmount)
    {
        balance = beginAmount;
        name = inName;
    }
}
```

```c#
BankAccount bankAccount = new BankAccount("Andie", 30);
 ```

---

# Gratis default constructor: Wel of niet?

- Van zodra we minstens 1 constructor schrijven dan zal compiler niet meer helpen

    ```c#
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(int beginAmount)
        {
            balance = beginAmount;
        }
    }
    ```

    ![:50% 50%](error_default_constructor.png)

---

# Waarom constructor?

```c#
public class Student
{
    public String Name { get; set; }
    public String Address { get; set; }
}
```
Je kan een Student aanmaken zonder naam:
```c#
static void Main(string[] args)
{
    Student student = new Student();
    student.Address = "Trammezandlei 122, Schoten";
}
```

---
# Waarom constructor?

```c#
public class Student
{
    public String Name { get; set; }
    public String Address { get; set; }

    public Student(string name, string address)
    {
        Name = name;
        Address = address;
    }
}
```
- Niet meer mogelijk objecten aan te maken in inconsistente staat
  - d.w.z. met waarden die we niet willen toestaan, bv. naam `null`
- **Daarom wordt hier ook geen default constructor gemaakt!**

--- 

# Constructors: Random

```c#
class Student
{
    private int age;
}
```

- We willen bij het aanmaken van een Student object een random leeftijd geven.
- ```private int age = random.Next(10,20)``` gaat **niet!**
- Via een constructor is dit mogelijk:

--- 

# Constructors: Random

Zoals verteld moet de constructor de naam van de klasse hebben, public zijn en geen returntype definiëren.

```c#
class Student
{
    public Student()
    {
        // zet hier de code die bij initialisatie moet gebeuren
    }

    private int age;
}
```

--- 

# Constructors: Random

Vervolgens voegen we de code toe die we nodig hebben:

```c#
class Student
{
    public Student()
    {
        Random r= new Random();
        age= r.Next(10,20);
    }

    private int age;
}
```

- **Opgepast:** Hier zit nog een probleem in!

---

# Constructor: Random

```c#
class Student
{
    public Student()
    {
        Random r= new Random();
        age= r.Next(10,20);
    }

    private int age;
}
```
- **Opgepast:** Hier zit nog een probleem in!
- **TIP:** Wat als je twee of meerdere studenten snel na elkaar aanmaakt?

---

# Constructor: Random

**Probleem:**
- Als je twee of meerdere Studenten snel na elkaar aanmaakt zullen deze dezelfde leeftijd hebben.
- Ieder object maakt zijn eigen Random aan.
- Elke random generator genereert dezelfde random getallen als die vlak na mekaar in tijd zijn aangemaakt

---

# Constructor: Random
- **Oplossing** static! 

    ```c#
    class Student
    {
        static Random r = new Random();
        public Student()
        {
            age= r.Next(10,20);
        }

        private int age;
    }
    ```

---

# Constructor chaining
- niet nodig alle initialisatiecode te herhalen in elke constructor
- speciale syntax `: this(<arg1>,<arg2>,...)` na constructor noteren
- roept andere constructor aan **voor** deze, op basis van argumenten
- goed idee één algemene constructor te schrijven, rest met defaultwaarden

    ```c#
    public Student() : this("Tim Dams","Trammezandlei")
    {
    }
    ```
---

# Constructor chaining: beperking
- Constructor aangeduid via `this` wordt **eerst** opgeroepen
- Dit werkt zoals verwacht
    ```c#
    public Student() : this("Tim Dams","Trammezandlei")
    {
        Console.WriteLine("Student aangemaakt!");
    }
    ```
- Dit werkt **niet** zoals gehoopt
    ```c#
    public Student() : this(number.ToString(),"Trammezandlei")
    {
        // dit gebeurt pas **na** oproep andere constructor
        Random r = new Random();
        number = r.Next(10,20);
    }
    ```

---

# Static

- Static al een paar keer gezien in vorig semester (bv bij main)
- Tot nu toe geen static voor methoden gezet in klassen.
- **static keyword** zegt of een methode of variabele bij de klasse hoort en niet bij het object zelf.
- De methoden en properties spelen dan op klasse niveau ipv op object niveau


---

# Wanneer static gebruiken? 

**static kan op 2 manieren gebruikt worden:**
- Bij variabelen om een gedeelde variabele aan te maken, over de objecten heen.
- Bij methoden om zogenaamde methoden-bibliotheken of hulpmethoden aan te maken.

---

# Variabelen en het static keyword
<style scoped>
    pre {
            font-size:80%
    }
</style>
- **Zonder static**: 
    - ieder object heeft zijn eigen variabelen en aanpassingen hebben geen invloed op andere objecten.

        ```c#
        class Mens
        {
            private int leeftijd=1;
            public void Jarig()
            {
                leeftijd++;
            }

            public void ToonLeeftijd()
            {
                Console.WriteLine(leeftijd);
            }
        }
        ```

---

# Variabelen en het static keyword

```c#
Mens m1= new Mens();
Mens m2= new Mens();

m1.Jarig();
m1.Jarig();

m2.Jarig();

m1.ToonLeeftijd();
m2.ToonLeeftijd();
```

**Wat is het resultaat?**

---

# Variabelen MET static
<style scoped>
    pre {
            font-size:70%
    }
</style>
```c#
class Mens
{
    private static int leeftijd=1;
    public void Jarig()
    {
        leeftijd++;
    }

    public void ToonLeeftijd()
    {
        Console.WriteLine(leeftijd);
    }
}
```
- **Alle objecten van Mens gaan de variabelen leeftijd delen.**
- Maar 1 instantie in het geheugen.

---

# Variabelen MET static

```c#
Mens m1= new Mens();
Mens m2= new Mens();

m1.Jarig();
m1.Jarig();

m2.Jarig();

m1.ToonLeeftijd();
m2.ToonLeeftijd();
```
**Wat is het resultaat?**

---

# Misbruiken van static

- Static laat je dus toe om informatie over de objecten heen te delen. 
- Gebruik static niet te pas en te onpas
    - vaak druist het in tegen de concepten van OO en wordt het vooral misbruikt 
    - Ga je dit vaak nodig hebben? Niet zo vaak.

---

# Methoden met static

- Vaak voorkomende use case:

    ```c#
    Math.Pow(3,2);
    ```

    We moeten geen instantie van Math maken zoals:

    ```c#
    Math myMath= new Math(); //dit mag niet!
    myMath.Pow(3,2)
    ```

- Alle methoden in de klasse Math staan gedefinieerd als static.
- Dit is de reden dat je de math-bibliotheken kan aanroepen rechtsreeks op de klasse.

---

# Voorbeeld van static methoden
<style scoped>
    pre {
            font-size:70%
    }
</style>
```c#
class EpicLibray
{
    static public void ToonInfo()
    {
        Console.WriteLine("Ik ben ik");
    }

    static public int TelOp(int a, int b)
    {
        return a+b;
    }
}
```
Hoe episch is dit? Je eigen hulp bibliotheek:
```
EpicLibrary.ToonInfo();

int opgeteld= EpicLibrary.TelOp(3,5);
```

---
# Nog een voorbeeld
<style scoped>
    pre {
            font-size:70%
    }
</style>
```c#
class Fiets
{
    private static int aantalFietsen = 0;
    public Fiets()
    {
        aantalFietsen++;
        Console.WriteLine($"Er zijn nu {aantalFietsen} gemaakt");
    }

    public static void VerminderFiets()
    {
        aantalFietsen--;
    }
}
```

**We houden bij hoeveel keer we de constructor hebben aangeroepen.**
---



---
# Aanroepen van andere methoden

```c#
class Mens
{
    private int gewicht=50;

    private static void VerminderGewicht()
    {
        gewicht--;
    }
}
```

**Waarom werkt deze code niet?**

---

# Aanroepen van andere methoden

- Zodra je een methode static maakt kan deze alleen maar
    - **static variabelen** gebruiken
    - **static methoden** aanroepen
- **instantiemethoden** en **variabelen of properties** van een instantie zijn er niet
- kan wel aan **externe** objecten (aangemaakt via `new` of doorgegeven als argument)

---

# Static en main

Dit verklaart ook waarom je bij console applicaties in Program.cs steeds alle methoden static moet maken: 
```c#
public class Program
{
        public static void Main()
        {

        }
}
```

---

# Comma Separated Values

- Een Comma Separated Values (.csv) bestand is een bestand met alleen tekstgegevens dat wordt gebruikt om gegevens op te slaan, 
- vaak gebruikt met spreadsheet- of databasesoftware. 
- elke lijn is een rij in de spreadsheet
- elk stuk tekst gescheiden door ; is een cel in de spreadsheet

**Bijvoorbeeld: adressen.csv**
```
Vermeulen;Joske;Trammezandlei 122
Holmes;Sherlock;221B Baker Street
Trump;Donald;1600 Pennsylvania Avenue
```

---
# Excel: CSV Importeren
<img src="import_csv.png" style="align-self: center; width: 80%; margin-left: 80px" align="left"/>

---

# Excel: CSV Importeren
<img src="csv_in_excel.png" style="align-self: center; width: 80%"/>

---

# Excel: CSV Opslaan
 
- Bestand -> Opslaan als -> Comma delimited values (.csv)
(File -> Save As -> Comma delimited values (.csv))

---

# CSV: wegschrijven in C#

Je kan een text wegschrijven in een bestand: 
**De 2 eenvoudigste manieren zijn:**
- File.WriteAllText: deze gebruik je als je 1 enkele string wilt wegschrijven
- File.WriteAllLines: deze is de omgekeerde van ReadAllLines() en zal een array van strings wegschrijven.

---

# CSV: wegschrijven in C#
```c#
string[] achterNamen = { "Vermeulen", "Holmes", "Trump" };
string[] voorNamen = { "Joske", "Sherlock", "Donald" };
string[] adressen = { "Trammezandlei 122", "221B Baker Street", "1600 Pennsylvania Avenue"};

string[] lines = new string[voorNamen.Length];
for (int i = 0; i < lines.Length; i++)
{
    lines[i] = $"{achterNamen[i]};{voorNamen[i]};{adressen[i]}";
}

System.IO.File.WriteAllLines("adressen.csv", lines);
```

- **Pas op:** WriteAllLines schrijft onherroepelijk de file over. Gebruik ```if(File.Exists(pathtofile))```!
---

# CSV: Inlezen in C#

```c#
string[] lines = File.ReadAllLines(@"c:\adressen.csv");
for (int i = 0; i < lines.Length; i++)
{
    string[] splitted = lines[i].Split(';');

    Console.WriteLine($"Voornaam {i}= {splitted[1]}" );
    Console.WriteLine($"Achternaam {i}= {splitted[0]}");
    Console.WriteLine($"Adres {i}= {splitted[2]}");
}
```

- **@ character**: de hele string die nu volgt moet je beschouwen zoals hij er staat. Je mag alle escape karakters negeren.

--- 

# CSV: Inlezen in C#
- **ReadAllLines()**
    - Via System.File.ReadAllLines() lezen we het hele adressen.csv bestand uit. 
    - De methode geeft een array van string terug. 
    - Per lijn die eindigt met een newline (\r\n) zal een nieuwe string aan de array toegevoegd worden.

- **Split()**
    - De Split methode laat toe de csv string te splitsen op het ; teken. Het resultaat is terug een array van strings.

---

# CSV downloaden

- WebClient klasse gebruiken om online bronnen aan te sprkeen.
- Bevindt zich in de System.Net namespace:
    ```c#
    using System.Net
    ```
- Dan kunnen we op de volgende manier de csv inlezen:
    ```c#
    WebClient wc = new WebClient();
    string csv = wc.DownloadString("www.fakeaddress.com/mydata.csv");
    ```
- De string moet nog wel gesplit worden voor een array van strings te krijgen:
    ```c#
    string[] split = csv.Split('\n');
    ```
