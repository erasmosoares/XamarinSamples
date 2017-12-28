using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormGeneralPage : ContentPage
    {
        public FormGeneralPage()
        {
            InitializeComponent();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            label.Text = "Completed";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label.Text = e.NewTextValue;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactMethod = ContactMethods.Items[ContactMethods.SelectedIndex];
            DisplayAlert("Selection", contactMethod, "Ok");
        }

        //private void Switch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    label.IsVisible = e.Value;
        //}
    }
}