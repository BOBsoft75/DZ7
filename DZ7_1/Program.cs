// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // int n = int.Parse(Console.ReadLine()); - то же самое

double[,] matrix = new double[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Random rand = new Random();
        matrix[i, j] = Math.Round((rand.NextDouble() * new Random().Next(-9,10)),1);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}