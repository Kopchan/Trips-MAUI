using CommunityToolkit.Mvvm.ComponentModel;

namespace MyProjects.Models
{
    public partial class Trip : ObservableObject
    {
        [ObservableProperty] private string destination;
        [ObservableProperty] private DateTime date;
        [ObservableProperty] private bool isDone = false;
    }
}
