using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApplications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bir değer giriniz!");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {
                Random r = new Random();
                int rastgeleTamSayi = r.Next(0, listBox1.Items.Count);
                string kisi = listBox1.Items[rastgeleTamSayi].ToString();
                MessageBox.Show(kisi);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
