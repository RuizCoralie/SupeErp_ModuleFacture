using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ModuleFactureUserControl.Helpers
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToCollapsedVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolean = false;
            if (value is bool) boolean = (bool)value;
            return boolean ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("ConvertBack not supported");
        }
    }

    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanNegateToCollapsedVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)value) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("ConvertBack not supported");
        }
    }
}
