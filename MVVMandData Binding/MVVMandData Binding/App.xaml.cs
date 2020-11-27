using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginRegisterXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navigationPage = new NavigationPage(new LoginRegisterTabbedPage());

            MainPage = navigationPage;

         
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
