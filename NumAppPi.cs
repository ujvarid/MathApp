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
    public partial class NumAppPi : Form
    {
        public NumAppPi()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = "MathApp";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void midAgePiUpD_ValueChanged(object sender, EventArgs e)
        {
            if (midAgePiUpD.Value > 0)
            {
                MidAgePiValue.Text = MidAgePiApproaching((int)midAgePiUpD.Value).ToString();
            }
            else
            {
                MessageBox.Show("Enter a natural number to approach e.");
            }
        }

        private double MidAgePiApproaching(int n)
        {
            double retVal = 0;
            for (int i = 0; i <= n; ++i)
            {
                retVal += (Math.Pow(-3, -i) / (2 * i + 1));
            }
            return Math.Sqrt(12) * retVal;
        }

        private void WallisNumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            if (WallisNumUpDwn.Value > 0)
            {
                WallisPiTextBox.Text = WallisPiApproaching((int)WallisNumUpDwn.Value).ToString();
            }
            else
            {
                MessageBox.Show("Enter a natural number to approach e.");
            }
        }

        private double WallisPiApproaching(int n)
        {
            double retval = 1;
            for (int i = 1; i <= n; ++i)
            {
                retval *= (double)(4 * i * i) / (4 * i * i - 1);
            }
            return retval * 2;
        }

        private void RamanujanNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (RamanujanNumUpD.Value > 0)
            {
                RamanujanTextBox.Text = RamanujanPiApproaching((int)RamanujanNumUpD.Value).ToString();
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

        private double RamanujanPiApproaching(int n)
        {
            double retVal = 0;
            for (int i = 0; i <= n; ++i)
            {
                retVal += (Factorial(4 * i) * (1103 + 26390 * i)) / (Math.Pow(Factorial(i), 4) * (Math.Pow(396, 4 * i)));
            }
            return 1/((2 * Math.Sqrt(2))/(9801) * retVal);
        }
    }
}
