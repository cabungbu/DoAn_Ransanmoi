namespace RanSanMoi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timerchuchay = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtocdo1 = new System.Windows.Forms.Label();
            this.lbtocdo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusdiem = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusdiem = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnchuchay = new System.Windows.Forms.Panel();
            this.lblChuoichu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chơiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.statusdiem.SuspendLayout();
            this.pnchuchay.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bấm Phím F2 Để Bắt Đầu Chơi";
            // 
            // timerchuchay
            // 
            this.timerchuchay.Enabled = true;
            this.timerchuchay.Interval = 20;
            this.timerchuchay.Tick += new System.EventHandler(this.timerchuchay_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = global::RanSanMoiVH.Properties.Resources.Screenshot_2023_11_04_140820;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbtocdo1);
            this.panel1.Controls.Add(this.lbtocdo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.statusdiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnchuchay);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(630, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 651);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 539);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "km/h";
            // 
            // lbtocdo1
            // 
            this.lbtocdo1.AutoSize = true;
            this.lbtocdo1.BackColor = System.Drawing.Color.Transparent;
            this.lbtocdo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtocdo1.Location = new System.Drawing.Point(117, 539);
            this.lbtocdo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtocdo1.Name = "lbtocdo1";
            this.lbtocdo1.Size = new System.Drawing.Size(0, 25);
            this.lbtocdo1.TabIndex = 17;
            // 
            // lbtocdo
            // 
            this.lbtocdo.AutoSize = true;
            this.lbtocdo.BackColor = System.Drawing.Color.Transparent;
            this.lbtocdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtocdo.Location = new System.Drawing.Point(27, 539);
            this.lbtocdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtocdo.Name = "lbtocdo";
            this.lbtocdo.Size = new System.Drawing.Size(82, 25);
            this.lbtocdo.TabIndex = 16;
            this.lbtocdo.Text = "Tốc Độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Điểm:";
            // 
            // statusdiem
            // 
            this.statusdiem.BackColor = System.Drawing.Color.Transparent;
            this.statusdiem.Dock = System.Windows.Forms.DockStyle.None;
            this.statusdiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusdiem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusdiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusdiem});
            this.statusdiem.Location = new System.Drawing.Point(167, 106);
            this.statusdiem.Name = "statusdiem";
            this.statusdiem.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusdiem.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusdiem.Size = new System.Drawing.Size(52, 39);
            this.statusdiem.TabIndex = 14;
            this.statusdiem.Text = "Điểm";
            // 
            // toolStripStatusdiem
            // 
            this.toolStripStatusdiem.Name = "toolStripStatusdiem";
            this.toolStripStatusdiem.Size = new System.Drawing.Size(27, 32);
            this.toolStripStatusdiem.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Luật Chơi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnchuchay
            // 
            this.pnchuchay.BackColor = System.Drawing.Color.Transparent;
            this.pnchuchay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnchuchay.Controls.Add(this.lblChuoichu);
            this.pnchuchay.Location = new System.Drawing.Point(32, 240);
            this.pnchuchay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnchuchay.Name = "pnchuchay";
            this.pnchuchay.Size = new System.Drawing.Size(354, 277);
            this.pnchuchay.TabIndex = 12;
            // 
            // lblChuoichu
            // 
            this.lblChuoichu.AutoSize = true;
            this.lblChuoichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuoichu.ForeColor = System.Drawing.Color.Black;
            this.lblChuoichu.Location = new System.Drawing.Point(4, 297);
            this.lblChuoichu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuoichu.Name = "lblChuoichu";
            this.lblChuoichu.Size = new System.Drawing.Size(0, 25);
            this.lblChuoichu.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chơiLạiToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chơiLạiToolStripMenuItem
            // 
            this.chơiLạiToolStripMenuItem.Name = "chơiLạiToolStripMenuItem";
            this.chơiLạiToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.chơiLạiToolStripMenuItem.Text = "Chơi Lại";
            this.chơiLạiToolStripMenuItem.Click += new System.EventHandler(this.chơiLạiToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::RanSanMoiVH.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Rắn Săn Mồi VH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusdiem.ResumeLayout(false);
            this.statusdiem.PerformLayout();
            this.pnchuchay.ResumeLayout(false);
            this.pnchuchay.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chơiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Timer timerchuchay;
        private System.Windows.Forms.Panel pnchuchay;
        private System.Windows.Forms.Label lblChuoichu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusdiem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusdiem;
        private System.Windows.Forms.Label lbtocdo1;
        private System.Windows.Forms.Label lbtocdo;
        private System.Windows.Forms.Label label4;

    }
}

