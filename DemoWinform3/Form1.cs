namespace DemoWinform3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            label1.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            label1.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            label1.Text = txtHoLot.Text + " " + txtTen.Text;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
