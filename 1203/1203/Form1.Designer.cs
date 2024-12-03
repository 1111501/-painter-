namespace _1203
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            畫筆色彩ToolStripMenuItem = new ToolStripMenuItem();
            藍色ToolStripMenuItem = new ToolStripMenuItem();
            紅色ToolStripMenuItem = new ToolStripMenuItem();
            綠色ToolStripMenuItem = new ToolStripMenuItem();
            白色ToolStripMenuItem = new ToolStripMenuItem();
            黑色ToolStripMenuItem = new ToolStripMenuItem();
            線條粗細ToolStripMenuItem = new ToolStripMenuItem();
            細ToolStripMenuItem = new ToolStripMenuItem();
            中ToolStripMenuItem = new ToolStripMenuItem();
            粗ToolStripMenuItem = new ToolStripMenuItem();
            線條樣式ToolStripMenuItem = new ToolStripMenuItem();
            直線ToolStripMenuItem = new ToolStripMenuItem();
            點ToolStripMenuItem = new ToolStripMenuItem();
            虛線ToolStripMenuItem = new ToolStripMenuItem();
            長虛線ToolStripMenuItem = new ToolStripMenuItem();
            儲存檔案ToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 畫筆色彩ToolStripMenuItem, 線條粗細ToolStripMenuItem, 線條樣式ToolStripMenuItem, 儲存檔案ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(612, 34);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 畫筆色彩ToolStripMenuItem
            // 
            畫筆色彩ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 藍色ToolStripMenuItem, 紅色ToolStripMenuItem, 綠色ToolStripMenuItem, 白色ToolStripMenuItem, 黑色ToolStripMenuItem });
            畫筆色彩ToolStripMenuItem.Name = "畫筆色彩ToolStripMenuItem";
            畫筆色彩ToolStripMenuItem.Size = new Size(108, 30);
            畫筆色彩ToolStripMenuItem.Text = "畫筆色彩";
            // 
            // 藍色ToolStripMenuItem
            // 
            藍色ToolStripMenuItem.Name = "藍色ToolStripMenuItem";
            藍色ToolStripMenuItem.Size = new Size(126, 30);
            藍色ToolStripMenuItem.Text = "藍色";
            藍色ToolStripMenuItem.Click += 藍色ToolStripMenuItem_Click;
            // 
            // 紅色ToolStripMenuItem
            // 
            紅色ToolStripMenuItem.Name = "紅色ToolStripMenuItem";
            紅色ToolStripMenuItem.Size = new Size(126, 30);
            紅色ToolStripMenuItem.Text = "紅色";
            紅色ToolStripMenuItem.Click += 紅色ToolStripMenuItem_Click;
            // 
            // 綠色ToolStripMenuItem
            // 
            綠色ToolStripMenuItem.Name = "綠色ToolStripMenuItem";
            綠色ToolStripMenuItem.Size = new Size(126, 30);
            綠色ToolStripMenuItem.Text = "綠色";
            綠色ToolStripMenuItem.Click += 綠色ToolStripMenuItem_Click;
            // 
            // 白色ToolStripMenuItem
            // 
            白色ToolStripMenuItem.Name = "白色ToolStripMenuItem";
            白色ToolStripMenuItem.Size = new Size(126, 30);
            白色ToolStripMenuItem.Text = "白色";
            白色ToolStripMenuItem.Click += 白色ToolStripMenuItem_Click;
            // 
            // 黑色ToolStripMenuItem
            // 
            黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
            黑色ToolStripMenuItem.Size = new Size(126, 30);
            黑色ToolStripMenuItem.Text = "黑色";
            黑色ToolStripMenuItem.Click += 黑色ToolStripMenuItem_Click;
            // 
            // 線條粗細ToolStripMenuItem
            // 
            線條粗細ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 細ToolStripMenuItem, 中ToolStripMenuItem, 粗ToolStripMenuItem });
            線條粗細ToolStripMenuItem.Name = "線條粗細ToolStripMenuItem";
            線條粗細ToolStripMenuItem.Size = new Size(108, 30);
            線條粗細ToolStripMenuItem.Text = "線條粗細";
            // 
            // 細ToolStripMenuItem
            // 
            細ToolStripMenuItem.Name = "細ToolStripMenuItem";
            細ToolStripMenuItem.Size = new Size(110, 30);
            細ToolStripMenuItem.Text = "細";
            細ToolStripMenuItem.Click += 細ToolStripMenuItem_Click;
            // 
            // 中ToolStripMenuItem
            // 
            中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            中ToolStripMenuItem.Size = new Size(110, 30);
            中ToolStripMenuItem.Text = "中";
            中ToolStripMenuItem.Click += 中ToolStripMenuItem_Click;
            // 
            // 粗ToolStripMenuItem
            // 
            粗ToolStripMenuItem.Name = "粗ToolStripMenuItem";
            粗ToolStripMenuItem.Size = new Size(110, 30);
            粗ToolStripMenuItem.Text = "粗 ";
            粗ToolStripMenuItem.Click += 粗ToolStripMenuItem_Click;
            // 
            // 線條樣式ToolStripMenuItem
            // 
            線條樣式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 直線ToolStripMenuItem, 點ToolStripMenuItem, 虛線ToolStripMenuItem, 長虛線ToolStripMenuItem });
            線條樣式ToolStripMenuItem.Name = "線條樣式ToolStripMenuItem";
            線條樣式ToolStripMenuItem.Size = new Size(108, 30);
            線條樣式ToolStripMenuItem.Text = "線條樣式";
            // 
            // 直線ToolStripMenuItem
            // 
            直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            直線ToolStripMenuItem.Size = new Size(180, 30);
            直線ToolStripMenuItem.Text = "直線";
            直線ToolStripMenuItem.Click += 直線ToolStripMenuItem_Click;
            // 
            // 點ToolStripMenuItem
            // 
            點ToolStripMenuItem.Name = "點ToolStripMenuItem";
            點ToolStripMenuItem.Size = new Size(180, 30);
            點ToolStripMenuItem.Text = "點";
            點ToolStripMenuItem.Click += 點ToolStripMenuItem_Click;
            // 
            // 虛線ToolStripMenuItem
            // 
            虛線ToolStripMenuItem.Name = "虛線ToolStripMenuItem";
            虛線ToolStripMenuItem.Size = new Size(180, 30);
            虛線ToolStripMenuItem.Text = "長-短虛線";
            虛線ToolStripMenuItem.Click += 虛線ToolStripMenuItem_Click;
            // 
            // 長虛線ToolStripMenuItem
            // 
            長虛線ToolStripMenuItem.Name = "長虛線ToolStripMenuItem";
            長虛線ToolStripMenuItem.Size = new Size(180, 30);
            長虛線ToolStripMenuItem.Text = "長虛線";
            長虛線ToolStripMenuItem.Click += 長虛線ToolStripMenuItem_Click;
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            儲存檔案ToolStripMenuItem.Size = new Size(108, 30);
            儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            儲存檔案ToolStripMenuItem.Click += 儲存檔案ToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "*.jpg|*.jpg";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 377);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "*.jpg|*.jpg";
            // 
            // button1
            // 
            button1.Location = new Point(555, 12);
            button1.Name = "button1";
            button1.Size = new Size(45, 36);
            button1.TabIndex = 2;
            button1.Text = "清空";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 443);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 畫筆色彩ToolStripMenuItem;
        private ToolStripMenuItem 藍色ToolStripMenuItem;
        private ToolStripMenuItem 線條粗細ToolStripMenuItem;
        private ToolStripMenuItem 線條樣式ToolStripMenuItem;
        private ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem 紅色ToolStripMenuItem;
        private ToolStripMenuItem 綠色ToolStripMenuItem;
        private ToolStripMenuItem 白色ToolStripMenuItem;
        private ToolStripMenuItem 黑色ToolStripMenuItem;
        private ToolStripMenuItem 細ToolStripMenuItem;
        private ToolStripMenuItem 中ToolStripMenuItem;
        private ToolStripMenuItem 粗ToolStripMenuItem;
        private ToolStripMenuItem 直線ToolStripMenuItem;
        private ToolStripMenuItem 虛線ToolStripMenuItem;
        private ToolStripMenuItem 點ToolStripMenuItem;
        private ToolStripMenuItem 長虛線ToolStripMenuItem;
        private Button button1;
    }
}