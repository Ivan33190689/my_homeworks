// Homework 5.
// Task 1.
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] GetArray(int Length)
// {
//     int[] array = new int[Length];

//     for(int i = 0; i < Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// int GetLength()
// {
//     Console.WriteLine("Input length of array: ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     return length;
// }

// int EvenNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             count ++;
//         }
//     }
//     return count;
// }

// int length = GetLength();
// int[] array = GetArray(length);
// Console.WriteLine(String.Join(", ", array));

// int result = EvenNumbers(array);
// Console.WriteLine($"Quantity even numbers = {result}");


// Task 2.
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] GetArray(int Length)
// {
//     int[] array = new int[Length];

//     for(int i = 0; i < Length; i++)
//     {
//         array[i] = new Random().Next(100);
//     }
//     return array;
// }

// int GetLength()
// {
//     Console.WriteLine("Input length of array: ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     return length;
// }

// int OddNumbers(int[] array)
// {
//     int sum = 0;

//     for(int i = 1; i < array.Length; i+=2)
//     {
//         sum += array[i];
//     }
//     return sum;
// }

// int result = GetLength();
// int[] newarray = GetArray(result);
// Console.WriteLine(String.Join(", ", newarray));

// int res = OddNumbers(newarray);
// Console.WriteLine($"Sum of numbers on odd positions = {res}");


// Task 3.
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[] GetArray(int Length)
// {
//     double[] array = new double[Length];

//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = new Random().NextDouble();
//     }
//     return array;
// }

// int GetLength()
// {
//     Console.WriteLine("Input a length of array: ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     return length;
// }

// int length = GetLength();
// double[] array = GetArray(length);

// Console.WriteLine(String.Join(", ", array));

// double DiffMaxMin(double[]array)
// {
//     double min = array.Min();
//     double max = array.Max();
//     double difference = 0;

//     foreach (int number in array)
//     {
//         difference = max - min;
//     }
//     return difference;
// }

// double difference = DiffMaxMin(array);
// Console.WriteLine($"Difference max and min of numbers = {difference}");





// Task 4.
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке 
// [10,99].

// void GetArray(int[] array)
// {
//     for (int i = 0; i < 123; i++)
//     {
//         array[i] = new Random().Next(123);
//     }
// }

// int CutOfNumbers(int[] array)
// {
//     int count = 0;

//     foreach (int number in array)
//     {
//         if (number >= 10 && number < 100)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] array = new int[123];

// GetArray(array);
// Console.WriteLine(String.Join(", ", array));

// int cut = CutOfNumbers(array);
// Console.WriteLine($"In a cut [10, 99] quantity of numbers = {cut}");


// Task 5.
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3

int[] GetArray(int Length)
{
    int[] array = new int[Length];

    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("Input length of array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int[] CompositionNumbers(int[] array)
{
    int[] newarray = new int[array.Length / 2];

    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = array[i] * array[array.Length - 1 - i];
    }
    return newarray;
}

int getlength = GetLength();
int[] array = GetArray(getlength);
Console.WriteLine(String.Join(", ", array));

int[] newarray = CompositionNumbers(array);
Console.WriteLine(newarray);