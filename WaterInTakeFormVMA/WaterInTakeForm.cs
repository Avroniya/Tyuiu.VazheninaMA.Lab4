using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterInTakeCalc.Lib;
using WaterInTakeCalc.Test;

namespace WaterInTakeFormVMA
{
    public partial class WaterInTakeCalcFormVMA : Form
    {
        public WaterInTakeCalcFormVMA()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(textBoxWeightVMA.Text);
            double physicalActivity = double.Parse(textBoxPAVMA.Text);
            double result = 0;

            // Выбор формулы в зависимости от выбранного пола
            if (comboBoxChooseGenderVMA.SelectedItem.ToString() == "Мужчина")
            {
                result = weight * 0.035 + physicalActivity * 0.5;
            }
            else if (comboBoxChooseGenderVMA.SelectedItem.ToString() == "Женщина")
            {
                result = weight * 0.031 + physicalActivity * 0.5;
            }

            // Добавление дополнительной воды за каждый час физической нагрузки
            result += physicalActivity * 0.5;

            textBoxResultVMA.Text = result.ToString();
        }

        private void comboBoxChooseGenderVMA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
