# Labo

{% hint style="warning" %}
Dit is een behoorlijk abstract hoofdstuk. Daarom wordt er veel gedemonsteerd. Volg de demonstraties en doe zelf dezelfde aanpassingen in je eigen code voor je de opdrachten maakt.
{% endhint %}

## SchoolAdmin project

### Bugfix array studenten als argument voor constructor

Volg onderstaande demonstratie en pas toe op de modeloplossing:

{% hint style="success" %}
[Demonstratie](https://youtu.be/yY30nsUMMtE)
{% endhint %}

### Bugfix ontbrekend reference type

Volg onderstaande demonstratie en pas toe op de modeloplossing:

{% hint style="success" %}
[Demonstratie](https://youtu.be/ozZwxgWOjIM)
{% endhint %}

#### Opdracht

Pas dezelfde controle op `null` waarden toe op alle setters van reference types.

### Verbetering: cursussen registreren in bestaande array

Volg onderstaande demonstratie en pas toe op de modeloplossing:

{% hint style="success" %}
[Demonstratie](https://youtu.be/56Kp2LviIsg)
{% endhint %}

#### Opdracht

Voeg een constructor toe aan `StudyProgram` die een lege array met ruimte voor 5 cursussen aanmaakt. Voeg je cursussen toe door gebruik te maken van `RegisterCourse` in plaats van door een opgevulde array mee te geven.

### Property `Students` toevoegen aan `StudyProgram`

Volg onderstaande demonstratie en pas toe op de modeloplossing:

{% hint style="danger" %}
Het filmpje mist nog een instructie. Na de toekenning aan `usableIndex` in de lus moet je een `break` toevoegen. Anders wordt de nieuwe cursus op de laatste vrije plaats ingevoegd en niet op de eerste.
{% endhint %}

{% hint style="success" %}
[Demonstratie](https://youtu.be/M2VGxVpZDsY) \(zet de `break` die hierboven vermeld wordt wel in je code!\)
{% endhint %}

### Property `Grades` toevoegen aan `StudyProgram`

Volg onderstaande demonstratie en pas toe op de modeloplossing:

{% hint style="success" %}
[Demonstratie](https://youtu.be/UuM0XN0xFE8)
{% endhint %}

#### Opdracht

Voeg een read-only property `CompactGrades` toe die een array van cijfers van de studenten teruggeeft, maar gekwoteerd op vijf in plaats van op twintig. Je mag de kwotering op vijf berekenen door het oorspronkelijke cijfer te delen door vier.

Let op: je code mag het cijfer van een student niet aanpassen en mag hooguit acht regels code tellen. Elk statement zet je op een eigen regel en je volgt dezelfde stijl voor blokken omgeven door accolades als onder normale omstandigheden.

### Opdracht: correctie `ApplyBonusCredit`

Je krijgt onderstaande methode, die elke student in een programma een bonuspunt geeft. Ze werkt niet. Corrigeer zelf. Het is niet erg dat sommige studenten op dit moment meermaals een bonuspunt kunnen krijgen omdat ze meermaals in de `Students` property voorkomen. Dat lossen we in een volgend labo op.

```text
public void ApplyBonusCredit() {
    for(int i = 0; i < this.Students.Length; i++) {
        Student student = this.Students[i];
        int oldGrade = student.Grade;
        int newGrade = oldGrade + 1;
        oldGrade = newGrade;
    }
}
```

{% hint style="info" %}
Je weet nog niet hoe je een exception moet afhandelen, dus controleer of het cijfer al 20 is met een `if`.
{% endhint %}

