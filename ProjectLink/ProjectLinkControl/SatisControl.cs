using ProjectLinkType;
using ProjectLinkVtAction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkControl
{
    public class SatisControl
    {

        VtSatisAction _vtSatisAction = new VtSatisAction();


        public void Add(SatisType entity)
        {
            try
            {
                if (entity.sat_musterikodu == "" ||  entity.sat_aciklama == "" || entity.sat_evrakno == "")
                {
                    throw new Exception("Veri Kontrol");
                }

                _vtSatisAction.Add(entity);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<SatisType> Get2(string name)
        {

            return _vtSatisAction.Get2(name);
        }

        public List<SatisType> Get3()
        {

            return _vtSatisAction.Get3();
        }


        public List<SatisType> Get4(DateTime zaman)
        {

            return _vtSatisAction.Get4(zaman);
        }
    }
}
