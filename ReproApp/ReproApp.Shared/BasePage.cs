using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
#if !WINDOWS_UWP
using Uno.UI.Toolkit;
#else
using Windows.Foundation;
using Windows.UI.ViewManagement;
#endif

namespace ReproApp.Shared
{
    public abstract partial class BasePage : Page
    {
        protected BasePage()
        {
#if !WINDOWS_UWP
            VisibleBoundsPadding.SetPaddingMask(this, VisibleBoundsPadding.PaddingMask.All);
#else

            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(500, 889));//iphone 6s ratio
            ApplicationView.PreferredLaunchViewSize = new Size(500, 889);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
#endif
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = e.Parameter;
            base.OnNavigatedTo(e);
        }
    }
}
