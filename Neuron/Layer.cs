using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Layer
    {
        private Neuron[] neurons;
        private double[] outputs;

        public Layer(int[] n, int c)
        {
            neurons = new Neuron[n[c]];
            if (c == 0)
                for (int i = 0; i < n[c]; i++)
                    Neurons[i] = new Neuron(n[c]);
            else
                for (int i = 0; i < n[c]; i++)
                    Neurons[i] = new Neuron(n[c - 1]);
            outputs = new double[n[c]];
        }
        
        public Neuron[] Neurons
        {
            get { return neurons; }
        }
        public double[] OutOfLayer(double[] input)
        {
            double[] out_l = new double[Neurons.Count()];
            for (int i = 0; i < Neurons.Count(); i++)
            {
                out_l[i] = Neurons[i].OutOfNeuron(input);
            }
            return out_l;
        }
        public void GenerateWeights(Random rnd)
        {
            foreach (Neuron n in Neurons)
                n.GenerateWeights(rnd);
        }
    }
}
