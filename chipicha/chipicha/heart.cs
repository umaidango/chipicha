using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chipicha
{
    public partial class heart : Form
    {
        int MouseX;
        int MouseY;
        public heart()
        {
            InitializeComponent();
        }

        private void heart_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Color.White;
            this.TopMost = true;
        }

        private void heart_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseX;
                this.Top += e.Y - MouseY;

            }
        }

        private void heart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.MouseX = e.X;
                this.MouseY = e.Y;
            }
        }

        private void heart_DoubleClick(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
