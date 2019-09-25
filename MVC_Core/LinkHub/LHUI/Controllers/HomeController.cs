using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LHUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.BooksPubBooksTotCount = 10;

            ViewBag.EpisodeUpdateTotCount = 12;  
            ViewBag.EpisodeReviewTotCount = 13;
            ViewBag.EpisodePublishedTotCount = 16;

            ViewBag.UserPlayerTotCount = 14;
            ViewBag.UserInternalUserCouunt = 15;


            return View();
        }
        //[HttpPost]
        //public IActionResult RedirectToBookList
        //{
        //    return RedirectToAction("GameBooks/)
        //}
    }
}