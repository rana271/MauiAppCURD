using MauiAppCURD.Models;

namespace MauiAppCURD;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(EmployeeModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}