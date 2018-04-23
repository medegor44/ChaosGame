namespace Chaos_game
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.mainCanvas = new System.Windows.Forms.PictureBox();
            this.posA = new System.Windows.Forms.TextBox();
            this.posB = new System.Windows.Forms.TextBox();
            this.posC = new System.Windows.Forms.TextBox();
            this.posX_0 = new System.Windows.Forms.TextBox();
            this.iterations = new System.Windows.Forms.TextBox();
            this.draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cntA = new System.Windows.Forms.TrackBar();
            this.cntB = new System.Windows.Forms.TrackBar();
            this.cntC = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.probs = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntC)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.Location = new System.Drawing.Point(12, 12);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(760, 737);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
            this.mainCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseDown);
            // 
            // posA
            // 
            this.posA.Location = new System.Drawing.Point(778, 12);
            this.posA.Name = "posA";
            this.posA.Size = new System.Drawing.Size(118, 20);
            this.posA.TabIndex = 1;
            // 
            // posB
            // 
            this.posB.Location = new System.Drawing.Point(778, 38);
            this.posB.Name = "posB";
            this.posB.Size = new System.Drawing.Size(118, 20);
            this.posB.TabIndex = 2;
            // 
            // posC
            // 
            this.posC.Location = new System.Drawing.Point(779, 65);
            this.posC.Name = "posC";
            this.posC.Size = new System.Drawing.Size(117, 20);
            this.posC.TabIndex = 3;
            // 
            // posX_0
            // 
            this.posX_0.Location = new System.Drawing.Point(779, 92);
            this.posX_0.Name = "posX_0";
            this.posX_0.Size = new System.Drawing.Size(117, 20);
            this.posX_0.TabIndex = 4;
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(779, 119);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(117, 20);
            this.iterations.TabIndex = 5;
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(779, 314);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(117, 49);
            this.draw.TabIndex = 6;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(902, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(902, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X_0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(902, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Iterations";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(779, 370);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(117, 51);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cntA
            // 
            this.cntA.Location = new System.Drawing.Point(778, 145);
            this.cntA.Name = "cntA";
            this.cntA.Size = new System.Drawing.Size(118, 45);
            this.cntA.TabIndex = 13;
            // 
            // cntB
            // 
            this.cntB.Location = new System.Drawing.Point(779, 196);
            this.cntB.Name = "cntB";
            this.cntB.Size = new System.Drawing.Size(117, 45);
            this.cntB.TabIndex = 14;
            // 
            // cntC
            // 
            this.cntC.Location = new System.Drawing.Point(779, 247);
            this.cntC.Name = "cntC";
            this.cntC.Size = new System.Drawing.Size(117, 45);
            this.cntC.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.probs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 759);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(953, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // probs
            // 
            this.probs.Name = "probs";
            this.probs.Size = new System.Drawing.Size(118, 17);
            this.probs.Text = "toolStripStatusLabel1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(902, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "P(A)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(902, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "P(B)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(902, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "P(C)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 781);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cntC);
            this.Controls.Add(this.cntB);
            this.Controls.Add(this.cntA);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.iterations);
            this.Controls.Add(this.posX_0);
            this.Controls.Add(this.posC);
            this.Controls.Add(this.posB);
            this.Controls.Add(this.posA);
            this.Controls.Add(this.mainCanvas);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.Text = "Chaos game";
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntC)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.TextBox posA;
        private System.Windows.Forms.TextBox posB;
        private System.Windows.Forms.TextBox posC;
        private System.Windows.Forms.TextBox posX_0;
        private System.Windows.Forms.TextBox iterations;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TrackBar cntA;
        private System.Windows.Forms.TrackBar cntB;
        private System.Windows.Forms.TrackBar cntC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel probs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

