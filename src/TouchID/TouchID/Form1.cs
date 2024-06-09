using System.Drawing;
using TouchID.Backend;
namespace TouchID
{
    public partial class Form1 : Form
    {
        private bool sudahInput;
        private string imagePath;
        public Form1()
        {
            InitializeComponent();
            pictureBox_input.Image = Properties.Resources.default_pictureBox_input;
            pictureBox_result.Image = Properties.Resources.default_pictureBox_input;
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
                open.Filter = "Image Files (*.bmp; *.jpg; *.jpeg; *.png)|*.bmp; *.jpg; *.jpeg; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_input.Image = new Bitmap(open.FileName);
                    imagePath = open.FileName;
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
            string pilihanAlgoritma, kemiripan;
            int value;
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
                pictureBox_result.Image = new Bitmap(imagePath);
                pilihanAlgoritma = comboBox_algoritma.SelectedItem.ToString();
                string pattern = ImageToASCII.binaryToASCII(ImageToASCII.bitmapToBinary(imagePath));
                string text = ImageToASCII.binaryToASCII(ImageToASCII.bitmapToBinary(imagePath));
                kemiripan = StringCompare.tingkatKemiripan(pattern, text);
                if (pilihanAlgoritma == "KMP")
                {
                    value = BM.bmFunction(pattern, text);
                    MessageBox.Show("KMP Value: " + value + " Kemiripan: " + kemiripan);
                    /*Ini nanti diganti algoritma KMP*/
                }
                else if (pilihanAlgoritma == "BM")
                {
                    value = BM.bmFunction(pattern, text);
                    MessageBox.Show("BM value: " + value + " Kemiripan: " + kemiripan);
                    /*Ini nanti diganti algoritma BM*/
                }
            }
        }
    }
}
