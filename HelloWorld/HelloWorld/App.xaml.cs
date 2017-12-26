using HelloWorld.Layouts;
using HelloWorld.Navigation.Hierarchical;
using HelloWorld.Navigation.MasterDetail;
using HelloWorld.Navigation.MasterDetailPageView;
using HelloWorld.Navigation.TabbedPageView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Tabs();

            //MainPage = new NavigationPage(new ContactsPage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
