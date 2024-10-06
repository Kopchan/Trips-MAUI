using CommunityToolkit.Mvvm.ComponentModel;

namespace MyProjects.Models
{
    public partial class TipCategory(string name) : ObservableObject
    {
        [ObservableProperty] private string name = name;
        [ObservableProperty] private bool isSelected = false;
    }
}
