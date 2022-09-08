// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillArray(int[,] mtrx)
{
    for (int m = 0; m < mtrx.GetLength(0); m++)
    {
        for (int n = 0; n < mtrx.GetLength(1); n++)
        {
            mtrx[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] mtrx)
{
    for (int m = 0; m < mtrx.GetLength(0); m++)
    {
        Console.Write("[");
        for (int n = 0; n < mtrx.GetLength(1); n++)
        {
            Console.Write($"{mtrx[m, n]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int Sum(int[,] mtrx)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int m = 0; m < mtrx.GetLength(0); m++)
    {
        for (int n = 0; n < mtrx.GetLength(1); n++)
        {
            if (m == 0) 
            {
                sum += mtrx[m, n];
                minSum += mtrx[m, n]; 
            }
            else sum += mtrx[m, n]; 
        }
        if (sum <= minSum)
        {
            minSum = sum;
            minNum = m;
        }
        Console.WriteLine($"сумма элементов строки {m}: = {minSum}");
        sum = 0;
    }
    return minNum;
    
}

Console.WriteLine("m");
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("n");
int n = int.Parse(Console.ReadLine());
int[,] mtrxix = new int[m, n];
if (m!=n)
{
FillArray(mtrxix);
PrintArray(mtrxix);
Console.WriteLine();
Console.WriteLine($"Cтрока с наименьшей суммой элементов : " + Sum(mtrxix));
}
else
Console.WriteLine("Матрица квадратная");
