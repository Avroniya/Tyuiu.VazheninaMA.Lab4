using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdinaryCalc.Lib;
using ArithmeticCalc.Lib;
using ConversionCalcFormVMA;
using WaterInTakeFormVMA;


namespace Tyuiu.VazheninaMA.Lab4
{
    public partial class MainFormVMA : Form
    {
        private double FirstValue;
        private string currentOperation;
        private OrdinaryCalcLib calculator;
        private ArithmeticCalcLib arifmetic_calculator;
        private Stack<double> valuesStack;
        private Stack<string> operationsStack;
        public MainFormVMA()
        {
            InitializeComponent();
            calculator = new OrdinaryCalcLib();
            arifmetic_calculator = new ArithmeticCalcLib();
            valuesStack = new Stack<double>();
            operationsStack = new Stack<string>();

            this.Size = new Size(400, 600);
            for (int i = 5; i < tableLayoutPanelChooseFunction.ColumnCount; i++)
            {
                tableLayoutPanelChooseFunction.ColumnStyles[i].SizeType = SizeType.Absolute;
                tableLayoutPanelChooseFunction.ColumnStyles[i].Width = 0;
            }
        }

        private void MainFormVMA_Load(object sender, EventArgs e)
        {
        }
        private void buttonZeroVMA_Click(object sender, EventArgs e)
        {
             AppendDigit("0");
        }

        private void buttonOneVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void buttonTwoVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void buttonThreeVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void buttonFourVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void buttonFiveVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void buttonSixVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void buttonSevenVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void buttonEightVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void buttonNineVMA_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (!textBoxShowResultVMA.Text.Contains(","))
            {
                textBoxShowResultVMA.Text += ",";
            }
        }

        private void buttonOperationSumma_Click(object sender, EventArgs e)
        {
            PushOperation("+");
        }

        private void buttonOperationDifference_Click(object sender, EventArgs e)
        {
            PushOperation("-");
        }

        private void buttonOperationMultiplication_Click(object sender, EventArgs e)
        {
            PushOperation("*");
        }

        private void buttonOperationQuotient_Click(object sender, EventArgs e)
        {
            PushOperation("/");
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            PushOperation("+-");
        }

        private void buttonOperationPercent_Click(object sender, EventArgs e)
        {
            PushOperation("%");
        }

        private void buttonFindSqrt_Click(object sender, EventArgs e)
        {
            PushOperation("sqrt");
        }

        private void buttonFindSquare_Click(object sender, EventArgs e)
        {
            PushOperation("square");
        }

        private void buttonFindReciprocal_Click(object sender, EventArgs e)
        {
            PushOperation("rec");
        }

        private void buttonFindLn_Click(object sender, EventArgs e)
        {
            PushOperation("ln");
        }

        private void buttonFindExp_Click(object sender, EventArgs e)
        {
            PushOperation("exp");
        }

        private void buttonFindPi_Click(object sender, EventArgs e)
        {
            double pi = arifmetic_calculator.CalcPi();
            textBoxShowResultVMA.Text = pi.ToString();
        }

        private void buttonFindCos_Click(object sender, EventArgs e)
        {
            PushOperation("cos");
        }

        private void buttonFindSin_Click(object sender, EventArgs e)
        {
            PushOperation("sin");
        }

        private void buttonFindTan_Click(object sender, EventArgs e)
        {
            PushOperation("tan");
        }

        private void buttonFindPowerOfTen_Click(object sender, EventArgs e)
        {
            PushOperation("powoften");
        }

        private void buttonFindPowerOfNumbers_Click(object sender, EventArgs e)
        {
            PushOperation("powofn");
        }

        private void buttonFindFactorial_Click(object sender, EventArgs e)
        {
            PushOperation("fact");
        }

        private void buttonFindAbs_Click(object sender, EventArgs e)
        {
            PushOperation("abs");
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (textBoxShowResultVMA.Text.Length > 0)
            {
                textBoxShowResultVMA.Text = textBoxShowResultVMA.Text.Substring(0, textBoxShowResultVMA.Text.Length - 1);
            }
        }

