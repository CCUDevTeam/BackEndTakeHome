using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.DAL.Entities;
using TodoApp.DAL.Repositories;

namespace TodoApp.BLL.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        // TODO: Implement this class
    }
}
