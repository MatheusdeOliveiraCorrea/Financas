using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] a = { "FII", "Acões", "Tudo" };

            comboBox1.Visible = true;
            comboBox1.Text = "alguma coisa";
            comboBox1.Items.AddRange(a);



            listBox1.Items.AddRange(a);
            



        }
    }
}
