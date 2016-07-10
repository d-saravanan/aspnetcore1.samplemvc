using System;
using ToDo.Models;
using ToDo.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ToDoApp
{
	[Route("todo")]
	public class TodoController : Controller
	{
		private readonly IToDoRepository _rep;
		
		public TodoController(IToDoRepository repository){
			_rep = repository;
		}
		
		[HttpGet]
		public List<ToDoItems> Get(){
			return _rep.GetAll();
		}
	}
}