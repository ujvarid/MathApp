using EquationSolverApp;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;  // nem szabadul fel memoria

namespace MathApp  //  bin mappa nem lett feltoltve kene x y tengely kiiras?
{
    public partial class FunctionPlotting : Form
    {
        private const int IVMAX = 99999;
        private const int IVMIN = -99999;

        readonly FormsPlot FormsPlot1 = new FormsPlot() { Dock = DockStyle.Fill };

        public FunctionPlotting()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = "MathApp";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            panel1.Controls.Add(FormsPlot1);
        }

        private void PlotBtn_Click(object sender, EventArgs e)
        {
            (bool correct, string errorMessage) = EquationSolver.CheckInput(textBox1.Text);
            if (correct)
            {
                List<string> expression = new();

                string[] exp = textBox1.Text.Split(' ');

                for (int i = 0; i < exp.Length; i++)
                {
                    expression.Add(exp[i]);
                }

                double[] dataX = new double[IVMAX * 2 + 1];
                double[] dataY = new double[IVMAX * 2 + 1];

                EvaluatingFunction(expression, dataX, dataY);

                FormsPlot1.Plot.Add.Scatter(dataX, dataY);
                FormsPlot1.Refresh();
            }
            else
            {
                MessageBox.Show($"{errorMessage}\n\nFor more, you can check the Help menu.");
            }
        }

        private void EvaluatingFunction(List<string> expression, double[] dataX, double[] dataY) // nullaval osztas utan elbaszodik
        {
            int j = IVMIN;
            for (int i = 0; i < IVMAX * 2 + 1; i++) { dataX[i] = j; ++j; }
            bool divisionByZero = true;
            List<string> expressionConst = new();

            for (int i = 0; i < expression.Count; i++)
            {
                expressionConst.Add(expression[i]);
            }

            double evalResult;
            j = IVMIN;
            for (int i = 0; i < IVMAX * 2 + 1; i++)
            {
                try
                {
                    evalResult = EquationSolver.Evaluating(expressionConst, expression, j); // vissza adhatna, hogy minusz vagy plusz vegtelen ( a szamlalo +/- )
                    ++j;
                    dataY[i] = evalResult;
                    divisionByZero = false;
                }
                catch (Exception e)
                {
                    //dataY[i] = e.ToString()[e.ToString().Length - 1] == '+' ? 99999 : -99999;
                    dataY[i] = 0;
                    ++j;
                    continue;
                }
            }
            if (divisionByZero)
            {
                MessageBox.Show("The function has a division with zero.\n\nFor more, you can check the Help menu.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e) // help button
        {
            MessageBox.Show("Enter the function by separating every character with a whitespace.\n\nExample: ( x + x ^ 3 ) / ( 2 * 3 )");
        }
    }
}
