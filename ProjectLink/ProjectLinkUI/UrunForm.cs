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
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        UrunControl _urunControl = new UrunControl();


        private void UrunEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UrunRecnoTxt.Text == "" || UrunAdTxt.Text == "" || UrunBrmTxt.Text == "" || UrunFiyatTxt.Text == "" || UrunKdvTxt.Text == "")
                {
                    throw new Exception("Boş Geçilemez.");
                }

                _urunControl.Add(new UrunType
                {

                    uru_kod = UrunRecnoTxt.Text,
                    uru_ad = UrunAdTxt.Text,
                    uru_birim = UrunBrmTxt.Text,
                    uru_fiyat = Convert.ToSingle(UrunFiyatTxt.Text),
                    uru_kdvorani = Convert.ToSingle(UrunKdvTxt.Text)


                });
                MessageBox.Show("İşlem Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
         
            UrunList();
        }


        private void UrunList()
        {

            List<UrunType> urun = new List<UrunType>();

            urun = _urunControl.Select();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ürün Ad");
            dt.Columns.Add("Ürün Adet");
            dt.Columns.Add("Ürün Fiyat");
            dt.Columns.Add("Kdv Oranı");



            foreach (var item in urun)
            {
                DataRow drow = dt.NewRow();
                drow["ID"] = item.uru_kod;
                drow["Ürün Ad"] = item.uru_ad;
                drow["Ürün Adet"] = item.uru_birim;
                drow["Ürün Fiyat"] = item.uru_fiyat;
                drow["Kdv Oranı"] = item.uru_kdvorani;

                dt.Rows.Add(drow);
            }



            dataGridView1.DataSource = dt;


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false; 

        }

        private void UrunSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    if (Convert.ToInt32(dataGridView1.CurrentRow.Selected) > 0)
                    {
                        string kod = dataGridView1.CurrentRow.Cells[0].Value.ToString();


                        _urunControl.Delete(new UrunType
                        {

                            uru_kod = kod

                        });

                        MessageBox.Show("İşlem Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UrunList();
                       
                    }
                    else
                    {
                        throw new Exception("Seçim Yapınız");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            UrunRecnoTxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            UrunAdTxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            UrunBrmTxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            UrunFiyatTxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            UrunKdvTxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void UrunGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UrunRecnoTxt.Text == "" || UrunAdTxt.Text == "" || UrunBrmTxt.Text == "" || UrunFiyatTxt.Text == "" || UrunKdvTxt.Text == "")
                {
                    throw new Exception("Boş Geçilemez.");
                }

                _urunControl.Update(new UrunType
                {

                    uru_kod = UrunRecnoTxt.Text,
                    uru_ad = UrunAdTxt.Text,
                    uru_birim = UrunBrmTxt.Text,
                    uru_fiyat = Convert.ToSingle(UrunFiyatTxt.Text),
                    uru_kdvorani = Convert.ToSingle(UrunKdvTxt.Text)


                });
                MessageBox.Show("İşlem Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
