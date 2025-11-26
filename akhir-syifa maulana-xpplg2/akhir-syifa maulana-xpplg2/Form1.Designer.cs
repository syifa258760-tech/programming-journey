namespace akhir_syifa_maulana_xpplg2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dttanggal = new System.Windows.Forms.DateTimePicker();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtnomor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbjenis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbharga = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dttanggal);
            this.groupBox1.Controls.Add(this.txtalamat);
            this.groupBox1.Controls.Add(this.txtnama);
            this.groupBox1.Controls.Add(this.txtnomor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA PEMESANAN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dttanggal
            // 
            this.dttanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttanggal.Location = new System.Drawing.Point(146, 195);
            this.dttanggal.Name = "dttanggal";
            this.dttanggal.Size = new System.Drawing.Size(95, 23);
            this.dttanggal.TabIndex = 7;
            this.dttanggal.ValueChanged += new System.EventHandler(this.dttanggal_ValueChanged);
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(146, 143);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtalamat.Size = new System.Drawing.Size(188, 42);
            this.txtalamat.TabIndex = 6;
            this.txtalamat.TextChanged += new System.EventHandler(this.txtalamat_TextChanged);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(146, 33);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(188, 23);
            this.txtnama.TabIndex = 5;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // txtnomor
            // 
            this.txtnomor.Location = new System.Drawing.Point(146, 82);
            this.txtnomor.Name = "txtnomor";
            this.txtnomor.Size = new System.Drawing.Size(188, 23);
            this.txtnomor.TabIndex = 4;
            this.txtnomor.TextChanged += new System.EventHandler(this.txtnomor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal booking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomor Telepon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama pemesan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbjenis);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbharga);
            this.groupBox2.Location = new System.Drawing.Point(405, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 141);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BOOKING PRIDE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbjenis
            // 
            this.cbjenis.FormattingEnabled = true;
            this.cbjenis.Items.AddRange(new object[] {
            "VIP",
            "KELAS 1",
            "KELAS 2",
            "KELAS 3"});
            this.cbjenis.Location = new System.Drawing.Point(163, 43);
            this.cbjenis.Name = "cbjenis";
            this.cbjenis.Size = new System.Drawing.Size(163, 23);
            this.cbjenis.TabIndex = 8;
            this.cbjenis.SelectedIndexChanged += new System.EventHandler(this.cbjenis_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "harga sewa perhari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "jenis kamar";
            // 
            // cbharga
            // 
            this.cbharga.Location = new System.Drawing.Point(163, 91);
            this.cbharga.Name = "cbharga";
            this.cbharga.Size = new System.Drawing.Size(163, 23);
            this.cbharga.TabIndex = 1;
            this.cbharga.TextChanged += new System.EventHandler(this.cbharga_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nm,
            this.Lm,
            this.alm,
            this.tb});
            this.dataGridView1.Location = new System.Drawing.Point(371, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(431, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // nm
            // 
            this.nm.HeaderText = "Nama Pemesan";
            this.nm.Name = "nm";
            this.nm.ReadOnly = true;
            // 
            // Lm
            // 
            this.Lm.HeaderText = "Nomor Telepon";
            this.Lm.Name = "Lm";
            this.Lm.ReadOnly = true;
            // 
            // alm
            // 
            this.alm.HeaderText = "Alamat";
            this.alm.Name = "alm";
            this.alm.ReadOnly = true;
            // 
            // tb
            // 
            this.tb.HeaderText = "Tanggal Booking";
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(35, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 148);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NAVIGASI";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "&RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "&PESAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "&CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "HOTEL WIJAYA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PEMESANAN HOTEL BINTANG 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtalamat;
        private TextBox txtnama;
        private TextBox txtnomor;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cbjenis;
        private Label label6;
        private Label label5;
        private TextBox cbharga;
        private GroupBox groupBox3;
        private Button button2;
        private Button button1;
        private Label label11;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dttanggal;
        private Button button3;
        private DataGridViewTextBoxColumn nm;
        private DataGridViewTextBoxColumn Lm;
        private DataGridViewTextBoxColumn alm;
        private DataGridViewTextBoxColumn tb;
    }
}