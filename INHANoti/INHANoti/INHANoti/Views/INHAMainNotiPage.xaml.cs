using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace INHANoti.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class INHAMainNotiPage : ContentPage
    {
        WebView webView;

        public INHAMainNotiPage()
        {
            InitializeComponent();

            webView = INHAMainNotiWebView;
            ETC.mainNotiWebView = webView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            webView.Source = "https://www.inha.ac.kr/kr/950/subview.do";
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

        private async void INHAMainNotiWebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            WebViewProgressBar.Progress = 0;
            WebViewProgressBar.IsVisible = true;

            await WebViewProgressBar.ProgressTo(0.95, 1000, Easing.CubicInOut);
        }

        private async void INHAMainNotiWebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            await WebViewProgressBar.ProgressTo(1.00, 500, Easing.Linear);

            WebViewProgressBar.IsVisible = false;
        }

        protected override bool OnBackButtonPressed()
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }

            return true;
        }
    }
}