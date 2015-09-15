using MVVMbasicsDesktopExtensions;
using MVVMbasicsDesktopExtensions.Services;

namespace MvvmApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : BaseApplication
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public App()
        {
            // MVVMbasics-specific initialization
            NavigatorService navigatorService = new NavigatorService();
            //TODO: Modify the following line to automatically or manually register your Views
            navigatorService.RegisterAll("Views.*");
            ServiceLocator.Register(navigatorService);
            ServiceLocator.Register<MessageboxService>();
            //TODO: Modify the following line to automatically or manually register your Services
            ServiceLocator.RegisterAll("Services.*");
        }
    }
}
