using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkVtAction.VtBasicAction
{
    interface IVtBasicAction<Z>
    {

        List<Z> GetAll();
        Z Get(int id);
        void Add(Z entity);
        void Update(Z entity);
        void Delete(Z entity);
    }
}
