// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Пример  0, 7, 8, -2, -2 -> 2

// Пример  1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество вводимых чисел");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];

Console.WriteLine("Введите числа");

for (int i = 0; i < M; i++)
{
  Console.Write($"array[{i}] = ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

int count_of_positive = 0;

for (int j = 0; j < M; j++)
{
    if (array[j] > 0) 
    {
    count_of_positive++;
    }
}

Console.WriteLine($"Количество положительных чисел = {count_of_positive}");