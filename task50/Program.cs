// Напишите программу, которая на вход принимает 
// значение элемента в двумерном массиве, и возвращает позицию этого 
// элемента или же указание, что такого элемента нет.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 30);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

int[] FindElement(int[,] array, int target)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == target)
            {
                return new int[] {i, j};
            }
        }
    }
    return null;
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
System.Console.WriteLine();

Console.Write("Введите искомое значение: ");
int target = Convert.ToInt32(Console.ReadLine());

int[] position = FindElement(array, target);

if (position != null)
{
    Console.WriteLine($"Индекс элемента {target} в массиве: [{position[0]}, {position[1]}]");
}
else
{
    Console.WriteLine($"Значение {target} не найден в массиве.");
}

System.Console.WriteLine();


