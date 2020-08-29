
![](../assets/infoclip.png)

* [Bespreking oplossingen hoofdstuk 2](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=7e2513f7-7002-4687-a214-a97000751f5e)

# Code oplossingen

## Unicode Art

```java
            string myname = @"▄▄▄█████▓ ██▓ ███▄ ▄███▓   ▓█████▄  ▄▄▄       ███▄ ▄███▓  ██████ 
▓  ██▒ ▓▒▓██▒▓██▒▀█▀ ██▒   ▒██▀ ██▌▒████▄    ▓██▒▀█▀ ██▒▒██    ▒ 
▒ ▓██░ ▒░▒██▒▓██    ▓██░   ░██   █▌▒██  ▀█▄  ▓██    ▓██░░ ▓██▄   
░ ▓██▓ ░ ░██░▒██    ▒██    ░▓█▄   ▌░██▄▄▄▄██ ▒██    ▒██   ▒   ██▒
  ▒██▒ ░ ░██░▒██▒   ░██▒   ░▒████▓  ▓█   ▓██▒▒██▒   ░██▒▒██████▒▒
  ▒ ░░   ░▓  ░ ▒░   ░  ░    ▒▒▓  ▒  ▒▒   ▓▒█░░ ▒░   ░  ░▒ ▒▓▒ ▒ ░
    ░     ▒ ░░  ░      ░    ░ ▒  ▒   ▒   ▒▒ ░░  ░      ░░ ░▒  ░ ░
  ░       ▒ ░░      ░       ░ ░  ░   ░   ▒   ░      ░   ░  ░  ░  
          ░         ░         ░          ░  ░       ░         ░  
                            ░                                    ";
            Console.WriteLine(myname);
```

## ASCI Art & Colors

```java

Console.Write("▄▄▄█████▓ ██▓ ███▄ ▄███▓   ");
Console.ForegroundColor = ConsoleColor.Red; 
Console.Write("▓█████▄"); 
Console.ResetColor(); 
Console.Write("  ▄▄▄       ███▄ ▄███▓  ██████ \n");
Console.Write("▓  ██▒ ▓▒▓██▒▓██▒▀█▀ ██▒   "); 
Console.ForegroundColor = ConsoleColor.Red; 
Console.Write("▒██▀ ██▌"); Console.ResetColor(); 
Console.Write("▒████▄    ▓██▒▀█▀ ██▒▒██    ▒ \n");
Console.Write("▒ ▓██░ ▒░▒██▒▓██    ▓██░   "); 
Console.ForegroundColor = ConsoleColor.Red; 
Console.Write("░██   █▌"); Console.ResetColor(); 
Console.Write("▒██  ▀█▄  ▓██    ▓██░░ ▓██▄   \n");
Console.Write("░ ▓██▓ ░ ░██░▒██    ▒██    "); 
Console.ForegroundColor = ConsoleColor.Red; 
Console.Write("░▓█▄   ▌"); Console.ResetColor(); 
Console.Write("░██▄▄▄▄██ ▒██    ▒██   ▒   ██▒\n");
Console.Write("  ▒██▒ ░ ░██░▒██▒   ░██▒   "); 
Console.ForegroundColor = ConsoleColor.Red; Console.Write("░▒████▓ "); 
Console.ResetColor(); Console.Write(" ▓█   ▓██▒▒██▒   ░██▒▒██████▒▒\n");
string blood = @"  ▒ ░░   ░▓  ░ ▒░   ░  ░    ▒▒▓  ▒  ▒▒   ▓▒█░░ ▒░   ░  ░▒ ▒▓▒ ▒ ░
░     ▒ ░░  ░      ░    ░ ▒  ▒   ▒   ▒▒ ░░  ░      ░░ ░▒  ░ ░
░       ▒ ░░      ░       ░ ░  ░   ░   ▒   ░      ░   ░  ░  ░  
░         ░         ░          ░  ░       ░         ░  
                ░ ";
Console.WriteLine(blood);
```