using ProjectLinkType;
using ProjectLinkVtAction.VtBasicAction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkVtAction
{
    public class VtSatisDetayAction : IVtBasicAction<SatisDetayType>
    {
        VtConnection _vtConnection = new VtConnection();
        

        public void Add(SatisDetayType entity)
        {
            try
            {
                string Query = "insert into satisdetay(sad_satisevrakno, sad_urunkodu, sad_miktar, sad_fiyat, sad_tutar, sad_kdvorani, sad_kdvtutari, sad_geneltoplam) values (@kod,@evrak, @date, @aciklama, @kod2,@evrak2, @date2, @aciklama2)";

                SqlCommand komut = new SqlCommand(Query, _vtConnection.Connection());
                komut.Parameters.AddWithValue("@kod", entity.sad_satisevrakno);
                komut.Parameters.AddWithValue("@evrak", entity.sad_urunkodu);
                komut.Parameters.AddWithValue("@date", entity.sad_miktar);
                komut.Parameters.AddWithValue("@aciklama", entity.sad_fiyat);
                komut.Parameters.AddWithValue("@kod2", entity.sad_tutar);
                komut.Parameters.AddWithValue("@evrak2", entity.sad_kdvorani);
                komut.Parameters.AddWithValue("@date2", entity.sad_kdvtutari);
                komut.Parameters.AddWithValue("@aciklama2", entity.sad_geneltoplam);
                komut.ExecuteNonQuery();
                _vtConnection.Connection().Close();
            }
            catch (Exception)
            {

                throw new Exception("Vt Hatası. Yöneticiye Ulaşın.");
            }

        }

        public void Delete(SatisDetayType entity)
        {
            throw new NotImplementedException();
        }

        public SatisDetayType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<SatisDetayType> Get2(string kod)
        {
            try
            {
                List<SatisDetayType> li = new List<SatisDetayType>();

                string Query = "SELECT * FROM satisdetay WHERE sad_satisevrakno LIKE '%" + kod + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SatisDetayType s = new SatisDetayType();

                    s.sad_satisevrakno = dr["sad_satisevrakno"].ToString();
                    s.sad_urunkodu = dr["sad_urunkodu"].ToString();
                    s.sad_miktar = Convert.ToSingle(dr["sad_miktar"]);
                    s.sad_fiyat = Convert.ToSingle(dr["sad_fiyat"]);
                    s.sad_tutar = Convert.ToSingle(dr["sad_tutar"]);
                    s.sad_kdvorani = Convert.ToSingle(dr["sad_kdvorani"]);
                    s.sad_kdvtutari = Convert.ToSingle(dr["sad_kdvtutari"]);
                    s.sad_geneltoplam = Convert.ToSingle(dr["sad_geneltoplam"]);

                    li.Add(s);


                }

                _vtConnection.Connection().Close();
                return li;
            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }

        }

        public List<SatisDetayType> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(SatisDetayType entity)
        {
            throw new NotImplementedException();
        }
    }
}
