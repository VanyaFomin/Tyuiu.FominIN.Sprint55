using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FominIN.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string inputFile = @"C:\DataSprint5\InPutDataFileTask7V19.txt";
            string outputFile = @"C:\DataSprint5\OutPutDataFileTask7V19.txt";

            string data = File.ReadAllText(inputFile);
            data = data.Replace("сс", "с");

            File.WriteAllText(outputFile, data);

            return data.Length.ToString();
        }
    }
}
