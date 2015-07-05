using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PraktikaMusicStoreWebsite.Models;
using System.Data;
using System.Net.Mail;

namespace PraktikaMusicStoreWebsite.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        // GET: Feedback/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Feedback/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Confirmation()
        {
            return View();
        }

        // POST: Feedback/Create
        [HttpPost]
        public ActionResult Create([Bind(Include="Name,Email,Phone, Message")] Feedback feedback)
        {
            try
            {
                // TODO: Add insert logic here
                MailMessage mail = new MailMessage("wellsaid@mail.ru", feedback.Email);
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.google.com";
                mail.Subject = "feedback from " + feedback.Name;
                string message = feedback.Message + "/n/n" + "Name: " + feedback.Name + "/n" + "Phone: " + feedback.Phone.ToString() + "/n";
                mail.Body = message;
                client.Send(mail);
                 

                return RedirectToAction("Confirmation");
            }
            catch
            {
                return View();
            }
        }

        // GET: Feedback/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Feedback/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Feedback/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Feedback/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
