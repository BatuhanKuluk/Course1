using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        List<string> students;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string> { "Batuhan", "Onur", "Birol" };
            Yenile();
        }

        private void Yenile()
        {
            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxStudentsName.Text.Length > 2)
            {
                students.Add(tbxStudentsName.Text);
                lbxStudentList.Items.Clear();
                Yenile();
            }
            else
            {
                MessageBox.Show("Öğrenci ismi en az 3 karakterde olmalı");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();
                Yenile();
            }
            else
            {
                btnRemove.Enabled = false;
            }

        }
    }
}
