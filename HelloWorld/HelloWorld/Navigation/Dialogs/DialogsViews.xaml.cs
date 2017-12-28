using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation.Dialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DialogsViews : ContentPage
    {
        public DialogsViews()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");

            if (response)
                await DisplayAlert("Done", "Your response will be save!", "Ok");
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message","Email");
            await DisplayAlert("Response", response, "Ok");
        }
    }
}