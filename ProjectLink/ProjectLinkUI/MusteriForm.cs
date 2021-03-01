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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        MusteriControl _musteriControl = new MusteriControl();


        private void MusteriForm_Load(object sender, EventArgs e)
        {
            MusteriList();
            MusAdres1Txt.MaxLength = 143;
            MusAdres2Txt.MaxLength = 143;
            MusAdres3Txt.MaxLength = 143;
        }

        private void MusteriEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MusIdTxt.Text == "" || MusAdTxt.Text == "" || MusAdres1Txt.Text == "" || MusAdres2Txt.Text == "" || MusAdres3Txt.Text == "" || MusTelTxt.Text == "" || MusMailTxt.Text == "")
                {
                    throw new Exception("Boş Geçilemez.");
                }

                _musteriControl.Add(new MusteriType
                {

                    mus_kod = MusIdTxt.Text,
                    mus_ad = MusAdTxt.Text,
                    mus_adres1 = MusAdres1Txt.Text,
                    mus_adres2 = MusAdres2Txt.Text,
                    mus_adres3 = MusAdres3Txt.Text,
                    mus_telefon = MusTelTxt.Text,
                    mus_email = MusMailTxt.Text


                });
                MusteriList();
                MessageBox.Show("İşlem Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void MusteriList()
        {

            List<MusteriType> musteri = new List<MusteriType>();

            musteri = _musteriControl.Select();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Adres1");
            dt.Columns.Add("Adres2");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("E Mail");

            foreach (var item in musteri)
            {
                DataRow drow = dt.NewRow();
                drow["ID"] = item.mus_kod;
                drow["Ad"] = item.mus_ad;
                drow["Adres"] = item.mus_adres1;
                drow["Adres1"] = item.mus_adres2;
                drow["Adres2"] = item.mus_adres3;
                drow["Telefon"] = item.mus_telefon;
                drow["E Mail"] = item.mus_email;

                dt.Rows.Add(drow);
            }



            dataGridView1.DataSource = dt;


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;

        }

        private void UrunGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MusIdTxt.Text == "" || MusAdTxt.Text == "" || MusAdres1Txt.Text == "" || MusAdres2Txt.Text == "" || MusAdres3Txt.Text == "" || MusTelTxt.Text == "" || MusMailTxt.Text == "")
                {
                    throw new Exception("Boş Geçilemez.");
                }

                _musteriControl.Update(new MusteriType
                {

                    mus_kod = MusIdTxt.Text,
                    mus_ad = MusAdTxt.Text,
                    mus_adres1 = MusAdres1Txt.Text,
                    mus_adres2 = MusAdres2Txt.Text,
                    mus_adres3 = MusAdres3Txt.Text,
                    mus_telefon = MusTelTxt.Text,
                    mus_email = MusMailTxt.Text


                });
                MusteriList();
                MessageBox.Show("İşlem Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MusIdTxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MusAdTxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            MusAdres1Txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            MusAdres2Txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            MusAdres3Txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            MusTelTxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            MusMailTxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

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


                        _musteriControl.Delete(new MusteriType
                        {
                            mus_kod = kod
                        });

                        MessageBox.Show("İşlem Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MusteriList();

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
    }
}
