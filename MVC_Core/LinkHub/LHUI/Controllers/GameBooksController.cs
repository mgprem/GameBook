using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LHBLL;
using Microsoft.AspNetCore.Authorization;

namespace LHUI.Controllers
{
  
    public class GameBooksController : Controller
    {
        IGamebookBs gameBookBs;
        public GameBooksController(IGamebookBs _gameBookBs)
        {
            gameBookBs = _gameBookBs;
        }
        //public IActionResult Index()
        //{

        //    //var gb = gameBookBs.GetById(2);
        //    //var gb3 = gameBookBs.Delete(2);
        //    var gb1 = gameBookBs.GetAll();
        //    //var gb2 = gameBookBs.Create();
           
        //    return View(gb1);
        //}
        public IActionResult Index(string SortOrder, string SortBy, String Page)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;
            //var gb = gameBookBs.GetById(2);
            //var gb3 = gameBookBs.Delete(2);
            var gb1 = gameBookBs.GetAll();
            //var gb2 = gameBookBs.Create();
            switch (SortBy)
            {
                case "Id":
                        switch (SortOrder)
                        {
                            case "Asc":
                                gb1=gb1.OrderBy(x=>x.Id).ToList();
                                break;
                            case "Desc":
                                gb1 = gb1.OrderByDescending(x => x.Id).ToList();
                                break;
                            default:
                                break;
                        }
                    break;
                case "Name":
                    switch (SortOrder)
                    {
                        case "Asc":
                            gb1 = gb1.OrderBy(x => x.Name).ToList();
                            break;
                        case "Desc":
                            gb1 = gb1.OrderByDescending(x => x.Name).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    gb1 = gb1.OrderBy(x => x.Id).ToList();
                    break;
            }
            ViewBag.TotalPages = Math.Ceiling(gameBookBs.GetAll().Count() / 10.0);
            int page = int.Parse(Page == null ? "1" : Page);
            ViewBag.Page = page;
            gb1 = gb1.Skip((page - 1) * 10).Take(10);
            return View(gb1);
        }
        //[HttpPost]
        //public JsonResult FilterRecords ( string grade)
        //{

        //   // List<School> schoolList = CreateSchool();
        //   // List<School> newSchoolList = schoolList.Where(a => grade.Contains(a.Grade)).OrderBy(b => b.Grade).ToList();
        //    var gb1 = gameBookBs.GetAll().Where(a => grade.Contains(a.Id.ToString() )).ToList();
        //    return Json(gb1);
        //}
        //[HttpPost]
        //public void FilterRecords(List<int> Ids, string Status)
        //{

        //    // List<School> schoolList = CreateSchool();
        //    // List<School> newSchoolList = schoolList.Where(a => grade.Contains(a.Grade)).OrderBy(b => b.Grade).ToList();
        //   // var gb1 = gameBookBs.GetAll().Where(a => grade.Contains(a.Id.ToString())).ToList();
        //   // return View();
        //}
        [HttpPost]
        public IActionResult FilterRecords(List<int> Ids, string Status)
        {
            try
            {
                var gb1 = gameBookBs.GetAll().Where(a => Ids.Contains(a.Id)).ToList();
                return PartialView("pv_GameBookList", gb1);
            }
            catch(Exception e)
            {
                var gb1 = gameBookBs.GetAll().Where(a => Ids.Contains(a.Id)).ToList();
                return PartialView("pv_GameBookList", gb1);
            }

            // List<School> schoolList = CreateSchool();
            // List<School> newSchoolList = schoolList.Where(a => grade.Contains(a.Grade)).OrderBy(b => b.Grade).ToList();
            // var gb1 = gameBookBs.GetAll().Where(a => grade.Contains(a.Id.ToString())).ToList();
            // return View();
        }

        
        [HttpPost]
        public IActionResult SearchRecords(string Search)
        {
            try
            {
                var gbSearch = gameBookBs.GetAll().Where(a => Search.Contains(a.Id.ToString())).ToList();
                if (gbSearch.Count<=0)
                {
                   gbSearch = gameBookBs.GetAll().Where(a => Search.Contains(a.Name.ToString())).ToList();
                   if (gbSearch.Count<=0)  
                    gbSearch = gameBookBs.GetAll().Where(a => a.Name.ToUpper().StartsWith(Search.ToUpper())).ToList();
                }

                return PartialView("pv_GameBookList", gbSearch);
            }
            catch (Exception e)
            {
                var gb1 = gameBookBs.GetAll().Where(a => Search.Contains(a.Id.ToString())).ToList();
                return PartialView("pv_GameBookList", gb1);
            }

            // List<School> schoolList = CreateSchool();
            // List<School> newSchoolList = schoolList.Where(a => grade.Contains(a.Grade)).OrderBy(b => b.Grade).ToList();
            // var gb1 = gameBookBs.GetAll().Where(a => grade.Contains(a.Id.ToString())).ToList();
            // return View();
        }
    }
}