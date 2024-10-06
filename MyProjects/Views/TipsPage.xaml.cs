using MyProjects.ViewModels;
using System.Windows.Input;

namespace MyProjects.Views;

public partial class TipsPage : ContentPage
{
	public TipsPage()
	{
		InitializeComponent();
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (BindingContext is TipsViewModel viewModel)
        {
            viewModel.FilterSearchCommand.Execute(null);
        }
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is TipsViewModel viewModel)
        {
            viewModel.FilterSearchCommand.Execute(null);
        }
    }
}