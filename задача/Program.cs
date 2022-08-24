// Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали
int[, ] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10,11);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

void Sum (int[, ] array)
{
    int Sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    if (i == j)
    {
        Sum = Sum + array[i, j];
    }
    }
}
Console.WriteLine("Сумма " + Sum);
}
Sum(array);
