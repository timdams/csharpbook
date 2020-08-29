
![](../assets/infoclip.png)

* [Bespreking oplossingen hoofdstuk 0](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=1a353c40-e317-4b1d-b81b-a966007b8ed2)

# Code oplossingen

## Oplossing Rommelzin

```java
Console.WriteLine("Wat is je favoriete kleur?");
string favkleur = Console.ReadLine();
Console.WriteLine("Wat is je favoriete eten?");
string faveten = Console.ReadLine();
Console.WriteLine("Wat is je favoriete boek?");
string favboek = Console.ReadLine();
Console.WriteLine("Wat is je favoriete auto?");
string favauto = Console.ReadLine();


Console.WriteLine("Je favoriete kleur is"+ faveten +". Je eet graag"+ favauto +". Je lievelingsfilm is"+ favboek +" en je favoriete boek is "+ favkleur);
```

## Met kleuren

```java
//...
//Op het einde
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Je favoriete kleur is"+ faveten);
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Je eet graag"+ favauto);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Je lievelingsfilm is"+ favboek);
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("en je favoriete boek is "+ favkleur);
```

Of per woord:

```java
//...
//Op het einde
Console.BackgroundColor = ConsoleColor.Blue;
Console.Write("Je ");
Console.BackgroundColor = ConsoleColor.Green;
Console.Write("favoriete ");
Console.BackgroundColor = ConsoleColor.Red;
Console.Write("kleur ");
Console.BackgroundColor = ConsoleColor.Yellow;
Console.Write("is ");
Console.BackgroundColor = ConsoleColor.Lime;
Console.Write(faveten);
//enzovoort
```

