using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class Start : Form
    {
        static int[] l = { 100, 50, 25, 10, 1 };
        public Network MyNet;

        public Start()
        {
            InitializeComponent();
        }

        private void Training()
        {
            info.Text = "Идет обучение...";
            using (var ChooseFolder = new FolderBrowserDialog())
            {
                ChooseFolder.Description = "Выберите папку с обучающей выборкой";
                DialogResult result = ChooseFolder.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ChooseFolder.SelectedPath))
                {
                    string path = ChooseFolder.SelectedPath;
                    StudyData data = WorkWithFiles.ReadData(System.IO.Path.Combine(path, "Study.txt"));
                    if (data.Inputs.Count() > 0)
                    {
                        MyNet.Study(data);
                        info.Text = "Обучение завершено.";
                        return;
                    }
                }
                info.Text = "";
            }
        }

        private void b_draw_st_Click(object sender, EventArgs e)
        {
            Adding f = new  Adding();
            if (!f.IsDisposed)
                f.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MyNet != null && MyNet.IsTrained)
            {
                Form f = new Recognition(MyNet);
                f.ShowDialog();
            }
            else
                info.Text = "Сначала необходимо обучить сеть.";
        }
        private void bStudy_Click(object sender, EventArgs e)
        {
            MyNet = new Network(l);
            Training();
        }
    }
}
