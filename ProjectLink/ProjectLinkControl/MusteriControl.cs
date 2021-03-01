using ProjectLinkType;
using ProjectLinkVtAction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkControl
{
    public class MusteriControl
    {

        VtMusteriAction _vtMusteriAction = new VtMusteriAction();

        public void Add(MusteriType musteriType)
        {
            try
            {
                if (musteriType.mus_kod == "" || musteriType.mus_ad == "" || musteriType.mus_adres1 == "" || musteriType.mus_adres2 == "" || musteriType.mus_adres3 == "" || musteriType.mus_email == "" || musteriType.mus_telefon == "" )
                {
                    throw new Exception("Veri Kontrol");
                }

                _vtMusteriAction.Add(musteriType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        public List<MusteriType> Select()
        {
            return _vtMusteriAction.GetAll();

        }


        public void Update(MusteriType musteriType)
        {
            try
            {
                if (musteriType.mus_kod == "" || musteriType.mus_ad == "" || musteriType.mus_adres1 == "" || musteriType.mus_adres2 == "" || musteriType.mus_adres3 == "" || musteriType.mus_email == "" || musteriType.mus_telefon == "")
                {
                    throw new Exception("Veri Kontrol");
                }

                _vtMusteriAction.Update(musteriType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        public void Delete(MusteriType entity)
        {
            try
            {
                if (entity.mus_kod == "")
                {
                    throw new Exception("Veri Kontrol");
                }

                _vtMusteriAction.Delete(entity);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public List<MusteriType> Get2(string name)
        {
          return  _vtMusteriAction.Get2(name);
  
        }


        public List<MusteriType> Get3(int id)
        {
            return _vtMusteriAction.Get3(id);


        }


        public List<MusteriType> Get4(string name)
        {
            return _vtMusteriAction.Get4(name);

        }


    }
}
