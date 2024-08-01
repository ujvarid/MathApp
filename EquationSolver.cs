using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EquationSolverApp  
{
    public partial class EquationSolver : Form
    {

        private const int IVMAX = 99999;
        private const int IVMIN = -99999;
        public EquationSolver()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = "MathApp";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // solving button
        {
            (bool correct, string errorMessage) = CheckInput(textBox1.Text);
            if (correct)
            {
                List<string> expression = new();

                string[] exp = textBox1.Text.Split(' ');

                for (int i = 0; i < exp.Length; i++)
                {
                    expression.Add(exp[i]);
                }
                try
                {
                    Solving(expression);
                }
                catch (Exception)
                {
                    MessageBox.Show("Bolzano's theorem cannot be applied to the given function, because the it is not continuous in the given interval.\nThe solving process will be slower and will only be able to give an integer solution");
                    BruteForce(expression);
                }
            }
            else
            {
                MessageBox.Show($"{errorMessage}\n\nFor more, you can check the Help menu.");
            }
        }

        private void BruteForce(List<string> expression)
        {
            bool divisionByZero = true;
            List<string> expressionConst = new();

            for (int i = 0; i < expression.Count; i++)
            {
                expressionConst.Add(expression[i]);
            }

            double evalResult;

            for (int i = IVMIN; i < IVMAX; i++)
            {
                try
                {
                    evalResult = Evaluating(expressionConst, expression, i);
                    if (evalResult == 0)
                    {
                        string expr = "";
                        for (int j = 0; j < expressionConst.Count; j++) { expr += expressionConst[j]; }
                        MessageBox.Show($"The equation:\n\n{expr} = 0\n\nThe solution: \n\nx = " + evalResult);
                        return;
                    }
                    divisionByZero = false;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (divisionByZero) 
            {
                MessageBox.Show("The equation has a division with zero.\n\nFor more, you can check the Help menu.");
                return;
            }
            MessageBox.Show("Sorry, I could not find an integer solution.");
        }

        private (bool, string) CheckInput(string text)
        {
            string[] expr = text.Split(' ');
            if(text.Contains("/ 0")) { return (false, "The equation has a division with zero."); }
            if (!(IsWellParenthesized(expr))) { return (false, "The equation is not parenthesized well."); }
            if (string.IsNullOrEmpty(text)) { return (false, "The equation is empty."); }
            if (!text.Contains('x')) { return (false, "The equation does not contain an x variable."); }
            for (int i = 0; i < expr.Length; ++i)
            {
                if (!(IsInteger(expr[i])) && !(IsOperator(expr[i])) && !(expr[i] == "x"))
                {
                    return (false, $"The equation has an illegal character: {expr[i]}.");
                }
                if (i > 0 && IsInteger(expr[i]) && IsInteger(expr[i - 1]))
                {
                    return (false, $"An operator is missing between {expr[i - 1]} and {expr[i]}.");
                }
                if (i > 0 && IsOperator(expr[i]) && IsOperator(expr[i - 1]) && expr[i - 1] != ")" && expr[i] != "(")
                {
                    return (false, $"A number or variable is missing between {expr[i - 1]} and {expr[i]}.");
                }
                if (i > 0 && (expr[i] == "x") && (expr[i - 1] == "x"))
                {
                    return (false, $"An operator is missing between the two x variables.");
                }
            }
            return (true, "");
        }

        private bool IsWellParenthesized(string[] expr)
        {
            Stack<char> V = new Stack<char>();
            for (int i = 0; i < expr.Length; ++i)
            {
                if (expr[i] == "(")
                {
                    V.Push('(');
                }
                if (expr[i] == ")")
                {
                    if (V.Count != 0)
                    {
                        V.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return V.Count == 0;
        }

        private bool IsInteger(string text) { int a; return int.TryParse(text, out a); }

        private bool IsOperator(string text) { return (text == "-" || text == "+" || text == "*" || text == "/" || text == "^" || text == "(" || text == ")"); }

        private void textBox1_TextChanged(object sender, EventArgs e) // equation input
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        static void Solving(List<string> expression)
        {
            List<string> expressionConst = new();

            for (int i = 0; i < expression.Count; i++)
            {
                expressionConst.Add(expression[i]);
            }

            // using Bolzano's Intermediate Value Theorem

            CopyLists(expressionConst, out expression);
            int a, b;

            // 1. step: finding two places where the signs of the function values ​​differ

            (a, b) = PlacesWhereTheSignsDiffer(expression);

            // 2. step: interval halving

            (a, b) = IntervalHalving(expression, a, b);

            if (a == b)
            {
                if (a == 0 && Evaluating(expressionConst, expression, 0) != 0)
                {
                    MessageBox.Show($"Sorry, I could not find a solution given the interval [{IVMIN}, {IVMAX}]");
                }
                else
                {
                    string expr = null;
                    for (int i = 0; i < expression.Count; ++i)
                    {
                        expr += expression[i];
                    }
                    MessageBox.Show($"The equation:\n\n{expr} = 0\n\nThe solution: \n\nx = " + a);
                }
            }
            else
            {
                string expr = null;
                for (int i = 0; i < expression.Count; ++i)
                {
                    expr += expression[i];
                }
                MessageBox.Show($"The equation:\n\n{expr} = 0\n\nThe solution: \n\nx is in the interval ({a}, {b})");
            }
        }

        public static void CopyLists(List<string> list, out List<string> list2)
        {
            list2 = new List<string>();
            for (int i = 0; i < list.Count(); ++i)
            {
                list2.Add(list[i]);
            }
        }

        public static (int a, int b) PlacesWhereTheSignsDiffer(List<string> function)
        {
            int a = FindSignChangePoint(function, positive: false);
            int b = FindSignChangePoint(function, positive: true);
            return (a, b);
        }

        public static int FindSignChangePoint(List<string> function, bool positive)
        {
            int k = 0;
            List<string> expressionConst = new List<string>(function);

            for (int i = positive ? IVMAX : IVMIN; positive ? i >= IVMIN : i <= IVMAX; i += positive ? -1 : 1)
            {
                double evalResult = Evaluating(expressionConst, function, i);
                if ((positive && evalResult > 0) || (!positive && evalResult < 0))
                {
                    k = i;
                    break;
                }
            }
            return k;
        }

        public static (int, int) IntervalHalving(List<string> function, int a, int b)
        {
            List<string> expressionConst = new();

            for (int i = 0; i < function.Count; i++)
            {
                expressionConst.Add(function[i]);
            }

            int z = (a + b) / 2;
            int k = a;
            int d = b;

            for (int i = 0; i <= (Math.Log2(Math.Abs(k - d)) + 1); ++i)
            {
                double evalResult = Evaluating(expressionConst, function, z);
                if (evalResult == 0)
                {
                    return (z, z);
                }
                else if (evalResult > 0)
                {
                    b = z;
                }
                else
                {
                    a = z;
                }
                z = (a + b) / 2;
            }
            return (a, b);
        }

        public static double Evaluating(List<string> expressionConst, List<string> function, int a)
        {
            CopyLists(expressionConst, out function);
            function = PolishNotation.ToPolishForm(function, false);
            function = PolishNotation.ChangeX(function, a);
            return PolishNotation.EvaluatePolishForm(function);
        }

        private void button2_Click(object sender, EventArgs e) // help button
        {
            MessageBox.Show("Enter the eqation by separating every character with a whitespace.\n\nExample: ( x + x ^ 3 ) / ( 2 * 3 )");
        }

        private void button3_Click(object sender, EventArgs e) // exit button
        {
            this.Close();
        }
    }
}