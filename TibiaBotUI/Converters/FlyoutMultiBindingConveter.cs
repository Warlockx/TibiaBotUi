﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using MediviaBotUI.Models;

namespace MediviaBotUI.Converters
{
    public class FlyoutMultiBindingConveter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length > 2 && values[2] is WaypointType)
            return values[0].ToString().Equals(parameter) && (bool)values[1] && (WaypointType)values[2] == WaypointType.Action;
            
            return values[0].ToString().Equals(parameter) && (bool) values[1];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new[] {int.Parse(parameter.ToString()), value };
        }
    }
}
