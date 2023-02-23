namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = new DateTime(1950, 12, 31);
            dateTimePicker1.MaxDate = DateTime.Today;
        }
    }
}