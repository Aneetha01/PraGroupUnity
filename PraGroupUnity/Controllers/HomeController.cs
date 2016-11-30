using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PraGroupUnity.Services;
using PraGroup.Models;

namespace PraGroupUnity.Controllers
{
    public class HomeController : Controller
     {
        private readonly IWidgetData _widgetdata;
        private readonly IStateData _stateData;
        private readonly ICalculation _calculation;

        public HomeController(IWidgetData WidgetData,IStateData StateData,ICalculation Calculation)
        {
            _widgetdata = WidgetData;

            _stateData = StateData;

           _calculation = Calculation;
        }
        public ActionResult Index()
        {
             ViewBag.Widgets = _widgetdata.GetAllWidgetsForDropDown();
            ViewBag.States = _stateData.GetAllStatesForDropDown();
            return View();
        }


        [HttpPost]
        public ActionResult Calculate(PraGroupModel pragroupmodel)
        {
            if (ModelState.IsValid)
            {
                List<Widgets> lstwidget = new List<Widgets>();
                lstwidget = _widgetdata.GetWidgetDataById(pragroupmodel.SelectedWidgetId);
                List<States> lstState = new List<States>();
                lstState = _stateData.GetStatesDataById(pragroupmodel.SelectedStateId);
                pragroupmodel.wd = lstwidget;
                pragroupmodel.state = lstState;
                pragroupmodel.BasePrice = _calculation.BasePrice(lstwidget[0].Price, pragroupmodel.WidgetQty);
                pragroupmodel.GrandTotal = _calculation.GrandTotal(pragroupmodel.BasePrice, lstwidget[0].Discount, lstState[0].Tax);

                return View(pragroupmodel);
            }
            return View();
         }

      }
}