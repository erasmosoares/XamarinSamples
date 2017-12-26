using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation.Hierarchical
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}