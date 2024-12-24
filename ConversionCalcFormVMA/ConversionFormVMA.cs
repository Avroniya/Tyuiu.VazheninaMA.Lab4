using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversionCalc.Lib;

namespace ConversionCalcFormVMA
{
    public partial class ConversionFormVMA : Form
    {
        private ConversionCalcLib conversionCalc;
        public ConversionFormVMA()
        {
            InitializeComponent();
            conversionCalc = new ConversionCalcLib();
        }

        private string GetUnitAbbreviation(string fullUnitName)
        {
            switch (fullUnitName)
            {
                case "Килограммы (kg)": return "kg";
                case "Граммы (grams)": return "g";
                case "Тонны (tons)": return "tons";
                case "Фунты (lbs)": return "lbs";
                case "Унции (oz)": return "oz";
                case "Метры (m)": return "m";
                case "Сантиметры (cm)": return "cm";
                case "Миллиметры (mm)": return "mm";
                case "Километры (km)": return "km";
                case "Футы (ft)": return "ft";
                case "Дюймы (in)": return "in";
                case "Литры (l)": return "l";
                case "Миллилитры (ml)": return "ml";
                case "Галлоны (gal)": return "gal";
                case "Кубические метры (m3)": return "m3";
                default: return string.Empty;
            };
        }

        private void CalculateConversion(ComboBox inUnitComboBox, ComboBox outUnitComboBox, TextBox inputTextBox, TextBox outputTextBox)
        {
            if (double.TryParse(inputTextBox.Text, out double inputValue))
            {
                string inUnit = inUnitComboBox.SelectedItem?.ToString() ?? string.Empty;
                string outUnit = outUnitComboBox.SelectedItem?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(inUnit) || string.IsNullOrEmpty(outUnit))
                {
                    MessageBox.Show("Выберите входную и выходную единицы измерения.");
                    return;
                }

                inUnit = GetUnitAbbreviation(inUnit);
                outUnit = GetUnitAbbreviation(outUnit);

                try
                {
                    double result = conversionCalc.Convert(inputValue, inUnit, outUnit);
                    outputTextBox.Text = result.ToString();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void buttonCalulateWeightVMA_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInWeightVMA, comboBoxChooseOutWeightVMA, textBoxInputWeightVMA, textBoxOutputWeightVMA);
        }

        private void buttonCalculateLengthVMA_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInLengthVMA, comboBoxChooseOutLengthVMA, textBoxInputLengthVMA, textBoxOutputLengthVMA);
        }

        private void buttonCalculateVolumeVMA_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInVolumeVMA, comboBoxChooseOutVolumeVMA, textBoxInputVolumeVMA, textBoxOutputVolumeVMA);
        }

        private void panelConversionFormMainVMA_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
