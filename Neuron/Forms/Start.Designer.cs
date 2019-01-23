namespace NeuralNetwork
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_draw_st = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bStudy = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_draw_st
            // 
            this.b_draw_st.Location = new System.Drawing.Point(55, 35);
            this.b_draw_st.Name = "b_draw_st";
            this.b_draw_st.Size = new System.Drawing.Size(122, 52);
            this.b_draw_st.TabIndex = 1;
            this.b_draw_st.Text = "Добавить варианты написания букв в обучающую выборку";
            this.b_draw_st.UseVisualStyleBackColor = true;
            this.b_draw_st.Click += new System.EventHandler(this.b_draw_st_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Распознавание букв М и К";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bStudy
            // 
            this.bStudy.Location = new System.Drawing.Point(55, 111);
            this.bStudy.Name = "bStudy";
            this.bStudy.Size = new System.Drawing.Size(122, 41);
            this.bStudy.TabIndex = 2;
            this.bStudy.Text = "Обучить нейронную сеть";
            this.bStudy.UseVisualStyleBackColor = true;
            this.bStudy.Click += new System.EventHandler(this.bStudy_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(32, 256);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 4;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 295);
            this.Controls.Add(this.info);
            this.Controls.Add(this.bStudy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_draw_st);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_draw_st;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bStudy;
        private System.Windows.Forms.Label info;
    }
}