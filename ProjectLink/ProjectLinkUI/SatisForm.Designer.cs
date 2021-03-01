
namespace ProjectLinkUI
{
    partial class SatisForm
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
            this.MusListBtn = new System.Windows.Forms.Button();
            this.UrunListBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MusteriAraTxt = new System.Windows.Forms.TextBox();
            this.MusteriAraBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UrunAraTxt = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MusteriSiparisEkle = new System.Windows.Forms.Button();
            this.UrunSiparisEkle = new System.Windows.Forms.Button();
            this.UrnFiyatTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MusAdRadioBtn = new System.Windows.Forms.RadioButton();
            this.MusKodRadioBtn = new System.Windows.Forms.RadioButton();
            this.UrnKodRadioBtn = new System.Windows.Forms.RadioButton();
            this.UrnAdRadioBtn = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisEkleBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SiparisGrntlBtn = new System.Windows.Forms.Button();
            this.RaporSatisBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // MusListBtn
            // 
            this.MusListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusListBtn.Location = new System.Drawing.Point(1046, 13);
            this.MusListBtn.Name = "MusListBtn";
            this.MusListBtn.Size = new System.Drawing.Size(141, 33);
            this.MusListBtn.TabIndex = 0;
            this.MusListBtn.Text = "Müsteri İşlemleri";
            this.MusListBtn.UseVisualStyleBackColor = true;
            this.MusListBtn.Click += new System.EventHandler(this.MusListBtn_Click);
            // 
            // UrunListBtn
            // 
            this.UrunListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunListBtn.Location = new System.Drawing.Point(1046, 52);
            this.UrunListBtn.Name = "UrunListBtn";
            this.UrunListBtn.Size = new System.Drawing.Size(141, 33);
            this.UrunListBtn.TabIndex = 1;
            this.UrunListBtn.Text = "Ürün İşlemleri";
            this.UrunListBtn.UseVisualStyleBackColor = true;
            this.UrunListBtn.Click += new System.EventHandler(this.UrunListBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Seç";
            // 
            // MusteriAraTxt
            // 
            this.MusteriAraTxt.Location = new System.Drawing.Point(16, 67);
            this.MusteriAraTxt.Multiline = true;
            this.MusteriAraTxt.Name = "MusteriAraTxt";
            this.MusteriAraTxt.Size = new System.Drawing.Size(144, 27);
            this.MusteriAraTxt.TabIndex = 7;
            // 
            // MusteriAraBtn
            // 
            this.MusteriAraBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAraBtn.Location = new System.Drawing.Point(193, 67);
            this.MusteriAraBtn.Name = "MusteriAraBtn";
            this.MusteriAraBtn.Size = new System.Drawing.Size(141, 27);
            this.MusteriAraBtn.TabIndex = 8;
            this.MusteriAraBtn.Text = "Müsteri Ara";
            this.MusteriAraBtn.UseVisualStyleBackColor = true;
            this.MusteriAraBtn.Click += new System.EventHandler(this.MusteriAraBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(775, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ürün Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrunAraTxt
            // 
            this.UrunAraTxt.Location = new System.Drawing.Point(598, 63);
            this.UrunAraTxt.Multiline = true;
            this.UrunAraTxt.Name = "UrunAraTxt";
            this.UrunAraTxt.Size = new System.Drawing.Size(144, 27);
            this.UrunAraTxt.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(598, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(340, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(710, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Seç";
            // 
            // MusteriSiparisEkle
            // 
            this.MusteriSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriSiparisEkle.Location = new System.Drawing.Point(215, 193);
            this.MusteriSiparisEkle.Name = "MusteriSiparisEkle";
            this.MusteriSiparisEkle.Size = new System.Drawing.Size(141, 27);
            this.MusteriSiparisEkle.TabIndex = 13;
            this.MusteriSiparisEkle.Text = "Müsteri Ekle";
            this.MusteriSiparisEkle.UseVisualStyleBackColor = true;
            this.MusteriSiparisEkle.Click += new System.EventHandler(this.MusteriSiparisEkle_Click);
            // 
            // UrunSiparisEkle
            // 
            this.UrunSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunSiparisEkle.Location = new System.Drawing.Point(797, 227);
            this.UrunSiparisEkle.Name = "UrunSiparisEkle";
            this.UrunSiparisEkle.Size = new System.Drawing.Size(141, 27);
            this.UrunSiparisEkle.TabIndex = 15;
            this.UrunSiparisEkle.Text = "Ürün Ekle";
            this.UrunSiparisEkle.UseVisualStyleBackColor = true;
            this.UrunSiparisEkle.Click += new System.EventHandler(this.UrunSiparisEkle_Click);
            // 
            // UrnFiyatTxt
            // 
            this.UrnFiyatTxt.Location = new System.Drawing.Point(681, 185);
            this.UrnFiyatTxt.Multiline = true;
            this.UrnFiyatTxt.Name = "UrnFiyatTxt";
            this.UrnFiyatTxt.Size = new System.Drawing.Size(144, 27);
            this.UrnFiyatTxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(595, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ürün Fiyat";
            // 
            // MusAdRadioBtn
            // 
            this.MusAdRadioBtn.AutoSize = true;
            this.MusAdRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusAdRadioBtn.Location = new System.Drawing.Point(210, 112);
            this.MusAdRadioBtn.Name = "MusAdRadioBtn";
            this.MusAdRadioBtn.Size = new System.Drawing.Size(134, 21);
            this.MusAdRadioBtn.TabIndex = 17;
            this.MusAdRadioBtn.TabStop = true;
            this.MusAdRadioBtn.Text = "Müşteri İsmi İle";
            this.MusAdRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MusKodRadioBtn
            // 
            this.MusKodRadioBtn.AutoSize = true;
            this.MusKodRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusKodRadioBtn.Location = new System.Drawing.Point(26, 112);
            this.MusKodRadioBtn.Name = "MusKodRadioBtn";
            this.MusKodRadioBtn.Size = new System.Drawing.Size(134, 21);
            this.MusKodRadioBtn.TabIndex = 18;
            this.MusKodRadioBtn.TabStop = true;
            this.MusKodRadioBtn.Text = "Müşteri Kod ile";
            this.MusKodRadioBtn.UseVisualStyleBackColor = true;
            // 
            // UrnKodRadioBtn
            // 
            this.UrnKodRadioBtn.AutoSize = true;
            this.UrnKodRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrnKodRadioBtn.Location = new System.Drawing.Point(598, 104);
            this.UrnKodRadioBtn.Name = "UrnKodRadioBtn";
            this.UrnKodRadioBtn.Size = new System.Drawing.Size(116, 21);
            this.UrnKodRadioBtn.TabIndex = 19;
            this.UrnKodRadioBtn.TabStop = true;
            this.UrnKodRadioBtn.Text = "Ürün Kod ile";
            this.UrnKodRadioBtn.UseVisualStyleBackColor = true;
            // 
            // UrnAdRadioBtn
            // 
            this.UrnAdRadioBtn.AutoSize = true;
            this.UrnAdRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrnAdRadioBtn.Location = new System.Drawing.Point(775, 104);
            this.UrnAdRadioBtn.Name = "UrnAdRadioBtn";
            this.UrnAdRadioBtn.Size = new System.Drawing.Size(116, 21);
            this.UrnAdRadioBtn.TabIndex = 20;
            this.UrnAdRadioBtn.TabStop = true;
            this.UrnAdRadioBtn.Text = "Ürün İsim ile";
            this.UrnAdRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 263);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(562, 270);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(554, 263);
            this.dataGridView2.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Ad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adet";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fiyat";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "KDV";
            this.Column5.Name = "Column5";
            // 
            // SiparisEkleBtn
            // 
            this.SiparisEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparisEkleBtn.Location = new System.Drawing.Point(1122, 280);
            this.SiparisEkleBtn.Name = "SiparisEkleBtn";
            this.SiparisEkleBtn.Size = new System.Drawing.Size(117, 50);
            this.SiparisEkleBtn.TabIndex = 23;
            this.SiparisEkleBtn.Text = "Sipariş Ekle";
            this.SiparisEkleBtn.UseVisualStyleBackColor = true;
            this.SiparisEkleBtn.Click += new System.EventHandler(this.SiparisEkleBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(944, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 27);
            this.button3.TabIndex = 24;
            this.button3.Text = "Ürün Çıkar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SiparisGrntlBtn
            // 
            this.SiparisGrntlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparisGrntlBtn.Location = new System.Drawing.Point(1122, 336);
            this.SiparisGrntlBtn.Name = "SiparisGrntlBtn";
            this.SiparisGrntlBtn.Size = new System.Drawing.Size(117, 50);
            this.SiparisGrntlBtn.TabIndex = 25;
            this.SiparisGrntlBtn.Text = "Sipariş Görüntüle";
            this.SiparisGrntlBtn.UseVisualStyleBackColor = true;
            this.SiparisGrntlBtn.Click += new System.EventHandler(this.SiparisGrntlBtn_Click);
            // 
            // RaporSatisBtn
            // 
            this.RaporSatisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RaporSatisBtn.Location = new System.Drawing.Point(1122, 392);
            this.RaporSatisBtn.Name = "RaporSatisBtn";
            this.RaporSatisBtn.Size = new System.Drawing.Size(117, 50);
            this.RaporSatisBtn.TabIndex = 26;
            this.RaporSatisBtn.Text = "Satış Görüntüle";
            this.RaporSatisBtn.UseVisualStyleBackColor = true;
            this.RaporSatisBtn.Click += new System.EventHandler(this.RaporSatisBtn_Click);
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 551);
            this.Controls.Add(this.RaporSatisBtn);
            this.Controls.Add(this.SiparisGrntlBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SiparisEkleBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UrnAdRadioBtn);
            this.Controls.Add(this.UrnKodRadioBtn);
            this.Controls.Add(this.MusKodRadioBtn);
            this.Controls.Add(this.MusAdRadioBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UrunSiparisEkle);
            this.Controls.Add(this.UrnFiyatTxt);
            this.Controls.Add(this.MusteriSiparisEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UrunAraTxt);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.MusteriAraBtn);
            this.Controls.Add(this.MusteriAraTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.UrunListBtn);
            this.Controls.Add(this.MusListBtn);
            this.Name = "SatisForm";
            this.Text = "SatisForm";
            this.Load += new System.EventHandler(this.SatisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MusListBtn;
        private System.Windows.Forms.Button UrunListBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MusteriAraTxt;
        private System.Windows.Forms.Button MusteriAraBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UrunAraTxt;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MusteriSiparisEkle;
        private System.Windows.Forms.Button UrunSiparisEkle;
        private System.Windows.Forms.TextBox UrnFiyatTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton MusAdRadioBtn;
        private System.Windows.Forms.RadioButton MusKodRadioBtn;
        private System.Windows.Forms.RadioButton UrnKodRadioBtn;
        private System.Windows.Forms.RadioButton UrnAdRadioBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button SiparisEkleBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SiparisGrntlBtn;
        private System.Windows.Forms.Button RaporSatisBtn;
    }
}