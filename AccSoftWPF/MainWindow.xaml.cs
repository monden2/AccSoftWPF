using AccSoftWPF.Core;
using System.Windows;
using System.Windows.Controls;

namespace AccSoftWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public ApplicationViewModel ApplicationViewModel => new ApplicationViewModel();

        public MainWindow()
        {
            InitializeComponent();

            ColumnDefinition cd = new ColumnDefinition();
            cd.Width = new GridLength(175, GridUnitType.Pixel);

            /// <summary>
            /// Load viewmodel WindowViewModel into MainWindow
            /// </summary>
            this.DataContext = new WindowViewModel(this);

        }

    }
}
