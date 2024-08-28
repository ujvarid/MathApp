using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
    // (x-4) ^ 2 nem jo nem talal megoldast de jol plottolja páros kitevőre nem működik, páratlanra igen => mert az intervallum felezesnel nem talal negativ erteket
   // de akkor az x^2 miert jo?
  // mert akkor az a = 0 es ez veletlen mert akkor 0 az a ha nem talal placet where signs differ
 // de ez esetben a brute force hogy lehet rossz, ha jol van abrazolva a plottingnal
namespace EquationSolverApp 
{
    public class PolishNotation
    {
        public List<string> expression;
        public List<string> polishForm;
        public PolishNotation(List<string> expression) 
        {
            this.expression = expression;
        }

        public static List<string> ToPolishForm(List<string> expression, bool sideEffect) 
        {
            Stack<string> V = new Stack<string>();
            List<string> result = new List<string>();
            for (int i = 0; i < expression.Count; i++) 
            {
                string c = expression[i];
                switch (c)
                {
                    case "(":
                        V.Push(c);
                        break;
                    case ")":
                        while(V.Peek() != "(")
                        {
                            result.Add(V.Pop());
                        }
                        V.Pop();
                        break;
                    case "+": 
                    case "-":
                        while (V.Count() != 0 && V.Peek() != "(" && V.Peek() != "=") 
                        {
                            result.Add(V.Pop());
                        }
                        V.Push(c);
                        break;
                    case "*":
                    case "/":
                        while ((V.Count() != 0 && V.Peek() != "(") && (V.Peek() == "*" || V.Peek() == "/" || V.Peek() == "^")) 
                        {
                            result.Add(V.Pop());
                        }
                        V.Push(c);
                        break;
                    case "^":                                           
                        //while (V.Count() != 0 && V.Peek() != "(" && V.Peek() != "^") nincs nála nagyobb prioritású operátor, ígyis úgyis emegy a stackbe
                        //{
                        //    result.Add(V.Pop());
                        //}
                        V.Push(c);
                        break;
                    case "=":
                        while (V.Count() != 0 && V.Peek() != "(" && V.Peek() != "=") 
                        {
                            result.Add(V.Pop());
                        }
                        V.Push(c);
                        break;
                    default:
                        result.Add(c);
                        break;
                }

            }
            while (V.Count() != 0)
            {
                if (V.Peek() != "(" && V.Peek() != ")")
                {
                    result.Add(V.Pop());
                }
                else { V.Pop(); }
            }
            if (sideEffect) 
            { 
                for (int i = 0; i < result.Count; ++i)
                {
                    Console.Write(result[i]);
                }
            }
            return result;
        }

        public static List<string> ChangeX(List<string> expression, double value) 
        {
            List<string> result = new List<string>();
            for(int i = 0; i < expression.Count; ++i)  
            {
                if (expression[i] == "x")
                {
                    result.Add(value.ToString());
                }
                else
                {
                    result.Add(expression[i]);
                }
            }
            return result;
        }
    
        public static double EvaluatePolishForm(List<string> expression)
        {
            Stack<double> V = new Stack<double>();
            double r, l;
            for (int i = 0; i < expression.Count; ++i)
            {
                switch (expression[i])
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "^":
                        r = V.Pop();
                        l = V.Pop();
                        switch (expression[i])
                        {
                            case "+":
                                V.Push(l + r);
                                break;
                            case "-":
                                V.Push(l - r);
                                break;
                            case "*":
                                V.Push(l * r);
                                break;
                            case "/":
                                if (r == 0)
                                {
                                    //MessageBox.Show("Error: Division by zero!"); // EZ ROSSZ, CSAK AKKOR KENE KIIRNI HA BENNE VAN, HOGY /0, HA VISZONT PÉLDÁUL /(X-1) AKKOR HA 1-HEZ ÉR AKKOR ÁT KÉNE UGRANIA, DE AZ A BAJ, HOGY A BOLZANO FELEZES CSAK FOLYTONOS FUGGVENYEN MUKODIK -> HA EZ VAN BRUTE FORCE KELL
                                    if (l >= 0)
                                    {
                                        throw new Exception("Division by zero +");
                                    }
                                    else 
                                    {
                                        throw new Exception("Division by zero -");
                                    }
                                }
                                V.Push(l / r);
                                break;
                            case "^":
                                V.Push(Math.Pow(l,r));
                                break;
                        }
                        break;
                    default:
                        V.Push(double.Parse(expression[i].ToString())); // ide kell exception handling
                        break;
                }
            }
            return V.Pop();
        }
    }
}
