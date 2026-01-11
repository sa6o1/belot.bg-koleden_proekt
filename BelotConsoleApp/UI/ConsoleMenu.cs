using Spectre.Console;
using BelotConsoleApp.Services;
using BelotConsoleApp.Data.Models;
namespace BelotConsoleApp.UI
{
    public class ConsoleMenu
    {
        private readonly PlayerService service = new();
        public void Show()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("belot.bg").Centered().Color(Color.Green));
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Меню")
                    .AddChoices("Добави играч", "Покажи играчи", "Изтрий играч", "Изход"));
            if (choice == "Добави играч")
            {
                var name = AnsiConsole.Ask<string>("Име:");
                service.Create(new Player { Username = name });
            }
            if (choice == "Покажи играчи")
            {
                var table = new Table().AddColumn("Име").AddColumn("Победи");
                foreach (var p in service.GetAll())
                    table.AddRow(p.Username, p.GamesWon.ToString());
                AnsiConsole.Write(table);
                Console.ReadKey();
            }
            if (choice == "Изтрий играч")
            {
                int id = AnsiConsole.Ask<int>("ID:");
                service.Delete(id);
            }
            if (choice == "Изход") Environment.Exit(0);
        }
    }
}