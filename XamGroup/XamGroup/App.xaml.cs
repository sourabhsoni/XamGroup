using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamGroup.View;

namespace XamGroup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsencePage();
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
