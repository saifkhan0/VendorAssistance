using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using supplier_dashboard_1._0.Models;

namespace supplier_dashboard_1._0.Controllers

{
    public class BiddingWindowController : Controller
    {
        // GET: BiddingWindow
        public ActionResult Index()
        {
            Bidding_Window_ViewModel vm = new Bidding_Window_ViewModel();        
            return View(vm);
        }
    }
}