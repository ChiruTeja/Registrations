using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using user_reg.Models;

namespace user_reg.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Register/Insert.cshtml");
        }
        private readonly RegDBContext _context;

        public RegisterController(RegDBContext context)
        {
            _context = context;
        }
        [HttpPost]
      //[ValidateAntiForgeryToken]
       public async Task<IActionResult> Create(Registration registration)
       // public IActionResult Create(Registration registration)
        {
            // Registration A = JsonConvert.DeserializeObject<Registration>(model);
            if (ModelState.IsValid)
            {
                _context.Registrations.Add(registration);
                _context.SaveChanges();
                return new JsonResult(true);

            }
            else
            {
                return new JsonResult(false);
            }
        }

     
    }
}