using System.Collections.ObjectModel;
using System.ComponentModel;

using Xamarin.Forms;

namespace INHANoti.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class INHAMajorListPage : ContentPage
    {
        private ObservableCollection<Major> searchResult;

        public INHAMajorListPage()
        {
            InitializeComponent();

            searchResult = new ObservableCollection<Major>();

            foreach (var item in ETC.majors)
            {
                searchResult.Add(item);
            }

            MajorCollectionView.ItemsSource = searchResult;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchResult.Clear();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                foreach (var item in ETC.majors)
                {
                    searchResult.Add(item);
                }
            }
            else
            {
                foreach (var item in ETC.majors)
                {
                    if (item.Name.Contains(e.NewTextValue))
                    {
                        searchResult.Add(item);
                    }
                }
            }
        }

        private async void MajorCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cv = sender as CollectionView;
            var item = cv.SelectedItem as Major;

            if (cv.SelectedItem != null)
            {
                ETC.nowMainShell = false;

                await Navigation.PushModalAsync(new NavigationPage(new WebViewPage(item.Name, item.URL)));
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ETC.nowMainShell = true;
        }
    }
}