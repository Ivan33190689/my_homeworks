// Homework
// Task 1.
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// `


// Task 2.
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
 
// Console.WriteLine("Input a1: ");
// double a1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input c1: ");
// double c1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input a2: ");
// double a2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input c3: ");
// double c2 = Convert.ToDouble(Console.ReadLine());

// double result = Math.Round(Math.Sqrt((a2 - a1)*(a2 - a1) + (b2 - b1)*(b2 - b1) + (c2 - c1)*(c2 - c1)),2);

// Console.WriteLine(result);


// Task 3.
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

 Console.WriteLine("Input a number: ");
 int number = Convert.ToInt32(Console.ReadLine());

 for(int i = 1; i <= number; i++)
 {
     double result = Math.Pow(i, 3);
        Console.Write($"{result} ");
 }