using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation.TabbedPageView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tabs : TabbedPage
	{
		public Tabs ()
		{
			InitializeComponent ();

            //this.Children.Add(new ContentPage());
            //this.Children.Add(new NavigationPage(new ContentPage()));
            
		}
	}
}