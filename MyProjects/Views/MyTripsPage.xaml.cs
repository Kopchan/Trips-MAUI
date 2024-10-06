using MyProjects.Models;
using MyProjects.ViewModels;

namespace MyProjects.Views;

public partial class MyTripsPage : ContentPage
{
	public MyTripsPage()
	{
		InitializeComponent();
	}

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var checkBox = sender as CheckBox;
        var trip = checkBox.BindingContext as Trip;
        var viewModel = BindingContext as MyTripsViewModel;

        if (trip != null && viewModel != null)
        {
            viewModel.ToggleCompletedCommand.Execute(trip);
        }
    }
}