
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrientationHandle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Send(this, AppOrientation.Landscape);
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Send(this, AppOrientation.Landscape);
            base.OnDisappearing();
        }
    }
}