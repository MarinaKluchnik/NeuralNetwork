using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    static public class WorkWithFiles
    {        
        static public void WriteToFile(string path, int[] results, int output)
        {
            using (System.IO.StreamWriter stream = new System.IO.StreamWriter(path, true))
            {
                foreach (int el in results)
                    stream.Write(el);
                stream.Write(output);
                stream.WriteLine();
            }
        }
        static public StudyData ReadData(string path)
        {
            StudyData data = new StudyData();
            try
            {
                double[] input;
                double output;
                System.IO.StreamReader stream = new System.IO.StreamReader(path);
                string str = stream.ReadLine();
                while (str != "" && str != null)
                {
                    input = new double[100];
                    for (int i = 0; i < 100; i++)
                        input[i] = Int32.Parse(str[i].ToString());
                    output = Int32.Parse(str[100].ToString());
                    data.AddValue(input, output);                    
                    str = stream.ReadLine();
                }
                stream.Close();
                data.Mix(1);
                return data;
            }
            catch
            {
                MessageBox.Show("Ошибка чтения обучающей выборки.");
                return new StudyData();
            }
        }
    }
}
