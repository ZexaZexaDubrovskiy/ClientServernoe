using System.Globalization;
using System.Windows.Data;
using System.Windows;
using System;

namespace WpfApp2
{
    class ConverterValue : IValueConverter
    {
        public static readonly ConverterValue Instanse = new ConverterValue();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return ((DateTime)value).ToString("dd.MM.yyyy");
            }
            else
            { return null; }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
