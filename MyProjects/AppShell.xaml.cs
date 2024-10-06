namespace MyProjects
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            CurrentItem = new ShellContent { 
                ContentTemplate = new DataTemplate(typeof(Views.MainPage)), 
                Route = "MainPage" 
            };
        }
    }
}
