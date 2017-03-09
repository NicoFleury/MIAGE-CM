using AutoMapper;
using MIAGE.Exemple.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIAGE.Exemple.Client.Controllers
{
    public class HomeController : Controller
    {
        private IEnumerable<SelectListItem> pays = Mapper.Map<IEnumerable<SelectListItem>>(Utils.Pays);

        // GET: Home
        public ActionResult Index()
        {
            List<ContactModel> models = new List<ContactModel>();
            using(ContactService.ContactServiceClient client = new ContactService.ContactServiceClient())
            {
                models = Mapper.Map<List<ContactModel>>(client.GetAllContacts());
            }

            return View(models);
        }

        // GET: Home/Details/5
        public ActionResult Details(long id)
        {
            using (ContactService.ContactServiceClient client = new ContactService.ContactServiceClient())
            {
                ContactModel model = Mapper.Map<ContactModel>(client.GetContactById(id));
                return View(model);
            }
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.Pays = pays;
            ContactModel model = new ContactModel();
            return View(model);
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(ContactModel model)
        {
            ViewBag.Pays = pays;
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                var entity = Mapper.Map<ContactService.Contact>(model);

                using (ContactService.ContactServiceClient client = new ContactService.ContactServiceClient())
                {
                    client.SaveContact(entity);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Pays = pays;
            using (ContactService.ContactServiceClient client = new ContactService.ContactServiceClient())
            {
                ContactModel model = Mapper.Map<ContactModel>(client.GetContactById(id));
                return View(model);
            }
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(ContactModel model)
        {
            ViewBag.Pays = pays;
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                var entity = Mapper.Map<ContactService.Contact>(model);

                using (ContactService.ContactServiceClient client = new ContactService.ContactServiceClient())
                {
                    client.SaveContact(entity);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

    }
}
