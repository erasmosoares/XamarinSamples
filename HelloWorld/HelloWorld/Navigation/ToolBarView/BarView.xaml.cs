using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation.ToolBarView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarView : ContentPage
    {
        public BarView()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem Activated", "Ok");
        }
    }
}