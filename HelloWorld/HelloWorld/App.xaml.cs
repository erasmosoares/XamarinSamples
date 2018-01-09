using HelloWorld.DataAccess;
using HelloWorld.Forms;
using HelloWorld.Layouts;
using HelloWorld.Navigation.Carousel;
using HelloWorld.Navigation.Dialogs;
using HelloWorld.Navigation.Hierarchical;
using HelloWorld.Navigation.MasterDetail;
using HelloWorld.Navigation.MasterDetailPageView;
using HelloWorld.Navigation.TabbedPageView;
using HelloWorld.Navigation.ToolBarView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class App : Application
    {
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationEnabled";

        public App()
        {
            InitializeComponent();

            MainPage = new RESTApi();

            //MainPage = new NavigationPage(new FormTabbedPage());

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

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                   return Properties[TitleKey].ToString();

                return "";
            }
            set
            {
                Properties[TitleKey] = value;
            }
        }

        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return (bool)Properties[NotificationsEnabledKey];

                return false;
            }
            set
            {
                Properties[NotificationsEnabledKey] = value;
            }
        }

    }
}
