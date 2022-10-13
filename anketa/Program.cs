using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var (name, age) = ("илья", 28);

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.WriteLine("Введите возраст с цифрами: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст {0}", age);

        Console.ReadKey();
    }
}