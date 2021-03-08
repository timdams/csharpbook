---
marp: true
---
<style>
section {
  padding: 100px;
  padding-left: 140px;
  padding-bottom: 200px;
  background-image: url('background.png');
  background-size: cover;
}
h1 {
    color: rgb(153,35,36)
}
</style>

# OO Programmeren
<style scoped>
section {
  padding-left: 400px;
  color: white;
}
h1 {
  font-size: 60px;
  color: white;
}
a {
  color: white ;
}
h3 {
  font-size: 40px;
  color: white
}
</style>
![bg](background_cover.png)

DateTime: Leren werken met objecten

https://apwt.gitbook.io/cursus-pro-oo/


---

# DateTime objecten aanmaken

2 manieren om DateTime objecten aan te maken:
 - **DateTime.Now**
   - voor de huidige tijd te gebruiken.
 - **Via de constructor**
   - voor manueel de datum en tijd in te stellen.

---

# DateTime.Now

```csharp
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
        }
    }
}

```

---

# Via constructor

```csharp
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //year, month, day
            DateTime birthday = new DateTime(1984, 12, 13);
            //year, month, day, hour, min, sec
            DateTime someMomentInTime = new DateTime(2020, 2, 12, 18, 15, 00); 
        }
    }
}

```

---

# Add methoden

- Voegen een bepaald aantal dagen, uren, minuten,... aan je huidig object toe.
- **DateTime is immutable**
  - De Add methoden geven steeds een nieuw DateTime object


---

# Add methoden
```
public DateTime AddYears(int years);
public DateTime AddMonths(int months);
public DateTime AddDays(double value);
public DateTime AddHours(double value);
public DateTime AddMinutes(double value);
public DateTime AddSeconds(double value);
public DateTime AddMilliseconds(double value);
public DateTime AddTicks(long value)
```

---

# Add methoden - voorbeeld

```csharp
DateTime timeNow = DateTime.Now;
DateTime nextWeek = timeNow.AddDays(7);
```
en
```csharp
DateTime someTime= new DateTime(2019, 4, 1);

//much later...
someTime = someTime.AddYears(10);
Console.WriteLine(someTime);
```
---

# DateTime properties

- Interne staat van objecten uitlezen én aanpassen
- Het fijne aan properties is dat:
  - Je gebruikt ze alsof het gewone variabelen zijn.
  - Ze werken zoals methoden.
- Alle properties van DateTime zijn read-only.

---

# DateTime properties
```
Date
Day
DayOfWeek
DayOfYear
Hour
Millisecond
Minute
Month
Second
Ticks
TimeOfDay
Today
UtcNow
Year
```

---
# DateTime properties - voorbeeld

```
DateTime moment = new DateTime(1999, 1, 13, 3, 57, 32, 11);

// Year gets 1999.
int year = moment.Year;

// Month gets 1 (January).
int month = moment.Month;

// Day gets 13.
int day = moment.Day;

// Hour gets 3.
int hour = moment.Hour;

// Minute gets 57.
int minute = moment.Minute;

// Second gets 32.
int second = moment.Second;

// Millisecond gets 11.
int millisecond = moment.Millisecond;
```

---
# Datum en tijd formatteren

**DateTime objecten omzetten naar string met extra formatter syntax**

```
DateTime now = DateTime.Now;

WriteLine(now.ToString("d")); // short date 
WriteLine(now.ToString("D")); // long date
WriteLine(now.ToString("F")); // full date and time
WriteLine(now.ToString("M")); // month and day
WriteLine(now.ToString("o")); // date en time separated by T and time zone at the end
WriteLine(now.ToString("R")); // RFC1123 date and time
WriteLine(now.ToString("t")); // short time
WriteLine(now.ToString("T")); // long time
WriteLine(now.ToString("Y")); // year and month
```


---
# Datum en tijd formatteren - Custom

```
using System;  

namespace OOP  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            // Get current DateTime. It can be any DateTime object in your code.  
            DateTime aDate = DateTime.Now;  
  
            // Format Datetime in different formats and display them  
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));  
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));  
            Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm"));  
            Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm:ss"));  
            Console.WriteLine(aDate.ToString("MMMM dd"));  
        
         }  
    }  
}  
```

---
# Datum en tijd formatteren - Localized time

- ToString Afhankelijk van de landinstellingen van je systeem
- **Wil je anders?** Culture specificeren
```
DateTime now = DateTime.Now;
CultureInfo russianCI = new CultureInfo("ru-RU");

Console.WriteLine($"Current time in Russian style is: {now.ToString("F", russianCI)}");
// Current time in Russian style is: понедельник, 10 февраля 2020 г. 20:45:46
```
---
# Culture names (Voorbeelden)
```
// https://www.csharp-examples.net/culture-names/
...

       de-DE       German (Germany)
       de-CH       German (Switzerland)

       nl-NL       Dutch
       nl-BE       Dutch (Belgium)
       nl-NL       Dutch (Netherlands)

       en-GB       English (United Kingdom)
       en-IE       English (Ireland)
       en-US       English (United States)
       en-NZ       English (New Zealand)

...
```

---
# Static methoden

- Kan je enkel rechtstreeks aanroepen op de klasse.
- Vaak hulpmethoden waar individuele objecten niets aan hebben.

---
# Parsing time

- Parsen laat toe dat je strings omzet naar DateTime. 
- handig als je via ReadLine tijd en datum wilt laten invoeren.
- Afhankelijk van huidige Culture.

```
string dateString = "8/11/2016"; //dit zou dus ook door gebruiker kunnen ingetypt zijn
DateTime dt = DateTime.Parse(dateString);
Console.WriteLine(dt);
```
---
# IsLeapYear

**Geeft een bool terug als object eens schrikkeljaar is of niet**

```
DateTime today= DateTime.Now;
bool isLeap = DateTime.IsLeapYear(today.Year);
if (isLeap==true)
    Console.WriteLine("This year is a leap year");
```

---
# TimeSpan

Je kan DateTime objecten ook bij mekaar optellen en aftrekken. Resultaat is **GEEN** DateTime object maar **TimeSpan**

```
DateTime today = DateTime.Today;
DateTime borodino_battle = new DateTime(1812, 9, 7);

TimeSpan diff = today - borodino_battle;

WriteLine("{0} days have passed since the Battle of Borodino.", diff.TotalDays);
```
