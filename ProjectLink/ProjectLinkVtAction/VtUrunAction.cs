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
    public class VtUrunAction : IVtBasicAction<UrunType>
    {
        VtConnection _vtConnection = new VtConnection();

        public void Add(UrunType entity)
        {
            
            try
            {

                string Query = "insert into urun(uru_kod, uru_ad, uru_birim, uru_fiyat, uru_kdvorani) values (@id, @ad, @birim, @fiyat, @kdv)";

                SqlCommand komut = new SqlCommand(Query, _vtConnection.Connection());
                komut.Parameters.AddWithValue("@id", entity.uru_kod);
                komut.Parameters.AddWithValue("@ad", entity.uru_ad);
                komut.Parameters.AddWithValue("@birim", entity.uru_birim);
                komut.Parameters.AddWithValue("@fiyat", entity.uru_fiyat);
                komut.Parameters.AddWithValue("@kdv", entity.uru_kdvorani);
                komut.ExecuteNonQuery();
             

                _vtConnection.Connection().Close();
            }
            catch (Exception)
            {

                throw new Exception("Vt Hatası. Yöneticiye Ulaşın.");
            }
        }

        public void Delete(UrunType entity)
        {
            try
            {
                string Query = "Delete from urun where uru_kod=@kod";

                SqlCommand komut = new SqlCommand(Query, _vtConnection.Connection());
                komut.Parameters.AddWithValue("@kod", entity.uru_kod);
                komut.ExecuteNonQuery();


                _vtConnection.Connection().Close();

            }
            catch (Exception)
            {

                throw new Exception("Vt Hatası. Yöneticiye Ulaşın.");
            }
        }

        public UrunType Get(int id)
        {
            throw new NotImplementedException();
        }


        public List<UrunType> Get2(string name)
        {
            try
            {
                List<UrunType> li = new List<UrunType>();


                string Query = "SELECT * FROM urun WHERE uru_ad LIKE '%" + name + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UrunType s = new UrunType();

                    s.uru_kod = dr["uru_kod"].ToString();
                    s.uru_ad = dr["uru_ad"].ToString();
                    s.uru_birim = dr["uru_birim"].ToString();
                    s.uru_fiyat = Convert.ToSingle(dr["uru_fiyat"]);
                    s.uru_kdvorani = Convert.ToSingle(dr["uru_kdvorani"]);

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


        public List<UrunType> Get3(int id)
        {
            try
            {
                List<UrunType> li = new List<UrunType>();

                string kod = id.ToString();

                string Query = "SELECT * FROM urun WHERE uru_kod LIKE '%" + kod + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UrunType s = new UrunType();

                    s.uru_kod = dr["uru_kod"].ToString();
                    s.uru_ad = dr["uru_ad"].ToString();
                    s.uru_birim = dr["uru_birim"].ToString();
                    s.uru_fiyat = Convert.ToSingle(dr["uru_fiyat"]);
                    s.uru_kdvorani = Convert.ToSingle(dr["uru_kdvorani"]);

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

        public List<UrunType> Get4(string kod)
        {
            try
            {
                List<UrunType> li = new List<UrunType>();

                string Query = "SELECT * FROM urun WHERE uru_ad LIKE '%" + kod + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UrunType s = new UrunType();

                    s.uru_kod = dr["uru_kod"].ToString();
                    s.uru_ad = dr["uru_ad"].ToString();
                    s.uru_birim = dr["uru_birim"].ToString();
                    s.uru_fiyat = Convert.ToSingle(dr["uru_fiyat"]);
                    s.uru_kdvorani = Convert.ToSingle(dr["uru_kdvorani"]);

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


        public List<UrunType> Get5(string kod)
        {
            try
            {
                List<UrunType> li = new List<UrunType>();

                string Query = "SELECT * FROM urun WHERE uru_ad LIKE '%" + kod + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UrunType s = new UrunType();

                    s.uru_fiyat = Convert.ToSingle(dr["uru_fiyat"]);
               
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


        public List<UrunType> GetAll()
        {
            List<UrunType> li = new List<UrunType>();

            string Query = "select * from urun";


            SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UrunType s = new UrunType();

                s.uru_kod = dr["uru_kod"].ToString();
                s.uru_ad = dr["uru_ad"].ToString();
                s.uru_birim = dr["uru_birim"].ToString();
                s.uru_fiyat = Convert.ToSingle(dr["uru_fiyat"]);
                s.uru_kdvorani = Convert.ToSingle(dr["uru_kdvorani"]);



                li.Add(s);


            }

            _vtConnection.Connection().Close();
            return li;
        }

        public void Update(UrunType entity)
        {

            try
            {
                
                string Query = " UPDATE urun SET uru_ad = @ad, uru_birim= @birim, uru_fiyat = @fiyat, uru_kdvorani = @kdv WHERE uru_kod = @kod";

                SqlCommand komut = new SqlCommand(Query, _vtConnection.Connection());
                komut.Parameters.AddWithValue("@ad", entity.uru_ad);
                komut.Parameters.AddWithValue("@birim", entity.uru_birim);
                komut.Parameters.AddWithValue("@fiyat", entity.uru_fiyat);
                komut.Parameters.AddWithValue("@kdv", entity.uru_kdvorani);
                komut.Parameters.AddWithValue("@kod", entity.uru_kod);

                komut.ExecuteNonQuery();

                _vtConnection.Connection().Close();
            }
            catch (Exception)
            {

                throw new Exception("Admin Ulaşın");
            }

        }
    }
}
