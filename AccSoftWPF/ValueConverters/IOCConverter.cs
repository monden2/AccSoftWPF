using AccSoftWPF.Core;
using Ninject;
using System;
using System.Diagnostics;
using System.Globalization;

namespace AccSoftWPF
{
    public class IOCConverter : BaseValueConverter<IOCConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)parameter)
            {
                case nameof(ApplicationViewModel):
                    return IOCContainer.Get<ApplicationViewModel>();

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
