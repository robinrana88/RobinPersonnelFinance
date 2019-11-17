using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finance.Application.Abstractions.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalFinanceApp.Models.ViewModels;

namespace PersonalFinanceApp.Controllers
{
    public class UsersController : Controller
    {
        #region fields
        private readonly IUserService _userService;
        #endregion

        #region ctor
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion
        // GET: Users
        public ActionResult Index()
        {
            var userList = _userService.GetUsers().Select(item => new UserViewModel()
            {
                Address = item.Address,
                EmailAddress = item.EmailAddress,
                FirstName = item.FirstName,
                Gender = item.Gender,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                UserId = item.UserId
            }).ToList();
            return View(userList);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}