using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class TwoVarSolver : Form
    {
        public TwoVarSolver()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = "MathApp";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private (bool, double[,]) FillMatrix()
        {
            double[,] matrix = new double[2, 3];
            double val;
            if (double.TryParse(x1TextBox.Text, out val) && val != 0)
            {
                matrix[0, 0] = (double)val;
            }
            else
            {
                MessageBox.Show($"Please enter a valid number for the first x variable (cannot be zero).");
                return (false, null);
            }

            if (double.TryParse(y1TextBox.Text, out val) && val != 0)
            {
                matrix[0, 1] = (double)val;
            }
            else
            {
                MessageBox.Show($"Please enter a valid number for the first y variable (cannot be zero).");
                return (false, null);
            }

            if (double.TryParse(constant1TextBox.Text, out val))
            {
                matrix[0, 2] = (double)val;
            }
            else
            {
                MessageBox.Show($"Please enter a valid number for the first constant.");
                return (false, null);
            }

            if (double.TryParse(x2TextBox.Text, out val) && val != 0)
            {
                matrix[1, 0] = (double)val;
            }
            else
            {
                MessageBox.Show($"Please enter a valid number for the second x variable (cannot be zero).");
                return (false, null);
            }

            if (double.TryParse(y2TextBox.Text, out val) && val != 0)
            {
                matrix[1, 1] = (double)val;
            }
            else
            {
                MessageBox.Show($"Please enter a valid number for the second y variable (cannot be zero).");
                return (false, null);
            }

            if (double.TryParse(constant2TextBox.Text, out val))
            {
                matrix[1, 2] = (double)val;
            }
            else
            {
                MessageBox.Show($"Please enter a valid number for the second constant.");
                return (false, null);
            }

            return (true, matrix);
        }

        private void RowDivision(double[,] matrix, int rowNum, double divisor)
        {
            if (divisor == 0) // akkor lehet 0, ha kiejti az y változót az első elimináció
            {
                throw new Exception("Division by zero in row division!");
            }

            for (int i = 0; i < 3; ++i)
            {
                matrix[rowNum, i] /= divisor;
            }
        }

        private void RowSubtraction(double[,] matrix, int rowSubFrom, int rowSubTo, double factor)
        {
            for (int i = 0; i < 3; ++i)
            {
                matrix[rowSubTo, i] -= factor * matrix[rowSubFrom, i];
            }
        }

        private (string, string) GaussJordan(double[,] matrix)
        {
            for (int k = 0; k < 2; ++k)
            {
                double pivot = matrix[k, k];

                try
                {
                    RowDivision(matrix, k, pivot);
                }
                catch (Exception)
                {
                    return ("There is no solution", "There is no solution");
                }

                for (int i = 0; i < 2; ++i)
                {
                    if (i != k)
                    {
                        double factor = matrix[i, k];
                        RowSubtraction(matrix, k, i, factor);
                    }
                }
            }
            return (matrix[0, 2].ToString(), matrix[1, 2].ToString());
        }


        private void SolveBtn_Click(object sender, EventArgs e)
        {
            // 1.: fill 2 * 3 matrix with variables + constants

            (bool l, double[,] matrix) = FillMatrix();

            if (!l)
            {
                return;
            }

            // 2.: Gauss - Jordan

            (xValueTextBox.Text, yValueTextBox.Text) = GaussJordan(matrix);
        }
    }
}
