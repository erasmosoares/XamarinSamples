using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShorTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShorTitle = shortTitle;
        }
    }
}
