using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        //private readonly SalesWebMvcContext _context;


        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
            //context = _context;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        ////    public async Task<IActionResult> Create([Bind("Id, Name, Email, BirthDate, BaseSalary, Departament")] Seller seller)
        ////    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(seller);
        //            await _context.SaveChangesAsync();
        //            /*return RedirectToAction(nameof(Index));*/
        //        }
        //        return View(seller);
        //    }
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof (Index));
        }
    }
}