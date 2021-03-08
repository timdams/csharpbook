# Bitwise operators

## Binaire bewerkingen

Je kan ook met binaire getallen werken in C\#. Dit kan nuttig zijn wanneer je bijvoorbeeld met een stuk hardware wilt communiceren via C\# en je bepaalde bits moet in/uit schakelen. [Deze uitleg](https://playground.arduino.cc/Code/BitMath/#common) toont enkele toffe voorbeelden waarom bitwise operators nuttig zijn wanneer je met Arduino werkt en [hier](https://stackoverflow.com/questions/38997913/python-bitwise-logic-to-operate-leds) met een Raspberry Pi.

### Omzetten van en naar binaire voorstelling

Je kan een string die een binair getal voorstelt eenvoudig naar een getal omzetten m.b.v.

```csharp
string data = "0101";
int output = Convert.ToInt32(data, 2);
```

De tweede parameter `2` bij de Convert geeft aan van welke base het getal komt. Je kan hier ook 8 en 16 \(hexadecimaal\) zetten indien je bijvoorbeeld een hexadecimale voorstelling wilt omzetten.

Ook in de andere richting kan, maar dan met behulp van de `Convert.ToString` methode:

```csharp
int value = 8;
string binary = Convert.ToString(value, 2);
```

## Bitwise operator

Bitwise operators in C\# laten toe om de klassieke binaire bewerkingen \(AND, OR, NOT, etc\) die je kent uit booleanse algebra toe te passen op je variabelen.

Stel dat we volgende twee variabelen hebben: `int A=60` en `int B=13`. Volgende operators kan je gebruiken [bron](https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm):

| Operator | Beschrijving | Voorbeeld |
| :--- | :--- | :--- |
| `&` | Binary AND Operator copies a bit to the result if it exists in both operands. \(De Binaire AND Operator kopieerd een bit naar het resultaat indien de bit bestaat in beide factoren.\) | `(A & B) = 12`, which is 0000 1100 |
| `|` | Binary OR Operator copies a bit if it exists in either operand. \(De Binaire OR Operator kopieerd een bit naar het resultaat als het in één of beide van de factoren voorkomt.\) | `(A | B) = 61`, which is 0011 1101 |
| `^` | Binary XOR Operator copies the bit if it is set in one operand but not both.    \(De Binaire XOR Operator  kopieert en bit naar het resultaat indien het in slechts één van de twee factoren voorkomt.\) | `(A ^ B) = 49`, which is 0011 0001 |
| `~` | Binary Ones Complement Operator is unary and has the effect of 'flipping' bits. \(De Binaire Ones Complement Operator is unair en 'draait de bits om'.\) | `(~A ) = -61`, which is 1100 0011 in 2's complement due to a signed binary number. |
| `<<` | Binary Left Shift Operator. The left operands value is moved left by the number of bits specified by the right operand. \(De Binaire Links Shift Operator. De linkse factor zijn waarde wordt naar links verschoven met dezelfde hoeveelheid als de waarde van de rechterfactor.\) | `A << 2 = 240`, which is 1111 0000 |
| `>>` | Binary Right Shift Operator. The left operands value is moved right by the number of bits specified by the right operand. \(De Binaire Rechts Shift Operator. De linkse factor zijn waarde wordt naar rechts verschoven met dezelfde hoeveelheid als de waarde van de rechterfactor.\) | `A >> 2 = 15`, which is 0000 1111 |

### Voorbeeld

Een uitgewerkt voorbeeld \(ook van [hier](https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm)\):

```csharp
int a = 60;            /* 60 = 0011 1100 */ 
int b = 13;            /* 13 = 0000 1101 */
int c = 0; 

c = a & b;             /* 12 = 0000 1100 */ 
Console.WriteLine("Line 1 - Value of c is {0}", c );

c = a | b;             /* 61 = 0011 1101 */
Console.WriteLine("Line 2 - Value of c is {0}", c);

c = a ^ b;             /* 49 = 0011 0001 */
Console.WriteLine("Line 3 - Value of c is {0}", c);

c = ~a;                /*-61 = 1100 0011 */
Console.WriteLine("Line 4 - Value of c is {0}", c);

c = a << 2;      /* 240 = 1111 0000 */
Console.WriteLine("Line 5 - Value of c is {0}", c);

c = a >> 2;      /* 15 = 0000 1111 */
Console.WriteLine("Line 6 - Value of c is {0}", c);
Console.ReadLine();
```

Geeft als uitvoer:

```text
Line 1 - Value of c is 12
Line 2 - Value of c is 61
Line 3 - Value of c is 49
Line 4 - Value of c is -61
Line 5 - Value of c is 240
Line 6 - Value of c is 15
```

