using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoList.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewTaskList : ContentPage
	{
		public ViewTaskList()
		{
			InitializeComponent();
		}
		async void OnAddClicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync(nameof(CreateTaskList));
		}
	}
}