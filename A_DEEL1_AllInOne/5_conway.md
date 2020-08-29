# Conway game of life

Life (of Conway Game of Life) is een leuke manier om 2D arrays te gebruiken om 'leven' te simuleren. Afhankelijk van enkele eenvoudige regels wordt beslist of een cel (1 element in de array) wel of niet overleeft naar de volgende generatie. De regels zijn gebaseerd op de 8 omliggende plekken rond de cel die ofwel leeg zijn ofwel een andere cel bevatten:

* Any live cell with fewer than two live neighbors dies, as if by underpopulation.
* Any live cell with two or three live neighbors lives on to the next generation.
* Any live cell with more than three live neighbors dies, as if by overpopulation.
* Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.

Meer uitleg: [wikipedia](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)

Kan je zelf een simulator maken die telkens generatie per generatie op het scherm toont?

# Oplossing

```java
static void Main(string[] args)
{
  
    int[,] playfield = new int[50, 250];
    ResetField(playfield);

    while (true)
    {

        ShowField(playfield);
        Console.WriteLine("Enter for next generation");
        Console.ReadLine();
        playfield = GenerateNextLevel(playfield);
        Console.Clear();
    }

}

private static void ShowField(int[,] field)
{
    StringBuilder str = new StringBuilder();
    int xl = field.GetLength(0);
    int yl = field.GetLength(1);
    for (int i = 1; i < xl - 1; i++)
    {
        for (int j = 1; j < yl - 1; j++)
        {
            if (field[i, j] == 1)
            {
                str.Append("X");
            }
            else
            {
                str.Append(" ");
            }
        }
        str.Append(Environment.NewLine);
    }
    Console.WriteLine(str.ToString());
}

private static int[,] GenerateNextLevel(int[,] playfield)
{
    int[,] newfield = new int[playfield.GetLength(0), playfield.GetLength(1)];


    for (int i = 1; i < playfield.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < playfield.GetLength(1) - 1; j++)
        {
            int neighbours = CountNeighbours(playfield, i, j);
            if (playfield[i, j] > 0)
            {
                if (neighbours < 2)
                    newfield[i, j] = 0;
                else if (neighbours == 2 || neighbours == 3)
                    newfield[i, j] = 1;
                else if (neighbours > 3)
                    newfield[i, j] = 0;
            }
            else if (neighbours == 3)
                newfield[i, j] = 1;
        }
    }
    return newfield;
}

private static int CountNeighbours(int[,] playfield, int orx, int ory)
{

    int sum = 0;
    for (int i = orx - 1; i < orx + 2; i++)
    {
        for (int j = ory - 1; j < ory + 2; j++)
        {
            if (!(i == orx && j == ory))
                sum += playfield[i, j];
        }
    }
    return sum;
}

static void ResetField(int[,] field, int randomcells = 100)
{
    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            field[i, j] = 0;
        }
    }

    Random r = new Random();
    for (int i = 0; i < randomcells; i++)
    {
        int x = r.Next(1, field.GetLength(0) - 2);
        int y = r.Next(1, field.GetLength(1) - 2);
        field[x, y] = 1;
    }



}
        ```