## Debuggen

"Joepie!! M'n code werkt!" Je ontkurkt de champagne/bier/melk/frisdrank/water, doet een Fortnite danske en laat je programma door duizenden, neen miljoenen gebruikers ontdekken. Nog geen uur later staat er een meute met hooivorken en toortsen voor je kantoor. 

Helaas, er zaten nog "een paar bugs" in je code...

Tijd dus om je **debugger** boven te halen en die (logische) fouten uit je code te halen.

### Logische fouten vs C# fouten

Code die compileert is enkel code die foutloos geschreven is volgens de C# afspraken qua grammatica en syntax. De code zal met andere woorden gecompileerd worden, maar wat er daarna gebeurt is volledig afhankelijk van wat juist de betekenis is van wat je hebt geschreven.

Volgende algoritme bijvoorbeeld is perfecte Nederlandstalige code en zal dus door een fictieve compiler kunnen gecompileerd worden. Het vervolgens uitvoeren is echter niet aan te raden (natrium en water samen geeft een stevige exotherme reactie):

<!---{line-numbers:false}--->
```text
Neem natrium
Neem water
Voeg beide samen
```

Dit is dus een logische fout, oftewel bug (in dit geval een **BOEM!!!!**).


### Debuggen met Visual Studio

Standaard wanneer je je code uitvoert met de grote groene playknop start jouw programma in zogenaamde "debug modus". Dit laat je toe om je code ten allen tijde te onderbreken en naar de huidige staat van je programma te kijken. Je kan dan bijvoorbeeld onderzoeken wat de waarden van bepaalde variabelen zijn op dat moment en of die wel correct zijn. Dit is bughunting en zal je héél vaak doen in je programmeer-carrière. 

Om dit te doen moet je een **breakpoint** (of meerdere) in je code plaatsen. Breakpoint zet je aan een lijn code en wanneer je programma dan aan deze lijn komt tijdens de uitvoer zal de debugger alles pauzeren.

Een breakpoint plaats je door op het grijze gedeelte links van de lijn code te klikken. Als alles goed gaat verschijnt er dan een grote rode "breakpointbol":
<!--- {height:30%} --->
![](../assets/1_csharpbasics/breakpoint.png)

In bovenstaande figuur plaatsen we een breakpoint aan lijn 11. De code uitvoer zal dus nog wel lijn 10 uitvoeren, maar niet lijn 11.

Als je nu je project uitvoert zal de code pauzeren aan die lijn en zal VS in "debug modus" openspringen wat er vervolgens als volgt uit ziet:
![](../assets/1_csharpbasics/debugmode.png)

In dit "nieuwe" scherm zijn er momenteel 2 belangrijke delen:
* Onderaan zie je de **autos** en **locals** . In deze tabs kan je de waarden van iedere variabele in je huidige code zien op het moment van pauzeren. Ideaal om te onderzoeken waarom een bepaalde berekening of expressie niet doet wat ze moet doen.
* Bovenaan zijn enkele debug-knoppen verschenen. Deze lichten we in de volgende sectie toe.
* Voorts kan je in debug-modus kan  met je muis over eender welke variabele of expressie *hoveren* om het resultaat van dat element te bekijken wat we in volgende afbeeldingen tonen

![Kan je trouwens verklaren waarom deze deling 0 blijkbaar geeft en niet 1.667.](../assets/1_csharpbasics/debugbug.png)


### Door je code steppen

Wanneer je gepauzeerd bent kan je de nieuw verschenen debug-knoppen boven gebruiken om het verdere verloop te bepalen:

![Debug knoppen](../assets/1_csharpbasics/debugmove.png)

We lichten hier de knoppen toe die je zeker zal nodig hebben:
* De **continue** knop is logisch: hier op klikken zal je programma terug voortzetten vanaf het breakpoint waar je gepauzeerd bent. Het zal vervolgens verder gaan tot het weer een breakpoint bereikt of wanneer het einde van het programma wordt bereikt.
* De **rode stop** knop gebruik je indien je niet verder wilt debuggen en ogenblikkelijk terug je code wilt aanpassen.
* De **step-over** knop (het gebogen pijltje) is een belangrijke knop. Deze zal je code & lijn code verder uitvoeren en dan weer pauzeren. Het laat je dus toe om letterlijk doorheen je code te *stappen*. Je kan dit doen om de flow van je programma te bekijken (zie volgende hoofdstukken) en om te zien hoe bepaalde variabelen evolueren doorheen je code. 

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)

Pfft. Debuggen. Waarom moet ik me daar nu mee bezig houden? 

Even je oren open zetten aub, ik ga iets roepen:**"Debugging is een ESSENTIËLE SKILL!!!"**. Ik laat mijn metselaars ook geen huizen bouwen zonder dat ze ooit een truweel hebben vastgepakt. Een programmeur die niet kan debuggen...is als een vis die niet kan zwemmen!. 
 
 Zorg dus dat je vlot breakpoints kunt plaatsen om zo tijdens de uitvoer te pauzeren om de inhoud van je variabelen te bekijken (via het zogenaamde watch-venster). Gebruik vervolgens de "step"-buttons om door je code te 'stappen', lijn per lijn.

 Is that al?!

 NEEN! Een goede programmeur zal telkens **eerst voorspellen** wat er gaat gebeuren: welke waarden zullen de variabelen hebben als ik naar de volgende lijn ga? Wat gaar er op het scherm komen? Etc. Als je dan vervolgens naar de volgende lijn gaat of breakpoint gaat en er gebeuren dingen die je niet voorspeld had, dan is de kans groot dat je een bug hebt gevonden.

 De grootste fout die je kunt doen is gewoon door je code te "steppen" en hopen dat de bug magisch zal tevoorschijn komen. Neen, zo werkt het dus niet. Je moet actief mee denken of dat je programma effectief op een logische manier, zoals jij het voor ogen had, werkt. 

 Dit geldt trouwens ook wanneer je niet aan het debuggen bent, maar gewoon je programma uitvoert om het te testen. Eigenlijk ben je dan ook aan het debuggen. Ook dan moet je voorspellen wat het eindresultaat zal zijn en of dit overeen komt met wat er op het scherm gebeurt. **Wees kritisch!**
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)
* [Debuggen in VS ](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a78b3bf5-ef96-4c2a-8248-a976006fabd1)
<!---NOBOOKEND--->

