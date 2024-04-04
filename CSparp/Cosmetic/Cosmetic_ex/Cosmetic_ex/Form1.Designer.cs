namespace Cosmetic_ex
{
           partial class Form1
        {
            /// <summary>
            /// 필수 디자이너 변수입니다.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// 사용 중인 모든 리소스를 정리합니다.
            /// </summary>
            /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form 디자이너에서 생성한 코드

            /// <summary>
            /// 디자이너 지원에 필요한 메서드입니다. 
            /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
            /// </summary>
            private void InitializeComponent()
            {
                this.dataGridView1 = new System.Windows.Forms.DataGridView();
                this.button1 = new System.Windows.Forms.Button();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.button4 = new System.Windows.Forms.Button();
                this.dataGridView2 = new System.Windows.Forms.DataGridView();
                this.groupBox1 = new System.Windows.Forms.GroupBox();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.button5 = new System.Windows.Forms.Button();
                this.groupBox2 = new System.Windows.Forms.GroupBox();
                this.groupBox3 = new System.Windows.Forms.GroupBox();
                this.menuStrip1 = new System.Windows.Forms.ToolStrip();
                this.ToolStrip0 = new System.Windows.Forms.ToolStripLabel();
                this.ToolStrip1 = new System.Windows.Forms.ToolStripLabel();
                this.ToolStrip2 = new System.Windows.Forms.ToolStripLabel();
                this.ToolStrip3 = new System.Windows.Forms.ToolStripLabel();
                this.ToolStrip4 = new System.Windows.Forms.ToolStripLabel();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
                this.groupBox1.SuspendLayout();
                this.groupBox2.SuspendLayout();
                this.groupBox3.SuspendLayout();
                this.menuStrip1.SuspendLayout();
                this.SuspendLayout();
                // 
                // dataGridView1
                // 
                this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView1.Location = new System.Drawing.Point(6, 20);
                this.dataGridView1.Name = "dataGridView1";
                this.dataGridView1.RowTemplate.Height = 23;
                this.dataGridView1.Size = new System.Drawing.Size(1139, 485);
                this.dataGridView1.TabIndex = 0;
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(6, 49);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(121, 23);
                this.button1.TabIndex = 1;
                this.button1.Text = "공정 조건 조회";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(133, 51);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(219, 21);
                this.textBox1.TabIndex = 3;
                // 
                // button4
                // 
                this.button4.Location = new System.Drawing.Point(6, 19);
                this.button4.Name = "button4";
                this.button4.Size = new System.Drawing.Size(121, 23);
                this.button4.TabIndex = 14;
                this.button4.Text = "전체 조회";
                this.button4.UseVisualStyleBackColor = true;
                this.button4.Click += new System.EventHandler(this.button4_Click);
                // 
                // dataGridView2
                // 
                this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView2.Location = new System.Drawing.Point(6, 20);
                this.dataGridView2.Name = "dataGridView2";
                this.dataGridView2.RowTemplate.Height = 23;
                this.dataGridView2.Size = new System.Drawing.Size(1139, 404);
                this.dataGridView2.TabIndex = 15;
                // 
                // groupBox1
                // 
                this.groupBox1.Controls.Add(this.textBox2);
                this.groupBox1.Controls.Add(this.button5);
                this.groupBox1.Controls.Add(this.button4);
                this.groupBox1.Controls.Add(this.button1);
                this.groupBox1.Controls.Add(this.textBox1);
                this.groupBox1.Location = new System.Drawing.Point(12, 28);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Size = new System.Drawing.Size(1151, 116);
                this.groupBox1.TabIndex = 16;
                this.groupBox1.TabStop = false;
                this.groupBox1.Text = "데이터 조회";
                // 
                // textBox2
                // 
                this.textBox2.Location = new System.Drawing.Point(133, 80);
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(219, 21);
                this.textBox2.TabIndex = 16;
                // 
                // button5
                // 
                this.button5.Location = new System.Drawing.Point(6, 78);
                this.button5.Name = "button5";
                this.button5.Size = new System.Drawing.Size(121, 23);
                this.button5.TabIndex = 15;
                this.button5.Text = "QC 조건 조회";
                this.button5.UseVisualStyleBackColor = true;
                this.button5.Click += new System.EventHandler(this.button5_Click);
                // 
                // groupBox2
                // 
                this.groupBox2.Controls.Add(this.dataGridView1);
                this.groupBox2.Location = new System.Drawing.Point(12, 150);
                this.groupBox2.Name = "groupBox2";
                this.groupBox2.Size = new System.Drawing.Size(1151, 511);
                this.groupBox2.TabIndex = 17;
                this.groupBox2.TabStop = false;
                this.groupBox2.Text = "공정 데이터";
                // 
                // groupBox3
                // 
                this.groupBox3.Controls.Add(this.dataGridView2);
                this.groupBox3.Location = new System.Drawing.Point(12, 667);
                this.groupBox3.Name = "groupBox3";
                this.groupBox3.Size = new System.Drawing.Size(1151, 430);
                this.groupBox3.TabIndex = 17;
                this.groupBox3.TabStop = false;
                this.groupBox3.Text = "QC 데이터";
                // 
                // menuStrip1
                // 
                this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip0,
            this.ToolStrip1,
            this.ToolStrip2,
            this.ToolStrip3,
            this.ToolStrip4});
                this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                this.menuStrip1.Name = "menuStrip1";
                this.menuStrip1.Size = new System.Drawing.Size(1171, 25);
                this.menuStrip1.TabIndex = 18;
                this.menuStrip1.Text = "데이터 관리";
                // 
                // ToolStrip0
                // 
                this.ToolStrip0.Name = "ToolStrip0";
                this.ToolStrip0.Size = new System.Drawing.Size(39, 22);
                this.ToolStrip0.Text = "[메인]";
                this.ToolStrip0.Click += new System.EventHandler(this.ToolStrip0_Click);
                // 
                // ToolStrip1
                // 
                this.ToolStrip1.Name = "ToolStrip1";
                this.ToolStrip1.Size = new System.Drawing.Size(107, 22);
                this.ToolStrip1.Text = "[공정 데이터 관리]";
                this.ToolStrip1.Click += new System.EventHandler(this.ToolStrip1_Click);
                // 
                // ToolStrip2
                // 
                this.ToolStrip2.Name = "ToolStrip2";
                this.ToolStrip2.Size = new System.Drawing.Size(100, 22);
                this.ToolStrip2.Text = "[QC 데이터 관리]";
                this.ToolStrip2.Click += new System.EventHandler(this.ToolStrip2_Click);
                // 
                // ToolStrip3
                // 
                this.ToolStrip3.Name = "ToolStrip3";
                this.ToolStrip3.Size = new System.Drawing.Size(67, 22);
                this.ToolStrip3.Text = "[공정 차트]";
                this.ToolStrip3.Click += new System.EventHandler(this.ToolStrip3_Click);
                // 
                // ToolStrip4
                // 
                this.ToolStrip4.Name = "ToolStrip4";
                this.ToolStrip4.Size = new System.Drawing.Size(60, 22);
                this.ToolStrip4.Text = "[QC 차트]";
                this.ToolStrip4.Click += new System.EventHandler(this.ToolStrip4_Click);
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScroll = true;
                this.BackColor = System.Drawing.SystemColors.Control;
                this.ClientSize = new System.Drawing.Size(1171, 1108);
                this.Controls.Add(this.menuStrip1);
                this.Controls.Add(this.groupBox3);
                this.Controls.Add(this.groupBox2);
                this.Controls.Add(this.groupBox1);
                this.Name = "Form1";
                this.Text = "화장품 생산 관리 프로그램";
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                this.groupBox2.ResumeLayout(false);
                this.groupBox3.ResumeLayout(false);
                this.menuStrip1.ResumeLayout(false);
                this.menuStrip1.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.DataGridView dataGridView1;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.Button button4;
            private System.Windows.Forms.DataGridView dataGridView2;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.GroupBox groupBox2;
            private System.Windows.Forms.GroupBox groupBox3;
            private System.Windows.Forms.ToolStrip menuStrip1;
            private System.Windows.Forms.ToolStripLabel ToolStrip1;
            private System.Windows.Forms.ToolStripLabel ToolStrip2;
            private System.Windows.Forms.ToolStripLabel ToolStrip3;
            private System.Windows.Forms.ToolStripLabel ToolStrip4;
            private System.Windows.Forms.ToolStripLabel ToolStrip0;
            private System.Windows.Forms.Button button5;
            private System.Windows.Forms.TextBox textBox2;
        }
    }
