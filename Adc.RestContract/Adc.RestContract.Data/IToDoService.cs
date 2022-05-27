using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adc.RestContract.Data.Model;
using Codeworx.Rest;

namespace Adc.RestContract.Data
{
    [RestRoute("api/todo")]
    public interface IToDoService
    {
        [RestGet]
        Task<IEnumerable<ToDoItem>> GetItemsAsync();

        [RestGet("{name}")]
        Task<ToDoDetailItem> GetItemByNameAsync(string name);
    }
}
