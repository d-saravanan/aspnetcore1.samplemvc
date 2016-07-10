using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Models;

namespace ToDo.DAL
{
	public interface IToDoRepository
	{
		void Add(ToDoItems item);
		ToDoItems Get(string id);
		List<ToDoItems> GetAll();
		int Update(ToDoItems item);
		int Delete(string userId);
	}
	
	public class ToDoDAL : IToDoRepository
	{
		public ToDoDAL(){
			
			var sampleData = new ToDoItems{
				Id = Guid.NewGuid().ToString(),
				UserId = Guid.NewGuid().ToString(),
				Task = "Greet Hello",
				DueDate = DateTime.UtcNow,
				IsComplete = false
			};
			
			_store.Add(sampleData.Id, sampleData);
		}
		
		
		private static Dictionary<string, ToDoItems> _store = new Dictionary<string, ToDoItems>();
		
		public void Add(ToDoItems item){
			item.Id = Guid.NewGuid().ToString();
			_store.Add(item.Id, item);
			}
		public ToDoItems Get(string id){
			
			if (_store.Count > 0)
			{
				return _store.Values.FirstOrDefault(t=>t.Id == id);
			}
			return null;
			}
		public List<ToDoItems> GetAll(){
			return _store.Values.ToList();
		}
		public int Update(ToDoItems item){
			if (_store.Count > 0 && _store.ContainsKey(item.Id))
			{
				_store[item.Id] = item;return 1;
			}
			return -1;
		}
		public int Delete(string id){
			if (_store.Count > 0 && _store.ContainsKey(id))
			{
				_store.Remove(id); return 1;
			}
			
			return -1;
			
			}
		
	}
}