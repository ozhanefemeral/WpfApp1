using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using System;

namespace WpfApp1
{
    public class BookTypeToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string) || String.Equals("", value)) return Brushes.Transparent;

            string type = (string)value;
            if (type.Equals("PaperBack", StringComparison.OrdinalIgnoreCase))
            {
                return Brushes.LightGray;
            }
            else
            {
                return Brushes.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}