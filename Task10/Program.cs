// Задача 10
// Напишите программу, которая принимает на 
// вход трехзначное число и на выходе 
// показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8

System.Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
   
    if (num > 99 && num < 1000)
    {
        int result1 = num % 100;
        int result2 = result1 / 10;
        System.Console.WriteLine($"{num} -> {result2}");
    }

    else
    {
        System.Console.WriteLine("Некорректное число");
    }
