using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WpfTreeView
{
    [ValueConversion(typeof(string), typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = (String)value;
            if (path == null)
            {
                return null;
            }
            var image = string.Empty;

            var name = MainWindow.GetFileFolderName(path);

            if (name.IndexOf(".") > 0)
            {
                image = "file";
            }
            else
            {
                image = "drive";
            }

            return new BitmapImage(new Uri($"pack://application:,,,/Images/{image}.png"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
