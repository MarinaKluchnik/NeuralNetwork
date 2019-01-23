using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Coordinates
    {
        private const int defaultSize = 155;
        private int xMin;
        private int xMax;
        private int yMin;
        private int yMax;

        public Coordinates()
        {
            xMin = defaultSize;
            xMax = 0;
            yMin = defaultSize;
            yMax = 0;
        }
        public int DefaultSize
        {
            get { return defaultSize; }
        }
        public int XMin
        {
            get { return xMin; }
            set { xMin = value; }
        }
        public int XMax
        {
            get { return xMax; }
            set { xMax = value; }
        }
        public int YMin
        {
            get { return yMin; }
            set { yMin = value; }
        }
        public int YMax
        {
            get { return yMax; }
            set { yMax = value; }
        }
    }
}
