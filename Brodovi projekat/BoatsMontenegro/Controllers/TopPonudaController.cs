using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.Models;
using BoatsMontenegro.BaseBase;

namespace BoatsMontenegro.Controllers
{
    public class TopPonudaController : Controller
    {
        
    }
}


//BaseContext objContext;
//public TopPonudaController()
//{
//    objContext = new BaseContext();
//}
//public ActionResult Index(string search, string SortOrder, string SortBy)
//{
//    var boats = objContext.Boats.ToList();

//    if (search != null)
//    {
//        var model = boats.Where(x => x.Size.Contains(search) || x.Category.Contains(search)).ToList();
//        return View(model);
//    }


//    ViewBag.sortorder = SortOrder;
//    switch (SortOrder)
//    {
//        case "Acs":
//            {
//                boats = boats.OrderBy(x => x.Price).ToList();
//                break;
//            }
//        case "Des":
//            {
//                boats = boats.OrderByDescending(x => x.Price).ToList();
//                break;
//            }
//        default:
//            {
//                boats = boats.OrderBy(x => x.Price).ToList();
//                break;
//            }
//    }
//    return View(boats);
//}