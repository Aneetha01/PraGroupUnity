using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraGroupUnity;
using PraGroupUnity.Controllers;
using PraGroupUnity.Services;
using System.Data;
using PraGroup.Models;

namespace PraGroupUnity.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private WidgetDataProvider wservice = new WidgetDataProvider();
        private StateDataProviderServices services = new StateDataProviderServices();
        private CalculationProviderService cservices = new CalculationProviderService();

        [TestMethod]
        public void Index()
        {
                        // Arrange
            HomeController controller = new HomeController(wservice, services, cservices);

            // Act
            ViewResult result = controller.Index() as ViewResult;


            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void GetWidgetDataById_IsNotNull()
        {

            PraGroupModel pragroupmodel = new PraGroupModel();
            HomeController controller = new HomeController(wservice, services, cservices);

            pragroupmodel.SelectedWidgetId = 2;
            //Act
            controller.ViewBag.Widgets = wservice.GetWidgetDataById(pragroupmodel.SelectedWidgetId);
           
            // Assert
            Assert.IsNotNull(controller.ViewBag.Widgets);
        }

        [TestMethod]
        public void GetStatesDataById_IsNotNull()
        {
            HomeController controller = new HomeController(wservice, services, cservices);
            PraGroupModel pragroupmodel = new PraGroupModel();
            
            pragroupmodel.SelectedWidgetId = 2;
            //Act
            List<States> lstState = services.GetStatesDataById(pragroupmodel.SelectedStateId);

            //Assert
            Assert.IsNotNull(lstState);
        }

        [TestMethod]
        public void VerifytheBasePriceCalculation()
        {
            HomeController controller = new HomeController(wservice, services, cservices);
                   
            //Assert
            Assert.AreEqual(100, cservices.BasePrice(50, 2));
        }


        [TestMethod]
        public void VerifyGrandTotalCalculation()
        {
            HomeController controller = new HomeController(wservice, services, cservices);
            PraGroupModel pragroupmodel = new PraGroupModel();

            //Assert
            Assert.AreEqual(95, cservices.GrandTotal(100,10,5));
        }

      }


}
