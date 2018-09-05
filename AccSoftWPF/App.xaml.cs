using AccSoftWPF.Core;
using System.Windows;

namespace AccSoftWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IOCContainer.Setup();
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }
    }
}
