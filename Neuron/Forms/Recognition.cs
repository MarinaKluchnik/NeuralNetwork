using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class Recognition : Form
    {
        public Recognition(Network net)
        {
            MyNet = net;
            InitializeComponent();
        }
        
        public Network MyNet;

        private void b_rec_Click(object sender, EventArgs e)
        {
            RecognizeLetter();
        }
                
        private void RecognizeLetter()
        {
            if (myDrawPanel.BitmapNotEmpty())
            {
                Bitmap cloneBitmap = myDrawPanel.AreaSelection();
                double y = Logic.CalculateResult(cloneBitmap, MyNet);
                cloneBitmap.Dispose();
                if (y > 0.5)
                    label1.Text = "Буква: K. ";
                else label1.Text = "Буква: M. ";
            }
        }
    }
    

}
