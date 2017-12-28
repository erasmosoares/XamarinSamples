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
    public partial class FormTab1 : ContentPage
    {
        public FormTab1()
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
    }
}