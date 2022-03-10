// В матрице чисел найти сумму элементов главной диагонали.

Console.Clear();

Console.Write("Задайте размер массива по X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Задайте размерность массива по Y: ");
int Y = int.Parse(Console.ReadLine());

int[,] mass = new int[X, Y];
int summ = 0;
int diag = 0;
Random rnd = new Random();

for (int i = 0; i < X; i++)
{
    for (int j = 0; j < Y; j++)
    {
        mass[i, j] = rnd.Next(0, 10);
    }
}

if (X > Y) diag = (X - Y);
else if (X < Y) diag = (Y - X);
else diag = X;

void Summa(int[,] array, int diagon, int summa)
{
    for (int i = 0; i < diagon; i++)
    {
       summa += array[i, i];
    }
    Console.WriteLine(summa);
}

void Printmass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Printmass(mass);
Summa(mass, diag, summ);