Op deze pagina vind je alle briljante en minder briljante oefeningen terug die niet meer bij een bepaald hoofdstuk staan. Meestal staan deze oefeningen hier omdat ze leerstof behandelen die niet meer bij de verplichte leerstof hoort.

## Alledaags

Zoek een foto naar keuze (nieuws, privé, etc) waarop meer dan één element opstaat (dus geen pasfoto of foto van blauwe lucht zonder wolken). Tracht de nodige klassen te verzinnen en verzin minstens 1 auto-property en 1 methode per klasse.  Maak in een console-applicatie vervolgens objecten van deze klassen aan en test ze. Voeg de foto aan je solution-folder toe.

Bijvoorbeeld: een foto van een betoging. Je zou minstens 3 klassen kunnen verzinnen (gebouw, politie, betoger). Van ieder van deze klassen maak je dan objecten aan zoals je ze op de foto ziet (uiteraard gaan we geen 30 betoger-instanties maken, enkele zijn genoeg, als voorbeeld).

# Binaire god

> Deze leerstof werd niet in het hoorcollege gezien. NEem zelf het hoofdstuk "Bitwise operators" door.

Vraag een getal aan de gebruiker (als int). Gebruik enkel bitwise operators om:

* het getal te verdubelen: onderzoek zelf hoe je binair verdubbelt (wat is de binaire voorstelling van 1,2,4, 8 bijvoorbeeld? Zie je het?)
* het getal te halveren: merk op dat dit enkel werkt voor even getallen
* het getal van teken te veranderen

Doe hetzelfde maar vraag nu aan de gebruiker een string met de binaire voorstelling van een getal (bv ``"0011"``) en zit dit eerst om naar een int. Toon telkens het resultaat zowel als int en als een binaire string voorstelling.


# APCenture-Job Agency

> Opgave is niet erg duidelijk.
> 
Maak een klasse ``Job``. Deze klasse heeft vier private fields

* Description (``string``) bijvoorbeeld "ruiten wassen"
* Duration (``int``) , stelt tijd voor die nodig is om job uit te voeren
* RatePerHour (``int``), stelt kostprijs per uur voor van deze job
* TotalFee (``int``), stelt totale prijs voor zijnde  ``Duration * RatePerHour``

Voorzie properties voor deze 4 velden, echter de TotalFee heeft geen ‘set’ daar deze een berekening van andere properties is en dus een read-only property is.

Telkens de Duration of RatePerHour wordt aangepast (set) wordt de TotalFee herberekend (je zal dus een private totalFee nodig hebben waar de public property TotalFee z’n waarde van krijgt).

Voorzie 2 constructors:

* Default constructor: stelt de description in op "onbekend" en zet duration en rateperhour op 0.
* Overloaded constructor: waarbij je de 3 velden (behalve TotalFee) kan aanpassen tijdens de constructie van een Job-object.

Toon de werking van je klasse aan door enkele objecten aan te maken met zowel de default als de overloaded constructor. Toon vervolgens dat TotalFee correct werkt.

# APCenture-Job Agency, deel 2: Operator Overloading

Pas de klasse ``Job`` aan zodat de + operator kan gebruikt worden om 2 job-objecten bij elkaar op te tellen.
Bv:

```java
Job epicDuoJob= jobOne+jobTwo;  //jobOne en jobTwo zijn ook van het type Job
```

De som van 2 job-objecten gaat als volgt te werk:

* Description: beide description worden na elkaar geplakt, waarbij het voegwoord ‘en’ tussen beide wordt gezet.
* Duration: som van beide durations
* RatePerHour: gemiddelde de ``rateperhour``van beide objecten

Toon in je main aan dat je nieuwe klasse werkt en dat je 2 jobs kan samenvoegen. Toon ook aan dat je vervolgens deze nieuwe samenvoeging op zijn beurt kan samenvoegen met een andere job (of zelfs met een andere samengevoegde job!).

# Breuk
Maak een klasse ``Breuk`` dat dus een breuk zal voorstellen met een noemer en teller.

Voorzie properties voor noemer en teller, waarbij de noemer niet 0 mag zijn (zet deze op 1 indien de gebruiker dit toch probeert).

Voeg 2 constructors toe:

* Default constructor: de breuk wordt ingesteld op 0/1
* Overloaded constructor: zowel de noemer als teller worden als parameter meegegeven

Voorts:

