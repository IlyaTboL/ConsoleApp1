class MainClass 
{
    public static void Main(string[] agrs)
    {
        Console.WriteLine("Введите свое имя");

        var name = Console.ReadLine();

        Console.WriteLine("Ваше имя по буквам: ");

        foreach( var ch in name)
        {
            Console.WriteLine(ch + " ");
        }

        Console.WriteLine("Последняя буква вашего имени:{0}", name[name.Length - 1]);
        
        Console.ReadKey();
    }
        }