using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using MyProjects.Models;
using System.Windows.Input;
using System.Text.Json;
using CommunityToolkit.Mvvm.Input;

namespace MyProjects.ViewModels
{
    public partial class MyTripsViewModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<Trip> trips = [];
        [ObservableProperty] private string addField = "";

        public MyTripsViewModel()
        {
            if (Preferences.ContainsKey("Trips"))
            {
                string json = Preferences.Get("Trips", string.Empty);
                if (!string.IsNullOrEmpty(json))
                    Trips = JsonSerializer.Deserialize<ObservableCollection<Trip>>(json);
            }
        }
        [ICommand] private void AddTrip()
        {
            Trips.Insert(0, new Trip()
            {
                Destination = AddField,
                Date = DateTime.Now
            });
            AddField = "";

            SaveTrips();
        }
        [ICommand] private async void DeleteTrip(Trip trip)
        {
            if (trip == null) return;

            bool result = await Application.Current.MainPage.DisplayAlert(
                "Удаление поездки", 
                "Вы уверены что хотите удалить эту поездку?", 
                "Да", "Отмена"
            );

            if (!result) return; 
                
            Trips.Remove(trip);

            SaveTrips();
        }
        [ICommand] private void ToggleCompleted(Trip trip)
        {
            trip.IsDone ^= true;
            SortTrips();
            SaveTrips();
        }

        private void SortTrips()
        {
            Trips = new ObservableCollection<Trip>(
                Trips.OrderBy(t => t.IsDone).ThenByDescending(t => t.Date)
            );
        }
        private void SaveTrips()
        {
            string json = JsonSerializer.Serialize(Trips);
            Preferences.Set("Trips", json);
        }
    }
}
