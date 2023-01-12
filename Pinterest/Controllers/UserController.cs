﻿
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

using PhotoHome.Data;
using PhotoHome.Helpers;
using PhotoHome.IRepository;
using PhotoHome.Models;
using PhotoHome.Models.Entity;
using PhotoHome.Models.ViewModels;

using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json.Linq;
using System;


namespace PhotoHome.Controllers
{

    public class UserController : Controller
    {


        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignupViewModel usersdata)
        {
            string[] option = usersdata.Email.Split("@");
            var user = new User
            {
                Email = usersdata.Email,
                FirstName = usersdata.FirstName,
                LastName = usersdata.FirstName,
                UserName = option[0]

            };
            var result = await userManager.CreateAsync(user, usersdata.Password);
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in result.Errors)
                    ModelState.AddModelError(item.Code, item.Description);
            }

            return RedirectToAction("SignUp");

        }



        [HttpPost]
        public async Task<IActionResult> Authenticate(LoginViewModel usersdata, string? returnUrl)
        {
            var user = await userManager.FindByEmailAsync(usersdata.Email);
            if (user != null)
            {
                if (await userManager.CheckPasswordAsync(user, usersdata.Password))
                {
                    await signInManager.SignInAsync(user, true);
                    if (!string.IsNullOrWhiteSpace(returnUrl))
                    {
                        //var token = _jWTManager.Authenticate(user);

                        //if (token == null)
                        //{
                        //    return Unauthorized();
                        //}
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }

            }


            return RedirectToAction("LogIn");
        }


        public IActionResult Created()
        {
            return View();
        }

        public IActionResult LogIn(string? returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Liked()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}