1. Voeg een ``+ operator`` toe die het mogelijk maakt om 2 breuken bij elkaar op te tellen. Wanneer de + operatie is toegepast wordt ook automatisch de Vereenvoudig-methode aangeroepen (zie verder) voor het resultaat wordt teruggegeven. Belangrijk: je dient aan operator overloading te doen. We willen dus dat je bijvoorbeeld kan schrijven ``Breuk breuksom= breuk1 + breuk2;``
2. Voeg voorts een ``* operator`` toe die breuken vermenigvuldigen mogelijk maakt (ook hier wordt het resultaat vereenvoudigd teruggegeven).
3. Voeg een methode ``AlsString`` toe die de breuk als string teruggeeft, waarbij de breuklijn als slash wordt voorgesteld.

Maak een array van 4 breuken in je main en laat de gebruiker deze alle 4 invullen. Toon vervolgens de som en vermenigvuldiging van deze 4 breuken als strings op het scherm.

Pro: Voeg een methode ``Vereenvoudig`` toe. Deze zal de breuk vereenvoudigen indien mogelijk. Als dus de breuk op 2/4 staat dan wordt deze na het uitvoeren van deze methode 1/2.



# Heroes of AP
 
 *Volgende opgave komt uit een examen van augustus 2018 van dit boek*

** Opgelet: deze opgave is erg brak en niet conform mijn gewoonlijke standaard.Waarvoor excuses**

## Inleiding
Heroes of AP is een single-player kaartspel dat we als consolespel spelenwaarbij de speler in zo weinig mogelijk beurten maximaal punten wil scoren. Het spel is een combinatie van geluk en strategie.
Spelregels
Heroes of AP bestaat uit een deck van tien kaarten met drie soorten kaarten:
* Landen: deze genereren mana 
  * Per beurt dat een kaart gedekt ligt verhoogt z’n mana-waarde (=COST)
* Centrales:
  * Per beurt genereert een centrale 1 punt indien deze zichtbaar is 
* Helden: deze gebruiken mana om punten te genereren
  * Per beurt dat een kaart gedekt ligt verlaagt z’n mana-waarde (=COST), maar nooit onder 1
  * Een held genereert een willekeurig aantal punten indien hij zichtbaar is afhankelijk van wat de gebruiker aan Mana betaald:
    * Om 1 punten te genereren moet de speler de Cost van de held in mana betalen
    * Het overschot aan mana dat de speler betaald zal ervoor zorgen dat de held mogelijk meer punten maakt, namelijk tussen 1 en het extra aan mana.

## Opzetten spel

* De speler krijgt 10 willekeurige kaarten  voor zich die gedekt blijven liggen. 
* Vijf kaarten zijn landkaarten,3 kaarten zijn centrales, 2 kaarten zijn helden
  * Iedere kaart heeft een willekeurige kost tussen 5 en 10

## Spelen spel

Zolang de speler geen 10 punten heeft zal de speler steeds een beurt spelen bestaande uit 4 fasen:
* **Fase 0 - Upkeep**: 
  *  alle landen die gedekt liggen zullen hun Cost met 1 verhogen (deze landen kunnen dus meer mana genereren van zodra de speler ze omdraait)
  *   alle helden die nog gedekt zijn hun Cost verlaagt met 1 (maar nooit lager dan 1)
  * alle centrale die zichtbaar zijn genereren 1 punt (hun Cost wordt niet gebruikt)
* **Fase 1 - FlipCard**: de speler kiest een kaart die moet omgekeerd worden.
  * Enkel kaarten die nog niet omgekeerd werden kunnen uiteraard omgekeerd worden.
* **Fase 2 - GenerateMana**: De speler kiest welke land mana genereert (enkel mogelijk indien er zichtbare landen zijn)
   * Een land genereert evenveel mana als de Cost van de kaart
* **Fase 3 - GeneratePoint**: De speler kiest welke held punten genereert (enkel mogelijk indien er zichtbare helden zijn)
  * De speler betaald hiervoor de cost van de held in mana. De held genereert vervolgens een willekeurig aantal punten tussen 1 en de cost van de held.

# Basisspel maken
## Deel 1 (8 punten)

**Gebruik de gegeven klassen (onderaan de opgave) in je project en pas ze aan waar nodig**

![](../../assets/Aallinone/heroap0.png) 
 
