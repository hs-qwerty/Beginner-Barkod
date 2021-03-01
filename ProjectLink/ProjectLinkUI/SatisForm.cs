using ProjectLinkControl;
using ProjectLinkType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLinkUI
{
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }

        UrunControl _urunControl = new UrunControl();
        MusteriControl _musteriControl = new MusteriControl();

        SatisControl _satisControl = new SatisControl();

        SatisDetayControl _satisDetayControl = new SatisDetayControl();

        private void MusListBtn_Click(object sender, EventArgs e)
        {
            MusteriForm musteriForm = new MusteriForm();
            musteriForm.Show();
        }

        private void UrunListBtn_Click(object sender, EventArgs e)
        {
            UrunForm urunForm = new UrunForm();
            urunForm.Show();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            Urunlist();
            Musterilist();
         


        }

        private void Urunlist()
        {

            List<UrunType> urun = new List<UrunType>();

            urun = _urunControl.Select();


            foreach (var item in urun)
            {
                 comboBox2.Items.Add(item.uru_ad);
                

            }

        }

        private void Musterilist()
        {
            List<MusteriType> musteri = new List<MusteriType>();

            musteri = _musteriControl.Select();

            foreach (var item in musteri)
            {
                comboBox1.Items.Add(item.mus_ad);

            }

        }

        private void MusteriAraBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MusAdRadioBtn.Checked == true)
                {
                    if (MusteriAraTxt.Text == "")
                    {
                        throw new Exception("Boş Geçilemez.");
                    }
                    List<MusteriType> musteri = new List<MusteriType>();
                    musteri = _musteriControl.Get2(MusteriAraTxt.Text);

                    if (musteri.Count > 0)
                    {
                        foreach (var item in musteri)
                        {
                            comboBox1.SelectedItem = item.mus_ad.ToString();
                        }
                    }
                    else
                    {
                        throw new Exception("Sonuç 0.");
                    }
                }
                else if (MusKodRadioBtn.Checked == true)
                {

                    if (MusteriAraTxt.Text == "")
                    {
                        throw new Exception("Boş Geçilemez.");
                    }
                    List<MusteriType> musteri = new List<MusteriType>();
                    musteri = _musteriControl.Get3(Convert.ToInt32(MusteriAraTxt.Text));

                    if (musteri.Count > 0)
                    {
                        foreach (var item in musteri)
                        {
                            comboBox1.SelectedItem = item.mus_ad.ToString();
                        }
                    }
                    else
                    {
                        throw new Exception("Sonuç 0.");
                    }
                }
                else
                {
                    throw new Exception("Lütfen Tür Seçimi Yapınız");
                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (UrnAdRadioBtn.Checked == true)
                {
                    if (UrunAraTxt.Text == "")
                    {
                        throw new Exception("Boş Geçilemez.");
                    }
                    List<UrunType> urun = new List<UrunType>();
                    urun = _urunControl.Get2(UrunAraTxt.Text);

                    if (urun.Count > 0)
                    {
                        foreach (var item in urun)
                        {
                            comboBox2.SelectedItem = item.uru_ad.ToString();
                            UrnFiyatTxt.Text = item.uru_fiyat.ToString();
                        }
                    }
                    else
                    {
                        throw new Exception("Sonuç 0.");
                    }
                }
                else if (UrnKodRadioBtn.Checked == true)
                {

                    if (UrunAraTxt.Text == "")
                    {
                        throw new Exception("Boş Geçilemez.");
                    }
                    List<UrunType> urun = new List<UrunType>();
                    urun = _urunControl.Get3(Convert.ToInt32(UrunAraTxt.Text));

                    if (urun.Count > 0)
                    {
                        foreach (var item in urun)
                        {
                            comboBox2.SelectedItem = item.uru_ad.ToString();
                            UrnFiyatTxt.Text = item.uru_fiyat.ToString();
                        }
                    }
                    else
                    {
                        throw new Exception("Sonuç 0.");
                    }
                }
                else
                {
                    throw new Exception("Lütfen Tür Seçimi Yapınız");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MusteriSiparisEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    throw new Exception("Müşteri Seçimi Yapınız.");
                }

               string name = comboBox1.SelectedItem.ToString();

                List<MusteriType> musteri = new List<MusteriType>();
                musteri = _musteriControl.Get4(name);

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Müşteri Ad");
                dt.Columns.Add("Adres");
                dt.Columns.Add("Adres1");
                dt.Columns.Add("Adres2");
                dt.Columns.Add("Telefon");
                dt.Columns.Add("Mail");



                foreach (var item in musteri)
                {
                    DataRow drow = dt.NewRow();
                    drow["ID"] = item.mus_kod;
                    drow["Müşteri Ad"] = item.mus_ad;
                    drow["Adres"] = item.mus_adres1;
                    drow["Adres1"] = item.mus_adres2;
                    drow["Adres2"] = item.mus_adres2;
                    drow["Telefon"] = item.mus_telefon;
                    drow["Mail"] = item.mus_email;

                    dt.Rows.Add(drow);
                }



                dataGridView1.DataSource = dt;


                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Width = 70;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToDeleteRows = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UrunSiparisEkle_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox2.SelectedIndex == -1)
                {
                    throw new Exception("Ürün Seçimi Yapınız.");
                }

                string name = comboBox2.SelectedItem.ToString();

                List<UrunType> urun = new List<UrunType>();
                urun = _urunControl.Get4(name);
                dataGridView2.Rows.Add();
                int deger = dataGridView2.Rows.Count;

                foreach (var item in urun)
                {
                    
                    int bac = deger - 2;
                    dataGridView2.Rows[bac].Cells[0].Value = item.uru_kod;
                    dataGridView2.Rows[bac].Cells[1].Value = item.uru_ad;
                    dataGridView2.Rows[bac].Cells[2].Value = item.uru_birim;
                    dataGridView2.Rows[bac].Cells[3].Value = UrnFiyatTxt.Text;
                    dataGridView2.Rows[bac].Cells[4].Value = item.uru_kdvorani;

                }

                

                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataGridView2.Columns[0].Width = 70;
                dataGridView2.ReadOnly = true;
                dataGridView2.AllowUserToDeleteRows = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           string kod =  comboBox2.SelectedItem.ToString();

            List<UrunType> urun = new List<UrunType>();

            urun = _urunControl.Get5(kod);


            foreach (var item in urun)
            {

                UrnFiyatTxt.Text = item.uru_fiyat.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SiparisEkleBtn_Click(object sender, EventArgs e)
        {
            string musteriKod = dataGridView1.Rows[0].Cells[0].Value.ToString();
           
            string aciklama = "uzun";

            Random Rdn = new Random();
            int rd = Rdn.Next(10, 1500);
            string evrakno = rd.ToString();

            try
            {
                if (musteriKod == "" || aciklama == "" || evrakno == "" )
                {
                    throw new Exception("Boş Geçilemez.");
                }

               _satisControl.Add(new SatisType
                {
                    sat_musterikodu = musteriKod,
                    sat_evraktarihi = DateTime.Now,
                    sat_evrakno = evrakno,
                    sat_aciklama = aciklama

                });

                int a = dataGridView2.Rows.Count;

                int b = a - 1;

                int deneme = 10;


                for (int i = 0; i < b; i++)
                { 
                    _satisDetayControl.Add(new SatisDetayType
                    {

                       sad_satisevrakno = evrakno,
                       sad_urunkodu = dataGridView2.Rows[i].Cells[0].Value.ToString(),
                       sad_miktar = Convert.ToSingle(dataGridView2.Rows[i].Cells[2].Value),
                       sad_fiyat = Convert.ToSingle(dataGridView2.Rows[i].Cells[3].Value),
                       sad_kdvorani = Convert.ToSingle(dataGridView2.Rows[i].Cells[4].Value),
                       sad_kdvtutari = Convert.ToSingle(deneme),
                       sad_geneltoplam = Convert.ToSingle(deneme),
                       sad_tutar = Convert.ToSingle(deneme),

                    });

                }


                MessageBox.Show("Succesful");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public static string kod;

        private void SiparisGrntlBtn_Click(object sender, EventArgs e)
        {
             kod = dataGridView1.Rows[0].Cells[0].Value.ToString();

            SatisDetayForm satisDetay = new SatisDetayForm();
            satisDetay.Show();
            

        }

        private void RaporSatisBtn_Click(object sender, EventArgs e)
        {
            RaporSatisForm raporSatisForm = new RaporSatisForm();
            raporSatisForm.Show();
        }
    }
}
