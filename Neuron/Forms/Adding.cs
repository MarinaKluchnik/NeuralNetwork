using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class Adding : Form
    {
        string path;

        public Adding()
        {
            using (var ChooseFolder = new FolderBrowserDialog())
            {
                ChooseFolder.Description = "Выберите папку с обучающей выборкой";
                DialogResult result = ChooseFolder.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ChooseFolder.SelectedPath))
                {
                    path = ChooseFolder.SelectedPath;
                    InitializeComponent();
                }
                else
                {
                    this.Close();
                }
            }
        }
                
        private void SaveLetter(int output)
        {
            if (myDrawPanel.BitmapNotEmpty())
            {
                Bitmap cloneBitmap = myDrawPanel.AreaSelection();
                int[] results = Logic.SequenceCalculation(cloneBitmap);
                cloneBitmap.Dispose();
                WorkWithFiles.WriteToFile(System.IO.Path.Combine(path, "Study.txt"), results, output);
                WriteToTextBox(results);
            }
        }
        
        private void WriteToTextBox(int[] results)
        {
            int c = 0;
            textBox1.Text = "";
            for (int i = 0; i < results.Count(); i++)
            {
                textBox1.Text += results[i] + " ";
                c++;
                if (c == 10)
                {
                    textBox1.Text += Environment.NewLine;
                    c = 0;
                }
            }
        }

        private void b_save_M_Click(object sender, EventArgs e)
        {
            SaveLetter(0);
        }

        private void b_save_K_Click(object sender, EventArgs e)
        {
            SaveLetter(1);
        }
    }
}
