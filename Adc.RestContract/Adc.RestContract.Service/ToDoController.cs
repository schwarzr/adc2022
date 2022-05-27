using Adc.RestContract.Data;
using Adc.RestContract.Data.Model;
using Adc.RestContract.Database;
using Microsoft.EntityFrameworkCore;

namespace Adc.RestContract.Controllers
{

    public class ToDoController : IToDoService
    {
        private readonly ToDoContext _db;

        public ToDoController(ToDoContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<ToDoItem>> GetItemsAsync()
        {
            var query = _db.ToDoEntries.Select(p => new ToDoItem
            {
                Id = p.Id,
                Name = p.Title,
                Completed = p.Completed.HasValue
            });

            return await query.ToListAsync();
        }

        public async Task<ToDoDetailItem> GetItemByNameAsync(string name)
        {
            var query = _db.ToDoEntries
                .Where(p => p.Title == name)
                .Select(p => new ToDoDetailItem
                {
                    Id = p.Id,
                    Name = p.Title,
                    DueDate = p.DueDate,
                    Completed = p.Completed,
                });

            return await query.FirstOrDefaultAsync();
        }
    }
}
