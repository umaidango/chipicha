﻿using Microsoft.VisualBasic.Devices;
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
    public partial class ichigo : Form
    {
        int MouseX;
        int MouseY;
        public ichigo()
        {
            InitializeComponent();
        }

        private void ichigo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Color.White;
            this.TopMost = true;
        }

        private void window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.MouseX = e.X;
                this.MouseY = e.Y;
            }
        }

        private void window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseX;
                this.Top += e.Y - MouseY;

            }

        }

        private void mouse_potipoti(object sender, MouseEventArgs e)
        {
            TopMost = true;
        }

        private void ichigo_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
