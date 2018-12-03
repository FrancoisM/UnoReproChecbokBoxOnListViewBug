using System;
using Windows.UI.Xaml.Data;

namespace ReproApp.Shared.Converters
{
    public class InvertBool : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language) => !(bool)value;

        public object ConvertBack(object value, Type targetType, object parameter, string language) => !(bool)value;
    }
}
