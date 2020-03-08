using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace INHANoti.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        internal static WebView webView;

        public WebViewPage(string title, string url)
        {
            InitializeComponent();

            Title = $"{title} 공지";

            webView = INHANotiWebView;
            webView.Source = url;
        }

        private void OnBackItemClick(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        private void OnForwardItemClick(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        private async void INHANotiWebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            WebViewProgressBar.Progress = 0;
            WebViewProgressBar.IsVisible = true;

            await WebViewProgressBar.ProgressTo(0.95, 1000, Easing.CubicInOut);
        }

        private async void INHANotiWebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            await WebViewProgressBar.ProgressTo(1.00, 500, Easing.Linear);

            WebViewProgressBar.IsVisible = false;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            ETC.mainNotiWebView = null;
        }

        protected override bool OnBackButtonPressed()
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                Navigation.PopModalAsync();
            }

            return true;
        }
    }
}