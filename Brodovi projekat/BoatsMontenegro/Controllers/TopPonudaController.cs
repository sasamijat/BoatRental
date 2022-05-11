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
        
        public ActionResult ShowOne(string id)   /*string id*/
        {
            int BoatId = Int32.Parse(id);
            
            var boats = objContext.Boats.Where(b=>b.BoatID== BoatId).ToList();
            return View(boats.Take(6));
        }
    }
}


