using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PraGroupUnity.Models;
using System.Web.Mvc;

namespace PraGroupUnity.Services
{
    public class WidgetDataProvider: IWidgetData
    {
        public List<Widgets> GetWidgetDataById(int id)
        {
            PraGroupEntities db = new PraGroupEntities();
        var list = (from widget in db.Widgets
                    where widget.Id == id
                    select widget).ToList();

            return list;
        }

    public SelectList GetAllWidgetsForDropDown()
        {
            PraGroupEntities db = new PraGroupEntities();

            return new SelectList(db.Widgets.ToList(), "Id", "Name");
        }
    }
}