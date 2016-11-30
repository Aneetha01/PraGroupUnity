using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PraGroupUnity.Services;

namespace PraGroupUnity.Controllers
{
    public class UnityDemoController : Controller
    {
        //private IWidgetData _widgetdata;
        public UnityDemoController(PraGroupUnity.Services.IWidgetData data)
        {
          //  _widgetdata = widgetdata;
        }
        // GET: UnityDemo
        public ActionResult Index()
        {
            return View();
        }
    }
}