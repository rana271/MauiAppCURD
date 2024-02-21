using MauiAppCURD.Models;
using MauiAppCURD.Services;

namespace MauiAppCURD;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	
    private void Button_Clicked(object sender, EventArgs e)
    {
		EmployeeModel obj = new EmployeeModel{ Name = name.Text, Email = email.Text, Address = address.Text };
		int c = new EmployeeService().InsertEmployee(obj);
		DisplayAlert("Insert", "Success", "Ok");
		Navigation.PushAsync(new DisplayEmployee());
    }
}

