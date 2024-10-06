using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using MyProjects.Models;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace MyProjects.ViewModels
{
    public partial class TipsViewModel : ObservableObject
    {
        [ObservableProperty] public string searchQuery;
        [ObservableProperty] public ObservableCollection<TipCategory> categories;
        [ObservableProperty] public ObservableCollection<Tip> tipsAll;
        [ObservableProperty] public ObservableCollection<Tip> tipsFiltered;

        public TipsViewModel()
        {
            Categories = [
                new("Семья"),
                new("Бюджет"),
                new("Транспорт"),
            ];
            
            TipsAll = [
                new() {
                    Question = "Как сэкономить на авиабилетах?",
                    Answer = "Покупайте билеты заранее, следите за акциями авиакомпаний и используйте сайты сравнения цен.",
                    Categories = [Categories[1]],
                },
                new() {
                    Question = "Как путешествовать с детьми?",
                    Answer = "Выбирайте отели с детскими площадками, заранее планируйте маршруты и учитывайте потребности детей.",
                    Categories = [Categories[0]],
                },
                new() {
                    Question = "Как выбрать бюджетный транспорт?",
                    Answer = "Используйте общественный транспорт, арендуйте велосипеды или пользуйтесь услугами каршеринга.",
                    Categories = [Categories[1], Categories[2]],
                },
                new() {
                    Question = "Как сэкономить на проживании?",
                    Answer = "Выбирайте бюджетные отели, хостелы или используйте сервисы для поиска жилья у местных жителей.",
                    Categories = [Categories[1]],
                },
                new() {
                    Question = "Как путешествовать с животными?",
                    Answer = "Уточняйте правила провоза животных в транспорте и выбирайте отели, принимающие животных.",
                    Categories = [Categories[0]],
                },
                new() {
                    Question = "Как сэкономить на еде?",
                    Answer = "Готовьте еду самостоятельно, покупайте продукты на рынках и используйте сервисы доставки еды.",
                    Categories = [Categories[1]],
                },
                new() {
                    Question = "Как выбрать удобный транспорт для семьи?",
                    Answer = "Выбирайте транспорт с большим количеством мест и удобными условиями для перевозки детей и багажа.",
                    Categories = [Categories[0], Categories[2]],
                },
                new() {
                    Question = "Как сэкономить на развлечениях?",
                    Answer = "Используйте бесплатные экскурсии, посещайте музеи в дни бесплатного входа и пользуйтесь скидками для студентов.",
                    Categories = [Categories[1]],
                },
                new() {
                    Question = "Как путешествовать с большой семьей?",
                    Answer = "Выбирайте отели с семейными номерами, заранее планируйте маршруты и учитывайте потребности всех членов семьи.",
                    Categories = [Categories[0]],
                },
                new() {
                    Question = "Как сэкономить на транспорте в городе?",
                    Answer = "Используйте карты городского транспорта, покупайте проездные билеты и пользуйтесь сервисами каршеринга.",
                    Categories = [Categories[1], Categories[2]],
                },
                new() {
                    Question = "Как путешествовать с маленькими детьми?",
                    Answer = "Выбирайте отели с детскими кроватками, заранее планируйте маршруты и учитывайте потребности детей.",
                    Categories = [Categories[0]],
                },
                new() {
                    Question = "Как путешествовать с бабушкой и дедушкой?",
                    Answer = "Выбирайте отели с удобными условиями для пожилых людей, заранее планируйте маршруты и учитывайте их потребности.",
                    Categories = [Categories[0]],
                },
                new() {
                    Question = "Как путешествовать с большим багажом?",
                    Answer = "Выбирайте транспорт с большим багажным отделением, заранее уточняйте правила провоза багажа.",
                    Categories = [Categories[0], Categories[2]],
                },
            ];

            TipsFiltered = TipsAll;
        }
        [ICommand] public void FilterSearch()
        { 
            List<string> selectedCategories = 
                Categories
                .Where(c => c.IsSelected)
                .Select(c => c.Name)
                .ToList();

            TipsFiltered = new ObservableCollection<Tip>(
                TipsAll
                .Where(tip =>
                    (
                        string.IsNullOrEmpty(SearchQuery) || 
                        tip.Question.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)
                    ) && (
                        selectedCategories.Count == 0 || 
                        tip.Categories.Any(category => selectedCategories.Contains(category.Name))
                    )
                )
            );
        }
    }
}
