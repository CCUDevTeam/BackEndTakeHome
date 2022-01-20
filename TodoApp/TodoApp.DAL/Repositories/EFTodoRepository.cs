using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TodoApp.DAL.Entities;

namespace TodoApp.DAL.Repositories
{
    public class EFTodoRepository : ITodoRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EFTodoRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public List<Todo> GetAllTodos()
        {
            return _context.Todos.ToList();
        }

        /// <inheritdoc />
        public Todo GetTodoById(int id)
        {
            return _context.Todos.First(t => t.Id == id);
        }

        /// <inheritdoc />
        public Todo CreateTodo(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return todo;
        }

        /// <inheritdoc />
        public void UpdateTodo(Todo updatedTodo)
        {
            var todo = GetTodoById(updatedTodo.Id);

            _mapper.Map(updatedTodo, todo);
            _context.Todos.Update(todo);
            _context.SaveChanges();
        }

        /// <inheritdoc />
        public void DeleteTodo(int id)
        {
            var todo = GetTodoById(id);
            _context.Todos.Remove(todo);
            _context.SaveChanges();
        }
    }
}
