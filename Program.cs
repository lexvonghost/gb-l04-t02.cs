//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

 int i = 0;
 while (n > 0)
    {
        i = i + n % 10;
        n = n /10 ;
    }
 Console.WriteLine(i);