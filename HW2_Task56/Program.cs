// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] CreateArray(int rows, int columns, int min, int max)
{
    int[,] userArray = new int[rows, columns];
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            userArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return userArray;
}

void ShowLowestSummaryLine(int[] array)
{
    int min = array[0];
    int x = 1;
    for (int i = 1; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
            x = i + 1;
        }

    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"The lowest summary value is {min} and stands in the line number {x}.");
}

void ShowArray(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Please enter the number of rows in the array:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number of columns in the array:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the starting number of the array range:");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the ending number of the array range:");
int end = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(rows, columns, start, end);
int[] sum = new int[array.GetLength(0)];
ShowArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum[i] += array[i, j];
    }
    // Console.WriteLine($"The {i+1} line summary is {sum[i]}.");
}

ShowLowestSummaryLine(sum);