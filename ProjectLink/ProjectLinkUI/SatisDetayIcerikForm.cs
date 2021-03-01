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
    public partial class SatisDetayIcerikForm : Form
    {

        SatisDetayControl _satisDetayControl = new SatisDetayControl();
        public SatisDetayIcerikForm()
        {
            InitializeComponent();

        }

        private void SatisDetayIcerikForm_Load(object sender, EventArgs e)
        {
            DetayList();
        }


        private void DetayList()
        {

            List<SatisDetayType> satisdetay = new List<SatisDetayType>();

            satisdetay = _satisDetayControl.Get2(SatisForm.kod);

            label2.Text = satisdetay.Count.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("Evran No");
            dt.Columns.Add("Ürün No");
            dt.Columns.Add("Miktar");
            dt.Columns.Add("Fiyat");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Kdv Oranı");
            dt.Columns.Add("Kdv Tutarı");
            dt.Columns.Add("Genel Toplam");


            
            foreach (var item in satisdetay)
            {
                DataRow drow = dt.NewRow();
                drow["Evran No"] = item.sad_satisevrakno;
                drow["Ürün No"] = item.sad_urunkodu;
                drow["Miktar"] = item.sad_miktar;
                drow["Fiyat"] = item.sad_fiyat;
                drow["Tutar"] = item.sad_tutar;
                drow["Kdv Oranı"] = item.sad_kdvorani;
                drow["Kdv Tutarı"] = item.sad_kdvtutari;
                drow["Genel Toplam"] = item.sad_geneltoplam;


                dt.Rows.Add(drow);
            }



            dataGridView1.DataSource = dt;


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;

        }
    }
}
