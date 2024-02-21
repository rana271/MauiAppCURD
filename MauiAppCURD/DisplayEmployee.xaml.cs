using MauiAppCURD.Models;
using MauiAppCURD.Services;
using System.Collections.ObjectModel;

namespace MauiAppCURD;

public partial class DisplayEmployee : ContentPage
{
    private List<EmployeeModel> _emps;
    public DisplayEmployee()
	{
		InitializeComponent();


	}
    protected override  void OnAppearing()
    {
        _emps=new List<EmployeeModel>();
        _emps = new EmployeeService().GetAllEmployees();
        empListView.ItemsSource= _emps;
       
        base.OnAppearing();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void empListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var model = empListView.SelectedItem as EmployeeModel;

         Navigation.PushAsync(new DetailsPage(model));
    }
}