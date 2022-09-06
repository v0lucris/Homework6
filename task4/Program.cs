// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

string Metod4 (int[,]mtrx)
{
    
    string result = String.Empty;
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        double res = 0;
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            sum = (sum + mtrx[i,j]);
            count ++;
        }
       res = sum/count; 
       result = result + res.ToString() + " ";
    }
    return result;
}

Console.WriteLine("m");
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("n");
int n = int.Parse(Console.ReadLine());
int[,] mtrx = new int [m,n];
int sum = 0;
Fill(mtrx);
Console.WriteLine(" ");
Print(mtrx);
Console.WriteLine(" ");
Console.WriteLine(Metod4(mtrx));





