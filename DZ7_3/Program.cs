// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите число строк массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int y = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[x, y];

Console.WriteLine("В массиве случайных целых чисел: ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double columnSum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        columnSum = columnSum + matrix[j, i];
    }
    Console.Write(Math.Round((columnSum / (y)), 1) + "\t");
}