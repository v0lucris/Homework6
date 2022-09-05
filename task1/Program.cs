// Показать двумерный массив размером m×n заполненный вещественными числами
void Fill(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = Convert.ToDouble(new Random().Next(1,10));
        }
    }
}

void Print(double[,] mtrx)
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
int m = Convert.ToInt32(Console.ReadLine()); //Преобразует заданное строковое представление числа в эквивалентное 32-битовое целое число со знаком
Console.WriteLine("n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] mtrx = new double [m,n];

Fill(mtrx);
Print(mtrx);





