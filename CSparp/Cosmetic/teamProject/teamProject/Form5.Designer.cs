namespace teamProject
{
    partial class Form5
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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.plotView3 = new OxyPlot.WindowsForms.PlotView();
            this.plotView4 = new OxyPlot.WindowsForms.PlotView();
            this.plotView5 = new OxyPlot.WindowsForms.PlotView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(12, 113);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(330, 137);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(458, 113);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(330, 137);
            this.plotView2.TabIndex = 1;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView3
            // 
            this.plotView3.Location = new System.Drawing.Point(12, 256);
            this.plotView3.Name = "plotView3";
            this.plotView3.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView3.Size = new System.Drawing.Size(330, 137);
            this.plotView3.TabIndex = 2;
            this.plotView3.Text = "plotView3";
            this.plotView3.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView3.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView3.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView4
            // 
            this.plotView4.Location = new System.Drawing.Point(458, 256);
            this.plotView4.Name = "plotView4";
            this.plotView4.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView4.Size = new System.Drawing.Size(330, 137);
            this.plotView4.TabIndex = 3;
            this.plotView4.Text = "plotView4";
            this.plotView4.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView4.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView4.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView5
            // 
            this.plotView5.Location = new System.Drawing.Point(12, 399);
            this.plotView5.Name = "plotView5";
            this.plotView5.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView5.Size = new System.Drawing.Size(330, 137);
            this.plotView5.TabIndex = 4;
            this.plotView5.Text = "plotView5";
            this.plotView5.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView5.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView5.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plotView5);
            this.Controls.Add(this.plotView4);
            this.Controls.Add(this.plotView3);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.plotView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private OxyPlot.WindowsForms.PlotView plotView4;
        private OxyPlot.WindowsForms.PlotView plotView5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}