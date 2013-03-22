﻿// new

using System;
using System.Windows.Data;

namespace Speedo
{
    public sealed class SpeedUnitToStringConverter : IValueConverter
    {
        public string Kilometers { get; set; }
        public string Miles { get; set; }

        public object Convert( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
        {
            return (SpeedUnit) value == SpeedUnit.Kilometers ? Kilometers : Miles;
        }

        public object ConvertBack( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
        {
            throw new NotSupportedException();
        }
    }
}