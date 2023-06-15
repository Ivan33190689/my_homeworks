// Homework 4.
// Task 1.
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// int DegreeOfNumber(int A, int B)
// {
//     int result = 1;
//     for(int i = 1; i <= B; i++)
//         result *= A;

//     return result; 
// }

// Console.WriteLine("Input a number A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a number B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int res = DegreeOfNumber(A, B);
// Console.WriteLine($"{A} in a degree {B} = {res}");


// Task 2.
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// int SumDigit(int num)
// {
//     int sum = 0;

//     while(num > 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
// return sum;
// }

// Console.WriteLine("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = SumDigit(num);
// Console.WriteLine(result);


// Task 3.
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

void ArrayNumbers(int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(100);
    }
}

int[] array = new int[8];

ArrayNumbers(array);
Console.WriteLine(String.Join(", ", array));