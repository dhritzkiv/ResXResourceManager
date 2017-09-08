﻿namespace tomenglertde.ResXManager.View.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Windows.Controls;
    using System.Windows.Data;

    using tomenglertde.ResXManager.View.Tools;

    public sealed class IsCellSelectionInvariantConverter : IValueConverter
    {
        public static readonly IsCellSelectionInvariantConverter Default = new IsCellSelectionInvariantConverter();

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as IEnumerable<DataGridCellInfo>).IsAnyItemInvariant();
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
