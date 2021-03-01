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


using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

using wordaktar = Microsoft.Office.Interop.Word;
using System.Reflection;


//Klasör İşlemleri
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;

namespace ProjectLinkUI
{
    public partial class RaporSatisForm : Form
    {
        public RaporSatisForm()
        {
            InitializeComponent();
        }

        SatisControl _satisControl = new SatisControl();

        private void RaporSatisForm_Load(object sender, EventArgs e)
        {
            SatisControl();
        }

        private void SatisControl()
        {

            List<SatisType> satislar = new List<SatisType>();

            satislar = _satisControl.Get3();


            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Müşteri No");
            dt.Columns.Add("Evrak No");
            dt.Columns.Add("Zaman");
            dt.Columns.Add("Açıklama");
 ;

            foreach (var item in satislar)
            {
                DataRow drow = dt.NewRow();
                drow["Müşteri No"] = item.sat_musterikodu;
                drow["Evrak No"] = item.sat_evrakno;
                drow["Zaman"] = item.sat_evraktarihi;
                drow["Açıklama"] = item.sat_aciklama;


                dt.Rows.Add(drow);
            }



            dataGridView1.DataSource = dt;
        }

        DataTableCollection tableCollection;

        private void button1_Click(object sender, EventArgs e)
        {
            int sutun = 1;
            int satir = 1;
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;
            ExcelApp.Worksheets[1].Activate();

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                ExcelApp.Cells[satir, sutun + j].Value = dataGridView1.Columns[j].HeaderText;
                ExcelApp.Cells[satir, sutun + j].Font.Color = System.Drawing.Color.Black;
                ExcelApp.Cells[satir, sutun + j].Font.Size = 10;
                ExcelApp.Cells[satir, sutun + j].ColumnWidth = 18;
                ExcelApp.Cells[satir, sutun + j].Font.Bold = true;
                ExcelApp.Cells[satir, sutun + j].Font.Name = "Arial Black";
            }
            satir++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    ExcelApp.Cells[satir + i, sutun + j].Value = dataGridView1[j, i].Value;
                  
                }

            }
        }
    }
}
