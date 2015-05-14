using Cirrious.MvvmCross.ViewModels;

namespace Kan.Sample
{
    public class App
        : MvxApplication
    {
        public App()
        {
            RegisterAppStart<SimpleListViewModel>();
        }
    }
}