Vul de 3 klassen aan klassen om aan bovenstaand schema te voldoen:
* **``Land``:** 
  * Land is een ``Card``
  * Heeft een methode ``GenerateMana`` die mana zal returnen gelijk aan de ``Cost`` van het land, maar enkel indien het land zichtbaar is (``IsHidden==false``)
  * Heeft als ``Name`` altijd "Land"
  * Zal bij de ``DrawCard`` methode zichzelf in groene tekst op het scherm zetten, namelijk z’n ``Name``, gevolgd door z’n Cost (bv ``"Land 5"``)
  * Verhoogt z’n ``Cost`` met 1 wanneer ``UpdateCost`` wordt aangeroepen
* **``Centrale``:**
  * Centrale is een ``Card``
  * Heeft als Name altijd "Centrale"
  * Zal bij de ``DrawCard`` methode zichzelf in geel tekst op het scherm zetten, namelijk z’n Name (bv ``"Centrale"``)
  * Heeft de interface ``IPointGenerator``
  * Zal steeds 1 punt genereren bij ``GeneratePoints`` (de parameter die wordt meegegeven wordt niet gebruikt).
* **``Hero``:**
  * Hero is een ``Card``
  *	Heeft als ``Name`` altijd "Hero"
  * Heeft de interface ``IPointGenerator``
  * Zal bij de ``DrawCard`` methode zichzelf in gele tekst op het scherm zetten, namelijk z’n Name, gevolgd door z’n Cost (bv ``"Hero 6"``)
  * Heeft een methode ``GeneratePoints`` die 1 parameter aanvaardt van het type int. Indien de parameter gelijk is aan Cost zal de methode een willekeurig getal tussen 1 en Cost teruggeven als punten. 
 
* **``Deck``:**
  * Deck heeft een lijst van kaarten genaamd Kaarten, van het type ``List<Card>`` 
  * Deck heeft een default constructor: wanneer deze aangeroepen wordt zullen er 10 willekeurige kaarten (3 Centrale, 2 Hero, 5 Land) in de Kaarten-list geplaatst worden
  * Deck heeft een methode ``DrawCards``: deze zal de ``DrawCard`` van alle Kaarten aanroepen
  * Deck heeft een methode ``UpdateCosts``: deze zal de ``UpdateCost`` van alle Kaarten aanroepen die dat kunnen.
  * Deck heeft een methode ``GeneratePoints``: deze zal de ``GeneratePoints`` van alle Kaarten aanroepen die dat kunnen.
  * Kaarten-list is beschikbaar vanuit een readonly-property

## Deel 2: Basis game loop (8 punten)

Maak een basis-versie van het spel. 

1. Genereren van een Deck-object en de kaarten op het scherm tonen via DrawCards
2. Een loop die blijft herhalen tot de gebruiker 10 punten heeft
   * Alle interactie met de kaarten gebeurt uiteraard via het Deck-object
   * Bestaat uit de 4 fasen die al dan niet vragen aan de gebruiker wat er moet gebeuren
     * **Fase 0**: update costs van verborgen kaarten + Genereer punt per zichtbare Centrale
     * **Fase 1**: vraag aan gebruiker welke kaart moet omgekeerd worden
     * **Fase 2**: vraag aan gebruiker welk land mana moet genereren
     * **Fase 3**: vraag aan gebruiker welke held punten moet genereren
   * Na iedere fase ververs je het beeld (``Console.Clear()``) en herteken je de kaarten en toon je de volgende extra info aan de gebruiker, namelijk Mana, Punten en Beurt
   ![](../../assets/Aallinone/heroap1.png) 
3. Na de loop wordt getoond hoeveel beurten de gebruiker heeft nodig gehad


## Deel 3 Extras

* 1 punt: Gebruik een enum om bij te houden in welke fase van een beurt je bent.
* 2 punten: plaats alle spel-logica in deck zodat de gameloop enkel nog maar bestaat uit de aanroep van een ``SpeelBeurt()``-methode en een check of de loop moet gestopt worden.

# Voorbeeld spelverloop: 
 
![](../../assets/Aallinone/heroap.png) 

# Start klasen

## Card

```java
abstract class Card
{
    public Card(string naamin)
    {
        Name = naamin;
    }

    public abstract void DrawCard();
    protected int cost;

    private string name;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }
}
```

## IPointGenerator

```java
interface IPointGenerator
{
    int GeneratePoints(int payedmana);
}
```

