int rows = int.Parse(Console.ReadLine());
int i, j;

for (i = 1; i <= rows; i++)
{
    for (j = 1; j <= i; j++)
        Console.Write(" " + i);
        Console.Write("\n");
}