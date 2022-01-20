using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApp.BLL.Services;
using TodoApp.DAL.Entities;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("todos")]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        // TODO: Implement endpoints

    }
}
