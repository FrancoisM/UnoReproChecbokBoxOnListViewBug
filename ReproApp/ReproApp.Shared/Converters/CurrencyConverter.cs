using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace ReproApp.Shared.Converters
{
    public class CurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is decimal number)) throw new ArgumentException("ToStringConverter: value is not a decimal");
            return number.ToString("C", CultureInfo.CurrentCulture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (!(value is string currency)) throw new ArgumentException("ToStringConverter: value is not a string");
            return decimal.TryParse(currency, NumberStyles.Currency, CultureInfo.CurrentCulture, out var number)
                ? number
                : 0M;
        }
    }
}
