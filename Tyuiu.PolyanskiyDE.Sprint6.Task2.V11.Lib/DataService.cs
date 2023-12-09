﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PolyanskiyDE.Sprint6.Task2.V11.Lib
{
    public class DataService : ISprint6Task2V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Cos(x)) / (x + 1)) - Math.Cos(x) * 1.3 + 3 * x, 2);
                if (!double.IsNaN(y) && !double.IsInfinity(y))
                {
                    valueArray[count] = y;
                }
                else
                {
                    valueArray[count] = 0;
                }
                count++;
            }
            return valueArray;
        }
    }
}
