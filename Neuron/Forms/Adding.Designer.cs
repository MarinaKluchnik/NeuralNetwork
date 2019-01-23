namespace NeuralNetwork
{
    partial class Adding
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_save_M = new System.Windows.Forms.Button();
            this.b_save_K = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myDrawPanel = new NeuralNetwork.DrawPanel();
            this.SuspendLayout();
            // 
            // b_save_M
            // 
            this.b_save_M.Location = new System.Drawing.Point(238, 52);
            this.b_save_M.Name = "b_save_M";
            this.b_save_M.Size = new System.Drawing.Size(91, 44);
            this.b_save_M.TabIndex = 1;
            this.b_save_M.Text = " М";
            this.b_save_M.UseVisualStyleBackColor = true;
            this.b_save_M.Click += new System.EventHandler(this.b_save_M_Click);
            // 
            // b_save_K
            // 
            this.b_save_K.Location = new System.Drawing.Point(238, 122);
            this.b_save_K.Name = "b_save_K";
            this.b_save_K.Size = new System.Drawing.Size(91, 44);
            this.b_save_K.TabIndex = 2;
            this.b_save_K.Text = "К";
            this.b_save_K.UseVisualStyleBackColor = true;
            this.b_save_K.Click += new System.EventHandler(this.b_save_K_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 155);
            this.textBox1.TabIndex = 3;
            // 
            // myDrawPanel
            // 
            this.myDrawPanel.Location = new System.Drawing.Point(1, 22);
            this.myDrawPanel.Name = "myDrawPanel";
            this.myDrawPanel.Size = new System.Drawing.Size(220, 252);
            this.myDrawPanel.TabIndex = 4;
            // 
            // Adding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 324);
            this.Controls.Add(this.myDrawPanel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_save_K);
            this.Controls.Add(this.b_save_M);
            this.Name = "Adding";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_save_M;
        private System.Windows.Forms.Button b_save_K;
        private System.Windows.Forms.TextBox textBox1;
        private DrawPanel myDrawPanel;
    }
}

