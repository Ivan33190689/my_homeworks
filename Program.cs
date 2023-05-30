// Homework 2.
// Task 1.
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Input a three digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int tens = (number / 10) % 10;

//     if(number > 99 && number < 1000)
//     {
//         Console.WriteLine($"A second digit of {number} is {tens}");
//     }
//     else
//     {
//         Console.WriteLine("It's not a three digit number!");
//     }


// Task 2.
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Console.WriteLine("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

//     while(number > 999)
//     {
//         number /= 10;
//     }
//     int digit = number % 10;
//         if(number > 99 && number < 1000)
//         {
//             Console.WriteLine($"A third digit of number is {digit}");
//         }
//         else
        // {
        //    Console.WriteLine("There is no third digit!");
        // }


// Task 3.
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Input a number: ");
// int weekends = Convert.ToInt32(Console.ReadLine());

//     if(weekends == 6 || weekends == 7)
//     {
//         Console.WriteLine("weekend");
//     }
//     else
//     {
//         Console.WriteLine("No");
//     }


// Task 3.1.
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Input a number: ");
// int weekends = Convert.ToInt32(Console.ReadLine());

//     switch(weekends)
//     {
//         case 6:
//         case 7:
//             Console.Write("Weekend");
//                 break;
//         default:
//             Console.Write("No");
//                 break;
//     }