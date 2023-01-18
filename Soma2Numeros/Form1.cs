using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma2Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int primeiro, segundo, total;
            //entrada de dados
            primeiro = int.Parse(textBox1.Text);
            segundo = int.Parse(textBox2.Text);
            //processamento
            total  = primeiro + segundo;
            //saida de dados
            txtTotal.Text = total.ToString();
        }
    }
}
