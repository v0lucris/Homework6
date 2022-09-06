// Написать программу, которая обменивает элементы первой строки и последней строки
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

Fill(mtrx);
Console.WriteLine(" ");
Print(mtrx);
Console.WriteLine(" ");

int temp = 0;
for (int i = 0; i < mtrx.GetLength(1); i++)
{
    temp = mtrx[mtrx.GetLength(0) - 1, i];
    mtrx[mtrx.GetLength(0) - 1, i] = mtrx[0, i];
    mtrx[0, i] = temp;
}
for (int i = 0; i < mtrx.GetLength(0); i++)
{
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        Console.Write(mtrx[i, j] + " ");
    }
    Console.WriteLine();
}


