# Maak volgende klassen
Maak 2 klassen: ``Enclave`` en ``StadsEnclave``
![Schematische voorstelling van de enclave](/assets/7_overerving/coronacompo.jpg)

Een enclave heeft 1 hospitaal, 1 generator en 1 of meerdere woonsten. Wanneer een enclave wordt aangemaakt heeft deze 3 woningen van bij de start, alsook een werkende generator en hospitaal. Al deze gebouwen komenop een willekeurige plek.

Een enclave heeft een virtuele methode ``BouwWoonst``. Wanneer deze wordt aangemaakt wordt er een woonst aan de enclave toegevoegd. Het huis komt op een willekeurige locatie maar nooit op een plek waar reeds andere gebouwen staan.

Een enclave heeft een virtuele methode ``ToonEnclave`` die alle gebouwen op het scherm zal ztetten.

Een stadsenclave heeft naast alles wat hij dankzij overerving van de enclave heeft ook nog een waterkrachtcentrale, een extra hospitaal en 1 of 2 flats. Van bij de start heeft een stadsenclave enkel de zaken die een gewone enclave van bij de start heeft.

De stadsenclave override ``BouwWoonst``. Deze zal nog steeds een woonst toevoegen, maar iedere keer als de enclave 3 woningen heeft worden deze verwijderd en komt er een flat in de plaats (op locatie naar keuze). 

De stadsenclave override ``ToonEnclave`` om ook de andere gebouwen (flat, extra hospitaal, waterkrachtcentrale) op het scherm te tekenen.

# Applicatie
Maak een eenvoudig programma dat 2 enclaves en 2 stadsenclaves aanmaakt. De gebruiker kan per enclave/stadenclave kiezen van welke enclave de bouwwoonst methode moet aangeroepen worden. Vervolgens wordt deze enclave op het scherm getoond m.b.v. toonenclave. Vervolgens verschijnt terug het keuze menu waarin gebruiker kan kiezen welke enclave nu een woonst moet bouwen. Dit blijft oneindig duren.

# Dictionary

Maak nu een dictionary aan: ``Dictionary<string, Enclave>``. De string is de naam van de enclave (bv "Antwerpen"). Merk op dat je zowel ``Enclave`` als ``StadsEnclave`` objecten aan deze lijst kunt toevoegen.

De gebruiker kan nu naast de werking van daarnet ook volgende zaken doen
1. Een nieuwe enclave of stadsenclave aanmaken en deze een naam geven. Zo wordt deze in de dictionary bewaard
2. Via de naam van de enclave kan de gebruiker kiezen van welke enclave ``BouwWoonst`` moet aangeroepen worden. 

