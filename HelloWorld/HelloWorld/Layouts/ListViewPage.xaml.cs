using HelloWorld.Models;
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
	public partial class ListViewPage : ContentPage
	{
        private List<Contact> _contacts;

		public ListViewPage ()
		{
			InitializeComponent ();

            _contacts = new List<Contact>
            {
                new Contact{ Name = "Mosh", ImageUrl="http://ceoas.oregonstate.edu/people/photos/allana_t.jpg"},
                new Contact{ Name = "John", ImageUrl="http://ceoas.oregonstate.edu/people/photos/allana_t.jpg", Status="Hey let's talk"}
            };

            listview.ItemsSource = _contacts;
        }

        private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "Ok");
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "Ok");
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

            if(String.IsNullOrWhiteSpace(searchText))
             return _contacts;

            return _contacts.Where(c => c.Name.StartsWith(searchText));
        }

        private void listview_Refreshing(object sender, EventArgs e)
        {
            listview.ItemsSource = GetContacts();
            listview.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}