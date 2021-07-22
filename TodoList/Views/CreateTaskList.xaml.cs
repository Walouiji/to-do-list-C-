using System;
using System.IO;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TodoList.Models;

namespace TodoList.Views
{
	[QueryProperty(nameof(ItemId), nameof(ItemId))]
	public partial class CreateTaskList : ContentPage
	{
		public string ItemId
		{
			set
			{
				//LoadNote(value);
			}
		}
		public CreateTaskList()
		{
			InitializeComponent();
			this.BindingContext = new TaskList();
		}
		void LoadTaskList(string Filename)
		{
			TaskList taskList = new TaskList
			{
				FileName = Filename,
				Title = File.ReadAllText(Filename),

			};
		}

        
    }
}