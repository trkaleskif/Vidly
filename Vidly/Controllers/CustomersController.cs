﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        [Route("customers/details/{id}")]
        public ActionResult Details(int? id)
        {
            var customerDetails = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            return View(customerDetails);
        }
        public ActionResult New()
        {
            var MembershipTypes = _context.MembershipTypes;
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = MembershipTypes
            };
            return View(viewModel);
        }
    }
}