namespace NeuralNetwork
{
    partial class Recognition
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
            this.b_rec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.myDrawPanel = new NeuralNetwork.DrawPanel();
            this.SuspendLayout();
            // 
            // b_rec
            // 
            this.b_rec.Location = new System.Drawing.Point(231, 43);
            this.b_rec.Name = "b_rec";
            this.b_rec.Size = new System.Drawing.Size(104, 45);
            this.b_rec.TabIndex = 2;
            this.b_rec.Text = "Распознать";
            this.b_rec.UseVisualStyleBackColor = true;
            this.b_rec.Click += new System.EventHandler(this.b_rec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Буква: ";
            // 
            // myDrawPanel
            // 
            this.myDrawPanel.Location = new System.Drawing.Point(-5, 12);
            this.myDrawPanel.Name = "myDrawPanel";
            this.myDrawPanel.Size = new System.Drawing.Size(230, 239);
            this.myDrawPanel.TabIndex = 6;
            // 
            // Recognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 266);
            this.Controls.Add(this.myDrawPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_rec);
            this.Name = "Recognition";
            this.Text = "Recognition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_rec;
        private System.Windows.Forms.Label label1;
        private DrawPanel myDrawPanel;
    }
}