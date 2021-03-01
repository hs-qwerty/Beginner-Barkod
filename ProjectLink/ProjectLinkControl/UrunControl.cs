using ProjectLinkType;
using ProjectLinkVtAction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkControl
{
    public class UrunControl
    {

        VtUrunAction _vtUrunAction = new VtUrunAction();



        public List<UrunType> Get2(string name)
        {

           return _vtUrunAction.Get2(name);
        }

        public List<UrunType> Get3(int id)
        {

            return _vtUrunAction.Get3(id);
        }

        public List<UrunType> Get4(string name)
        {

            return _vtUrunAction.Get4(name);
        }

        public List<UrunType> Get5(string name)
        {
            return _vtUrunAction.Get5(name);

        }





        public void Add(UrunType urunType)
        {

            try
            {
                if (urunType.uru_kod == "" || urunType.uru_ad == "" || urunType.uru_birim == "" || urunType.uru_fiyat < 0  || urunType.uru_kdvorani < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _vtUrunAction.Add(urunType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
        public List<UrunType> Select()
        {
           return _vtUrunAction.GetAll();

        }

        public void Delete(UrunType entity)
        {
            try
            {
                if (entity.uru_kod == "" )
                {
                    throw new Exception("Veri Kontrol");
                }

                _vtUrunAction.Delete(entity);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public void Update(UrunType urunType)
        {

            try
            {
                if (urunType.uru_kod == "" || urunType.uru_ad == "" || urunType.uru_birim == "" || urunType.uru_fiyat < 0 || urunType.uru_kdvorani < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _vtUrunAction.Update(urunType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        }



}


