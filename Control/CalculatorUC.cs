using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class CalculatorUC : UserControl
    {
        public CalculatorUC()
        {
            InitializeComponent();
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            var numar1 = int.Parse(tbNumar1.Text);
            var numar2 = int.Parse(tbNumar2.Text);

            var sum = numar1 - numar2;
            tbRezultatScadere.Text = sum.ToString();
        }
    }
}
