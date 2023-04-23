using DatabaseBizLand.DataAccess;
using DatabaseBizLand.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace DatabaseBizLand.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
       public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewModel viewM = new ViewModel()
            {
                Services=_context.Services.ToList(),
                TeamMembers=_context.TeamMembers.ToList()

            };
            return View(viewM);
        }

        

       
    }
}
