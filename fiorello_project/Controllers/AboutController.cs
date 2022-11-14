using fiorello_project.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using p323.ViewModels.About;

namespace fiorello_project.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _appDbcontext;
        public AboutController(AppDbContext appDbContext )
        {
            _appDbcontext = appDbContext;
        }
        public async  Task<IActionResult> Index()
        {
            var model = new AboutIndexViewModel
            {
                ObijectiveComponents= await _appDbcontext.ObijectiveComponents.ToListAsync()

            };
            return View(model);
        }
    }
}
