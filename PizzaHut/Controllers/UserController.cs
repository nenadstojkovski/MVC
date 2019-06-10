using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaHut.Models;
using PizzaHut.Models.IRepositories;
using PizzaHut.Models.ViewModels;

namespace PizzaHut.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository users;
        public UserController(IUserRepository repository)
        {
            users = repository;
        }
        public IActionResult Index()
        {
            var model = users.GetAll();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var user = users.Get(id);
            return View(user);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.Name = model.Name;
                user.Email = model.Email;
                user.Address = model.Address;
                user.City = model.City;
                user.Phone = model.Phone;

                users.Add(user);
                int count = users.GetAll().Count();
                return RedirectToAction("index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            User user = users.Get(id);
            if (user == null)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel
                {
                    RequestId = id.ToString()
                };
                return View("Error", errorViewModel);
            }

            EditUserViewModel editUserViewModel = new EditUserViewModel
            {
                ID = user.ID,
                Name = user.Name,
                Email = user.Email,
                Address = user.Address,
                City = user.City,
                Phone = user.Phone
            };
            return View(editUserViewModel);

        }

        [HttpPost]
        public IActionResult Edit(EditUserViewModel model)
        {
            User user = users.Get(model.ID);
            if (ModelState.IsValid)
            {
                user.Name = model.Name;
                user.Email = model.Email;
                user.Address = model.Address;
                user.City = model.City;
                user.Phone = model.Phone;

                users.Update(user);
                return View("Details", user);
            }
            return View();
        }


    }
}
