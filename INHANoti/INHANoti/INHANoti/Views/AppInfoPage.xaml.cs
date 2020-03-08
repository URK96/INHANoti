
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace INHANoti.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppInfoPage : ContentPage
    {
        public AppInfoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ETC.nowMainShell = false;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            ETC.nowMainShell = true;
        }

        private async void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}