using Microsoft.EntityFrameworkCore;
using TodoServerAppAvaevaPD.Data.Interfaces;

namespace TodoServerAppAvaevaPD.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }
    }
}
