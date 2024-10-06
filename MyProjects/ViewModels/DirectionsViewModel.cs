using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using MyProjects.Models;

namespace MyProjects.ViewModels
{
    public partial class DirectionsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Direction> directions;

        public DirectionsViewModel()
        {
            Directions =
            [
                new() { 
                    ImageUrl = "fethiye_amyntas.jpg", 
                    Title = "Фетхие, Турция", 
                    Description = "Фетхие — древний ликийский город с богатой историей, о чем напоминают развалины старинных крепостей и античный амфитеатр"
                },
                new() {
                    ImageUrl = "rome_colosseum.jpg",
                    Title = "Рим, Италия",
                    Description = "Рим — столица Италии, город с богатой историей и архитектурными шедеврами, такими как Колизей и Собор Святого Петра."
                },
                new() {
                    ImageUrl = "paris_eiffel_tower.jpg",
                    Title = "Париж, Франция",
                    Description = "Париж — столица Франции, известный своими достопримечательностями, такими как Эйфелева башня, Лувр и собор Парижской Богоматери."
                },
                new() {
                    ImageUrl = "tokyo_signboards.jpg",
                    Title = "Токио, Япония",
                    Description = "Токио — столица Японии, город, сочетающий в себе современные небоскребы и традиционную японскую культуру, такую как храмы и сады."
                },
                new() {
                    ImageUrl = "new_york_statue_of_liberty.jpg",
                    Title = "Нью-Йорк, США",
                    Description = "Нью-Йорк — один из крупнейших городов мира, известный своими достопримечательностями, такими как Статуя Свободы, Центральный парк и Эмпайр-стейт-билдинг."
                },
                new() {
                    ImageUrl = "rio_de_janeiro_christ_the_redeemer.jpg",
                    Title = "Рио-де-Жанейро, Бразилия",
                    Description = "Рио-де-Жанейро — город, известный своими пляжами, карнавалами и монументальной статуей Христа-Искупителя на горе Корковаду."
                },
            ];
        }
    }
}
