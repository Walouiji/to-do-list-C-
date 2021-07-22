using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Models
{
	class TaskList
	{
		public string FileName { get; set; }
		public string Title { get; set; }
		public string[] Tasks { get; set; }
		public DateTime CreationDate { get; set; }
	}
}
