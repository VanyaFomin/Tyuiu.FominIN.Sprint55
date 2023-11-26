using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FominIN.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double sum = 0;

            foreach (string line in lines)
            {
                string[] values = line.Split(' ');
                foreach (string value in values)
                {
                    if (double.TryParse(value.Replace(',', '.'), out double number))
                    {
                        if (number % 2 == 0)
                        {
                            sum += number;
                        }
                    }
                }
            }

            return Math.Round(sum, 3);
        }
    }
}
