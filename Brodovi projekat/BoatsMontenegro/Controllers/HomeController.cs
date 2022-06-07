using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoatsMontenegro.BaseBase;
using BoatsMontenegro.Models;
using BoatsMontenegro.AutorizationAuthentication;

namespace BoatsMontenegro.Controllers
{  
    public class HomeController : Controller
    {
        
        BaseContext objContext;
        public HomeController()
        {
            objContext = new BaseContext();
        }
        //public ViewResult Pretraga (string sortOrder, string searchString)
        //{
        //    ViewBag.CategorySortParam = String.IsNullOrEmpty(sortOrder) ? "category_desc" : "";
        //    ViewBag.PriceSortParam = sortOrder == "Price" ? "price_desc" : "Price";
        //    var boatsList = from s in objContext.Boats select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        boatsList = boatsList.Where(s => s.Category.Contains(searchString) || s.Price.ToString().Contains(searchString));
        //    }
        //    switch (sortOrder)
        //    {
        //        case "category_desc":
        //            boatsList = boatsList.OrderByDescending(s => s.Category);
        //            break;
        //        case "Price":
        //            boatsList = boatsList.OrderBy(s => s.Price);
        //            break;
        //        case "price_desc":
        //            boatsList = boatsList.OrderByDescending(s => s.Price);
        //            break;
        //        default:
        //            boatsList = boatsList.OrderBy(s => s.Category);
        //            break;
        //    }
        //    return View(boatsList.ToList());
        //}
        
        public ActionResult Index(string search, string SortOrder, string SortBy)
        {
            var boats = objContext.Boats.ToList();

            if (search != null)
            {
                //boats = boats.Where(x => x.Size.Contains(search) || x.Category.Contains(search)).ToList();
                return View(objContext.Boats.Where(x => x.Category.Contains(search)).ToList());
                //&& x.Size.Contains(search)
                //&& x.Capacity.ToString().Contains(search) && x.Price.ToString().Contains(search)).ToList());
            }

            ViewBag.sortorder = SortOrder;
            switch (SortOrder)
            {
                case "Acs":
                    {
                        boats = boats.OrderBy(x => x.Price).ToList();
                        break;
                    }
                case "Des":
                    {
                        boats = boats.OrderByDescending(x => x.Price).ToList();
                        break;
                    }
                default:
                    {
                        boats = boats.OrderBy(x => x.Price).ToList();
                        break;
                    }
            }
            return View(boats.Take(6));
        }

        
        public ActionResult UnAuthorized()
        {
            //ViewBag.Message = "Pristup odbijen!";
            return View();
        }
    }
}