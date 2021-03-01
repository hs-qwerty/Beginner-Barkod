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
    public class VtSatisAction : IVtBasicAction<SatisType>
    {

        public static string cevap, id;


        VtConnection _vtConnection = new VtConnection();

        public void Add(SatisType entity)
        {
            try
            {
                string Query = "insert into satis(sat_musterikodu, sat_evrakno, sat_evraktarihi, sat_aciklama) values (@kod,@evrak, @date, @aciklama)";

                SqlCommand komut = new SqlCommand(Query, _vtConnection.Connection());
                komut.Parameters.AddWithValue("@kod", entity.sat_musterikodu);
                komut.Parameters.AddWithValue("@evrak", entity.sat_evrakno);
                komut.Parameters.AddWithValue("@date", entity.sat_evraktarihi);
                komut.Parameters.AddWithValue("@aciklama", entity.sat_aciklama);
                komut.ExecuteNonQuery();
                _vtConnection.Connection().Close();
            }
            catch (Exception)
            {

                throw new Exception("Vt Hatası. Yöneticiye Ulaşın.");
            }
        }

        public void Delete(SatisType entity)
        {
            throw new NotImplementedException();
        }

        public SatisType Get(int id)
        {
            throw new NotImplementedException();
        }


        public List<SatisType> Get2(string kod)
        {
            try
            {
                List<SatisType> li = new List<SatisType>();

                string Query = "SELECT * FROM satis WHERE sat_musterikodu LIKE '%" + kod + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SatisType s = new SatisType();

                    s.sat_musterikodu = dr["sat_musterikodu"].ToString();
                    s.sat_evrakno = dr["sat_evrakno"].ToString();
                    s.sat_evraktarihi = Convert.ToDateTime(dr["sat_evraktarihi"]);
                    s.sat_aciklama = dr["sat_aciklama"].ToString();

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



        public List<SatisType> Get3()
        {
            try
            {
                List<SatisType> li = new List<SatisType>();

                string Query = "SELECT * FROM satis";

                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SatisType s = new SatisType();

                    s.sat_musterikodu = dr["sat_musterikodu"].ToString();
                    s.sat_evrakno = dr["sat_evrakno"].ToString();
                    s.sat_evraktarihi = Convert.ToDateTime(dr["sat_evraktarihi"]);
                    s.sat_aciklama = dr["sat_aciklama"].ToString();


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


        public List<SatisType> Get4(DateTime zaman)
        {
            try
            {

                string kod = zaman.ToString();

                List<SatisType> li = new List<SatisType>();

                string Query = "SELECT * FROM satis WHERE sat_evraktarihi LIKE '%" + kod + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SatisType s = new SatisType();

                    s.sat_musterikodu = dr["sat_musterikodu"].ToString();
                    s.sat_evrakno = dr["sat_evrakno"].ToString();
                    s.sat_evraktarihi = Convert.ToDateTime(dr["sat_evraktarihi"]);
                    s.sat_aciklama = dr["sat_aciklama"].ToString();

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

        public List<SatisType> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(SatisType entity)
        {
            throw new NotImplementedException();
        }
    }
}
