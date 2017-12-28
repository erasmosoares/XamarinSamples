using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageView : CarouselPage
    {
        public CarouselPageView()
        {
            InitializeComponent();
        }
    }
}