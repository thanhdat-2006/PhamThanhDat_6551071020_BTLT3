using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                txtNhapTen.ForeColor = Color.Red;
                lblLapTrinh.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                txtNhapTen.ForeColor = Color.Green;
                lblLapTrinh.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                txtNhapTen.ForeColor = Color.Blue;
                lblLapTrinh.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                txtNhapTen.ForeColor = Color.Black;
                lblLapTrinh.ForeColor = Color.Black;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Bold
            );
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Italic
            );
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Underline
            );
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}