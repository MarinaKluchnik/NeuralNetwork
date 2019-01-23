using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Network
    {
        private const int PeriodsOfStudy = 25;
        private Layer[] layers;
        private List<double> GeneralizationError;
        private List<double> LearningError;
        private double h = 0.1;
        private bool isTrained;

        public Layer[] Layers
        {
            get { return layers; } 
        }
        public bool IsTrained
        {
            get { return isTrained; }
        }

        public Network(int[] n)
        {
            layers = new Layer[n.Count()];
            GeneralizationError = new List<double>();
            LearningError = new List<double>();
            for (int i = 0; i < n.Count(); i++)
                Layers[i] = new Layer(n, i);
        }
        public double CalculateOut(double[] input)
        {
            double[] o = input;
            for (int i = 0; i < Layers.Count(); i++)
                o = Layers[i].OutOfLayer(o);
            return o[0];
        }
        private void GenerateWaights() 
        { 
            Random rnd = new Random();
            foreach (Layer l in Layers)
                l.GenerateWeights(rnd);
        }
        public void Study(StudyData S)
        {
            int layersCount = Layers.Count();
            LearningError.Clear();
            GeneralizationError.Clear();
            GenerateWaights();
            for (int index = 0; index < PeriodsOfStudy; index++)
            {
                double o_ob = 0;
                for (int i = 0; i < S.Inputs.Count() * 0.7; i++)
                {
                    double y = CalculateOut(S.Inputs[i]);
                    double delta = S.Outputs[i] - y; // общая ошибка
                    List<double>[] deltaNeurons = new List<double>[layersCount];
                    for (int j = 0; j < layersCount; j++)
                        deltaNeurons[j] = new List<double>();
                    deltaNeurons[layersCount - 1].Add(delta);
                    for (int j = layersCount - 2; j >= 0; j--)
                    {
                        for (int n = 0; n < Layers[j].Neurons.Count(); n++) //подсчет ошибки для каждого нейрона в каждом слое
                        {
                            double a = 0;
                            for (int b = 0; b < Layers[j + 1].Neurons.Count(); b++)
                                a += Layers[j + 1].Neurons[b].Weights[n] * deltaNeurons[j + 1][b];
                            a = a * Layers[j].Neurons[n].Output * (1.0 - Layers[j].Neurons[n].Output);
                            deltaNeurons[j].Add(a);
                        }
                    }
                    double delta_w;
                    for (int j = 0; j < layersCount - 1; j++)
                        for (int n = 0; n < Layers[j].Neurons.Count(); n++)
                            for (int w = 0; w < Layers[j].Neurons[n].Weights.Count(); w++)
                            {
                                delta_w = h * deltaNeurons[j][n] * Layers[j].Neurons[n].Inputs[w];
                                Layers[j].Neurons[n].Weights[w] = Layers[j].Neurons[n].Weights[w] + delta_w;  //изменение весов
                            }
                }
                for (int i = 0; i < S.Inputs.Count() * 0.7; i++)
                {
                    double y = CalculateOut(S.Inputs[i]);
                    double delta = S.Outputs[i] - y;
                    o_ob += 0.5 * Math.Pow(delta, 2);
                }
                S.Mix(0.7);
                double o_test = 0;
                for (int i = Convert.ToInt32(S.Inputs.Count() * 0.7); i < S.Inputs.Count(); i++)
                {
                    double d = CalculateOut(S.Inputs[i]);
                    d = CalculateOut(S.Inputs[i]) - S.Outputs[i];
                    o_test += 0.5 * Math.Pow(d, 2);
                }
                GeneralizationError.Add(o_test / (Convert.ToInt32(S.Inputs.Count() * 0.3)));
                LearningError.Add(o_ob / (Convert.ToInt32(S.Inputs.Count() * 0.7)));
            }
            isTrained = true;
        }
    }
}
