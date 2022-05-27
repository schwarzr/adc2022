using System.Text.Json;
using Adc.RestContract.Data;
using Adc.RestContract.Data.Model;
using Codeworx.Rest.Client;

namespace Adc.RestContract.Client.Commands
{
    public class ListCommand : ICommand
    {
        private readonly IToDoService _client;

        public ListCommand(IToDoService client)
        {
            _client = client;
        }

        public async Task ProcessAsync(string[] args)
        {
            IEnumerable<ToDoItem> data = await _client.GetItemsAsync();

            foreach (var item in data)
            {
                Console.WriteLine(JsonSerializer.Serialize(item));
            }
        }
    }
}
