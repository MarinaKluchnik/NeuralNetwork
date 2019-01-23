using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NeuralNetwork
{
    static public class Logic
    {
        
        static public int[] SequenceCalculation(Bitmap cloneBitmap) //картинку в последовательность 0 и 1
        {
            //разбиваем область 10*10
            int x10 = cloneBitmap.Width / 10;
            int y10 = cloneBitmap.Height / 10;
            int x_ost = cloneBitmap.Width % 10; // сколько пикселей не попадают в сетку
            int y_ost = cloneBitmap.Height % 10;
            int[] results = new int[100];
            int y1 = 0;
            for (int j = 0; j < 10; j++)
            {
                int x1 = 0;
                int y2 = y10 + (y_ost > j ? 1 : 0);
                for (int i = 0; i < 10; i++)
                {
                    int x2 = x10 + (x_ost > i ? 1 : 0);
                    for (int k = 0; k < y2; k++)
                    {
                        for (int m = 0; m < x2; m++)
                            if (cloneBitmap.GetPixel(x1 + m, y1 + k).ToArgb() == Color.DarkCyan.ToArgb())
                            {
                                results[j * 10 + i] = 1;
                                break;
                            }
                    }
                    x1 += x2;
                }
                y1 += y2;
            }
            return results;
        }
        
        static public double CalculateResult(Bitmap bitmap, Network myNet)
        {
            int[] sequence = SequenceCalculation(bitmap);
            double[] results = new double[100];
            for (int i = 0; i < sequence.Length; i++)
                results[i] = (double)sequence[i];
            double y = myNet.CalculateOut(results);
            return y;
        }
        static public Coordinates ChangeMinAndMaxXY(Coordinates previousValues, int currentX, int currentY)
        {
            if (currentX > previousValues.XMax && currentX < previousValues.DefaultSize)
            {
                if (currentX > previousValues.DefaultSize - 6)
                    previousValues.XMax = currentX - 6;
                else
                    previousValues.XMax = currentX;
            }
            if (currentX < previousValues.XMin && currentX > 0)
            {
                if (currentX < 4)
                    previousValues.XMin = 4;
                else
                    previousValues.XMin = currentX;
            }
            if (currentY > previousValues.YMax && currentY < previousValues.DefaultSize)
            {
                if (currentY > previousValues.DefaultSize - 8)
                    previousValues.YMax = currentY - 8;
                else
                    previousValues.YMax = currentY;
            }
            if (currentY < previousValues.YMin && currentY > 0)
            {
                if (currentY < 4) previousValues.YMin = 4;
                else previousValues.YMin = currentY;
            }
            return previousValues;
        }
    }
}
