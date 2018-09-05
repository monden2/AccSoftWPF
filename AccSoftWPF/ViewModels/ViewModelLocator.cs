using AccSoftWPF.Core;

namespace AccSoftWPF
{
    public class ViewModelLocator
    {
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        public static ApplicationViewModel ApplicationViewModel => IOCContainer.Get<ApplicationViewModel>();
    }
}
