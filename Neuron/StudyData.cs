using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public class StudyData
    {
        private List<double[]> inputs;
        private List<double> outputs;

        public StudyData()
        {
            inputs = new List<double[]>();
            outputs = new List<double>();
        }
        public List<double[]> Inputs
        {
            get { return inputs; }
        }
        public List<double> Outputs
        {
            get { return outputs; }
        }
        
        public void AddValue(double[] input,  double output)
        {
            inputs.Add(input);
            outputs.Add(output);
        }

        public void Mix(double part)
        {
            var rand = new Random();
            int length = (int)(inputs.Count() * part) - 1;
            for (int i = length; i >= 0; i--)
            {
                int j = rand.Next(0, length);
                var temp = inputs[i];
                inputs[i] = inputs[j];
                inputs[j] = temp;
                double t = outputs[i];
                outputs[i] = outputs[j];
                outputs[j] = t;
            }
        }
    }
}
