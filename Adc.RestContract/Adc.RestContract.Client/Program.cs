using Adc.RestContract.Client.Commands;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection.AddCommand<ListCommand>("list");
serviceCollection.AddCommand<GetCommand>("get");

//serviceCollection.AddScoped<IToDoService, ToDoController>();
//serviceCollection.AddDbContext<ToDoContext>(p => p.UseSqlite(@"Data Source=c:\Temp\todo.sqlite", p => p.MigrationsAssembly("Adc.RestContract.Sqlite")));


var services = serviceCollection.BuildServiceProvider();

//using (var scope = services.CreateScope())
//{
//    var ctx = scope.ServiceProvider.GetRequiredService<ToDoContext>();
//    ctx.Database.Migrate();
//}

Console.WriteLine("Ready!");
Console.Write('>');

var command = Console.ReadLine();
while (command != null && command != "exit")
{
    var split = command.Split(' ');
    using (var scope = services.CreateScope())
    {
        var cmd = scope.ServiceProvider.GetCommand(split[0]);
        if (cmd != null)
        {
            await cmd.ProcessAsync(split.Skip(1).ToArray());
        }
    }
    Console.WriteLine();
    Console.Write('>');
    command = Console.ReadLine();
}