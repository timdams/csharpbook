# Expression bodied members

Wanneer je methoden, constructors of properties schrijft waar **exact 1 expressie** \(_1 lijn code_ die een resultaat teruggeeft\) nodig is dan kan je gebruik maken van de **expression bodied member syntax** \(EBM\). Deze is van de vorm:

```text
member => expression
```

Dankzij EBM kan je veel kortere code schrijven.

We tonen telkens een voorbeeld hoe deze origineel is en hoe deze naar EBM syntax kan omgezet worden.

## Methoden en EBM

Origineel:

```csharp
public void ToonLeeftijd(int age)
{
    Console.WriteLine(age);
}
```

Met EBM:

```csharp
public void ToonLeetijd(int age) => Console.WriteLine(age);
```

Nog een voorbeeld, nu met een return. Merk op dat we return niet moeten schrijven:

```csharp
public int GeefGewicht()
{
    return 4* 34;
}
```

Met EBM:

```csharp
public int GeefGewicht() => 4*34;
```

## Constructors en EBM

Ook constructors die maar 1 expressie bevatten kunnen korter nu. Origineel:

```csharp
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

```csharp
class Student
{
    private int age;
    public Student(int inage) =>  age = inage;
}
```

## Full Properties met EBM

Properties worden een een soort blend tussen full en autoproperties. Originele full property:

```csharp
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

```csharp
private int name;
public int Name
{
    get => name;
    set => name=value;
}
```

## Read-only properties met EBM

Bij read-only properies hoeft het `get` keyword zelfs niet meer getypt te worden bij EBM.

Origineel:

```csharp
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

```csharp
private int name;
public int Name => name;
```

