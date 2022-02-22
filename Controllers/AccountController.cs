using AutoMapper;
using catering.Infrastructure;
using catering.ModelDto;
using catering.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace catering.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<user> userManager;
        private readonly SignInManager<user> signInManager;
        private readonly IMapper autoMapper;

        public AccountController(UserManager<user> userManager, SignInManager<user> signInManager, IMapper autoMapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.autoMapper = autoMapper;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string ReturnUrl = "")
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromForm] LoginUserDto model, string ReturnUrl = null)
        {
            if (ModelState.IsValid)
            {
                

                var result = await signInManager.PasswordSignInAsync(model.Name, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    var user= await userManager.FindByNameAsync(model.Name);
                    //获取该账号信息，存入claim中
    //                var claims = userManager.GetClaimsAsync(user);
    //                var claims2 = userManager.GetUsersForClaimAsync(claims.Result.FirstOrDefault());
    //                ClaimsIdentity claimsIdentity = new ClaimsIdentity(new List<Claim>
    //{
    //    new Claim(ClaimTypes.DateOfBirth,user?.DateOfBirth?.ToString())
    //}, CookieAuthenticationDefaults.AuthenticationScheme);
    //                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
    //                await signInManager.SignInWithClaimsAsync(user, isPersistent: false, claimsPrincipal.Claims);

                    ReturnUrl.ConvertURL();
                    if (!string.IsNullOrEmpty(ReturnUrl))
                    {
                        if (Url.IsLocalUrl(ReturnUrl))
                        {
                            return Redirect(ReturnUrl);
                        }
                    }
                    return RedirectToAction("index", "home");
                }
                ModelState.AddModelError(string.Empty, "登录失败，请重试！");
            }
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Me", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            var url=Url.Action(nameof(Register),nameof(AccountController),new { name="adfa",age=21});
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm] RegisterUserDto model)
        {
            if (ModelState.IsValid)
            {
                var user = autoMapper.Map<user>(model);
                var result = await userManager.CreateAsync(user, user.PasswordHash);
                if (result.Succeeded)
                {
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(new List<Claim>
    {
        new Claim(ClaimTypes.DateOfBirth,user.DateOfBirth?.ToString())
    }, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await signInManager.SignInWithClaimsAsync(user, isPersistent: false, claimsPrincipal.Claims);
                    return RedirectToAction("Me", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }
        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"邮箱：{email}已经被注册使用了.");
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
