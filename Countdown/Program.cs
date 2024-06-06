using System;
using System.Threading;

class Countdown
{
    static void Main()
    {
        Console.WriteLine("Введите количество секунд для обратного отсчета:");
        int seconds = int.Parse(Console.ReadLine());

        for (int i = seconds; i >= 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // Ожидание 1 секунду
        }
        Console.WriteLine("Обратный отсчет завершен!");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadLine();
    }
}
