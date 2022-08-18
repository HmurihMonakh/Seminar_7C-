/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
Console.WriteLine("введите количество строк");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n=Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArrayRazm(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}

FillArray(array);
PrintArrayRazm(array);

void ChangeArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) array[i, j] = array[i, j]*array[i, j];
        }
    }
}

Console.WriteLine();
ChangeArray(array);




