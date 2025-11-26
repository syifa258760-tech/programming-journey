namespace akhir_syifa_maulana_xpplg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HARGA SETIAP KAMAR
            if (cbjenis.SelectedItem.ToString() == "VIP") 
            {
                cbharga.Text = "Rp 500.000 / permalam";
            }
            else if (cbjenis.SelectedItem.ToString() == "KELAS 1")
            {
                cbharga.Text = "Rp 100.000 / permalam";
            }
            else if (cbjenis.SelectedItem.ToString() == "KELAS 2")
            {
                cbharga.Text = "Rp 250.000 / permalam";
            }
            else if (cbjenis.SelectedItem.ToString() == "KELAS 3")
            {
                cbharga.Text = "Rp 350.000 / permalam";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbiaya_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nama = txtnama.Text.ToString();
            string nomor = txtnomor.Text.ToString();
            string alamat = txtalamat.Text.ToString();
            string tanggal = dttanggal.Text.ToString();
            dataGridView1.Rows.Add(Nama, nomor, alamat, tanggal);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtalamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dttanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtnomor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbharga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}