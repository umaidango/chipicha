using System.Drawing.Printing;

namespace chipicha
{
    public partial class Form1 : Form
    {
        int MouseX;
        int MouseY;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;



        }

        private void Form1_Load(object sender, EventArgs e)
        {






        }

        private void window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.MouseX = e.X;
                this.MouseY = e.Y;
            }
        }

        private void window_MouseMovw(object sender, MouseEventArgs e)
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void f2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                BackgroundImage = Properties.Resources.ichigo_icons;
            }
        }

        private void f1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ichigo ichigo = new ichigo();
            ichigo.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            kurumi kurumi = new kurumi();
            kurumi.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Width = 136;
            pictureBox2.Height = 190;
            pictureBox2.Location = new Point(40, 32);
            Cursor = Cursors.Hand;
            Rectangle r = new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 18;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox2.Region = new Region(gp);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Width = 156;
            pictureBox2.Height = 210;
            pictureBox2.Location = new Point(22, 16);

            Cursor = Cursors.Default;

            Rectangle r = new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 28;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox2.Region = new Region(gp);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Width = 136;
            pictureBox3.Height = 190;
            pictureBox3.Location = new Point(210, 16);

            Cursor = Cursors.Hand;

            Rectangle r = new Rectangle(0, 0, pictureBox3.Width, pictureBox3.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 18;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox3.Region = new Region(gp);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Width = 156;
            pictureBox3.Height = 210;
            pictureBox3.Location = new Point(210, 20);

            Cursor = Cursors.Default;

            Rectangle r = new Rectangle(0, 0, pictureBox3.Width, pictureBox2.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 28;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox3.Region = new Region(gp);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            heart heart = new heart();
            heart.Show();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {

            pictureBox4.Width = 136;
            pictureBox4.Height = 190;
            pictureBox4.Location = new Point(404, 16);

            Cursor = Cursors.Hand;

            Rectangle r = new Rectangle(0, 0, pictureBox4.Width, pictureBox4.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 18;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox4.Region = new Region(gp);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Width = 156;
            pictureBox4.Height = 210;
            pictureBox4.Location = new Point(404, 16);

            Cursor = Cursors.Default;

            Rectangle r = new Rectangle(0, 0, pictureBox4.Width, pictureBox4.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 28;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox4.Region = new Region(gp);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog();
        }
    }
}
