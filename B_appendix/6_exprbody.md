## Expression bodied members

Wanneer je methoden, constructors of properties schrijft waar **exact 1 expressie** (*1 lijn code* die een resultaat teruggeeft) nodig is dan kan je gebruik maken van de **expression bodied member syntax** (EBM). Deze is van de vorm:

<!---{line-numbers:false}--->
```text
member => expression
```

Dankzij EBM kan je veel kortere code schrijven.

We tonen telkens een voorbeeld hoe deze origineel is en hoe deze naar EBM syntax kan omgezet worden.

### Methoden en EBM

Origineel:

```java
public void ToonLeeftijd(int age)
{
    Console.WriteLine(age);
}
```

Met EBM:

```java
public void ToonLeetijd(int age) => Console.WriteLine(age);
```

Nog een voorbeeld, nu met een return. Merk op dat we return niet moeten schrijven:

```java
public int GeefGewicht()
{
    return 4* 34;
}
```

Met EBM:
```java
public int GeefGewicht() => 4*34;
```

### Constructors en EBM
Ook constructors die maar 1 expressie bevatten kunnen korter nu.
Origineel:
```java
class Student
{
    private int age;
    public Student(int inage)
    {
        age = inage;
    }
}
```

Met EBM:
```java
class Student
{
    private int age;
    public Student(int inage) =>  age = inage;
}
```

### Full Properties met EBM
Properties worden een een soort blend tussen full en autoproperties.
Originele full property:
```java
private int name;
public int Name
{
    get
    {
        return name;
    }
    set
    {
        name=value;
    }

}
```

Met EBM:
```java
private int name;
public int Name
{
    get => name;
    set => name=value;
}
```
### Read-only properties met EBM
Bij read-only properies hoeft het ``get`` keyword zelfs niet meer getypt te worden bij EBM.

Origineel:

```java
private int name;
public int Name
{
    get
    {
        return name;
    }
}
```

Met EBM:
```java
private int name;
public int Name => name;
```
