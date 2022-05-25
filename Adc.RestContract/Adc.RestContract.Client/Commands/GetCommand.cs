using System.Text.Json;
using Adc.RestContract.Data.Model;

namespace Adc.RestContract.Client.Commands
{
    public class GetCommand : ICommand
    {
        public GetCommand()
        {
        }

        public async Task ProcessAsync(string[] args)
        {
            ToDoDetailItem data = null;
            Console.WriteLine(JsonSerializer.Serialize(data));
        }
    }
}
