namespace Lab1
{
    partial class Newton
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.functionLimitBox = new System.Windows.Forms.TextBox();
            this.interval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LimitationBox = new System.Windows.Forms.TextBox();
            this.epsilonBox = new System.Windows.Forms.TextBox();
            this.rightLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.SecondIntervalLimitation = new System.Windows.Forms.TextBox();
            this.FirstIntervalLimitation = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.TextBox();
            this.pvGraph = new OxyPlot.WindowsForms.PlotView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.IterationLabel = new System.Windows.Forms.Label();
            this.IterationBox = new System.Windows.Forms.TextBox();
            this.GraphDesignLabel = new System.Windows.Forms.Label();
            this.MethodDesignLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "функции (полож. сторона)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "функции (отриц. сторона)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "осей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Число точек построения";
            // 
            // functionLimitBox
            // 
            this.functionLimitBox.Location = new System.Drawing.Point(30, 160);
            this.functionLimitBox.Name = "functionLimitBox";
            this.functionLimitBox.Size = new System.Drawing.Size(69, 20);
            this.functionLimitBox.TabIndex = 40;
            this.functionLimitBox.Text = "5";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(175, 163);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(69, 20);
            this.interval.TabIndex = 39;
            this.interval.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Необходимая точность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Epsilon";
            // 
            // LimitationBox
            // 
            this.LimitationBox.Location = new System.Drawing.Point(27, 394);
            this.LimitationBox.Name = "LimitationBox";
            this.LimitationBox.Size = new System.Drawing.Size(69, 20);
            this.LimitationBox.TabIndex = 36;
            this.LimitationBox.Text = "0";
            // 
            // epsilonBox
            // 
            this.epsilonBox.Location = new System.Drawing.Point(27, 338);
            this.epsilonBox.Name = "epsilonBox";
            this.epsilonBox.Size = new System.Drawing.Size(69, 20);
            this.epsilonBox.TabIndex = 35;
            this.epsilonBox.Text = "0,1";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(164, 274);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(115, 13);
            this.rightLabel.TabIndex = 34;
            this.rightLabel.Text = "Знач. для числ. дифф";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(24, 274);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(100, 13);
            this.leftLabel.TabIndex = 33;
            this.leftLabel.Text = "Нач. приближение";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(27, 70);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(83, 13);
            this.functionLabel.TabIndex = 31;
            this.functionLabel.Text = "Ваша функция:";
            // 
            // SecondIntervalLimitation
            // 
            this.SecondIntervalLimitation.Location = new System.Drawing.Point(167, 290);
            this.SecondIntervalLimitation.Name = "SecondIntervalLimitation";
            this.SecondIntervalLimitation.Size = new System.Drawing.Size(69, 20);
            this.SecondIntervalLimitation.TabIndex = 30;
            this.SecondIntervalLimitation.Text = "0,01";
            // 
            // FirstIntervalLimitation
            // 
            this.FirstIntervalLimitation.Location = new System.Drawing.Point(27, 290);
            this.FirstIntervalLimitation.Name = "FirstIntervalLimitation";
            this.FirstIntervalLimitation.Size = new System.Drawing.Size(69, 20);
            this.FirstIntervalLimitation.TabIndex = 29;
            this.FirstIntervalLimitation.Text = "0";
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(30, 86);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(276, 20);
            this.function.TabIndex = 28;
            this.function.Text = "-x^3+3*x^2+4";
            // 
            // pvGraph
            // 
            this.pvGraph.Location = new System.Drawing.Point(312, 12);
            this.pvGraph.Name = "pvGraph";
            this.pvGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pvGraph.Size = new System.Drawing.Size(476, 413);
            this.pvGraph.TabIndex = 27;
            this.pvGraph.Text = "plotView1";
            this.pvGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pvGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pvGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Построить";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Искать";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // IterationLabel
            // 
            this.IterationLabel.AutoSize = true;
            this.IterationLabel.Location = new System.Drawing.Point(164, 322);
            this.IterationLabel.Name = "IterationLabel";
            this.IterationLabel.Size = new System.Drawing.Size(89, 13);
            this.IterationLabel.TabIndex = 50;
            this.IterationLabel.Text = "Число итераций";
            // 
            // IterationBox
            // 
            this.IterationBox.Location = new System.Drawing.Point(167, 338);
            this.IterationBox.Name = "IterationBox";
            this.IterationBox.Size = new System.Drawing.Size(69, 20);
            this.IterationBox.TabIndex = 49;
            this.IterationBox.Text = "10";
            // 
            // GraphDesignLabel
            // 
            this.GraphDesignLabel.AutoSize = true;
            this.GraphDesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphDesignLabel.Location = new System.Drawing.Point(26, 36);
            this.GraphDesignLabel.Name = "GraphDesignLabel";
            this.GraphDesignLabel.Size = new System.Drawing.Size(254, 20);
            this.GraphDesignLabel.TabIndex = 51;
            this.GraphDesignLabel.Text = "Настройка построения графика";
            // 
            // MethodDesignLabel
            // 
            this.MethodDesignLabel.AutoSize = true;
            this.MethodDesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodDesignLabel.Location = new System.Drawing.Point(23, 240);
            this.MethodDesignLabel.Name = "MethodDesignLabel";
            this.MethodDesignLabel.Size = new System.Drawing.Size(213, 20);
            this.MethodDesignLabel.TabIndex = 52;
            this.MethodDesignLabel.Text = "Настройка работы метода";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(167, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 74);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 51);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Максимум";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Минимум";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Пересечение";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Newton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MethodDesignLabel);
            this.Controls.Add(this.GraphDesignLabel);
            this.Controls.Add(this.IterationLabel);
            this.Controls.Add(this.IterationBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.functionLimitBox);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimitationBox);
            this.Controls.Add(this.epsilonBox);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.SecondIntervalLimitation);
            this.Controls.Add(this.FirstIntervalLimitation);
            this.Controls.Add(this.function);
            this.Controls.Add(this.pvGraph);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Newton";
            this.Text = "Newton";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox functionLimitBox;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LimitationBox;
        private System.Windows.Forms.TextBox epsilonBox;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox SecondIntervalLimitation;
        private System.Windows.Forms.TextBox FirstIntervalLimitation;
        private System.Windows.Forms.TextBox function;
        public OxyPlot.WindowsForms.PlotView pvGraph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        internal System.Windows.Forms.Label IterationLabel;
        private System.Windows.Forms.TextBox IterationBox;
        private System.Windows.Forms.Label GraphDesignLabel;
        private System.Windows.Forms.Label MethodDesignLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}