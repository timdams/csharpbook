# Code met uitleg
![](../assets/infoclip.png)

[De oplossing wordt hier stap voor stap besproken](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=2cb2acdb-d5f9-4ff4-aa9d-abb1008f7b70)
{% hint style='warning' %}
Het tweede gedeelte, waarin je landen van centra moet voorzien wordt niét besproken in de videoclip. De oplossing hiervan staat wel hier onder.
{% endhint %}

# Code
## Main

```java
Dictionary<string, VaccinatieCentrum> centraDB = new Dictionary<string, VaccinatieCentrum>();

while (true)
{
    Console.WriteLine("Wat wil je doen?");
    Console.WriteLine("1. Centra tonen");
    Console.WriteLine("2. Centrum bijmaken");
    Console.WriteLine("3. Centra vaccins laten maken");
    int keuze = Convert.ToInt32(Console.ReadLine());
    switch (keuze)
    {
        case 1:
            foreach (var centrum in centraDB)
            {
                Console.WriteLine(centrum.Key);
            }
            break;
        case 2:
            Console.WriteLine("Waar wil je dit bouwen?");
            string waar = Console.ReadLine();
            if (centraDB.ContainsKey(waar))
                Console.WriteLine("Dat land heeft reeds een centrum");
            else
                centraDB.Add(waar, new VaccinatieCentrum());
                Console.WriteLine("Gebouwd!");
            break;
        case 3:
            Console.WriteLine("Welk land moet vaccins maken?");
            string waarv = Console.ReadLine();
            if (centraDB.ContainsKey(waarv))
            {
                Vaccin gemaaktVaccin = centraDB[waarv].GeefVaccin();
                Console.WriteLine("Vaccin gemaakt");
                //nu moet je iets doen met het gemaaktVaccin
            }

            else
                Console.WriteLine("Dat land heeft geen vaccinatiecntrum");
            break;
        default:
            Console.WriteLine("Onbekend getal");
            break;
    }


    Console.WriteLine("Waar moet centra komen?");
    string stadin = Console.ReadLine();

}
```

## SlimVaccin

```java
class SlimVaccin: Vaccin
{
    public SlimVaccin(string naamin): base(naamin)
    {

    }

    int next = 0;
    public override int TryKillCode()
    {
        int tosend = next;
        next = next + 10;

        if(next>100)
        {
            int r = next % 10;
            next = r + 1;
        }

        return tosend;
    }
}
    ```

## DomVirus

```java
class DomVirus: Virus
{
    static Random r = new Random();
    public override bool TryVaccin(Vaccin vacin)
    {
        bool result= base.TryVaccin(vacin);
        if(r.Next(0,2)==0)
        {
            DoomCountDown += 2;
        }
        return result;
    }
}
```