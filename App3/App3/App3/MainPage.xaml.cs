using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Plugin.Share;


namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnShare_Clicked(object sender, System.EventArgs e)
        {
            await ShareText(txtText.Text);
        }

        void btnShareURL_Clicked(object sender, System.EventArgs e)
        {
            ShareUri(txtURl.Text);
        }

        void btnAppInfo_Clicked(object sender, System.EventArgs e)
        {

            AppInformation();
        }

        public async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Get share text"
            });
        }

        public void ShareUri(string uri)
        {
            CrossShare.Current.OpenBrowser(uri);
            //await Share.RequestAsync(new ShareTextRequest
            //{
                //Uri = uri, 
               // Title = "Get share Link"
            //});
        }

        public void AppInformation()
        {
            lblAppName.Text = "App Name :" + AppInfo.Name;
            lblVersion.Text = "Version :" + AppInfo.VersionString;
            lblBuildNumber.Text = "Build Number :" + AppInfo.BuildString;
        }
    }
}
