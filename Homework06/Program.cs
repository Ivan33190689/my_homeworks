// Homework 6.
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int CountPositiveNumbers(int[] numbers)
// {
//     int count = 0;

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Input a number for quantity of digits: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] numbers = new int[m];

// for (int i = 0; i < m; i++)
// {
//     Console.Write($"Input a number {m}: ");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }

// int countpositive = CountPositiveNumbers(numbers);
// Console.WriteLine($"Quantity positive numbers = {countpositive}");


// Task 2.
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void PointOfIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Point of intersection {x} {y}:");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

PointOfIntersection(b1, k1, b2, k2);