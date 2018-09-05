using AccSoftWPF.Core;
using System;
using System.Diagnostics;
using System.Globalization;

namespace AccSoftWPF
{
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();

                case ApplicationPage.Dashboard:
                    return new DashboardPage();

                case ApplicationPage.CMDCreate:
                    return new CMDCreate();

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
