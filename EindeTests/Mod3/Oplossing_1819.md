# Oplossing

## Main (Program.cs)

```java
Console.WriteLine("Rise and shine");
Console.WriteLine($"Het is nu {DateTime.Now.Hour}:{DateTime.Now.Minute}");
var log = QalAnalyzer.CreateDiary();
QalAnalyzer.AnalyseDiary(log);

QalAnalyzer.SummariseDiary(log);

Console.WriteLine("Dagboek wegschrijven?(j/n");
string csv = Console.ReadLine();
if(csv=="j")
{
    Console.WriteLine("Geef bestandsnaam");
    string nm = Console.ReadLine();
    QalAnalyzer.WriteDiary(log,nm);
}
```

## DagboekEntry Klasse

```java
class DagboekEntry
{
    public DagboekEntry()
    {
        ResetEntry();
    }
    public DagboekEntry(int qin, bool isinspin, bool isprivin, string descin)
    {
        Qal = qin;
        IsInspired = isinspin;
        IsPrivate = isprivin;
        Description = descin;
    }
    public bool IsInspired { get; set; }
    private string description;

    public string Description
    {
        get
        {
            if (isPrivate)
                return "***PRIVATE***";
            else return description;
        }
        set
        {
            description = value;
        }
    }

    private int qal;

    public int Qal
    {
        get { return qal; }
        set
        {
            if (value >= 0 && value <= 100)

                qal = value;
            else if (value < 0)
                qal = 0;
            else if (value > 100)
                qal = 100;
        }
    }
    private bool isPrivate = false;
    public void MakePrivate(bool goprivate)
    {
        IsPrivate = goprivate;
    }

    public bool IsPrivate
    {
        get { return isPrivate; }
        private set { isPrivate = value; }
    }
    public void ResetEntry()
    {
        isPrivate = false;
        qal = 50;
        description = "";
    }

    public void ShowLog()
    {
        Console.WriteLine("********");
        Console.WriteLine("ENTRY:");
        Console.WriteLine(Description);
        Console.WriteLine("QaL=" + qal);
        Console.WriteLine("********");
    }

}
```

## QalAnalyzer Klasse

```java
class QalAnalyzer
{
    public static void SummariseDiary(List<DagboekEntry> log)
    {
        foreach (var item in log)
        {
            item.ShowLog();
        }
    }

    public static void AnalyseDiary(List<DagboekEntry> log)
    {
        int qal = 0;
        int sominspired = 0;
        foreach (var qalitem in log)
        {
            if (!qalitem.IsPrivate)
                qal += qalitem.Qal;
            if (qalitem.IsInspired)
                sominspired++;
        }


        Console.WriteLine("Totale Quality of Life in deze periode (zonder private) " + qal);
        Console.WriteLine("Gemiddelde geïnspireerde dagen: " + (double)sominspired/log.Count);
    }

    internal static void WriteDiary(List<DagboekEntry> log, string filename)
    {
        string alllines = "";
        foreach (var logitem in log)
        {
            alllines+= $"{logitem.Qal};{logitem.IsInspired};{logitem.Description};{logitem.IsPrivate}{Environment.NewLine}";
        }
        System.IO.File.WriteAllText(filename, alllines);
    }

    public static List<DagboekEntry> CreateDiary()
    {
        Console.WriteLine("Hoeveel dagen wil je loggen in je dagboek?");
        int dagen = Convert.ToInt32(Console.ReadLine());
        List<DagboekEntry> diary = new List<DagboekEntry>();
        for (int i = 0; i < dagen; i++)
        {
            DagboekEntry l = new DagboekEntry();
            Console.WriteLine($"Dag {i + 1}: {DateTime.Now.AddDays(i).DayOfWeek}");
            Console.WriteLine("Hoe was je dag?");
            l.Description = Console.ReadLine();
            Console.WriteLine("Voelde je je geïnspireerd?(y/n)");
            string inspired = Console.ReadLine();
            if (inspired == "y")
                l.IsInspired = true;

            Console.WriteLine("Welke score geef je deze dag?");
            int score = Convert.ToInt32(Console.ReadLine());
            l.Qal = score;

            Console.WriteLine("Is dit een private entry?(y/n)");
            string prive = Console.ReadLine();
            if (prive == "y")
            {   
                 l.MakePrivate(true);
            }

            diary.Add(l);
        }
        return diary;
    }
}
```