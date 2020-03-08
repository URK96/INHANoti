using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Timers;

namespace INHANoti.Droid
{
    [Activity(Label = "INHANoti", Icon = "@drawable/inhanoti_icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private Timer exitTimer = new Timer(2000);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            
            exitTimer.AutoReset = false;
            exitTimer.Elapsed += delegate { exitTimer.Stop(); };

            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override void OnBackPressed()
        {
            if (!ETC.nowMainShell)
            {
                base.OnBackPressed();

                return;
            }

            if (ETC.mainNotiWebView != null)
            {
                if (ETC.mainNotiWebView.CanGoBack)
                {
                    ETC.mainNotiWebView.GoBack();
                }
                else
                {
                    if (exitTimer.Enabled)
                    { 
                        base.OnBackPressed();
                    }
                    else
                    {
                        Toast.MakeText(this, "뒤로가기를 한 번 더 누르면 앱이 종료됩니다.", ToastLength.Short).Show();
                        exitTimer.Start();
                    }
                }
            }
            else
            {
                if (exitTimer.Enabled)
                {
                    base.OnBackPressed();
                }
                else
                {
                    Toast.MakeText(this, "뒤로가기를 한 번 더 누르면 앱이 종료됩니다.", ToastLength.Short).Show();
                    exitTimer.Start();
                }
            }
        }
    }
}