# Oplossing
```java
    abstract class Card
    {
        public Card(string naamin)
        {
            Name = naamin;
        }
        public bool IsHidden { get; set; }
        public abstract void DrawCard();
        public abstract void UpdateCost();
        protected int cost;

        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
    }

     class Centrale : Card, IPointGenerator
    {
        public Centrale() : base("Centrale")
        {

        }

        

        public override void DrawCard()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Name);
            Console.ResetColor();
        }

        public int GeneratePoints(int payedmana)
        {
            return 1;
        }

        public override void UpdateCost()
        {
            //Do nothing
        }
    }

    class Deck
    {
        private List<Card> cards = new List<Card>();

        public List<Card> Cards
        {
            get { return cards; }
            private set { cards = value; }
        }

        public Deck()
        {
            for (int i = 0; i < 3; i++)
            {
                Centrale nieuweCentrale = new Centrale();
                Cards.Add(nieuweCentrale);
            }
            for (int i = 0; i < 2; i++)
            {
                Hero nieuweHero = new Hero();
                Cards.Add(nieuweHero);
            }
            for (int i = 0; i < 5; i++)
            {
                Land nieuwLand = new Land();
                Cards.Add(nieuwLand);
            }
        }

        internal int GenerateLandPoint(int keuzeland)
        {
            if (Cards[keuzeland] is Land)
                return (Cards[keuzeland] as Land).GenerateMana();
            return 0; //Dit is geen land!


        }

        internal int GenerateHeroPoint(int keuzehero, int mana)
        {
            if (Cards[keuzehero] is Hero)
                return (Cards[keuzehero] as Hero).GeneratePoints(mana);
            return 0; //Dit is geen hero!
        }

        public void DrawCards()
        {
            int teller = 1;
            foreach (var elem in Cards)
            {
                Console.Write(teller);
               elem.DrawCard();
                teller++;
            }
        }

        public void UpdateCost()
        {
            foreach (var elem in Cards)
            {
                if (elem is Land)
                {
                    Land temp = elem as Land;
                    if (temp.IsHidden)
                        temp.UpdateCost();
                }

                if (elem is Hero)
                {
                    Hero temp = elem as Hero;
                    if (temp.IsHidden)
                        temp.UpdateCost();
                }
            }
        }

        public void GenerateCentralePoints()
        {
            foreach (var elem in Cards)
            {
                if (elem is Centrale)
                {
                    if (!((Centrale)elem).IsHidden)
                    {
                        ((Centrale)elem).GeneratePoints(1);
                    }
                }
            }
        }
    }

        class Hero : Card, IPointGenerator
    {
        public Hero() : base("Hero")
        {

        }

        public override void DrawCard()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Name + " " + cost);
            Console.ResetColor();
        }
        static Random generator = new Random();
        public int GeneratePoints(int payedmana)
        {
            if (payedmana == cost)
            {
                return generator.Next(1, cost);
            }
            return 0;
        }
        public override void UpdateCost()
        {
            if (cost - 1 > 0)
                cost--;
        }
    }

        class Land : Card
    {
        public Land() : base("Land")
        {
        }

        public override void DrawCard()
        {
          
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Name + " " + cost);
            Console.ResetColor();
        
        }

        public int GenerateMana()
        {
            if (!IsHidden)
            {
                return cost;
            }
            else
            {
                return 0;
            }
        }

        public override void UpdateCost()
        {
            cost++;
        }
    }
```

```java
static void Main(string[] args)
{
    //deck genereren
    Deck deck = new Deck();
    int points = 0;
    int mana = 0;
    int tries = 0;
    while (points <= 10)
    {
        tries++;
        Console.WriteLine($"Mana:{mana} Points:{points} Tries:{tries}");
        deck.DrawCards();

        //Fase 0
        deck.UpdateCost();
        deck.GenerateCentralePoints();
        //Fase 1
        Console.WriteLine("Welke kaart omdraaien?");
        int keuze = Convert.ToInt32(Console.ReadLine());
        deck.Cards[keuze].IsHidden = false;

        //Fase 2
        Console.WriteLine("Welke land genereert punten?");
        int keuzeland = Convert.ToInt32(Console.ReadLine());
        mana += deck.GenerateLandPoint(keuzeland);

        //Fase 3
        Console.WriteLine("Welke hero genereert punten?");
        int keuzehero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hoeveel mana ga je betalen?");
        int manac = Convert.ToInt32(Console.ReadLine());
        points += deck.GenerateHeroPoint(keuzehero,manac);
        mana -= manac;
        Console.ReadLine();
        Console.Clear();
    }
}
```