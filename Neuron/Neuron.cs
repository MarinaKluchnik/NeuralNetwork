using System;
using System.Collections.Generic;
using System.Linq;
namespace NeuralNetwork
{
    public class Neuron
    {
        private double[] weights;
        private double[] inputs;
        private double output;

        public Neuron(int n)
        {
            weights = new double[n];
        }
        public double[] Weights
        {
            get { return weights; }           
        }
        public double[] Inputs
        {
            get { return inputs; }
        }
        public double Output
        {
            get { return output; }
        }
        private double Sumator(double[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Count(); i++)
                sum += input[i] * weights[i];
            return sum;
        }
        private double Sigmoid(double[] input)
        {
            Double sigm = 1 + Math.Exp(-Sumator(input));
            sigm = 1 / sigm;
            return sigm;
        }
        public double OutOfNeuron(double[] input)
        {
            inputs = input;
            output = Sigmoid(input);
            return output;
        }
        public void GenerateWeights(Random rnd)
        {
            for (int i = 0; i < weights.Count(); i++)
                weights[i] = rnd.Next(-10, 10) / 10.0;
        }
    }
}