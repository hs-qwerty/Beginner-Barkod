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
    public partial class SatisDetayForm : Form
    {
        public SatisDetayForm()
        {
            InitializeComponent();
        }

        SatisControl _satisControl = new SatisControl();

        private void SatisDetayForm_Load(object sender, EventArgs e)
        {
            label2.Text = SatisForm.kod;
            DetayList();

           
        }



        private void DetayList()
        {

            List<SatisType> satis = new List<SatisType>();

            satis = _satisControl.Get2(SatisForm.kod);

            label2.Text =  satis.Count.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ürün Ad");
            dt.Columns.Add("Ürün Adet");
            dt.Columns.Add("Ürün Fiyat");
            dt.Columns.Add("Kdv Oranı");



            foreach (var item in satis)
            {
                DataRow drow = dt.NewRow();
                drow["ID"] = item.sat_musterikodu;
                drow["Ürün Ad"] = item.sat_evrakno;
                drow["Ürün Adet"] = item.sat_evraktarihi;
                drow["Ürün Fiyat"] = item.sat_aciklama;

                dt.Rows.Add(drow);
            }



            dataGridView1.DataSource = dt;


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
           
        }

        public static string detay;
        private void SiparisDtyGrntleBtn_Click(object sender, EventArgs e)
        {
             detay =  dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            SatisDetayIcerikForm satisDetayIcerikForm = new SatisDetayIcerikForm();
            satisDetayIcerikForm.Show();
            
        }
    }
}
