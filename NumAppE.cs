using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class NumAppE : Form
    {
        public NumAppE()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = "MathApp";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void limENumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (limENumUpD.Value > 0)
            {
                limAppEValue.Text = LimEApproaching((int)limENumUpD.Value).ToString();
            }
            else
            {
                MessageBox.Show("Enter a natural number to approach e.");
            }
        }

        private double LimEApproaching(int n)
        {
            return Math.Pow((1.0 + 1.0 / n), n);
        }

        private void SeriesNumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            if (SeriesNumUpDwn.Value > 0)
            {
                SeriesTextBox.Text = SeriesEApproaching((int)SeriesNumUpDwn.Value).ToString();
            }
            else
            {
                MessageBox.Show("Enter a natural number to approach e.");
            }
        }

        private int Factorial(int n)
        {
            int retVal = 1;
            for (int i = 2; i <= n; i++)
            {
                retVal *= i;
            }
            return retVal;
        }

        private double SeriesEApproaching(int n)
        {
            double retVal = 0;
            for (int i = 0; i <= n; i++)
            {
                retVal += 1f / (Factorial(i));
            }
            return retVal;
        }

        private void Series2NumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (Series2NumUpD.Value > 0)
            {
                Series2TextBox.Text = Series2EApproaching((int)Series2NumUpD.Value).ToString();
            }
            else
            {
                MessageBox.Show("Enter a natural number to approach e.");
            }
        }
        private double Series2EApproaching(int n)
        {
            double retVal = 0;
            for (int i = 0; i <= n; i++)
            {
                retVal += (i + 1f) / (Factorial(2 * i + 1));
            }
            return 2 * retVal; 
        }
    }
}
