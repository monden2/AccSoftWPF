using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AccSoftWPF
{
    /// <summary>
    /// Set page BasePage as Page type
    /// </summary>
    public class BasePage : Page 
    {

        /// <summary>
        /// Define public variable PageLoadAnimation as new PageAnimation, and get/set value as SlideOutFromRight
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideInFromRight;

        /// <summary>
        /// Define public variable PageUnloadAnimation as new PageAnimation, and get/set value as FadeOut
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.FadeOut;

        /// <summary>
        /// Define public variable FadeSecondsIn as float, and get/set value as 0.2f (0.2 seconds)
        /// </summary>
        public float FadeSecondsIn { get; set; } = 0.2f;

        /// <summary>
        /// Define public variable FadeSecondsOut as float, and get/set value as 0.2f (0.2 seconds)
        /// </summary>
        public float FadeSecondsOut { get; set; } = 0.2f;

        /// <summary>
        /// Define public variable FadeSecondsIn as float, and get/set value as 0.2f (0.2 seconds)
        /// </summary>
        public float SlideSecondsIn { get; set; } = 0.5f;

        /// <summary>
        /// Define public variable FadeSecondsOut as float, and get/set value as 0.2f (0.2 seconds)
        /// </summary>
        public float SlideSecondsOut { get; set; } = 0.5f;

        public BasePage()
        {
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            this.Loaded += BasePage_Loaded;
        }

        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            await SlideInFromRight();
        }

        public async Task SlideInFromRight()
        {
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideInFromRight:

                    await this.SlideInFromRight(SlideSecondsIn);

                    break;
            }

        }

        public async Task FadeOut()
        {
            if (this.PageUnloadAnimation == PageAnimation.None)
                return;

            switch (this.PageUnloadAnimation)
            {
                case PageAnimation.FadeOut:

                    await this.FadeOut(FadeSecondsOut);

                    break;
            }
        }

    }
}
