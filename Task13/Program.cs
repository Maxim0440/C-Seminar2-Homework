// Напишите программу, которая выводит
//  третью цифру заданного числа или сообщает, что 
//  третьей цифры нет.


System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int result = num;

    while (Math.Abs(num) > 999)

   {
    num = Math.Abs(num) / 10;
   }


        if (Math.Abs(num) < 100)
        {
            System.Console.WriteLine($"{num} -> Третьей цифры нет");   
        }

        else 
        { 
            System.Console.WriteLine($"{result} -> {Math.Abs(num) % 10}");
        }
    
      
   

   
   
    
    
