using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EvolentHealth.Models;

namespace EvolentHealth.ViewModels
{
    public class RandomContactsViewModel
    {
        public List<Contact> Contacts { get; set; }

        public Contact Contact { get; set; }
        public string Title
        {
            get
            {
                if(Contact != null && Contact.Id != 0)
                {
                    return "Edit Contact";
                }
                else
                {
                    return "Add New Contact";
                }
            }
        }

    }
}