using System.Collections.ObjectModel;
using TodoListApp.Models;

namespace TodoListApp;

public partial class MainPage : ContentPage
{

	ObservableCollection<Todo> Todos = new ObservableCollection<Todo>();

	public MainPage()
	{
		InitializeComponent();
		TodoList.ItemsSource = Todos;
	}

    void AddButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Todos.Add(new Todo { Activity = TodoActivity.Text });
        TodoActivity.Text = string.Empty;
    }

    void DeleteButton_Clicked(System.Object sender, System.EventArgs e)
    {
        var button = (Button)sender;
        var todo = button.BindingContext as Todo;
        Todos.Remove(todo);
    }

}


