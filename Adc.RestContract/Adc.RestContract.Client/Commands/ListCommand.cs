using System.Text.Json;
using Adc.RestContract.Data.Model;

namespace Adc.RestContract.Client.Commands
{
    public class ListCommand : ICommand
    {
        public ListCommand()
        {
        }

        public async Task ProcessAsync(string[] args)
        {
            IEnumerable<ToDoItem> data = new ToDoItem[] { };

            foreach (var item in data)
            {
                Console.WriteLine(JsonSerializer.Serialize(item));
            }
        }
    }
}
