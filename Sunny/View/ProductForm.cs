using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sunny.View
{
    public partial class ProductForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        public ProductForm()
        {
            InitializeComponent();
            btnAdd.FlatAppearance.BorderColor = Color.Gray;
            btnAdd.FlatAppearance.BorderSize = 1;
        }

        private void ProductForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.DrawRectangle(new Pen(Color.DarkRed, 1), rect);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.White;
            lblExit.BackColor = Color.Red;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Black;
            lblExit.BackColor = Color.LavenderBlush;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureEdit_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureEdit.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

    }

}
