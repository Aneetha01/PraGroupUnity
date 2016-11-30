using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PraGroupUnity.Services
{
    public class StateDataProviderServices : IStateData
    {
        public SelectList GetAllStatesForDropDown()
        {
            PraGroupEntities db = new PraGroupEntities();

            return new SelectList(db.States.ToList(), "Id", "Name"); 
        }

        public List<States> GetStatesDataById(int id)
        {
            PraGroupEntities db = new PraGroupEntities();
            var list = (from state in db.States
                        where state.Id == id
                        select state).ToList();

            return list;
        }
    }
}