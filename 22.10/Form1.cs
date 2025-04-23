namespace _22._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data1 = dateTimePicker1.Value;
            DateTime data2 = dateTimePicker2.Value;
            TimeSpan differenza = data1 - data2;

            int secondiTotali = (int)differenza.TotalSeconds;

            int ore = secondiTotali / 3600;
            int minuti = (secondiTotali % 3600) / 60;
            int secondi = secondiTotali % 60;
            label1.Text = secondi.ToString();
            label2.Text = minuti.ToString();
            label3.Text = ore.ToString();
        }
    }
}
