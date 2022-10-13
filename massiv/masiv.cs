class MainClass 
{
    public static void Main(string[] agrs)
    {
        Console.WriteLine("Введите свое имя");

        var name = Console.ReadLine();

       for ( int i = name.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(name[i] + "");
        }
        
        Console.ReadKey();
    }
        }