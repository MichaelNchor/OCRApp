using IronOcr;

namespace OCRApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IronTesseract iron_ocr = new IronTesseract();
            var img = "C:\\Users\\UITS-PC\\Desktop\\whats-important-to-you-img-min.jpg";
            var result = iron_ocr.Read(img);
            richTextBox1.Text = result.Text;
            pictureBox1.Image = new Bitmap(img);
        }
    }
}