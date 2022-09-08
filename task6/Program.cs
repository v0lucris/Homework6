// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива
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
for (int i = 0; i < mtrx.GetLength(0); i++)
{
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int k = 0; k < mtrx.GetLength(1)-j-1  ; k++)
        {
             if (mtrx[i,k] < mtrx[i,(k+1)])
    {
            int max = mtrx[i,k];
            mtrx[i,k] = mtrx[i, (k+1)];
            mtrx[i, (k+1)] = max;
    }
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
Mass(mtrx);
Print(mtrx);
