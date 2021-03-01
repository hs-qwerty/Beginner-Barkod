
namespace ProjectLinkUI
{
    partial class MusteriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UrunSilBtn = new System.Windows.Forms.Button();
            this.UrunGuncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MusAdres1Lbl = new System.Windows.Forms.Label();
            this.MusAdres1Txt = new System.Windows.Forms.TextBox();
            this.MusAdLbl = new System.Windows.Forms.Label();
            this.MusAdTxt = new System.Windows.Forms.TextBox();
            this.MusIdLbl = new System.Windows.Forms.Label();
            this.MusIdTxt = new System.Windows.Forms.TextBox();
            this.MusteriEkleBtn = new System.Windows.Forms.Button();
            this.MusAdres2Lbl = new System.Windows.Forms.Label();
            this.MusAdres2Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MusAdres3Txt = new System.Windows.Forms.TextBox();
            this.MusMailLbl = new System.Windows.Forms.Label();
            this.MusMailTxt = new System.Windows.Forms.TextBox();
            this.MusTelLbl = new System.Windows.Forms.Label();
            this.MusTelTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunSilBtn
            // 
            this.UrunSilBtn.Location = new System.Drawing.Point(858, 116);
            this.UrunSilBtn.Name = "UrunSilBtn";
            this.UrunSilBtn.Size = new System.Drawing.Size(94, 36);
            this.UrunSilBtn.TabIndex = 37;
            this.UrunSilBtn.Text = "Müşteri Sil";
            this.UrunSilBtn.UseVisualStyleBackColor = true;
            this.UrunSilBtn.Click += new System.EventHandler(this.UrunSilBtn_Click);
            // 
            // UrunGuncelleBtn
            // 
            this.UrunGuncelleBtn.Location = new System.Drawing.Point(858, 65);
            this.UrunGuncelleBtn.Name = "UrunGuncelleBtn";
            this.UrunGuncelleBtn.Size = new System.Drawing.Size(94, 36);
            this.UrunGuncelleBtn.TabIndex = 36;
            this.UrunGuncelleBtn.Text = "Müşteri Güncelle";
            this.UrunGuncelleBtn.UseVisualStyleBackColor = true;
            this.UrunGuncelleBtn.Click += new System.EventHandler(this.UrunGuncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 228);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // MusAdres1Lbl
            // 
            this.MusAdres1Lbl.AutoSize = true;
            this.MusAdres1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusAdres1Lbl.Location = new System.Drawing.Point(360, 14);
            this.MusAdres1Lbl.Name = "MusAdres1Lbl";
            this.MusAdres1Lbl.Size = new System.Drawing.Size(113, 17);
            this.MusAdres1Lbl.TabIndex = 30;
            this.MusAdres1Lbl.Text = "Müşteri Adres:";
            // 
            // MusAdres1Txt
            // 
            this.MusAdres1Txt.Location = new System.Drawing.Point(494, 14);
            this.MusAdres1Txt.Multiline = true;
            this.MusAdres1Txt.Name = "MusAdres1Txt";
            this.MusAdres1Txt.Size = new System.Drawing.Size(312, 73);
            this.MusAdres1Txt.TabIndex = 29;
            // 
            // MusAdLbl
            // 
            this.MusAdLbl.AutoSize = true;
            this.MusAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusAdLbl.Location = new System.Drawing.Point(18, 55);
            this.MusAdLbl.Name = "MusAdLbl";
            this.MusAdLbl.Size = new System.Drawing.Size(90, 17);
            this.MusAdLbl.TabIndex = 28;
            this.MusAdLbl.Text = "Müşteri Ad:";
            // 
            // MusAdTxt
            // 
            this.MusAdTxt.Location = new System.Drawing.Point(116, 55);
            this.MusAdTxt.Name = "MusAdTxt";
            this.MusAdTxt.Size = new System.Drawing.Size(184, 20);
            this.MusAdTxt.TabIndex = 27;
            // 
            // MusIdLbl
            // 
            this.MusIdLbl.AutoSize = true;
            this.MusIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusIdLbl.Location = new System.Drawing.Point(18, 11);
            this.MusIdLbl.Name = "MusIdLbl";
            this.MusIdLbl.Size = new System.Drawing.Size(84, 17);
            this.MusIdLbl.TabIndex = 26;
            this.MusIdLbl.Text = "Müşteri Id:";
            // 
            // MusIdTxt
            // 
            this.MusIdTxt.Location = new System.Drawing.Point(116, 11);
            this.MusIdTxt.Name = "MusIdTxt";
            this.MusIdTxt.Size = new System.Drawing.Size(184, 20);
            this.MusIdTxt.TabIndex = 25;
            // 
            // MusteriEkleBtn
            // 
            this.MusteriEkleBtn.Location = new System.Drawing.Point(858, 12);
            this.MusteriEkleBtn.Name = "MusteriEkleBtn";
            this.MusteriEkleBtn.Size = new System.Drawing.Size(94, 36);
            this.MusteriEkleBtn.TabIndex = 24;
            this.MusteriEkleBtn.Text = "Müşteri Ekle";
            this.MusteriEkleBtn.UseVisualStyleBackColor = true;
            this.MusteriEkleBtn.Click += new System.EventHandler(this.MusteriEkleBtn_Click);
            // 
            // MusAdres2Lbl
            // 
            this.MusAdres2Lbl.AutoSize = true;
            this.MusAdres2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusAdres2Lbl.Location = new System.Drawing.Point(360, 93);
            this.MusAdres2Lbl.Name = "MusAdres2Lbl";
            this.MusAdres2Lbl.Size = new System.Drawing.Size(113, 17);
            this.MusAdres2Lbl.TabIndex = 39;
            this.MusAdres2Lbl.Text = "Müşteri Adres:";
            // 
            // MusAdres2Txt
            // 
            this.MusAdres2Txt.Location = new System.Drawing.Point(494, 93);
            this.MusAdres2Txt.Multiline = true;
            this.MusAdres2Txt.Name = "MusAdres2Txt";
            this.MusAdres2Txt.Size = new System.Drawing.Size(312, 73);
            this.MusAdres2Txt.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(360, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Müşteri Adres:";
            // 
            // MusAdres3Txt
            // 
            this.MusAdres3Txt.Location = new System.Drawing.Point(494, 171);
            this.MusAdres3Txt.Multiline = true;
            this.MusAdres3Txt.Name = "MusAdres3Txt";
            this.MusAdres3Txt.Size = new System.Drawing.Size(312, 73);
            this.MusAdres3Txt.TabIndex = 40;
            // 
            // MusMailLbl
            // 
            this.MusMailLbl.AutoSize = true;
            this.MusMailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusMailLbl.Location = new System.Drawing.Point(18, 137);
            this.MusMailLbl.Name = "MusMailLbl";
            this.MusMailLbl.Size = new System.Drawing.Size(89, 17);
            this.MusMailLbl.TabIndex = 45;
            this.MusMailLbl.Text = "Mail Adres:";
            // 
            // MusMailTxt
            // 
            this.MusMailTxt.Location = new System.Drawing.Point(116, 137);
            this.MusMailTxt.Name = "MusMailTxt";
            this.MusMailTxt.Size = new System.Drawing.Size(184, 20);
            this.MusMailTxt.TabIndex = 44;
            // 
            // MusTelLbl
            // 
            this.MusTelLbl.AutoSize = true;
            this.MusTelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusTelLbl.Location = new System.Drawing.Point(18, 93);
            this.MusTelLbl.Name = "MusTelLbl";
            this.MusTelLbl.Size = new System.Drawing.Size(68, 17);
            this.MusTelLbl.TabIndex = 43;
            this.MusTelLbl.Text = "Telefon:";
            // 
            // MusTelTxt
            // 
            this.MusTelTxt.Location = new System.Drawing.Point(116, 93);
            this.MusTelTxt.Name = "MusTelTxt";
            this.MusTelTxt.Size = new System.Drawing.Size(184, 20);
            this.MusTelTxt.TabIndex = 42;
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 509);
            this.Controls.Add(this.MusMailLbl);
            this.Controls.Add(this.MusMailTxt);
            this.Controls.Add(this.MusTelLbl);
            this.Controls.Add(this.MusTelTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MusAdres3Txt);
            this.Controls.Add(this.MusAdres2Lbl);
            this.Controls.Add(this.MusAdres2Txt);
            this.Controls.Add(this.UrunSilBtn);
            this.Controls.Add(this.UrunGuncelleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MusAdres1Lbl);
            this.Controls.Add(this.MusAdres1Txt);
            this.Controls.Add(this.MusAdLbl);
            this.Controls.Add(this.MusAdTxt);
            this.Controls.Add(this.MusIdLbl);
            this.Controls.Add(this.MusIdTxt);
            this.Controls.Add(this.MusteriEkleBtn);
            this.Name = "MusteriForm";
            this.Text = "MusteriForm";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UrunSilBtn;
        private System.Windows.Forms.Button UrunGuncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label MusAdres1Lbl;
        private System.Windows.Forms.TextBox MusAdres1Txt;
        private System.Windows.Forms.Label MusAdLbl;
        private System.Windows.Forms.TextBox MusAdTxt;
        private System.Windows.Forms.Label MusIdLbl;
        private System.Windows.Forms.TextBox MusIdTxt;
        private System.Windows.Forms.Button MusteriEkleBtn;
        private System.Windows.Forms.Label MusAdres2Lbl;
        private System.Windows.Forms.TextBox MusAdres2Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MusAdres3Txt;
        private System.Windows.Forms.Label MusMailLbl;
        private System.Windows.Forms.TextBox MusMailTxt;
        private System.Windows.Forms.Label MusTelLbl;
        private System.Windows.Forms.TextBox MusTelTxt;
    }
}