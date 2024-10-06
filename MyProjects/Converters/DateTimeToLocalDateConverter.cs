using System.Globalization;

namespace MyProjects.Converters
{
    public class DateTimeToLocalDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => ((DateTime)value).ToString("dddd, dd MMMM yyyy", new CultureInfo("ru-RU"));

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => DateTime.Parse(value.ToString());
    }
}
