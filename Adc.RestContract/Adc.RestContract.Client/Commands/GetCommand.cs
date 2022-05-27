using System.Text.Json;
using Adc.RestContract.Data;
using Adc.RestContract.Data.Model;
using Codeworx.Rest.Client;

namespace Adc.RestContract.Client.Commands
{
    public class GetCommand : ICommand
    {
        private readonly RestClient<IToDoService> _client;

        public GetCommand(RestClient<IToDoService> client)
        {
            _client = client;
        }

        public async Task ProcessAsync(string[] args)
        {
            ToDoDetailItem data = await _client.CallAsync(p => p.GetItemByNameAsync(args[0]));
            Console.WriteLine(JsonSerializer.Serialize(data));
        }
    }
}
