# EAICT Coding guidelines

## Naamgeving

* **Duidelijke naam**: de identifier moet duidelijk maken waarvoor de identifier dient. Schrijf dus liever ``gewicht`` of ``leeftijd`` in plaats van ``a`` of ``meuh``. 
* **Camel casing**: gebruik camel casing indien je meerdere woorden in je identfier wenst te gebruiken. Camel casing wil zeggen dat ieder nieuw woord terug met een hoofdletter begint. Een goed voorbeeld kan dus zijn ``leeftijdTimDams`` of ``aantalLeerlingenKlas1EA`` . Merk op dat we liefst het eerste woord met kleine letter starten.
* **Prefereer cijfers en letters**: gebruik geen liggende streepjes of andere karakters die geen cijfers of letters zijn.
* **Private kleine letter, public hoofdletter**: private variabelen starten met een kleine letter (bv ``pagesBook``), public variabelen (zie volgende boek) met een grote letter (bv. ``SizeBook``).
* **Methoden met hoofdletter**: methoden starten steeds met een hoofdletter (bv. ``OpenDataBase``).
* **Geen afkortingen**: Schrijf ``GetWindowsSize`` in plaats van ``GetWinSz``.
* **``Enum``**: zowel de naam van het enum-type als de afzonderlijke waarden starten met een hoofdletter
* **Solution/Project**: je VS solution en project-namen geef je steeds met een hoofdletter en volgt vervolgens de afspraken van identifiers: enkel liggende strepen, getallen en letters, inclusief camelcasing