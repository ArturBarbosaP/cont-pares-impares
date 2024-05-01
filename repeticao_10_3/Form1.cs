using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_10_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            int n, cont;
            n = int.Parse(txt_num.Text);

            ltx_imprimir.Items.Clear();
            ltx_imprimir.Items.Add("N = " + n);

            ltx_imprimir.Items.Add("Pares: ");
            for (cont = 1; cont <= n; cont++)
            {
                if (cont % 2 == 0)
                {
                    ltx_imprimir.Items.Add(cont);
                }
            }

            ltx_imprimir.Items.Add("Impares: ");
            for (cont = 1; cont <= n; cont++)
            {
                if (cont % 2 != 0)
                {
                    ltx_imprimir.Items.Add(cont);
                }
            }
        }
    }
}
