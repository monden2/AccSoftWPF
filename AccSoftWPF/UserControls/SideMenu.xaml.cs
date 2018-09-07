using AccSoftWPF.Core;
using System.Windows;
using System.Windows.Controls;

namespace AccSoftWPF
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    public partial class SideMenu : UserControl
    {

        public SideMenu()
        {
            InitializeComponent();
            CollapseAll();
        }

        public void CollapseAll()
        {
            this.CMDMenu.Visibility = System.Windows.Visibility.Collapsed;
            this.IMDMenu.Visibility = System.Windows.Visibility.Collapsed;
            this.SMDMenu.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void CMD_Click(object sender, RoutedEventArgs e)
        {

            if (this.IMDMenu.Visibility == Visibility.Visible)
            {
                this.IMDMenu.Visibility = System.Windows.Visibility.Collapsed;
            }

            if (this.SMDMenu.Visibility == Visibility.Visible)
            {
                this.SMDMenu.Visibility = System.Windows.Visibility.Collapsed;
            }

            this.CMDMenu.Visibility = this.CMDMenu.Visibility == Visibility.Visible
                                ? Visibility.Collapsed
                                : Visibility.Visible;
        }

        private void IMD_Click(object sender, RoutedEventArgs e)
        {
            if (this.CMDMenu.Visibility == Visibility.Visible)
            {
                this.CMDMenu.Visibility = System.Windows.Visibility.Collapsed;
            }

            if (this.SMDMenu.Visibility == Visibility.Visible)
            {
                this.SMDMenu.Visibility = System.Windows.Visibility.Collapsed;
            }

            this.IMDMenu.Visibility = this.IMDMenu.Visibility == Visibility.Visible
                        ? Visibility.Collapsed
                        : Visibility.Visible;
        }

        private void SMD_Click(object sender, RoutedEventArgs e)
        {
            if (this.CMDMenu.Visibility == Visibility.Visible)
            {
                this.CMDMenu.Visibility = System.Windows.Visibility.Collapsed;
            }

            if (this.IMDMenu.Visibility == Visibility.Visible)
            {
                this.IMDMenu.Visibility = System.Windows.Visibility.Collapsed;
            }
            this.SMDMenu.Visibility = this.SMDMenu.Visibility == Visibility.Visible
                                ? Visibility.Collapsed
                                : Visibility.Visible;
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            CollapseAll();
            IOCContainer.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Dashboard);
        }

        private void Invoice_Click(object sender, RoutedEventArgs e)
        {
            CollapseAll();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = Window.GetWindow(this);
            MainWindow.Close();
        }

        private void CMDCreate_Click(object sender, RoutedEventArgs e)
        {
            IOCContainer.Get<ApplicationViewModel>().GoToPage(ApplicationPage.CMDCreate);
        }
    }
}
