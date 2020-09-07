## Object initializer syntax

Uit het vorige hoofdstuk over constructor leren we dat je moet opletten dat je niet tientallen overloaded constructor schrijft voor iedere combinatie van parameters die je mogelijk nodig hebt. Meestal beperken we het tot de default constructor en 1 of 2 heel veel gebruikte overloaded constructor.

Dankzij object initializer syntax kan je namelijk ook parameters aan variabelen meegeven zonder dat je hiervoor een specifieke constructor voor moet schrijven.

Object initializer syntax laat je toe om tijdens (eigenlijk direct er na) creatie van een object Propertier beginwaarden te geven.

Stel dat we volgende klasse hebben:

```java
class TemperatuurMeting
{
    public double Temperatuur {get;set;}
    public string GemetenDoor {get;set;}
    public bool IsGeconfirmeerd {get;set;}
}
```

We kunnen deze properties beginwaarden geven via volgende initializer syntax:

```java
TemperatuurMeting eenMeting = new TemperatuurMeting { Temperatuur= 3.4, IsGeconfirmeerd=true};
```

Enkele opmerkingen hierbij:

* Je ziet het niet, maar sowieso wordt eerst nu de (onzichtbare) default constructor aangeroepen. Pas wanneer die klaar is zullen de properties de waarden krijgen die je meegeeft. Als je dus zelf een default constructor in ``TemperatuurMeting`` had geschreven dan had eerst die code uitgevoerd zijn geweest. Voorgaande voorbeeld zal intern eigenlijk als volgt plaatsvinden:

```java
TemperatuurMeting eenMeting = new TemperatuurMeting();
eenMeting.Temperatuur = 3.4;
eenMeting.IsGeconfirmeerd = true;
```

* Je hoeft niet alle (publieke) properties via deze syntax in te stellen, enkel de zaken die je wilt meegeven.

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Object initializer syntax](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=8f1ceebc-9f02-4593-84da-ab7a0099bf99)
<!---NOBOOKEND--->