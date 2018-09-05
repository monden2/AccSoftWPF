using AccSoftWPF.Core;
using System.Windows;
using System.Windows.Input;

namespace AccSoftWPF
{
    public class WindowViewModel : BaseViewModel
    {
        /// <summary>
        /// Command to Minimize Window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// Command to Maximize Window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// Command to Close Window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// Set variabale mWindow to this.Window
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// Set minimum Window height
        /// </summary>
        public double MinWindowHeight { get; set; } = 768;

        /// <summary>
        /// Set minimum Window width
        /// </summary>
        public double MinWindowWidth { get; set; } = 1200;

        /// <summary>
        /// Set variable ResizeBorder to 6
        /// </summary>
        public int ResizeBorder { get; set; } = 6;

        /// <summary>
        /// Set public Thickness variable ResizeBorderThickness to value of ResizeBorder variable
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder); } }

        /// <summary>
        /// Set mWindowRadius variable to 0
        /// </summary>
        public int WindowRadius { get; set; } = 0;

        /// <summary>
        /// Set public Thickness variable ResizeBorderThickness to value of ResizeBorder variable
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        /// <summary>
        /// Set the height of the caption bar
        /// </summary>
        public int CaptionHeight { get; set; } = 40;

        /// <summary>
        /// Set the height of the caption bar
        /// </summary>
        public GridLength CaptionHeightgridLength { get { return new GridLength(CaptionHeight + ResizeBorder); } }

        public WindowViewModel(Window window)
        {
            mWindow = window;

            mWindow.StateChanged += (sender, e) =>
            {
                OnProportyChanged(nameof(ResizeBorderThickness));
                OnProportyChanged(nameof(WindowRadius));
                OnProportyChanged(nameof(WindowCornerRadius));
            };

            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
        }


    }
}
