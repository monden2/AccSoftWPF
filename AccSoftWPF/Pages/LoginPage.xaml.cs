using System.Windows;
using System.Data.SqlClient;
using System.Data;
using AccSoftWPF.Core;

namespace AccSoftWPF
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage
    {

        public LoginPage()
        {
            InitializeComponent();
        }        

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            IOCContainer.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Dashboard);
        }
    }
}
