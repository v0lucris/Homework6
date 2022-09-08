// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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




void Mass(int[,]mtrx)
{
if (mtrx.GetLength(0) == mtrx.GetLength(1))
{
int [,] mass = new int [mtrx.GetLength(0),mtrx.GetLength(1)];
for (int i = 0; i < mtrx.GetLength(0); i++)
{
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
       mass[i, j]=mtrx[i,j];
                      
    }
}
for (int i = 0; i < mtrx.GetLength(0); i++)
{
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
       mtrx[i,j] = mass[j, i];
                      
    }
}
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
if (m ==n)
{
Mass(mtrx);
Print(mtrx);
}
else
Console.WriteLine("Невозможно заменить строки на столбцы");
