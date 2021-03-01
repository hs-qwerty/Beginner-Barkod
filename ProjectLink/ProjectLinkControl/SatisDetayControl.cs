using ProjectLinkType;
using ProjectLinkVtAction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkControl
{

    public class SatisDetayControl
    {

        VtSatisDetayAction _vtSatisDetayAction = new VtSatisDetayAction();


        public void Add(SatisDetayType entity)
        {

            _vtSatisDetayAction.Add(entity);
        }

        public List<SatisDetayType> Get2(string kod)
        {

            return _vtSatisDetayAction.Get2(kod);
        }
    }
}
