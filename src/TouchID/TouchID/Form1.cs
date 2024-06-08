namespace TouchID
{
    public partial class Form1 : Form
    {
        private bool sudahInput;
        public Form1()
        {
            InitializeComponent();
            pictureBox_input.Image = Properties.Resources.default_pictureBox_input;
            sudahInput = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void button_pilih_citra_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_input.Image = new Bitmap(open.FileName);
                    sudahInput = true;
                }
                else
                {
                    MessageBox.Show("Tipe file masukan tidak valid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuka file: " + ex.Message);
            }
        }

        private void comboBox_algoritma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_cari_Click(object sender, EventArgs e)
        {
            string pilihanAlgoritma;
            if (!sudahInput)
            {
                MessageBox.Show("Silahkan masukkan sidik jari terlebih dahulu.");
            }
            else if (comboBox_algoritma.SelectedItem == null)
            {
                MessageBox.Show("Pilih algoritma terlebih dahulu");
            }
            else
            {
                pilihanAlgoritma = comboBox_algoritma.SelectedItem.ToString();
                if (pilihanAlgoritma == "KMP")
                {
                    MessageBox.Show("KMP dipilih");
                    /*Ini nanti diganti algoritma KMP*/
                }
                else if (pilihanAlgoritma == "BM")
                {
                    MessageBox.Show("BM dipilih");
                    /*Ini nanti diganti algoritma BM*/
                }
            }
        }
    }
}
