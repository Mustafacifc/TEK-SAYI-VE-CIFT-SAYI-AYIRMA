using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEK_SAYI_VE_CIFT_SAYI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            listBox1.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                int sayi = rastgele.Next(1,100);
                listBox1.Items.Add(sayi);

                if (sayi % 2 != 0)
                {
                    listBox2.Items.Add(sayi);
                }

                if (sayi % 2 == 0)
                {
                    listBox3.Items.Add(sayi);
                }
            }
        }
    }
}
