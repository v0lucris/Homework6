// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void Fill(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1,10);
        }
    }
}

void Print(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.Write("]");
    Console.WriteLine(" ");
    }
}


Console.WriteLine("m");
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("n");
int n = int.Parse(Console.ReadLine());
int[,] mtrx = new int [m,n];

Console.WriteLine();
Fill(mtrx);
Print(mtrx);
Console.WriteLine();

for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
           if (i % 2 == 0 && j % 2 == 0 && i !=0 && j!=0)
           {
            mtrx[i, j] = mtrx[i, j] * mtrx[i, j];
           }
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.Write("]");
    Console.WriteLine(" ");
    }


