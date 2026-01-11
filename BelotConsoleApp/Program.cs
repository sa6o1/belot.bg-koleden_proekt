using System.Text;
using BelotConsoleApp.Engine;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        new Engine().Run();
    }
}
