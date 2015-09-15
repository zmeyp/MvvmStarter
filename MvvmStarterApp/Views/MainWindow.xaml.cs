using MVVMbasics.Attributes;
using MVVMbasicsDesktopExtensions.Views;
using MvvmApp1.Viewmodels;

namespace MvvmApp1.Views
{
    [MvvmNavigationTarget(typeof(MainViewmodel))]
    public partial class MainWindow : BaseView
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
