
namespace ProjectLinkUI
{
    partial class UrunForm
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
            this.UrunEkleBtn = new System.Windows.Forms.Button();
            this.recno = new System.Windows.Forms.Label();
            this.UrunRecnoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrunAdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UrunFiyatTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UrunBrmTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UrunKdvTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrunGuncelleBtn = new System.Windows.Forms.Button();
            this.UrunSilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunEkleBtn
            // 
            this.UrunEkleBtn.Location = new System.Drawing.Point(354, 13);
            this.UrunEkleBtn.Name = "UrunEkleBtn";
            this.UrunEkleBtn.Size = new System.Drawing.Size(94, 36);
            this.UrunEkleBtn.TabIndex = 10;
            this.UrunEkleBtn.Text = "Ürün Ekle";
            this.UrunEkleBtn.UseVisualStyleBackColor = true;
            this.UrunEkleBtn.Click += new System.EventHandler(this.UrunEkleBtn_Click);
            // 
            // recno
            // 
            this.recno.AutoSize = true;
            this.recno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recno.Location = new System.Drawing.Point(21, 22);
            this.recno.Name = "recno";
            this.recno.Size = new System.Drawing.Size(66, 17);
            this.recno.TabIndex = 12;
            this.recno.Text = "Ürün Id:";
            // 
            // UrunRecnoTxt
            // 
            this.UrunRecnoTxt.Location = new System.Drawing.Point(119, 22);
            this.UrunRecnoTxt.Name = "UrunRecnoTxt";
            this.UrunRecnoTxt.Size = new System.Drawing.Size(184, 20);
            this.UrunRecnoTxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Ad:";
            // 
            // UrunAdTxt
            // 
            this.UrunAdTxt.Location = new System.Drawing.Point(119, 66);
            this.UrunAdTxt.Name = "UrunAdTxt";
            this.UrunAdTxt.Size = new System.Drawing.Size(184, 20);
            this.UrunAdTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ürün Fiyat:";
            // 
            // UrunFiyatTxt
            // 
            this.UrunFiyatTxt.Location = new System.Drawing.Point(119, 148);
            this.UrunFiyatTxt.Name = "UrunFiyatTxt";
            this.UrunFiyatTxt.Size = new System.Drawing.Size(184, 20);
            this.UrunFiyatTxt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ürün Birim:";
            // 
            // UrunBrmTxt
            // 
            this.UrunBrmTxt.Location = new System.Drawing.Point(119, 104);
            this.UrunBrmTxt.Name = "UrunBrmTxt";
            this.UrunBrmTxt.Size = new System.Drawing.Size(184, 20);
            this.UrunBrmTxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ürün Kdv:";
            // 
            // UrunKdvTxt
            // 
            this.UrunKdvTxt.Location = new System.Drawing.Point(119, 188);
            this.UrunKdvTxt.Name = "UrunKdvTxt";
            this.UrunKdvTxt.Size = new System.Drawing.Size(184, 20);
            this.UrunKdvTxt.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 228);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // UrunGuncelleBtn
            // 
            this.UrunGuncelleBtn.Location = new System.Drawing.Point(354, 66);
            this.UrunGuncelleBtn.Name = "UrunGuncelleBtn";
            this.UrunGuncelleBtn.Size = new System.Drawing.Size(94, 36);
            this.UrunGuncelleBtn.TabIndex = 22;
            this.UrunGuncelleBtn.Text = "Ürün Güncelle";
            this.UrunGuncelleBtn.UseVisualStyleBackColor = true;
            this.UrunGuncelleBtn.Click += new System.EventHandler(this.UrunGuncelleBtn_Click);
            // 
            // UrunSilBtn
            // 
            this.UrunSilBtn.Location = new System.Drawing.Point(354, 117);
            this.UrunSilBtn.Name = "UrunSilBtn";
            this.UrunSilBtn.Size = new System.Drawing.Size(94, 36);
            this.UrunSilBtn.TabIndex = 23;
            this.UrunSilBtn.Text = "Ürün Sil";
            this.UrunSilBtn.UseVisualStyleBackColor = true;
            this.UrunSilBtn.Click += new System.EventHandler(this.UrunSilBtn_Click);
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 472);
            this.Controls.Add(this.UrunSilBtn);
            this.Controls.Add(this.UrunGuncelleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UrunKdvTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UrunFiyatTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UrunBrmTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrunAdTxt);
            this.Controls.Add(this.recno);
            this.Controls.Add(this.UrunRecnoTxt);
            this.Controls.Add(this.UrunEkleBtn);
            this.Name = "UrunForm";
            this.Text = "UrunForm";
            this.Load += new System.EventHandler(this.UrunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UrunEkleBtn;
        private System.Windows.Forms.Label recno;
        private System.Windows.Forms.TextBox UrunRecnoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrunAdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UrunFiyatTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UrunBrmTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UrunKdvTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UrunGuncelleBtn;
        private System.Windows.Forms.Button UrunSilBtn;
    }
}