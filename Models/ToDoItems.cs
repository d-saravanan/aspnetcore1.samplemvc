using System;

namespace ToDo.Models
{
	//[Serializable]
	public class ToDoItems
	{
		public string Id{get;set;}
		public string Task { get; set; }
		public string UserId{get;set;}
		public DateTime DueDate {get;set;}
		public bool IsComplete {get;set;}
	}
}