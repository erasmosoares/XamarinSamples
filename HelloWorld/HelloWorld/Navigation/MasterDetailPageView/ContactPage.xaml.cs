using HelloWorld.Models;
using HelloWorld.Navigation.MasterDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation.MasterDetailPageView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : MasterDetailPage
    {
        private List<Contact> _contacts;

        public ContactPage()
        {
            InitializeComponent();

            _contacts = new List<Contact>
            {
                new Contact{ Name = "Mosh", ImageUrl="http://ceoas.oregonstate.edu/people/photos/allana_t.jpg"},
                new Contact{ Name = "John", ImageUrl="http://ceoas.oregonstate.edu/people/photos/allana_t.jpg", Status="Hey let's talk"}
            };

            listview.ItemsSource = _contacts;
        }

        void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new ContactDetailPage(contact));
            IsPresented = false;
        }

        private void listview_Refreshing(object sender, EventArgs e)
        {
            listview.ItemsSource = GetContacts();
            listview.EndRefresh();
        }

        private IEnumerable<Contact> GetContacts(string searchText = null)
        {
            _contacts = new List<Contact>
            {
                new Contact{ Name = "Mosh", ImageUrl="http://ceoas.oregonstate.edu/people/photos/allana_t.jpg"},
                new Contact{ Name = "John", ImageUrl="http://ceoas.oregonstate.edu/people/photos/allana_t.jpg", Status="Hey let's talk"},
                new Contact{ Name = "Ben", ImageUrl="http://ceoas.oregonstate.edu/people/photos/allana_t.jpg"},
                new Contact{ Name = "Cindy", ImageUrl="http://ceoas.oregonstate.edu/people/photos/allana_t.jpg", Status="Hey cool"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return _contacts;

            return _contacts.Where(c => c.Name.StartsWith(searchText));
        }
    }
}
