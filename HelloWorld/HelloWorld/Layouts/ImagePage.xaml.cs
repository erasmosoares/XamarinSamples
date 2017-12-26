using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            var imageSource = new UriImageSource { Uri = new Uri("http://desktopwalls.net/wp-content/uploads/2014/10/Colorful%20Abstract%203D%20Illustration%20Desktop%20Wallpaper.png") };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;
        }
	}
}