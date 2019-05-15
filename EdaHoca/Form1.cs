using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
namespace EdaHoca
{
    public partial class Form1 : Form
    {
        public Form1(ListBox listBox)
        {
            InitializeComponent();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\trabz\source\repos\EdaHoca\Ramiz Quliyev - Ləpələr.wav";
            player.Play();
            timer1.Interval = 5000; // means 2 seconds
            timer2.Interval = 3000; // means 2 seconds
            timer2.Start();
            listBox1.Items.AddRange(listBox.Items);

        }
        public int[] height = new int[3];
        public int[] width = new int[3];
        public PictureBox[] pb = new PictureBox[3];
        private void Form1_Load(object sender, EventArgs e)
        {
            ball.ImageLocation = Directory.GetCurrentDirectory() + "\\objects\\exp2Object1.png";
            arrowR.ImageLocation = Directory.GetCurrentDirectory() + "\\objects\\exp2Object2.png";
            arrowL.ImageLocation = Directory.GetCurrentDirectory() + "\\objects\\exp2Object3.png";


            pb[0] = ball;
            pb[1] = arrowR;
            pb[2] = arrowL;
            arrowL.Visible = false;
            ball.Visible = false;
            
            arrowR.Visible = false;
            listBox1.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;
          

            this.WindowState = FormWindowState.Maximized;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            height[0] = this.Height / 2 - this.Height / 3;
            height[1] = this.Height / 2;
            height[2] = this.Height / 2 + this.Height / 3;

            width[0] = this.Width / 2 - this.Width / 3;
            width[1] = this.Width / 2;
            width[2] = this.Width / 2 + this.Width / 3;

            label1.Location = new Point(this.Width/2-label1.Width/2,this.Height/2-label1.Height/2);
            label1.Text = "Haydi Başlıyoruz";
            label1.Visible = true;
            timer1.Start();
            
        }
        
        private void setObjectandTime(PictureBox p , int seconds)
        {
            if (p.Visible ==true)
            {
                p.Visible = false;

            }
            else
            {
                p.Visible = true;

            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arrowR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Height.ToString());
            
        }
        public int indeces = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            //setObjectandTime(arrowR, 14);
            try
            {
                
                string one=listBox1.Items[indeces].ToString();
                string[] two = one.Split('\t');
                string san = two[0];
                //MessageBox.Show(two[0]+"  "  + two[1]+"  " + two[2]);
                timer1.Interval = int.Parse(san.ToString()) * 1000;

                string ind = two[1]; //listBox1.Items[indeces + 1].ToString();
                //MessageBox.Show(indeces + " dasd " + ind[1] + "leng" + width.Length.ToString());

                pb[int.Parse(two[2])-1].Location = new Point(width[int.Parse(ind[0].ToString()) - 1]-pb[int.Parse(two[2])-1].Width/2 , height[int.Parse(ind[1].ToString()) - 1]-pb[int.Parse(two[2])-1].Height/2 );
                //MessageBox.Show("RTT");
                if (ball.Visible == false & arrowR.Visible==false & arrowL.Visible==false)
                {
                    pb[int.Parse(two[2])-1].Visible = true;
                    indeces = indeces + 1;

                }
                else if (ball.Visible==true | arrowR.Visible==true | arrowL.Visible==true)
                {
                    try
                    {
                        timer1.Interval = int.Parse(two[3]) * 1000;

                    }
                    catch
                    {
                        timer1.Interval = 3000;
                    }
                    ball.Visible = false;
                    arrowR.Visible = false;
                    arrowL.Visible = false;
                }
                //setObjectandTime(ball, 22);
                //Thread.Sleep(10);
                //timer1.Stop();
            }
            catch
            {
                timer1.Stop();
                label1.Visible = true;
                ball.Visible = false;
                arrowL.Visible = false;
                arrowR.Visible = false;
            }

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.Size.ToString() + "Tıkladığın= " + MousePosition.X.ToString() + " " + MousePosition.Y.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void arrowL_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer2.Stop();
            label1.Text = "Test Bitti";
        }
    }
}
