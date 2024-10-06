using CommunityToolkit.Mvvm.ComponentModel;

namespace MyProjects.Models
{
    public partial class Direction : ObservableObject
    {
        [ObservableProperty]
        private string imageUrl;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private string description;
    }
}
