namespace yagmur
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblilcesi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtilce = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnduzelt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // lblilcesi
            // 
            this.lblilcesi.AutoSize = true;
            this.lblilcesi.Location = new System.Drawing.Point(43, 69);
            this.lblilcesi.Name = "lblilcesi";
            this.lblilcesi.Size = new System.Drawing.Size(31, 13);
            this.lblilcesi.TabIndex = 1;
            this.lblilcesi.Text = "İlçesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cep Numarası";
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(139, 23);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(145, 20);
            this.txtadi.TabIndex = 3;
            // 
            // txtilce
            // 
            this.txtilce.Location = new System.Drawing.Point(139, 61);
            this.txtilce.Name = "txtilce";
            this.txtilce.Size = new System.Drawing.Size(145, 20);
            this.txtilce.TabIndex = 4;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(139, 109);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(145, 20);
            this.txtcep.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(139, 157);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnduzelt
            // 
            this.btnduzelt.Location = new System.Drawing.Point(240, 157);
            this.btnduzelt.Name = "btnduzelt";
            this.btnduzelt.Size = new System.Drawing.Size(75, 23);
            this.btnduzelt.TabIndex = 6;
            this.btnduzelt.Text = "Düzeltme";
            this.btnduzelt.UseVisualStyleBackColor = true;
            this.btnduzelt.Click += new System.EventHandler(this.btnduzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(346, 157);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Silme";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(440, 157);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 6;
            this.btnara.Text = "Arama";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 179);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(317, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 20);
            this.txtId.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnduzelt);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtilce);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblilcesi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblilcesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtilce;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnduzelt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
    }
}

