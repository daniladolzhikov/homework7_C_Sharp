// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-30, 30);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],3}    ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);

double[] columnAverages = new double[cols];

for (int j = 0; j < cols; j++)
{
    double columnSum = 0;
    for (int i = 0; i < rows; i++)
    {
        columnSum += array[i, j];
    }
    columnAverages[j] = columnSum / rows;
}

System.Console.WriteLine();
System.Console.WriteLine("Средние арифметические значения в каждом столбце:");
System.Console.WriteLine();

for (int j = 0; j < cols; j++)
{
    System.Console.WriteLine($"Столбец {j + 1}: {columnAverages[j],6:F2}");
}
System.Console.WriteLine();