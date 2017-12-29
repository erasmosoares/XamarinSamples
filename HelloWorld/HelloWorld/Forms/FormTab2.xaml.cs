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
    public partial class FormTab2 : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        public FormTab2()
        {
            InitializeComponent();

            _contactMethods = GetContactMethod();

            foreach (var item in _contactMethods)
            {
                picker.Items.Add(item.Name);
            }
        }

        private IList<ContactMethod> GetContactMethod()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id=1, Name="SMS bm"},
                new ContactMethod { Id=2, Name="Email m"},
            };

        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactMethod = ContactMethods.Items[ContactMethods.SelectedIndex];
            DisplayAlert("Selection", contactMethod, "Ok");
        }

        private void picker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            DisplayAlert("Selection", name, "Ok");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            //e.OldDate
        }
    }

    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
