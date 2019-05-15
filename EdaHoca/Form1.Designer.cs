namespace EdaHoca
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ball = new System.Windows.Forms.PictureBox();
            this.arrowR = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrowL = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowL)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ball.Location = new System.Drawing.Point(466, 161);
            this.ball.Margin = new System.Windows.Forms.Padding(4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(244, 170);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // arrowR
            // 
            this.arrowR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowR.BackgroundImage")));
            this.arrowR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arrowR.Location = new System.Drawing.Point(214, 161);
            this.arrowR.Margin = new System.Windows.Forms.Padding(4);
            this.arrowR.Name = "arrowR";
            this.arrowR.Size = new System.Drawing.Size(244, 170);
            this.arrowR.TabIndex = 1;
            this.arrowR.TabStop = false;
            this.arrowR.Click += new System.EventHandler(this.arrowR_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 276);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(335, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Muhteşemdin! Tebrikler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // arrowL
            // 
            this.arrowL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowL.BackgroundImage")));
            this.arrowL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arrowL.Location = new System.Drawing.Point(739, 161);
            this.arrowL.Margin = new System.Windows.Forms.Padding(4);
            this.arrowL.Name = "arrowL";
            this.arrowL.Size = new System.Drawing.Size(244, 170);
            this.arrowL.TabIndex = 4;
            this.arrowL.TabStop = false;
            this.arrowL.Click += new System.EventHandler(this.arrowL_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.arrowL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.arrowR);
            this.Controls.Add(this.ball);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox arrowR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox arrowL;
        private System.Windows.Forms.Timer timer2;
    }
}

