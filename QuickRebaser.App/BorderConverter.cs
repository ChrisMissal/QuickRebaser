using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace QuickRebaser.App
{
    public class BorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var commit = value as CommitLineItem;
            if (commit.IsSelected)
                return new SolidColorBrush(Colors.DarkRed);

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}