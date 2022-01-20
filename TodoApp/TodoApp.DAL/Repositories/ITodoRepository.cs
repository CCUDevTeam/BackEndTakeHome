using System.Collections.Generic;
using TodoApp.DAL.Entities;

namespace TodoApp.DAL.Repositories
{
    public interface ITodoRepository
    {
        /// <summary>
        /// Get a list of the Todos
        /// </summary>
        /// <returns>All Todos</returns>
        List<Todo> GetAllTodos();

        /// <summary>
        /// Gets a single Todo by Id
        /// </summary>
        /// <param name="id">Todo Id</param>
        /// <returns>Todo</returns>
        Todo GetTodoById(int id);

        /// <summary>
        /// Creates a Todo
        /// </summary>
        /// <param name="todo">Todo for creation</param>
        /// <returns>Created Todo</returns>
        Todo CreateTodo(Todo todo);

        /// <summary>
        /// Updates a Todo
        /// </summary>
        /// <param name="updatedTodo">Updated Todo</param>
        /// <returns></returns>
        void UpdateTodo(Todo updatedTodo);

        /// <summary>
        /// Deletes a Todo
        /// </summary>
        /// <param name="id">Todo Id</param>
        /// <returns></returns>
        void DeleteTodo(int id);
    }
}
