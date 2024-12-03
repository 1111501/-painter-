using System.Drawing.Imaging;

namespace _1203
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        int x, y;

        Pen p = new Pen(Color.Black, 3);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image); //���wpicturebox���e��
                g.DrawLine(p, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();
            }
        }
        private void �¦�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }
        private void �Ŧ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void �զ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 3;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 10;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 20;
        }

        private void �x�s�ɮ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.png", ImageFormat.Png);
                MessageBox.Show("�s�ɦ��\");
            }
            catch
            {
                MessageBox.Show("�s�ɥ���");
            }
        }

        private void ���uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }
        private void �IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }
        private void ��uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void ����uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

       
    }
}