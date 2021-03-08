
> Tijd om die enclaves aan het werk te zetten.

Gebruik de applicatie uit de vorige missie als startpunt.

# Opgelet: 
Zorg ervoor dat minstens volgende zaken in je code aanwezig zijn:
* ``is`` keyword
* ``as`` keyword
* controle of een object ``null`` is of niet

# GroeiEnclave
Voeg een methode "GroeiEnclave" toe aan je hoofdprogramma. Deze methode aanvaardt een referentie naar een object van het type ``Enclave``. 

De methode zal eerst de ``ToonEnclave`` aanroepen zodat de gebruiker de enclave vooraf ziet.

Controleer in je methode of het object dat je krijgt een Enclave of een StadsEnclave is.

Indien het om een Enclave gaat zal de methode in de enclave een gebouw naar keuze toevoegen (de applicatie kiest dus random welk type).
Indien het om een StadsEnclave gaat zal de methode in de stadsenclave 2 gebouwen naar keuze toevoegen.

(hou rekening met de compositiebeperkingen uit de vorige missie: een ``eEclave`` kan bijvoorbeeld geen Waterkrachtcentrale hebben)

Vervolgens roept de methode weer ``ToonEnclave`` op zodat de gebruiker de enclave met z'n groei ziet.
In een zinnetje toon je finaal ook nog wat er werd toegevoegd door de ``PrintGebouw``  van het gemaakte gebouw aan te roepen.

# Menu uitbreiden
De gebruiker kan in het hoofdmenu de optie "GroeiEnclave" kiezen en dan opgeven welk object in de dictionary moet groeien. Vervolgens wordt het gekozen object in de dictionary doorgeven aan de methode en zal dit object groeien.

