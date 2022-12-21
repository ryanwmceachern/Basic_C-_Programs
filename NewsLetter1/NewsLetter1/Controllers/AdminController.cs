using NewsLetter1.Models;
using NewsLetter1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetter1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //var SignUps = db.SignUps.Where(x => x.Removed == null).ToList();
                var SignUps = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                var signupVms = new List<SignupVm>();
                foreach (var SignUp in SignUps)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = SignUp.Id;
                    signupVm.FirstName = SignUp.FirstName;
                    signupVm.LastName = SignUp.LastName;
                    signupVm.EmailAddress = SignUp.EmailAddress;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }
        }    
        
            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";
            //List<NewsletterSignUp> SignUps = new List<NewsletterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //        {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        SignUps.Add(signup);
            //        }
            //}

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                 var signup = db.SignUps.Find(Id);
                     signup.Removed = DateTime.Now;
                     db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        
    }
}