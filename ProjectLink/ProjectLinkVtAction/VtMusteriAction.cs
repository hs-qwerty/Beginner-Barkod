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
    public class VtMusteriAction : IVtBasicAction<MusteriType>
    {
        VtConnection _vtConnection = new VtConnection();
        public void Add(MusteriType entity)
        {
            try
            {
                string Query = "insert into musteri(mus_kod, mus_ad, mus_adres1, mus_adres2, mus_adres3, mus_telefon, mus_email) values (@kod, @ad, @adres1, @adres2, @adres3, @tel, @mail)";

                SqlCommand komut = new SqlCommand(Query, _vtConnection.Connection());
                komut.Parameters.AddWithValue("@kod", entity.mus_kod);
                komut.Parameters.AddWithValue("@ad", entity.mus_ad);
                komut.Parameters.AddWithValue("@adres1", entity.mus_adres1);
                komut.Parameters.AddWithValue("@adres2", entity.mus_adres2);
                komut.Parameters.AddWithValue("@adres3", entity.mus_adres3);
                komut.Parameters.AddWithValue("@tel", entity.mus_telefon);
                komut.Parameters.AddWithValue("@mail", entity.mus_email);
                komut.ExecuteNonQuery();


                _vtConnection.Connection().Close();
            }
            catch (Exception)
            {

                throw new Exception("Vt Hatası. Yöneticiye Ulaşın.");
            }
        }



        public void Delete(MusteriType entity)
        {
            try
            {
                string Query = "Delete from musteri where mus_kod=@kod";

                SqlCommand komut = new SqlCommand(Query, _vtConnection.Connection());
                komut.Parameters.AddWithValue("@kod", entity.mus_kod);
                komut.ExecuteNonQuery();


                _vtConnection.Connection().Close();

            }
            catch (Exception)
            {

                throw new Exception("Vt Hatası. Yöneticiye Ulaşın.");
            }
        }

        public MusteriType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<MusteriType> Get2(string name)
        {
            try
            {
                List<MusteriType> li = new List<MusteriType>();


                string Query = "SELECT * FROM musteri WHERE mus_ad LIKE '%" + name + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MusteriType s = new MusteriType();

                    s.mus_kod = dr["mus_kod"].ToString();
                    s.mus_ad = dr["mus_ad"].ToString();
                    s.mus_adres1 = dr["mus_adres1"].ToString();
                    s.mus_adres2 = dr["mus_adres2"].ToString();
                    s.mus_adres3 = dr["mus_adres3"].ToString();
                    s.mus_telefon = dr["mus_telefon"].ToString();
                    s.mus_email = dr["mus_email"].ToString();

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

        public List<MusteriType> Get3(int id)
        {
            try
            {
                List<MusteriType> li = new List<MusteriType>();

                string kod = id.ToString();

                string Query = "SELECT * FROM musteri WHERE mus_kod LIKE '%" + kod + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MusteriType s = new MusteriType();

                    s.mus_kod = dr["mus_kod"].ToString();
                    s.mus_ad = dr["mus_ad"].ToString();
                    s.mus_adres1 = dr["mus_adres1"].ToString();
                    s.mus_adres2 = dr["mus_adres2"].ToString();
                    s.mus_adres3 = dr["mus_adres3"].ToString();
                    s.mus_telefon = dr["mus_telefon"].ToString();
                    s.mus_email = dr["mus_email"].ToString();

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


        public List<MusteriType> Get4(string name)
        {
            try
            {
                List<MusteriType> li = new List<MusteriType>();

            
                string Query = "SELECT * FROM musteri WHERE mus_ad LIKE '%" + name + "%'";


                SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MusteriType s = new MusteriType();

                    s.mus_kod = dr["mus_kod"].ToString();
                    s.mus_ad = dr["mus_ad"].ToString();
                    s.mus_adres1 = dr["mus_adres1"].ToString();
                    s.mus_adres2 = dr["mus_adres2"].ToString();
                    s.mus_adres3 = dr["mus_adres3"].ToString();
                    s.mus_telefon = dr["mus_telefon"].ToString();
                    s.mus_email = dr["mus_email"].ToString();

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

        public List<MusteriType> GetAll()
        {
            List<MusteriType> li = new List<MusteriType>();

            string Query = "select * from musteri";


            SqlCommand cmd = new SqlCommand(Query, _vtConnection.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MusteriType s = new MusteriType();

                s.mus_kod = dr["mus_kod"].ToString();
                s.mus_ad = dr["mus_ad"].ToString();
                s.mus_adres1 = dr["mus_adres1"].ToString();
                s.mus_adres2 = dr["mus_adres2"].ToString();
                s.mus_adres3 = dr["mus_adres3"].ToString();
                s.mus_telefon = dr["mus_telefon"].ToString();
                s.mus_email = dr["mus_email"].ToString();

                li.Add(s);


            }

            _vtConnection.Connection().Close();
            return li;
        }

        public void Update(MusteriType entity)
        {
            try
            {

                string Query = " UPDATE musteri SET mus_ad = @ad, mus_adres1= @adres1, mus_adres2 = @adres2, mus_adres3 = @adres3, mus_telefon = @tel, mus_email = @email WHERE mus_kod = @kod";

                SqlCommand komut = new SqlCommand(Query, _vtConnection.Connection());
                komut.Parameters.AddWithValue("@ad", entity.mus_ad);
                komut.Parameters.AddWithValue("@adres1", entity.mus_adres1);
                komut.Parameters.AddWithValue("@adres2", entity.mus_adres2);
                komut.Parameters.AddWithValue("@adres3", entity.mus_adres3);
                komut.Parameters.AddWithValue("@tel", entity.mus_telefon);
                komut.Parameters.AddWithValue("@email", entity.mus_email);
                komut.Parameters.AddWithValue("@kod", entity.mus_kod);

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
