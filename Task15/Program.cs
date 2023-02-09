// // Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

System.Console.WriteLine("Введите цифру");
int num = Convert.ToInt32(Console.ReadLine());


    if (num <6  && num > 0)
    {
        System.Console.WriteLine($"{num} -> нет");
    }

    else if (num > 5 && num <8)
    {
        System.Console.WriteLine($"{num} -> да");
    }

    else 
    {
        System.Console.WriteLine($"{num} -> нет такого дня недели");
    }