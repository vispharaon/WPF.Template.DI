using System;
using System.Diagnostics;
using System.Globalization;
using WPF.Template.DI.Core.Enums;
using WPF.Template.DI.Pages;

namespace WPF.Template.DI.ValueConverters
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage" to actual view/page/>
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        /// <summary>
        /// Coverter from base value converter
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
