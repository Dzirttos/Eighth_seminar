// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int [,,] triplearray = new int [2,2,2];
for (int k = 0; k < triplearray.GetLength(0); k++)
{   
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"The {k+1} layer of threedimentional array:");
    for (int i = 0; i < triplearray.GetLength(1); i++)
    {   
       
        for (int j = 0; j < triplearray.GetLength(2); j++)
        {
            triplearray[i,j,k] = new Random().Next(10,100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"  {triplearray[i,j,k]} ({i},{j},{k})");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// вариант с неповторяющимися числами
// Console.Clear();
// int [,,] triplearray = new int [2,2,2];
// int p = new Random().Next(10,92);
// for (int k = 0; k < triplearray.GetLength(0); k++)
// {   
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine($"The {k+1} layer of threedimentional array:");
//     for (int i = 0; i < triplearray.GetLength(1); i++)
//     {   
       
//         for (int j = 0; j < triplearray.GetLength(2); j++)
//         {
//             triplearray[i,j,k] = p;
//             p++;
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             Console.Write($"  {triplearray[i,j,k]} ({i},{j},{k})");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }