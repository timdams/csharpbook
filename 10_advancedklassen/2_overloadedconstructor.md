## Overloaded constructors

Soms wil je parameters aan een object meegeven bij creatie. We willen bijvoorbeeld de leeftijd meegeven die het object moet hebben bij het aanmaken. 
Met andere woorden, stel dat we dit willen schrijven:

```java
Student jos= new Student(19);
```

Als we dit met voorgaande klasse , die enkel een default constructor heeft, uitvoeren zal de code een fout geven. C# vindt geen constructor die een int als parameter aanvaardt.

Net zoals bij overloading van methoden  kunnen we ook constructors overloaden. De code is verrassend gelijkaardig aan method overloading:

```java
class Student
{
    public Student(int startage)
    {
        age= startage
    }

    private int age;
}

```

Dat was eenvoudig, hé?

**Maar** denk eraan: je hebt een overloaded constructor geschreven en dus heeft C# gezet "ok, je schrijft zelf constructor, trek je plan. Maar de default zal je ook zal moeten schrijven!"
Je kan nu enkel je objecten met ``new Student(25)`` aanmaken. Schrijf je ``new Student()`` dan zal je een error krijgen. Wil je die constructor, de default constructor, nog hebben dan zal je die dus ook moeten schrijven, bijvoorbeeld:


```java
class Student
{
    public Student(int startage) //overloaded
    {
        age= startage;
    }
    
    public Student() //default
    {
        Random r= new Random();
        age= r.Next(10,20);
    }

    private int age;
}

```

### Meerdere overloaded constructors
Wil je meerdere overloaded constructors dan mag dat ook. Je wilt misschien een constructor die de leeftijd vraag alsook een bool om mee te geven of het om een werkstudent gaat:

```java
class Student
{
    public Student(int startage) //overloaded
    {
        age= startage;
    }
    
    public Student(int startage, bool werkstart) //overloaded
    {
        age= startage;
        isWerkStudent= werkstart;
    }

    public Student() //default
    {
        Random r= new Random();
        age= r.Next(10,20);
    }

    private int age;
    private bool isWerkStudent
}

```

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Overloaded constructors](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=24f83488-a058-4898-b34d-ab7a0097f165)
<!---NOBOOKEND--->
