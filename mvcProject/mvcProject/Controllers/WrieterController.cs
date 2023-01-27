using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcProject.Controllers
{
    public class WrieterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterDal());
        // GET: Wrieter
        public ActionResult Index()
        {
            var WriterValues = wm.GetList();    
            return View(WriterValues);
        }
    }
}