using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraGroupUnity.Models;
using System.Web.Mvc;

namespace PraGroupUnity.Services
{
    public interface IWidgetData
    {
        List<Widgets> GetWidgetDataById(int id);

        SelectList GetAllWidgetsForDropDown();

    }
}
