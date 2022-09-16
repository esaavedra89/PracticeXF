using PracXF.Topics.ItemReordering;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Reordering());
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
