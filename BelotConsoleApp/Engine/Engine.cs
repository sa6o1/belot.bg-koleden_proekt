using BelotConsoleApp.UI;
namespace BelotConsoleApp.Engine
{
    public class Engine
    {
        private readonly ConsoleMenu menu = new();
        public void Run()
        {
            while (true) menu.Show();
        }
    }
}