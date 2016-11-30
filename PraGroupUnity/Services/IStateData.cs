using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace PraGroupUnity.Services
{
    public interface IStateData
    {
        List<States> GetStatesDataById(int id);

        SelectList GetAllStatesForDropDown();
    }
}
