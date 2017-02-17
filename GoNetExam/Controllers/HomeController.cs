//------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="AACOSTA">
//     Copyright (c) AACOSTA All rights reserved.
//     Website: http://aacosta.com.mx/
// </copyright>
//------------------------------------------------------------------------

namespace GoNetExam.Controllers
{
    using Models;
    using System;
    using System.Web.Mvc;


    public class HomeController : Controller
    {

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var contact = new Contact()
            {
                Name = "Antonio Acosta Murillo",
                Mobile = "6671318545",
                Website = "http://aacosta.com.mx/",
                Email = "antonio@aacosta.com.mx",
                Skype = "eltony162"
            };

            return View(contact);
        }

        /// <summary>
        /// Gets the contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetContact(Contact contact)
        {
            var random = new Random();
            contact.LuckyNumber = random.Next(100);
            return Json(contact);
        }
    }
}