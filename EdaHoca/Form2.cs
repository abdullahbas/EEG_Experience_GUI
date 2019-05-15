using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EdaHoca;

namespace EdaHoca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtoku_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string adress="";
            try
            {
                OpenFileDialog fl = new OpenFileDialog();
                //fl.ShowDialog();
                if (fl.ShowDialog()==DialogResult.OK)
                {
                    adress = fl.FileName;
                }
            }
            catch
            {

            }
            ReadInTimeSheet((adress));
        }
        private void ReadInTimeSheet(string adress)
        {
            string [] fileLines = File.ReadAllLines(adress);

            foreach (string line in fileLines)
            {
                listBox1.Items.Add(line);
            }
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtoku, "Text okutarak işleme başla.But first let's say Bismillah");
            toolTip1.SetToolTip(fire, "Tıklarsan seçimlerine göre işlem başlar başlatma saniyesini txtlerle belirleyebilirsin. Daha fazla bilgi için tüm denemeleri yap");
        }

        private void fire_Click(object sender, EventArgs e)
        {
           if (test2.Checked==true)
            {
                Form nw = new Form1(listBox1);
                nw.Show();
            }
            else if (test1.Checked==true)
            {
                Form nw = new Form3(listBox1);
                nw.Show();
            }
            else
            {
                MessageBox.Show("Ne yârdan geçtin ne serden! Birini seçmen gerekecek maalesef","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

       

        private void test2_MouseClick(object sender, MouseEventArgs e)
        {
            if (test1.Checked == true)
            {
                test1.Checked = false;
            }
            test2.Checked = true;

        }

        private void test1_MouseClick(object sender, MouseEventArgs e)
        {
            if (test2.Checked == true)
            {
                test2.Checked = false;
            }
            test1.Checked = true;

        }

        private void button1_Click(object sender,EventArgs e)
        {
            if (test2.Checked == true)
            {
                test2.Checked = false;
            }
            test1.Checked = true;

            // test1_MouseClick(sender,mouseEventArgs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (test1.Checked == true)
            {
                test1.Checked = false;
            }
            test2.Checked = true;

        }
    }
}
