using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class MatrixCalculator : Form
    {
        private TextBox[] textBoxes = new TextBox[9];
        public MatrixCalculator()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            for (int i = 0; i < 9; i++)
            {
                textBoxes[i] = new TextBox
                {
                    Location = new System.Drawing.Point(320 + (i % 3) * 100, 100 + (i / 3) * 100),
                    Size = new System.Drawing.Size(100, 60),
                    Name = $"{i + 1}. Text Box",
                    TextAlign = HorizontalAlignment.Center
                };
                this.Controls.Add(textBoxes[i]);
            }
        }

        private void FillTextBoxes(double[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int index = i * 3 + j;
                    textBoxes[index].Text = matrix[i, j].ToString();
                }
            }
        }

        private (bool, double[,]) FillMatrix()
        {
            double[,] matrix = new double[3, 3];
            double val;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int index = i * 3 + j;
                    if (double.TryParse(textBoxes[index].Text, out val))
                    {
                        matrix[i, j] = (double)val;
                    }
                    else
                    {
                        MessageBox.Show($"Please enter a valid number in {textBoxes[index].Name}");
                        return (false, null);
                    }
                }
            }
            return (true, matrix);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double Determinant(double[,] matrix)
        {
            return (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) + (matrix[0, 1] * matrix[1, 2] * matrix[2, 0]) + (matrix[0, 2] * matrix[1, 0] * matrix[2, 1]) - (matrix[0, 2] * matrix[1, 1] * matrix[2, 0]) - (matrix[0, 0] * matrix[1, 2] * matrix[2, 1]) - (matrix[0, 1] * matrix[1, 0] * matrix[2, 2]);
        }

        private void DetermBtn_Click(object sender, EventArgs e)
        {
            (bool l, double[,] matrix) = FillMatrix();

            // Sarrus-szabály
            if (l)
            {
                MessageBox.Show($"The determinant of the matrix is {Determinant(matrix).ToString()}");
            }
        }

        private void TrpBtn_Click(object sender, EventArgs e)
        {
            (bool l, double[,] tempMatrix) = FillMatrix();
            if (!l) { return; }
            double[,] matrix = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = tempMatrix[j, i];
                }
            }
            FillTextBoxes(matrix);
        }

        private bool CanDoGJ(double[,] matrix)
        {
            return matrix[0, 0] != 0 && matrix[1, 1] != 0 && matrix[2, 2] != 0;
        }

        private double[,] CopyMatrix(double[,] matrix)
        {
            double[,] retMatrix = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    retMatrix[i, j] = matrix[i, j];
                }
            }
            return retMatrix;
        }

        private void SwitchRows(double[,] matrix, int row1Index, int row2Index)
        {
            for (int i = 0; i < 3; i++)
            {
                double temp = matrix[row1Index, i];
                matrix[row1Index, i] = matrix[row2Index, i];
                matrix[row2Index, i] = temp;
            }
        }

        private void MakeGJCompatible(double[,] matrix, double[,] identityMatrix)
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    SwitchRows(matrix, i, j);
                    SwitchRows(identityMatrix, i, j);
                    if (CanDoGJ(matrix))
                    {
                        return;
                    }
                }
            }
            throw new Exception("Could not create GJ compatible matrix");
        }

        private double[,] CreateidentityMatrix()
        {
            return new double[,]
            {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };
        }

        private void RowDivision(double[,] matrix, double[,] identityMatrix, int rowNum, double divisor)
        {
            if (divisor == 0)
            {
                throw new Exception("Division by zero in row division!");
            }

            for (int i = 0; i < 3; ++i)
            {
                matrix[rowNum, i] /= divisor;
                identityMatrix[rowNum, i] /= divisor;
            }
        }

        private void RowSubtraction(double[,] matrix, double[,] identityMatrix, int rowSubFrom, int rowSubTo, double factor)
        {
            for (int i = 0; i < 3; ++i)
            {
                matrix[rowSubTo, i] -= factor * matrix[rowSubFrom, i];
                identityMatrix[rowSubTo, i] -= factor * identityMatrix[rowSubFrom, i];
            }
        }

        private void GaussJordan(double[,] matrix)
        {
            double[,] identityMatrix = CreateidentityMatrix();

            if (!CanDoGJ(matrix))
            {
                MakeGJCompatible(matrix, identityMatrix);
            }

            for (int k = 0; k < 3; ++k)
            {
                double pivot = matrix[k, k];

                RowDivision(matrix, identityMatrix, k, pivot);

                for (int i = 0; i < 3; ++i)
                {
                    if (i != k)
                    {
                        double factor = matrix[i, k];
                        RowSubtraction(matrix, identityMatrix, k, i, factor);
                    }
                }
            }

            FillTextBoxes(identityMatrix);
        }



        private void InvBtn_Click(object sender, EventArgs e)
        {
            (bool l, double[,] matrix) = FillMatrix();
            if (!l)
            {
                return;
            }
            if (Determinant(matrix) == 0)
            {
                MessageBox.Show("The determinant of the matrix is ​​zero, so it cannot be inverted.");
                return;
            }


            GaussJordan(matrix);
        }

        private void button2_Click(object sender, EventArgs e) // help button
        {
            MessageBox.Show("Transposing and inversing the matrix will change the matrix itself.");
        }
    }
}
