using INHANoti.Views;
using System.Timers;
using Xamarin.Forms;

namespace INHANoti
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            InitList();
        }

        private void InitList()
        {
            ETC.InitMajorURLs();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ETC.nowMainShell = true;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            ETC.nowMainShell = false;
        }

        private async void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            var item = sender as MenuItem;

            ETC.nowMainShell = false;

            if (item == AppInfoMenuItem)
            {
                await Navigation.PushModalAsync(new NavigationPage(new AppInfoPage()));

                FlyoutIsPresented = false;
            }
        }
    }
}
