using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterInTakeCalc.Lib
{
    public class WaterInTakeCalcLib
    {
        public static double CalculateWaterIntake(double weight, int hoursOfExercise, string gender)
        {
            if (weight <= 0 || hoursOfExercise < 0)
                throw new ArgumentException("Вес и количество часов физической нагрузки должны быть положительными.");

            double baseWaterIntake;

            if (gender.ToLower() == "мужчина")
            {
                baseWaterIntake = weight * 0.035;
            }
            else if (gender.ToLower() == "женщина")
            {
                baseWaterIntake = weight * 0.031;
            }
            else
            {
                throw new ArgumentException("Неизвестный пол. Укажите 'мужчина' или 'женщина'.");
            }

            double additionalWater = hoursOfExercise * 0.5;
            return baseWaterIntake + additionalWater;
        }
    }
}
