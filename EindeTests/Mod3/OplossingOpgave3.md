<!---NOBOOKSTART--->
![](../assets/infoclip.png)
In volgende kennisclip werk ik de oplossing stap voor stap uit.
[Oplossing opgave coronatraining](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=ca8a4561-20f1-429b-9787-ab8400fca88c)
<!---NOBOOKEND--->


# Program.cs
```java
Virus v = new Virus();

List<Vaccin> vaccins = new List<Vaccin>();
for (int i = 0; i < 5; i++)
{
    vaccins.Add(new Vaccin(i.ToString()));
}

Vaccin theCure = null;
bool cureGevonden = false;
while (v.DoomCountDown > 0 && cureGevonden == false)
{
    foreach (Vaccin vaccin in vaccins)
    {
        if (v.TryVaccin(vaccin) == true)
        {
            theCure = vaccin;
            cureGevonden = true;
            break;
        }
    }
}

if (cureGevonden == true)
{
    //Fase 2
    theCure.ToonInfo();
    VaccinatieCentrum.BewaarVaccin(theCure.Oplossing);

    List<VaccinatieCentrum> centra = new List<VaccinatieCentrum>();
    for (int i = 0; i < 5; i++)
    {
        centra.Add(new VaccinatieCentrum());
    }

    List<Vaccin> containerVaccins = new List<Vaccin>();
    foreach (var centrum in centra)
    {
        for (int i = 0; i < 7; i++)
        {

            containerVaccins.Add(centrum.GeefVaccin());
        }
    }


    for (int i = 0; i < containerVaccins.Count; i++)
    {
        Console.Write(i);
        containerVaccins[i].ToonInfo();
    }

}
else
{
    Console.WriteLine("Gedaan");
}
        
```

# Vaccin

```java
class Vaccin
{
    public string Naam { get; private set; }
    public Vaccin(string naamin)
    {
        Naam = naamin;

    }
    public Vaccin(string naamin, int oploss)
    {
        Oplossing = oploss;
        Naam = naamin; //:this(naamin)
    }

    static Random r = new Random();
    public int Oplossing { get; set; } = -1;
    public int TryKillCode()
    {
        if (Oplossing != -1)
        {
            return Oplossing;
        }

        return r.Next(1, 100);
    }
    public void ToonInfo()
    {
        Console.WriteLine($"{Naam}, Oplossing is: {Oplossing}");
    }
}
```

# Virus

```java
class Virus
{
    public string Naam { get; private set; }
    private int doomCountDown;

    public int DoomCountDown
    {
        get { return doomCountDown; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Game Over");
            }
            doomCountDown = value;
        }
    }

    private int killcode;
    static Random r = new Random();
    public Virus()
    {
        DoomCountDown = r.Next(100, 200);
        killcode = r.Next(0, 99);
        
        for (int i = 0; i < 3; i++)
        {
            Naam +=(char) r.Next(65, 91);
        }
        Naam += r.Next(1, 100);
    }

    public bool TryVaccin(Vaccin vacin)
    {
        var ktest = vacin.TryKillCode();
        if(ktest==killcode)
        {
            vacin.Oplossing = ktest;
            return true;
            
        }
        DoomCountDown--;
        return false;
    }
}
```

# VaccinatieCentrum

```java
class VaccinatieCentrum
{
    public static int Oplossing { get; set; } = -1;
    public static void BewaarVaccin(int killcodein )
    {
        Oplossing = killcodein;
    }

    public Vaccin GeefVaccin()
    {
        if (Oplossing == -1) return null;

        return new Vaccin("THECURE", Oplossing);
    }
}
```