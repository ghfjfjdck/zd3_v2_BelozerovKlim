using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Qp road = new Qp();
        private void button1_Click(object sender, EventArgs e)
        {
            road.Addobject(num1,num2,num3,num4);
            MessageBox.Show("Добавлено");
            road.Listrestart(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = listBox1.SelectedIndex;
            if (d!=-1)
            {

                listBox1.Items.RemoveAt(d);


            }else
            {
                MessageBox.Show("Выберите строчку");
            }
        }
    }
}
