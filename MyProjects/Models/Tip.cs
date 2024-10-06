using CommunityToolkit.Mvvm.ComponentModel;

namespace MyProjects.Models
{
    public partial class Tip : ObservableObject
    {
        [ObservableProperty] public string question;
        [ObservableProperty] public string answer;
        [ObservableProperty] public List<TipCategory> categories;

    }
}
