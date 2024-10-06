using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyProjects.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ICommand NavigateToDirectionsCommand { get; }

        public MainViewModel()
        {
            NavigateToDirectionsCommand = new RelayCommand(NavigateToDirections);
        }

        private void NavigateToDirections()
        {
            Shell.Current.GoToAsync("//DirectionsPage");
        }
    }
}
