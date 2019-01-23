using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class DrawPanel : UserControl
    {
        
        bool isClicked = false ;
        Point CurrentPoint;
        Point PrevPoint;
        Coordinates letterCoordinates;
        Bitmap myBitmap;
        Graphics figure;
        bool thereIsDrawing;

        public DrawPanel()
        {
            InitializeComponent();
            letterCoordinates = new Coordinates();
            myBitmap = new Bitmap(letterCoordinates.DefaultSize, letterCoordinates.DefaultSize);
            figure = Graphics.FromImage(myBitmap);
        }

        private void Clean()
        {
            thereIsDrawing = false;
            figure.Clear(Color.White);
            pictureBox.Invalidate();
            letterCoordinates.XMax = 0;
            letterCoordinates.YMin = letterCoordinates.DefaultSize;
            letterCoordinates.YMax = 0;
            letterCoordinates.XMin = letterCoordinates.DefaultSize;
        }
        private void StartDrawing(Point current)
        {
            thereIsDrawing = true;
            isClicked = true;
            CurrentPoint = current;
            letterCoordinates = Logic.ChangeMinAndMaxXY(letterCoordinates, CurrentPoint.X, CurrentPoint.Y);
        }
        private void DrawingLetter(Point current)
        {
            if (isClicked)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = current;
                Pen pen = new Pen(Color.DarkCyan, 8);
                figure.DrawLine(pen, PrevPoint, CurrentPoint);
                pictureBox.Image = myBitmap;
                letterCoordinates = Logic.ChangeMinAndMaxXY(letterCoordinates, current.X, current.Y);
            }
        }
        private void StopDrawing()
        {
            isClicked = false;
        }
        public Bitmap AreaSelection()
        {
            Rectangle cloneRect = new Rectangle(letterCoordinates.XMin - 4, letterCoordinates.YMin - 4, letterCoordinates.XMax - letterCoordinates.XMin + 6, letterCoordinates.YMax - letterCoordinates.YMin + 8);
            Bitmap cloneBitmap = myBitmap.Clone(cloneRect, myBitmap.PixelFormat);
            Pen pen = new Pen(Color.Red);
            figure.DrawRectangle(pen, cloneRect);
            pictureBox.Image = myBitmap;
            return cloneBitmap;
        }
        
        public bool BitmapNotEmpty()
        {
            return thereIsDrawing;
        }

        private void b_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            DrawingLetter(e.Location);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            StopDrawing(); 
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            StartDrawing(e.Location);
        }

    }
}
