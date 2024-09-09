﻿using TodoServerAppAvaevaPD.Data.Interfaces;

namespace TodoServerAppAvaevaPD.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> Tasks { get; } =
        [
            new TaskItem { Id = 1, Title = "Задача 1", Description = "Описание задачи 1", CreatedDate = DateTime.Now },
            new TaskItem { Id = 2, Title = "Задача 2", Description = "Описание задачи 2", CreatedDate = DateTime.Now },
            new TaskItem { Id = 3, Title = "Задача 3", Description = "Описание задачи 3", CreatedDate = DateTime.Now },
        ];

        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }
    }
}
