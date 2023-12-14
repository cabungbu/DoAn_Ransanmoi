namespace RanSanMoi
{
    partial class FormMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuc));
            this.btde = new System.Windows.Forms.Button();
            this.btvua = new System.Windows.Forms.Button();
            this.btkho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btde
            // 
            this.btde.BackgroundImage = global::RanSanMoiVH.Properties.Resources.Screenshot_2023_11_04_002533;
            this.btde.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btde.Location = new System.Drawing.Point(134, 556);
            this.btde.Name = "btde";
            this.btde.Size = new System.Drawing.Size(148, 55);
            this.btde.TabIndex = 2;
            this.btde.Text = "Easy";
            this.btde.UseVisualStyleBackColor = true;
            this.btde.Click += new System.EventHandler(this.btde_Click);
            // 
            // btvua
            // 
            this.btvua.BackgroundImage = global::RanSanMoiVH.Properties.Resources.Screenshot_2023_11_04_002533;
            this.btvua.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvua.Location = new System.Drawing.Point(451, 556);
            this.btvua.Name = "btvua";
            this.btvua.Size = new System.Drawing.Size(187, 55);
            this.btvua.TabIndex = 3;
            this.btvua.Text = "Medium";
            this.btvua.UseVisualStyleBackColor = true;
            this.btvua.Click += new System.EventHandler(this.btvua_Click);
            // 
            // btkho
            // 
            this.btkho.BackgroundImage = global::RanSanMoiVH.Properties.Resources.Screenshot_2023_11_04_002533;
            this.btkho.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkho.Location = new System.Drawing.Point(790, 556);
            this.btkho.Name = "btkho";
            this.btkho.Size = new System.Drawing.Size(148, 55);
            this.btkho.TabIndex = 4;
            this.btkho.Text = "Hard";
            this.btkho.UseVisualStyleBackColor = true;
            this.btkho.Click += new System.EventHandler(this.btkho_Click);
            // 
            // FormMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::RanSanMoiVH.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 648);
            this.Controls.Add(this.btkho);
            this.Controls.Add(this.btvua);
            this.Controls.Add(this.btde);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mức Chơi";
            this.Load += new System.EventHandler(this.FormMuc_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btde;
        private System.Windows.Forms.Button btvua;
        private System.Windows.Forms.Button btkho;
    }
}