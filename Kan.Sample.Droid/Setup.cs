using System.Collections.Generic;
using System.Reflection;
using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;

namespace Kan.Sample.Droid
{
    public class Setup
        : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IList<Assembly> AndroidViewAssemblies
        {
            get 
            {
                var assemblies = base.AndroidViewAssemblies;
				assemblies.Add(typeof(Kan.Droid.Bindings.BindableViewPager).Assembly);
                return assemblies;
            }
        }
    }
}