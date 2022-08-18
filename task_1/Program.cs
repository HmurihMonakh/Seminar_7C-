//Задача 46: Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.

//m = 3, n = 4.

//1 4 8 19
//5 -2 33 -2
//77 3 8 1
/*
Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество стлбцов ");
int n = Convert.ToInt32(Console.ReadLine());
*/


Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] create_mas (int x)
{
int [] array = new int [x];
for (int i = 0; i < x; i++)
{
array[i] = new Random().Next(0,2);
}
return array;
}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
Console.Write($"{col[position]} ");
position++;
}
}
PrintArray(create_mas(x));

/*
+++++++++++++++++++++++++++++++++++++++++
int i = 0;

for (i = 1; i != B; i++)
{
int result = result * A;
}
return result;*/

Console.WriteLine("введите количество строк");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n=Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];

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
FillArray(array);
PrintArrayRazm(array);


