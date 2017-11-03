using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorEx
{
    public partial class Form1 : Form
    {
        public double Result;
        public double Element;
        private string strElem;
        private bool IsFract, IsMinus;
        public Operation op;

        public Form1()
        {
            InitializeComponent();
            Result = 0; Element = 0;
            IsFract = false; IsMinus = false;
            strElem = string.Empty; op = Operation.plus;
            lbResult.Text = string.Format("{0}", Math.Round(Result, 3));
        }

        /// <summary>
        /// Displays the result
        /// </summary>
        /// <param name="st"></param>
        private void Display(string st)
        {
            if (st == string.Empty)
            {
                IsMinus = false;
                IsFract = false;
                lbResult.Text = "0";
            }
            else
            {
                if (IsMinus) lbResult.Text = "-" + st;
                else lbResult.Text = st;
            }
        }

        /// <summary>
        /// Convert string to double
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private double StrToDbl(string a)
        {
            double b = 0;
            double.TryParse(a, out b);
            if (IsMinus) return -b;
            else return b;
        }

        private void gbNumber_MouseClick(object sender, MouseEventArgs e)
        {
            GlassButton gb = (GlassButton)sender;
            if (op == Operation.enter)
            {
                Result = 0;
                op = Operation.plus;
            }
            if (gb.TabIndex < 10)
            {
                strElem += gb.TextButton;
                if (strElem == "0") strElem = string.Empty;
            }
            if ((!IsFract) && (gb.TabIndex == 10))
            {
                IsFract = true;
                if (strElem == string.Empty) strElem = "0.";
                else strElem += ".";
            }
            if (gb.TabIndex == 11) IsMinus = !IsMinus;
            Display(strElem);
        }

        private void gbBack_MouseClick(object sender, MouseEventArgs e)
        {
            if (strElem != string.Empty)
            {
                int k = strElem.Length;
                strElem = strElem.Substring(0, k - 1);
                if (!strElem.Contains('.')) IsFract = false;
                if (strElem == "0") strElem = string.Empty;
            }
            Display(strElem);
        }

        private void gbOperation_MouseClick(object sender, MouseEventArgs e)
        {
            Element = StrToDbl(strElem);
            strElem = string.Empty;
            IsMinus = false;
            IsFract = false;
            if (op == Operation.enter) Element = Result;
            if (Element != 0)
            {
                switch (op)
                {
                    case Operation.plus:
                        Result = Result + Element;
                        break;
                    case Operation.minus:
                        Result = Result - Element;
                        break;
                    case Operation.mult:
                        Result = Result * Element;
                        break;
                    case Operation.div:
                        Result = Result / Element;
                        break;
                    case Operation.pow:
                        Result = Math.Pow(Result, Element);
                        break;
                }
            }
            lbResult.Text = string.Format("{0}", Math.Round(Result, 3));
            GlassButton gb = (GlassButton)sender;
            if (gb.TabIndex == 0) op = Operation.plus;
            else if (gb.TabIndex == 1) op = Operation.minus;
            else if (gb.TabIndex == 2) op = Operation.mult;
            else if (gb.TabIndex == 3) op = Operation.div;
            else if (gb.TabIndex == 4) op = Operation.pow;
            else if (gb.TabIndex == 5)
            {
                op = Operation.enter;
                Result = Math.Sqrt(Math.Abs(Element));
                lbResult.Text = string.Format("{0}", Math.Round(Result, 3));
            }
            else op = Operation.enter;
            if (gb.TabIndex < 5) lbOper.Text = gb.TextButton;
            else lbOper.Text = "=";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int k = e.KeyValue;
            if ((k > 95) && (k < 106))
            {
                if (op == Operation.enter)
                {
                    Result = 0;
                    op = Operation.plus;
                }
                strElem += (char)(k - 48);
                if (strElem == "0") strElem = string.Empty;
                Display(strElem);
            }
            if ((!IsFract) && (e.KeyCode == Keys.Decimal))
            {
                if (op == Operation.enter)
                {
                    Result = 0;
                    op = Operation.plus;
                }
                IsFract = true;
                if (strElem == string.Empty) strElem = "0.";
                else strElem += ".";
                Display(strElem);
            }
            if (e.KeyCode == Keys.Back)
            {
                if (strElem != string.Empty)
                {
                    int i = strElem.Length;
                    strElem = strElem.Substring(0, i - 1);
                    if (!strElem.Contains('.')) IsFract = false;
                    if (strElem == "0") strElem = string.Empty;
                    Display(strElem);
                }
            }
            if ((e.KeyCode == Keys.Add) || (e.KeyCode == Keys.Subtract) || (e.KeyCode == Keys.Multiply)
              || (e.KeyCode == Keys.Divide) || (e.KeyCode == Keys.Enter))
            {
                Element = StrToDbl(strElem);
                strElem = string.Empty;
                IsMinus = false;
                IsFract = false;
                if (op == Operation.enter) Element = Result;
                if (Element != 0)
                {
                    switch (op)
                    {
                        case Operation.plus:
                            Result = Result + Element;
                            break;
                        case Operation.minus:
                            Result = Result - Element;
                            break;
                        case Operation.mult:
                            Result = Result * Element;
                            break;
                        case Operation.div:
                            Result = Result / Element;
                            break;
                        case Operation.pow:
                            Result = Math.Pow(Result, Element);
                            break;
                    }
                }
                lbResult.Text = string.Format("{0}", Math.Round(Result, 3));
                if (e.KeyCode == Keys.Add)
                {
                    op = Operation.plus;
                    lbOper.Text = "+";
                }
                else if (e.KeyCode == Keys.Subtract)
                {
                    op = Operation.minus;
                    lbOper.Text = "-";
                }
                else if (e.KeyCode == Keys.Multiply)
                {
                    op = Operation.mult;
                    lbOper.Text = "x";
                }
                else if (e.KeyCode == Keys.Divide)
                {
                    op = Operation.div;
                    lbOper.Text = "/";
                }
                else
                {
                    op = Operation.enter;
                    lbOper.Text = "=";
                }
            }
        }


    }//end Form1
}
