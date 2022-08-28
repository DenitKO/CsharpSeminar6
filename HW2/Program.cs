// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// Пример  k1 = 5, 
        // b1 = 2,
        // k2 = 9,
        // b2 = 4 -> (-0,5; -0,5)

Console.WriteLine("Введите значения переменных b1, k1, b2 и k2");
Console.Write("b1 = ");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
Double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
Double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
Double k2 = Convert.ToDouble(Console.ReadLine());

Double y = 0; 
Double x = 0;

if ((k1-k2) == 0) Console.WriteLine("Прямые не пересекаются");
else  
{
    x = (b2-b1)/(k1-k2);
    y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке х = {x}, y = {y}");
}

