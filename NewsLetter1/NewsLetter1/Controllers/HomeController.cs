﻿using NewsLetter1.Models;
using NewsLetter1.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NewsLetter1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly string connectionString = @"Data Source=LAPTOP-JTPJE0DT\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUps(string FirstName, string LastName, string EmailAddress)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress)) 
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using(NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = FirstName;
                    signup.LastName = LastName;
                    signup.EmailAddress = EmailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();

                }
                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                //                            (@FirstName, @LastName, @EmailAddress)";
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = FirstName;
                //    command.Parameters["@LastName"].Value = LastName;
                //    command.Parameters["@EmailAddress"].Value = EmailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();

                //}
                return View("Success");
            }
        }
        
       
    }
}