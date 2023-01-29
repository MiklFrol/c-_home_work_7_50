// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int getDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ResetColor();
    int array = int.Parse(Console.ReadLine()!);
    return array;
}

int[,] get2DArray(int colLenght, int rowLenght, int start, int finish)
{
    int[,] array = new int[colLenght, rowLenght];
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rowLenght; j++)
        {
            array[i,j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] array)
{
     Console.Write(" \t");
    for (int j=0; j<array.GetLength(1); j++)
    {
         printInColor(j + "\t");
    }
    Console.WriteLine();

    for (int i=0; i<array.GetLength(0); i++)
    {
        printInColor( i + "\t");
        for (int j=0; j<array.GetLength(1); j++)
        {       
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int getValueElement(int[,] array, int i, int j, int n, int m)
{
    if(i <= n && j <= m)
    {
        Console.WriteLine($"Значение элемента на позиции ({i}, {j}): {array[i,j]}");
    }
    else
    {
        Console.WriteLine($"Такого элемента в массиве нет");
    } 
    return array[i, j];
}

int n = getDataFromUser("Введите число строк");
int m = getDataFromUser("Введите число столбцов");
int i = getDataFromUser("Введите позицию i");
int j = getDataFromUser("Введите позицию j");
int [,] array = get2DArray(n,m,0,10);
print2DArray(array);
int element = getValueElement(array, i, j, n, m);