// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите номер строки элемента: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int y = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[10, 10];

if (x < 10 && y < 10)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Random rand = new Random();
            matrix[i, j] = Math.Round((rand.NextDouble() * new Random().Next(-9, 10)), 1);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine(" -> "+matrix[x-1,y-1]);
}
else 
{
    Console.WriteLine("Такого числа в массиве нет");
}
