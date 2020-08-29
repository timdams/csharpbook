
# Oplossingen practica deel 0 - Opwarmers

<!---NOBOOKSTART--->
![](../assets/movie.png)

De oplossingen van dit deel worden in volgende kennisclip besproken: [hier](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=7d5b4399-8c6c-4207-8e4d-a9af00b4ac58)
<!---NOBOOKEND--->

# Oplossingen practica deel 1 - De basics

## Intro methode

Basic:

```java
static void MyIntro()
{
    Console.WriteLine("Ik ben Tim Dams, ik ben 18 jaar oud en woon in de Lambrisseringsstraat 666");
}
```

Basic 2:

```java
static void MyIntro(string name, int age, string address)
{
    Console.WriteLine($"Ik ben {name}, ik ben {age} jaar oud en woon in de {address}");
}
```

## Grootste methode

```java
static int Grootste(int getal1, int getal2, int getal3)
{
    if (getal1 >= getal2 && getal1 >= getal3)
        return getal1;
    if (getal2 >= getal1 && getal2 >= getal3)
        return getal2;

    return getal3;
}
```

## Rekenmachine

```java
static double TelOp(double a, double b) { return a + b; }
static double TrekAf(double a, double b) { return a - b; }
static double Vermenigvuldig(double a, double b) { return a * b; }
static double Deel(double a, double b) { return a / b; }
```

## Paswoord generator methode

```java
static string PaswoordGenerator(int lengte)
{
    string resultaat = "";
    Random r = new Random();
    for (int i = 0; i < lengte; i++)
    {
        switch(r.Next(0, 3))
        {
            case 0: //cijfer
                resultaat += r.Next(0, 10);
                break;
            case 1: //kleine letters
                resultaat += (char)r.Next(97, 123);
                break;
            case 2: //hoofdletters
                resultaat += (char)r.Next(65, 91);
                break;
        }
    }
    return resultaat;
}
```

# Deel 2 Geavanceerde methode concepten

## Film Default

```java
static void FilmRuntime(string naam, int duur= 90, Genre filmgenre= Genre.Onbekend )
{
    Console.WriteLine($"{naam} ({duur}, {filmgenre})");
}
```
