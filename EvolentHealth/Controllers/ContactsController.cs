using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EvolentHealth.Models;
using EvolentHealth.ViewModels;

namespace EvolentHealth.Controllers
{
    public class ContactsController : Controller
    {
        private ApplicationDbContext _context;

        public ContactsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

     
       

        // Get: Contacts/Edit/Id
        public ActionResult Edit(int id)
        {
            var contact = _context.Contacts.SingleOrDefault(c => c.Id == id);
            if (contact == null)
                return HttpNotFound();
            var viewModel = new RandomContactsViewModel
            {
                Contact = contact

            };
            return View("New", viewModel);
        }

        //Get: Contacts

        public ActionResult Index()
        {
            var contacts = _context.Contacts;
            return View(contacts);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Contacts.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }

        public ActionResult New(RandomContactsViewModel viewModel)
        {
            return View(viewModel);
        }


        [HttpPost]
        public ActionResult Save(Contact contact)
        {
            if (contact.Id == 0)
                _context.Contacts.Add(contact);
            else
            {
                var contactInDB = _context.Contacts.SingleOrDefault(c => c.Id == contact.Id);
                contactInDB.FirstName = contact.FirstName;
                contactInDB.LastName = contact.LastName;
                contactInDB.Email = contact.Email;
                contactInDB.PhoneNumber = contact.PhoneNumber;
                contactInDB.Status = contact.Status;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Contacts");
        }
       
    }
}