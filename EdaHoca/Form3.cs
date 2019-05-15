using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
namespace EdaHoca
{
    public partial class Form3 : Form
    {
        public Form3(ListBox list)
        {
            InitializeComponent();
            listBox1.Items.AddRange(list.Items);
            timer1.Interval = 2000;
            timer1.Start();
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\trabz\source\repos\EdaHoca\Ramiz Quliyev - Ləpələr.wav";
            player.Play();
        }
        public int[] height = new int[3];
        public int[] width = new int[3];
        private void Form3_Load(object sender, EventArgs e)
        {

            ball.ImageLocation = Directory.GetCurrentDirectory() + "\\objects\\exp1Object.png";
            listBox1.Visible = false;
            label1.Visible = false;
            ball.Visible = false;
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
            ball.Location = new Point(width[0], height[0]);

        }

        private void ball_Click(object sender, EventArgs e)
        {
            Console.Beep();
            this.Close();

        }
        public int indices = 0;
        public int bip = 0;
        public Action beep = Console.Beep;
        public int objec = 2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("aa");
            try
            {
                string item = listBox1.Items[indices].ToString();
                string[] s = new string[25];
                s = item.Split('\t');
                //MessageBox.Show(s[0] + s[1]);

                if (s[0] == "Bip" || s[0] == "bip" || s[0] == "BIP")
                {
                    float num1 = float.Parse(s[1]);
                    float num2 = float.Parse(s[2]);
                    num1 = ((num1 / num2) * 1000);
                    //MessageBox.Show(Math.Round((num1 / num2) * 1000).ToString());
                    timer1.Interval = int.Parse(Math.Round(num1).ToString());
                    Console.Beep();
                    bip++;
                    Console.WriteLine(bip);
                    if (bip == int.Parse(s[2]))
                    {
                        indices++;
                        bip = 0;
                    }
                }

                else if (s[0] == "object")
                {
                   // MessageBox.Show(s[objec]);
                    try
                    {
                        if(ball.Location==new Point(width[1]-ball.Width/2,height[1]-ball.Height/2))
                            
                        {
                            string obj = s[objec];

                            label1.Visible = false;
                            ball.Location = new Point(width[int.Parse(obj[0].ToString()) - 1] - ball.Width / 2, height[int.Parse(obj[1].ToString()) - 1] - ball.Height / 2);
                            ball.Visible = true;
                            timer1.Interval = int.Parse(s[1]) * 1000;
                            objec++;
                        }
                        else
                        {
                            ball.Location = new Point(width[1] - ball.Width / 2, height[1] - ball.Height / 2);
                            timer1.Interval = int.Parse(s[1]) * 1000;

                        }


                    }
                    catch
                    {
                        indices++;
                        ball.Visible = false;
                        label1.Visible = true;
                        objec = 2;
                    }



                }
                else
                {
                    label1.Text = s[0];
                    label1.Location = new Point(width[1] - label1.Width / 2, height[1] - label1.Height / 2);
                    label1.Visible = true;
                    timer1.Interval = int.Parse(s[1]) * 1000;
                    indices++;
                }
            }
            catch
            {
                timer1.Stop();
                label1.Text = "Test Bitti";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
