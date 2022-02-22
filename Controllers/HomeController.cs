using catering.Entity;
using catering.Interface;
using catering.ModelDto;
using catering.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace catering.Controllers
{

    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly dbContext dbContext;
        private readonly UserManager<user> userManager;
        private readonly SignInManager<user> signInManager;
        private readonly IMapper mapper;
        private readonly List<product> shoppings = new List<product>();


        public HomeController(ILogger<HomeController> logger, dbContext dbContext,UserManager<user> userManager,SignInManager<user> signInManager, IMapper mapper)
        {
            _logger = logger;
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);
            //List<product> prolist = await dbContext.products.ToListAsync();
            //ViewBag.prolist = prolist;


            //读取cate_item分类
            var cateList=await dbContext.category.ToListAsync();
            //var cateslist = new List<category>() {
                
            //    new category{Id="000000",parentId="-1",name="京东"},//一级
            //    new category{Id="010000",parentId="000000",name="手机"},//二级
            //        new category{Id="010100",parentId="010000",name="手机通讯"},//三级
            //            new category{Id="010101",parentId="010100",name="手机"},//四级
            //        new category{Id="010200",parentId="010000",name="手机配件"},
            //    new category{Id="020000",parentId="000000",name="运营商"},
            //    new category{Id="030000",parentId="000000",name="数码"},
            //};
            var cates = GetCate(cateList, new Cate() { Id="000000",name="京东"});
            

            return View(cates);
        }
        public List<Cate> GetCate(List<category> categories, Cate cate)
        {
            if (cate==null)
            {
                return null;
            }
            //cate的子级
            cate.cates = categories.Where(c =>  c.parentId == cate.Id
                ).Select(o => new Cate() { Id = o.currentId, parentId = o.parentId, name = o.name, cates = null }).ToList();

            foreach (var ca in cate.cates)
            {
                ca.cates = GetCate(categories, new Cate() { Id = ca.Id });
            }
            return cate.cates;
        }
        //[Authorize("Teenager")]
        public async Task<IActionResult> Order()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addshopping(int id)
        {
            return View();

        }
        public async Task<IActionResult> Shopping()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Me()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Game()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Gzwdzjs()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult G2048()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
