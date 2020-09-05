using OrientationHandle;
using OrientationHandle.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(NextPage), typeof(NextPageRenderer))]
namespace OrientationHandle.iOS
{
    using Foundation;
    using UIKit;
    using Xamarin.Forms.Platform.iOS;

    public class NextPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            AppDelegate.AllowLandscape = true;
            base.ViewWillAppear(animated);
            UIDevice.CurrentDevice.SetValueForKey(NSNumber.FromNInt((int)UIInterfaceOrientation.LandscapeLeft), new NSString("orientation"));
        }

        public override void ViewWillDisappear(bool animated)
        {
            AppDelegate.AllowLandscape = false;
            base.ViewWillDisappear(animated);
            UIDevice.CurrentDevice.SetValueForKey(NSNumber.FromNInt((int)UIInterfaceOrientation.Portrait), new NSString("orientation"));
        }
    }
}