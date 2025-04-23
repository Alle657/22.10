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

            DateTime data1 = dateTimePicker1.Value.Date;
            DateTime data2 = dateTimePicker2.Value.Date;

            int giorniDifferenza = (data1 - data2).Days;
            label1.Text = giorniDifferenza.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dataIniziale = dateTimePicker3.Value;
            int giorni;

            if (int.TryParse(textBox1.Text, out giorni))
            {
                DateTime nuovaData = dataIniziale.AddDays(giorni);
                label5.Text = $"Nuova data: {nuovaData.ToShortDateString()}";
            }
            else
            {
                label5.Text = "Inserisci un numero valido!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dataIniziale = dateTimePicker3.Value;
            int giorni;

            if (int.TryParse(textBox1.Text, out giorni))
            {
                DateTime nuovaData = dataIniziale.AddDays(-giorni);
                label5.Text = $"Nuova data: {nuovaData.ToShortDateString()}";
            }
            else
            {
                label5.Text = "Inserisci un numero valido!";
            }
        }
    }
}
