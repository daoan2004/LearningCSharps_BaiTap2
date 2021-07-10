using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Tong_gia=0;
            if (checkBox1.Checked == true) Tong_gia += 100000;
            if (checkBox2.Checked == true) Tong_gia += 1500000;
            Tong_gia += int.Parse(numericUpDown1.Value.ToString()) * 150000;
            Tong_gia += int.Parse(numericUpDown2.Value.ToString()) * 200000;
            textBox2.Text = Tong_gia.ToString();
            MessageBox.Show("Khách hàng " + textBox1.Text + " cần phải trả số tiền " + textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox2.Text = "0";
            textBox1.Text = "0";
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
    }
}
