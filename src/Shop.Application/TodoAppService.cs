using Shop.Dto;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Shop
{
    public class TodoAppService : Volo.Abp.Application.Services.ApplicationService, ITodoAppService
    {
        private readonly IRepository<TodoItem, Guid> _todoItemRepository;
        public TodoAppService(IRepository<TodoItem, Guid> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }
        //添加
        public async Task<TodoItemDto> CreateAsync(string text)
        {
            var todoItem = await _todoItemRepository.InsertAsync(
                    new TodoItem { Text = text }
                );
            return new TodoItemDto
            {
                Id = todoItem.Id,
                Text = todoItem.Text
            };
        }

        //删除
        public async Task DeleteAsync(Guid id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }

        //获取所有数据
        public async Task<List<TodoItemDto>> GetListAsync()
        {
            var items = await _todoItemRepository.GetListAsync();

            return items.Select(items => new TodoItemDto
            {
                Id = items.Id,
                Text = items.Text
            }).ToList();
        }
    }
}
