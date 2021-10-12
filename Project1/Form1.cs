using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string [] names = new string [3] {"Batuhan","Onur","Birol" };

            foreach (var name in names)
            {
                listBox1.Items.Add(name);
            }
            //for (int i = 0; i < names.Length; i++)
            //{
            //    listBox1.Items.Add(names[i]);
            //}
         
            //listBox1.Items.Add("Batuhan");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)  
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Ürün seçiniz");
            }

           
            //string secili = listBox1.Items[listBox1.SelectedIndex].ToString();
            //MessageBox.Show(secili);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }
    }
}
