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
                Graphics g = Graphics.FromImage(pictureBox1.Image); //指定picturebox為畫布
                g.DrawLine(p, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();
            }
        }
        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }
        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void 白色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void 細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 3;
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 10;
        }

        private void 粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 20;
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.png", ImageFormat.Png);
                MessageBox.Show("存檔成功");
            }
            catch
            {
                MessageBox.Show("存檔失敗");
            }
        }

        private void 直線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }
        private void 點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }
        private void 虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void 長虛線ToolStripMenuItem_Click(object sender, EventArgs e)
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