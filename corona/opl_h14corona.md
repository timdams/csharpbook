# Code met uitleg
![](../assets/infoclip.png)

[De oplossing wordt hier stap voor stap besproken](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=81e976c8-d865-4cfa-9851-abad0107f367)

## Enclave

```java
class Enclave
{
    protected static Random r = new Random();

    private Hospitaal hospitaal;
    private Generator generator;
    protected List<Woonst> woningen = new List<Woonst>();

    public Enclave()
    {
        hospitaal = new Hospitaal("starthospitaal", r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight));
        generator = new Generator("generator1", r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight));
        for (int i = 0; i < 3; i++)
        {
            woningen.Add(new Woonst(r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight)));
        }

    }

    public virtual void BouwWoonst()
    {
        int xpoging = 0;
        int ypoging = 0;
        do
        {
                xpoging = r.Next(1, Console.WindowWidth);
                ypoging = r.Next(1, Console.WindowHeight);
            
        } while ( !IsLeeg(xpoging,ypoging   ));

        woningen.Add(new Woonst(xpoging, ypoging));
    }


    public virtual void ToonEclave()
    {
        generator?.PrintGebouw();
        hospitaal?.PrintGebouw();
        foreach (var woonst in woningen)
        {
            woonst.PrintGebouw();
        }
    }

    private bool IsLeeg(int x,int y)
    {
        

        if (hospitaal.X == x && hospitaal.Y == y)
            return false;
        if (generator.X == x && generator.Y == y)
            return false;
        foreach (var huisje in woningen)
        {
            if (huisje.X == x && huisje.Y == y)
                return false;
        }

        return true;
    }
}
```

## StadsEnclave

```java
class StadsEnclave: Enclave
{
    private WaterkrachtCentrale waterkrachtcentrale;
    private Hospitaal extrahospitaal;
    private List<Flat> flats = new List<Flat>();

    public override void BouwWoonst()
    {
        base.BouwWoonst();
        if(woningen.Count%3==0)
        {
            for (int i = 0; i < 3; i++)
            {
                woningen.RemoveAt(0);
            }
            flats.Add(new Flat(r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight)));
        }
    }
    public override void ToonEclave()
    {
        base.ToonEclave();
        
        extrahospitaal?.PrintGebouw();
        waterkrachtcentrale?.PrintGebouw();
        foreach (var flat in flats)
        {
            flat.PrintGebouw();
        }
        
    }
}
```