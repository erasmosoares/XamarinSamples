using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.MarkupExtensions
{
    [ContentProperty("ResourceId")]
    class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId))
                return null;

            return ImageSource.FromResource(ResourceId);
        }
    }
}
