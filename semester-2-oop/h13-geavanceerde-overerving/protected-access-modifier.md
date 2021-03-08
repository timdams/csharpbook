# protected access modifier

De `private` \("enkel toegankelijk binnen code van deze klasse"\) en `public` \("toegankelijk van overal"\) access modifier stellen twee extremen voor met betrekking tot encapsulatie. Wanneer je overerving toepast, is dit niet altijd ideaal.

We nemen volgende code als voorbeeld:

```csharp
    public abstract class Persoon
    {
        private DateTime geboorteDatum;
        private string naam;
        public string Naam
        {
            get
            {
                return this.Naam;
            }
        }
        public virtual string NaamKaartje()
        {
            DateTime nu = DateTime.Now;
            int verschilJaren = nu.Year - this.geboorteDatum.Year;
            if (nu.Month < this.geboorteDatum.Month || nu.Month == geboorteDatum.Month && nu.Day < geboorteDatum.Day)
            {
                verschilJaren -= 1;
            }
            return $"{this.Naam} ({verschilJaren})";
        }
    }
```

Deze code kan gebruikt worden om een naamkaartje voor een persoon te genereren, met daarop de naam en tussen haakjes de leeftijd van die persoon. De leeftijd is volledig privé \(er is ook geen property om hem op te vragen, in tegenstelling tot de naam\). Dat betekent dat we niet, bijvoorbeeld, het volgende kunnen doen:

```csharp
    public class Student : Persoon
    {
        public override string NaamKaartje()
        {
            string output = $"Hallo, mijn naam is {this.Naam}";
            DateTime nu = DateTime.Now;
            if (nu.Day == this.geboorteDatum.Day && nu.Month == this.geboorteDatum.Month)
            {
                output += "\nHet is mijn verjaardag!";
            }
            return output;
        }
    }
```

Dit zou een speciaal naamkaartje afprinten voor studenten op hun verjaardag. Maar code binnen de klasse `Student` kan niet aan de verjaardag, want die is `private` en `Student` is een andere klasse dan `Persoon`. Mogelijk is het **geen** optie om een publieke getter te voorzien voor de verjaardag, omdat het niet de bedoeling is dat andere klassen dan de subklassen van `Persoon` er gebruik van maken: hoe meer encapsulatie, hoe liever.

Daarom is er een tussenoplossing: de `protected` access modifier. Deze zorgt ervoor dat een bepaald deel van een klasse zich als `private` gedraagt naar de buitenwereld, maar als `public` naar de eigen kindklassen. Zo wordt encapsulatie geen alles-of-iets verhaal:

Met andere woorden: als je in bovenstaande code het veld `geboorteDatum` `protected` maakt in plaats van `private`, wordt je code wel uitvoerbaar.

