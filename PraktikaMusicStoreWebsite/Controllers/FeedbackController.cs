using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PraktikaMusicStoreWebsite.Models;
using System.Data;
using System.Net.Mail;
using System.Net;

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
            //try
            //{
                // TODO: Add insert logic here
            string message = feedback.Message + System.Environment.NewLine + "Name: " + feedback.Name + System.Environment.NewLine + "Phone: " + feedback.Phone.ToString() + System.Environment.NewLine + "Email: " + feedback.Email;

            MailMessage mailMessage = new MailMessage();
            MailAddress fromAddress = new MailAddress("stevejobs@gmail.com");
            mailMessage.From = fromAddress;
            mailMessage.To.Add("billgates@yahoo.com");
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = " Testing Email";
            //var smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            //};


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "localhost";
            smtpClient.Send(mailMessage);
                 

                return RedirectToAction("Confirmation");
            //}
            //catch
            //{
            //    return View("Error");
            //}
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
