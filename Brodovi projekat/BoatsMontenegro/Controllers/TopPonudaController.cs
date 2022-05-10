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
        BaseContext objContext;
        public TopPonudaController()
        {
            objContext = new BaseContext();
        }
        public ActionResult TopPonudaView(string search, string SortOrder, string SortBy)
        {
            var boats = objContext.Boats.ToList();

            if (search != null)
            {
                boats = boats.Where(x => x.Size.Contains(search) || x.Category.Contains(search)).ToList();
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

        public ActionResult ShowOne(string id)
        {
            int BoatId = Int32.Parse(id);
            var boats = objContext.Boats.Where(b=>b.BoatID== BoatId).ToList();
            return View(boats.Take(6));
        }
    }
}

