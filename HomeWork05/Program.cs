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

// int result = GetLength();
// int[] newarray = GetArray(result);
// Console.WriteLine(String.Join(", ", newarray));

// int newresult = EvenNumbers(newarray);
// Console.WriteLine($"Quantity even numbers = {newresult}");