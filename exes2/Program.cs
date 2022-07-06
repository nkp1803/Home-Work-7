/* Задача 2: Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет. */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

bool Validation(int[,] array, int ind_i, int ind_j)
{
    if ((ind_i >= 0 && ind_i <= array.GetLength(0)) && (ind_j >= 0 && ind_j <= array.GetLength(1)))
    {
        return true;
    }
    else return false;
}
int row = Prompt("Количество строк >");
int column = Prompt("Количество столбцов >");
int min = -10;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
int ind_i = Prompt("Введите координату строки >");
int ind_j = Prompt("Введите координату столбца >");
if (Validation(array, ind_i, ind_j))
{
    int value = array[ind_i, ind_j];
    System.Console.WriteLine($"Значение элемента : {value} ");
}
else System.Console.WriteLine("Таких индексорв нет в массиве !");


