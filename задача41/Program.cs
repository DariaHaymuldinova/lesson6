// Пользователь вводит М чисел, программа считает сколько чисел больше 0 введено
Console.WriteLine("Введите количество вводимых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void Plus(int[] array)
{
   int counter = 0; 
   foreach (var item in array)
   {
    if (item > 0)
    {
        counter++;
    }
   }
     Console.WriteLine("Количество чисел больше нуля: " + counter);
}
Plus(array);