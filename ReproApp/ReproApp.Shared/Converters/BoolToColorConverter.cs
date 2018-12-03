using System;
using Windows.UI.Xaml.Data;

namespace ReproApp.Shared.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var colors = ((string)parameter).Split('|');
            return (bool)value ? colors[0] : colors[1];
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) => null;
    }
}
