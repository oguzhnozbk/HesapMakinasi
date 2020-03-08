using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
    public partial class Form1 : Form
    {
        bool TranslationButtonDefault = true;
        History historyForm;
        double[] _number = new double[2];
        int _numberSelect = 0; // 0 - number 1 , 1 - number2
        string memoryOperation = "0";
        string operators = "";
        FileOperations file = new FileOperations(@"D:\History.txt");
        Operations operations = new Operations();
        public Form1()
        {
            InitializeComponent();
            TranslationBtn();
        }

        private void btnTranslation_Click(object sender, EventArgs e)
        {
            if (TranslationButtonDefault)
                TranslationButtonDefault = false;
            else
                TranslationButtonDefault = true;
            TranslationBtn();
        }
        void TranslationBtn()
        {
            if (TranslationButtonDefault)
            {
                btnTranslation.BackColor = SystemColors.Control;
                btnX2.Text = "x²";
                btnX3.Text = "x³";
                btnXusY.Text = "xᵞ";
                btnOnUs.Text = "10ᵡ";
                btnLog.Text = "log";
                btnLn.Text = "ln";

            }
            else
            {
                btnTranslation.BackColor = Color.LightSkyBlue;
                btnX2.Text = "²√x";
                btnX3.Text = "³√x";
                btnXusY.Text = "ᵞ√x";
                btnOnUs.Text = "2ᵡ";
                btnLog.Text = "log";
                btnLn.Text = "eᵡ";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
            memoryOperation = "0";
            _number[0] = 0;
            _number[1] = 0;
            operators = "";
            _numberSelect = 0;

        }
        private void btnWipe_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0")
            {
                memoryOperation = memoryOperation.Substring(0, memoryOperation.Length - 1);
                if (memoryOperation.Length == 0) memoryOperation = "0";
                label1.Text = memoryOperation;
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                historyForm.Show();
            }
            catch (Exception)
            {

                historyForm = new History();
                historyForm.Show();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "0";
            else memoryOperation = "0";
            label1.Text = memoryOperation;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "1";
            else memoryOperation = "1";
            label1.Text = memoryOperation;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "2";
            else memoryOperation = "2";
            label1.Text = memoryOperation;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "3";
            else memoryOperation = "3";
            label1.Text = memoryOperation;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "4";
            else memoryOperation = "4";
            label1.Text = memoryOperation;

        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "5";
            else memoryOperation = "5";
            label1.Text = memoryOperation;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "6";
            else memoryOperation = "6";
            label1.Text = memoryOperation;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "7";
            else memoryOperation = "7";
            label1.Text = memoryOperation;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "8";
            else memoryOperation = "8";
            label1.Text = memoryOperation;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += "9";
            else memoryOperation = "9";
            label1.Text = memoryOperation;

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (memoryOperation != "0") memoryOperation += ",";
            else memoryOperation = "0,";
            label1.Text = memoryOperation;

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (!(operators == "+" || operators == "-" || operators == "/" || operators == "*")) { operators = ""; _numberSelect = 0; }
            if (operators == "+" || operators == "")
            {
                _number[_numberSelect] = Convert.ToDouble(label1.Text);
                label2.Text = label1.Text + " + ";
                operators = "+";
                memoryOperation = "0";
                _numberSelect++;
                if (_numberSelect > 1)
                {
                    _number[0] = operations.Addition(_number[0], _number[1]);
                    _numberSelect = 1;
                    label2.Text = _number[0].ToString() + " + ";
                }
            }
            else
            {
                label2.Text = _number[0].ToString() + " + ";
                operators = "+";
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (!(operators == "+" || operators == "-" || operators == "/" || operators == "*")) { operators = ""; _numberSelect = 0; }
            if (operators == "-" || operators == "")
            {
                _number[_numberSelect] = Convert.ToDouble(label1.Text);
                label2.Text = label1.Text + " - ";
                operators = "-";
                memoryOperation = "0";
                _numberSelect++;
                if (_numberSelect > 1)
                {
                    _number[0] = operations.Subtraction(_number[0], _number[1]);
                    _numberSelect = 1;
                    label2.Text = _number[0].ToString() + " - ";
                }
            }
            else
            {
                label2.Text = _number[0].ToString() + " - ";
                operators = "-";
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (!(operators == "+" || operators == "-" || operators == "/" || operators == "*")) { operators = ""; _numberSelect = 0; }
            if (operators == "x" || operators == "")
            {
                _number[_numberSelect] = Convert.ToDouble(label1.Text);
                label2.Text = label1.Text + " x ";
                operators = "x";
                memoryOperation = "0";
                _numberSelect++;
                if (_numberSelect > 1)
                {
                    _number[0] = operations.Multiplication(_number[0], _number[1]);
                    _numberSelect = 1;
                    label2.Text = _number[0].ToString() + " x ";
                }
            }
            else
            {
                label2.Text = _number[0].ToString() + " x ";
                operators = "x";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!(operators == "+" || operators == "-" || operators == "/" || operators == "*")) { operators = ""; _numberSelect = 0; }
            if (operators == "/" || operators == "")
            {
                _number[_numberSelect] = Convert.ToDouble(label1.Text);
                label2.Text = label1.Text + " / ";
                operators = "/";
                memoryOperation = "0";
                _numberSelect++;
                if (_numberSelect > 1)
                {
                    _number[0] = operations.Division(_number[0], _number[1]);
                    _numberSelect = 1;
                    label2.Text = _number[0].ToString() + " / ";
                }
            }
            else
            {
                label2.Text = _number[0].ToString() + " / ";
                operators = "/";
            }
        }
        private void btnYuzde_Click(object sender, EventArgs e)
        {
            _numberSelect = 0;
            _number[_numberSelect] = Convert.ToDouble(label1.Text);
            operators = "%";
            memoryOperation = "0";
            label2.Text = _number[_numberSelect].ToString() + " x %";
            _numberSelect++;
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            _numberSelect = 0;
            _number[_numberSelect] = Convert.ToDouble(label1.Text);
            operators = "mod";
            memoryOperation = "0";
            label2.Text = _number[_numberSelect].ToString() + " mod ";
            _numberSelect++;
        }
        private void btnXusY_Click(object sender, EventArgs e)
        {
            if (TranslationButtonDefault)
            {
                _numberSelect = 0;
                _number[_numberSelect] = Convert.ToDouble(label1.Text);
                operators = "x^y";
                memoryOperation = "0";
                label2.Text = _number[_numberSelect].ToString() + "^";
                _numberSelect++;
            }
            else
            {
                _numberSelect = 0;
                _number[_numberSelect] = Convert.ToDouble(label1.Text);
                operators = "xy";
                memoryOperation = "0";
                label2.Text = "ᵞ√" + _number[_numberSelect].ToString();
                _numberSelect++;
            }
        }
        private void btnNegate_Click(object sender, EventArgs e)
        {
            _number[_numberSelect] = (-1) * Convert.ToDouble(label1.Text);
            if (label2.Text == "" && _numberSelect == 0) label2.Text = "negate(" + label1.Text + ")";
            else if (_numberSelect == 0) label2.Text = "negate(" + label1.Text + ")";
            else label2.Text = _number[_numberSelect - 1] + " " + operators + " negate(" + label1.Text + ")";
            label1.Text = _number[_numberSelect].ToString();
            if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            _number[_numberSelect] = operations.Factorial(Convert.ToDouble(label1.Text));
            if (label2.Text == "" && _numberSelect == 0) label2.Text = "(" + label1.Text + ")!";
            else if (_numberSelect == 0) label2.Text = "(" + label1.Text + ")!";
            else label2.Text = _number[_numberSelect - 1] + " " + operators + " (" + label1.Text + ")!";
            label1.Text = _number[_numberSelect].ToString();
            if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);

        }

        private void btnAbsolute_Click(object sender, EventArgs e)
        {
            _number[_numberSelect] = operations.Absolute(Convert.ToDouble(label1.Text));
            if (label2.Text == "" && _numberSelect == 0) label2.Text = "abs(" + label1.Text + ")";
            else if (_numberSelect == 0) label2.Text = "abs(" + label1.Text + ")";
            else label2.Text = _number[_numberSelect - 1] + " " + operators + " abs(" + label1.Text + ")";
            label1.Text = _number[_numberSelect].ToString();
            if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);

        }

        private void btnOneDivided_Click(object sender, EventArgs e)
        {

            _number[_numberSelect] = operations.OneDivided(Convert.ToDouble(label1.Text));
            if (label2.Text == "" && _numberSelect == 0) label2.Text = "1/(" + label1.Text + ")";
            else if (_numberSelect == 0) label2.Text = "1/(" + label1.Text + ")";
            else label2.Text = _number[_numberSelect - 1] + " " + operators + " 1/(" + label1.Text + ")";
            label1.Text = _number[_numberSelect].ToString();
            if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            _number[_numberSelect] = operations.Enumber();
            if (label2.Text == "" && _numberSelect == 0) label2.Text = "e";
            else if (_numberSelect == 0) label2.Text = "e";
            else label2.Text = _number[_numberSelect - 1] + " " + operators + " e";
            label1.Text = _number[_numberSelect].ToString();
            if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            _number[_numberSelect] = operations.PI();
            if (label2.Text == "" && _numberSelect == 0) label2.Text = "π";
            else if (_numberSelect == 0) label2.Text = "π";
            else label2.Text = _number[_numberSelect - 1] + " " + operators + " π";
            label1.Text = _number[_numberSelect].ToString();
            if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
        }
        
        private void btnLn_Click(object sender, EventArgs e)
        {
            if (TranslationButtonDefault)
            {
                _number[_numberSelect] = operations.Ln(Convert.ToDouble(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "ln(" + label1.Text + ")";
                else if (_numberSelect == 0) label2.Text = "ln(" + label1.Text + ")";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " ln(" + label1.Text + ")";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
            else
            {
                _number[_numberSelect] = operations.EusX(Convert.ToInt32(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "e^(" + label1.Text + ")";
                else if (_numberSelect == 0) label2.Text = "e^(" + label1.Text + ")";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " e^(" + label1.Text + ")";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (TranslationButtonDefault)
            {
                _number[_numberSelect] = operations.Log(Convert.ToDouble(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "log(" + label1.Text + ")";
                else if (_numberSelect == 0) label2.Text = "log(" + label1.Text + ")";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " log(" + label1.Text + ")";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
            else
            {
                _number[_numberSelect] = operations.Log(Convert.ToDouble(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "log(" + label1.Text + ")";
                else if (_numberSelect == 0) label2.Text = "log(" + label1.Text + ")";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " log(" + label1.Text + ")";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
        }

        private void btnOnUs_Click(object sender, EventArgs e)
        {
            if (TranslationButtonDefault)
            {
                _number[_numberSelect] = operations.OnUsX(Convert.ToInt32(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "10^(" + label1.Text + ")";
                else if (_numberSelect == 0) label2.Text = "10^(" + label1.Text + ")";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " 10^(" + label1.Text + ")";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
            else
            {
                _number[_numberSelect] = operations.IkiUsX(Convert.ToInt32(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "2^(" + label1.Text + ")";
                else if (_numberSelect == 0) label2.Text = "2^(" + label1.Text + ")";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " 2^(" + label1.Text + ")";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            if (TranslationButtonDefault)
            {
                _number[_numberSelect] = operations.X3(Convert.ToDouble(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "(" + label1.Text + ")^3";
                else if (_numberSelect == 0) label2.Text = "(" + label1.Text + ")^3";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " (" + label1.Text + ")^3";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
            else
            {
                _number[_numberSelect] = operations.CubeRoot(Convert.ToInt32(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "³√(" + label1.Text + ")";
                else if (_numberSelect == 0) label2.Text = "³√(" + label1.Text + ")";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " ³√(" + label1.Text + ")";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            if (TranslationButtonDefault)
            {
                _number[_numberSelect] = operations.X2(Convert.ToDouble(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "(" + label1.Text + ")^2";
                else if (_numberSelect == 0) label2.Text = "(" + label1.Text + ")^2";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " (" + label1.Text + ")^2";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
            else
            {
                _number[_numberSelect] = operations.SquareRoot(Convert.ToInt32(label1.Text));
                if (label2.Text == "" && _numberSelect == 0) label2.Text = "²√(" + label1.Text + ")";
                else if (_numberSelect == 0) label2.Text = "²√(" + label1.Text + ")";
                else label2.Text = _number[_numberSelect - 1] + " " + operators + " ²√(" + label1.Text + ")";
                label1.Text = _number[_numberSelect].ToString();
                if (_numberSelect == 0) file.AddToHistoryFile(label2.Text + " = " + label1.Text);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operators)
            {

                case "+":
                    _number[_numberSelect] = Convert.ToDouble(label1.Text);
                    label2.Text =_number[0].ToString()+" + " + _number[1];
                    _number[0] = operations.Addition(_number[0], _number[1]);
                    label1.Text = _number[0].ToString();
                    _numberSelect = 0;
                    file.AddToHistoryFile(label2.Text + " = " + label1.Text);
                    memoryOperation = "0";
                    break;
                case "-":
                    _number[_numberSelect] = Convert.ToDouble(label1.Text);
                    label2.Text = _number[0].ToString() + " - " + _number[1];
                    _number[0] = operations.Subtraction(_number[0], _number[1]);
                    label1.Text = _number[0].ToString();
                    _numberSelect = 0;
                    file.AddToHistoryFile(label2.Text + " = " + label1.Text);
                    memoryOperation = "0";
                    break;
                case "x":
                    _number[_numberSelect] = Convert.ToDouble(label1.Text);
                    label2.Text = _number[0].ToString() + " x " + _number[1];
                    _number[0] = operations.Multiplication(_number[0], _number[1]);
                    label1.Text = _number[0].ToString();
                    _numberSelect = 0;
                    file.AddToHistoryFile(label2.Text + " = " + label1.Text);
                    memoryOperation = "0";
                    break;
                case "/":
                    _number[_numberSelect] = Convert.ToDouble(label1.Text);
                    label2.Text = _number[0].ToString() + " / " + _number[1];
                    _number[0] = operations.Division(_number[0], _number[1]);
                    label1.Text = _number[0].ToString();
                    _numberSelect = 0;
                    file.AddToHistoryFile(label2.Text + " = " + label1.Text);
                    memoryOperation = "0";
                    break;
                case "mod":
                    _number[_numberSelect] = Convert.ToDouble(label1.Text);
                    label2.Text = _number[0].ToString() + " mod " + _number[1];
                    _number[0] = operations.Mod(_number[0], _number[1]);
                    label1.Text = _number[0].ToString();
                    _numberSelect = 0;
                    file.AddToHistoryFile(label2.Text + " = " + label1.Text);
                    memoryOperation = "0";
                    break;
                case "%":
                    _number[_numberSelect] = Convert.ToDouble(label1.Text);
                    label2.Text = _number[0].ToString() + "x %" + _number[1];
                    _number[0] = operations.Yuzde(_number[0], _number[1]);
                    label1.Text = _number[0].ToString();
                    _numberSelect = 0;
                    file.AddToHistoryFile(label2.Text + " = " + label1.Text);
                    memoryOperation = "0";
                    break;
                case "x^y":
                    _number[_numberSelect] = Convert.ToDouble(label1.Text);
                    label2.Text = _number[0].ToString() + "^" + _number[1];
                    _number[0] = operations.XusY(_number[0], (int)_number[1]);
                    label1.Text = _number[0].ToString();
                    _numberSelect = 0;
                    file.AddToHistoryFile(label2.Text + " = " + label1.Text);
                    memoryOperation = "0";
                    break;
                case "xy":
                    _number[_numberSelect] = Convert.ToDouble(label1.Text);
                    label2.Text = _number[1].ToString() + "√" + _number[0];
                    _number[0] = operations.YRoot(_number[0], _number[1]);
                    label1.Text = _number[0].ToString();
                    _numberSelect = 0;
                    file.AddToHistoryFile(label2.Text + " = " + label1.Text);
                    memoryOperation = "0";
                    break;

                default:
                    break;
            }
        }
    }
}
