using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        private bool arama;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            listBox1.Items.Add(metin);
            textBox1.Text = "";
            //foreach (var item in listBox1.Items)
            //{
            //    string stringToMatch = null;
            //    if (item.ToString() == stringToMatch)
            //    {
            //        label1.Text = "Found a match";
            //    }

          
            //}
          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter' a basıldığında buraya girer.
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                if (textBox1.Text == listBox1.Items[i].ToString())
                {
                    arama = true;
                }
            }
            if (arama == true)
            {
                MessageBox.Show("Değer Bulundu");
            }
            else
            {
                MessageBox.Show("Değer Bulunamadı");
            }
            arama = false;

        }
    }
}