        private void buttonOperationResult_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }
        

        private void AppendDigit(string digit)
        {
            if (textBoxShowResultVMA.Text == "0" && digit != ",")
            {
                textBoxShowResultVMA.Text = digit;
            }
            else
            {
                textBoxShowResultVMA.Text += digit;
            }
        }

        private void PushOperation(string operation)
        {
            double currentValue = Convert.ToDouble(textBoxShowResultVMA.Text);
            valuesStack.Push(currentValue);
            operationsStack.Push(operation);
            textBoxShowResultVMA.Text = "0";
        }

        private void CalculateResult()
        {
            double currentValue = Convert.ToDouble(textBoxShowResultVMA.Text);
            valuesStack.Push(currentValue);

            while (operationsStack.Count > 0)
            {
                string operation = operationsStack.Pop();
                double value2 = valuesStack.Pop();
                double value1 = valuesStack.Pop();
                double result = PerformOperation(operation, value1, value2);
                valuesStack.Push(result);
            }

            double finalResult = valuesStack.Pop();
            textBoxShowResultVMA.Text = finalResult.ToString();

        }

        private double PerformOperation(string operation, double value1, double value2)
        {
            switch (operation)
            {
                case "+":
                    return calculator.CalcSumma(value1, value2);
                case "-":
                    return calculator.CalcDifference(value1, value2);
                case "*":
                    return calculator.CalcMultiplication(value1, value2);
                case "/":
                    return calculator.CalcQuotient(value1, value2);
                case "+-":
                    return -value1;
                case "%":
                    return calculator.CalcPercentage(value1);
                case "sqrt":
                    return calculator.CalcSquareRoot(value1);
                case "square":
                    return calculator.CalcSquare(value1);
                case "rec":
                    return calculator.CalcReciprocal(value1);
                case "ln":
                    return arifmetic_calculator.CalcNaturalLogarithm(value1);
                case "exp":
                    return arifmetic_calculator.CalcExponent(value1);

                case "cos":
                    return arifmetic_calculator.CalcCos(value1);
                case "sin":
                    return arifmetic_calculator.CalcSin(value1);
                case "tan":
                    return arifmetic_calculator.CalcTan(value1);
                case "powoften":
                    return arifmetic_calculator.CalcPowerOfTen(value1);
                case "powofn":
                    return arifmetic_calculator.CalcPowerOfNumber(value1, value2);
                case "fact":
                    return arifmetic_calculator.CalcFactorial(value1);
                case "abs":
                    return arifmetic_calculator.CalcAbsoluteValue(value1);
                default:
                    throw new InvalidOperationException("Неизвестная операция");
            }
        }

        private void ClearAll()
        {
            textBoxShowResultVMA.Clear();
            FirstValue = 0;
            currentOperation = string.Empty;
            valuesStack.Clear();
            operationsStack.Clear();
        }

      

        private void textBoxShowResultVMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(473, 483);
            for (int i = 5; i < tableLayoutPanelChooseFunction.ColumnCount; i++)
            {
                tableLayoutPanelChooseFunction.ColumnStyles[i].SizeType = SizeType.Absolute;
                tableLayoutPanelChooseFunction.ColumnStyles[i].Width = 0;
            }
        }

        private void переводЕдиницToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConversionFormVMA conversionForm = new ConversionFormVMA();
            conversionForm.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
                InfoFormVMA infoForm = new InfoFormVMA();
                infoForm.Show();
        }

        private void нормаВодыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WaterInTakeCalcFormVMA waterInTake = new WaterInTakeCalcFormVMA();
            waterInTake.Show();
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(679, 483);
            int columnCount = tableLayoutPanelChooseFunction.ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                tableLayoutPanelChooseFunction.ColumnStyles[i].SizeType = SizeType.Percent;
                tableLayoutPanelChooseFunction.ColumnStyles[i].Width = 100.0f / columnCount;
            }
        }
    }
}
