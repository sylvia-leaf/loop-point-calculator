namespace Loop_Point_Calculator_2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_repeat = new GroupBox();
            textBox_repLength = new TextBox();
            numericUpDown_repEnd = new NumericUpDown();
            numericUpDown_repStart = new NumericUpDown();
            label_repLength = new Label();
            label_repEnd = new Label();
            label_repStart = new Label();
            groupBox_crossfade = new GroupBox();
            textBox_xfEnd = new TextBox();
            textBox_xfStart = new TextBox();
            numericUpDown_xfLength = new NumericUpDown();
            label_xfEnd = new Label();
            label_xfStart = new Label();
            label_xfLength = new Label();
            groupBox_loop = new GroupBox();
            textBox_loopEnd = new TextBox();
            textBox_loopStart = new TextBox();
            label_loopEnd = new Label();
            label_loopStart = new Label();
            button_help = new Button();
            button_license = new Button();
            groupBox_repeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_repEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_repStart).BeginInit();
            groupBox_crossfade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_xfLength).BeginInit();
            groupBox_loop.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_repeat
            // 
            groupBox_repeat.Controls.Add(textBox_repLength);
            groupBox_repeat.Controls.Add(numericUpDown_repEnd);
            groupBox_repeat.Controls.Add(numericUpDown_repStart);
            groupBox_repeat.Controls.Add(label_repLength);
            groupBox_repeat.Controls.Add(label_repEnd);
            groupBox_repeat.Controls.Add(label_repStart);
            groupBox_repeat.Location = new Point(12, 12);
            groupBox_repeat.Name = "groupBox_repeat";
            groupBox_repeat.Size = new Size(255, 100);
            groupBox_repeat.TabIndex = 0;
            groupBox_repeat.TabStop = false;
            groupBox_repeat.Text = "Repeat Region";
            // 
            // textBox_repLength
            // 
            textBox_repLength.Location = new Point(129, 70);
            textBox_repLength.Name = "textBox_repLength";
            textBox_repLength.ReadOnly = true;
            textBox_repLength.Size = new Size(120, 23);
            textBox_repLength.TabIndex = 7;
            textBox_repLength.Text = "0 Samples";
            // 
            // numericUpDown_repEnd
            // 
            numericUpDown_repEnd.Location = new Point(129, 44);
            numericUpDown_repEnd.Name = "numericUpDown_repEnd";
            numericUpDown_repEnd.Size = new Size(120, 23);
            numericUpDown_repEnd.TabIndex = 6;
            numericUpDown_repEnd.ValueChanged += numericUpDown_repEnd_ValueChanged;
            // 
            // numericUpDown_repStart
            // 
            numericUpDown_repStart.Location = new Point(129, 17);
            numericUpDown_repStart.Name = "numericUpDown_repStart";
            numericUpDown_repStart.Size = new Size(120, 23);
            numericUpDown_repStart.TabIndex = 5;
            numericUpDown_repStart.ValueChanged += numericUpDown_repStart_ValueChanged;
            // 
            // label_repLength
            // 
            label_repLength.AutoSize = true;
            label_repLength.Location = new Point(6, 73);
            label_repLength.Name = "label_repLength";
            label_repLength.Size = new Size(83, 15);
            label_repLength.TabIndex = 2;
            label_repLength.Text = "Repeat Length";
            // 
            // label_repEnd
            // 
            label_repEnd.AutoSize = true;
            label_repEnd.Location = new Point(6, 46);
            label_repEnd.Name = "label_repEnd";
            label_repEnd.Size = new Size(66, 15);
            label_repEnd.TabIndex = 1;
            label_repEnd.Text = "Repeat End";
            // 
            // label_repStart
            // 
            label_repStart.AutoSize = true;
            label_repStart.Location = new Point(6, 19);
            label_repStart.Name = "label_repStart";
            label_repStart.Size = new Size(70, 15);
            label_repStart.TabIndex = 0;
            label_repStart.Text = "Repeat Start";
            // 
            // groupBox_crossfade
            // 
            groupBox_crossfade.Controls.Add(textBox_xfEnd);
            groupBox_crossfade.Controls.Add(textBox_xfStart);
            groupBox_crossfade.Controls.Add(numericUpDown_xfLength);
            groupBox_crossfade.Controls.Add(label_xfEnd);
            groupBox_crossfade.Controls.Add(label_xfStart);
            groupBox_crossfade.Controls.Add(label_xfLength);
            groupBox_crossfade.Location = new Point(12, 118);
            groupBox_crossfade.Name = "groupBox_crossfade";
            groupBox_crossfade.Size = new Size(255, 100);
            groupBox_crossfade.TabIndex = 1;
            groupBox_crossfade.TabStop = false;
            groupBox_crossfade.Text = "Crossfade Region";
            // 
            // textBox_xfEnd
            // 
            textBox_xfEnd.Location = new Point(129, 70);
            textBox_xfEnd.Name = "textBox_xfEnd";
            textBox_xfEnd.ReadOnly = true;
            textBox_xfEnd.Size = new Size(120, 23);
            textBox_xfEnd.TabIndex = 9;
            textBox_xfEnd.Text = "0 Samples";
            // 
            // textBox_xfStart
            // 
            textBox_xfStart.Location = new Point(129, 43);
            textBox_xfStart.Name = "textBox_xfStart";
            textBox_xfStart.ReadOnly = true;
            textBox_xfStart.Size = new Size(120, 23);
            textBox_xfStart.TabIndex = 8;
            textBox_xfStart.Text = "0 Samples";
            // 
            // numericUpDown_xfLength
            // 
            numericUpDown_xfLength.Location = new Point(129, 17);
            numericUpDown_xfLength.Name = "numericUpDown_xfLength";
            numericUpDown_xfLength.Size = new Size(120, 23);
            numericUpDown_xfLength.TabIndex = 8;
            numericUpDown_xfLength.ValueChanged += numericUpDown_xfLength_ValueChanged;
            // 
            // label_xfEnd
            // 
            label_xfEnd.AutoSize = true;
            label_xfEnd.Location = new Point(6, 73);
            label_xfEnd.Name = "label_xfEnd";
            label_xfEnd.Size = new Size(82, 15);
            label_xfEnd.TabIndex = 5;
            label_xfEnd.Text = "Crossfade End";
            // 
            // label_xfStart
            // 
            label_xfStart.AutoSize = true;
            label_xfStart.Location = new Point(6, 46);
            label_xfStart.Name = "label_xfStart";
            label_xfStart.Size = new Size(86, 15);
            label_xfStart.TabIndex = 4;
            label_xfStart.Text = "Crossfade Start";
            // 
            // label_xfLength
            // 
            label_xfLength.AutoSize = true;
            label_xfLength.Location = new Point(6, 19);
            label_xfLength.Name = "label_xfLength";
            label_xfLength.Size = new Size(99, 15);
            label_xfLength.TabIndex = 3;
            label_xfLength.Text = "Crossfade Length";
            // 
            // groupBox_loop
            // 
            groupBox_loop.Controls.Add(textBox_loopEnd);
            groupBox_loop.Controls.Add(textBox_loopStart);
            groupBox_loop.Controls.Add(label_loopEnd);
            groupBox_loop.Controls.Add(label_loopStart);
            groupBox_loop.Location = new Point(273, 12);
            groupBox_loop.Name = "groupBox_loop";
            groupBox_loop.Size = new Size(254, 100);
            groupBox_loop.TabIndex = 2;
            groupBox_loop.TabStop = false;
            groupBox_loop.Text = "Final Loop Region";
            // 
            // textBox_loopEnd
            // 
            textBox_loopEnd.Location = new Point(86, 68);
            textBox_loopEnd.Name = "textBox_loopEnd";
            textBox_loopEnd.ReadOnly = true;
            textBox_loopEnd.Size = new Size(146, 23);
            textBox_loopEnd.TabIndex = 6;
            textBox_loopEnd.Text = "0 Samples";
            // 
            // textBox_loopStart
            // 
            textBox_loopStart.Location = new Point(86, 31);
            textBox_loopStart.Name = "textBox_loopStart";
            textBox_loopStart.ReadOnly = true;
            textBox_loopStart.Size = new Size(146, 23);
            textBox_loopStart.TabIndex = 5;
            textBox_loopStart.Text = "0 Samples";
            // 
            // label_loopEnd
            // 
            label_loopEnd.AutoSize = true;
            label_loopEnd.Location = new Point(6, 71);
            label_loopEnd.Name = "label_loopEnd";
            label_loopEnd.Size = new Size(57, 15);
            label_loopEnd.TabIndex = 4;
            label_loopEnd.Text = "Loop End";
            // 
            // label_loopStart
            // 
            label_loopStart.AutoSize = true;
            label_loopStart.Location = new Point(6, 34);
            label_loopStart.Name = "label_loopStart";
            label_loopStart.Size = new Size(61, 15);
            label_loopStart.TabIndex = 3;
            label_loopStart.Text = "Loop Start";
            // 
            // button_help
            // 
            button_help.Location = new Point(324, 164);
            button_help.Name = "button_help";
            button_help.Size = new Size(75, 23);
            button_help.TabIndex = 3;
            button_help.Text = "Help";
            button_help.UseVisualStyleBackColor = true;
            button_help.Click += button_help_Click;
            // 
            // button_license
            // 
            button_license.Location = new Point(405, 164);
            button_license.Name = "button_license";
            button_license.Size = new Size(75, 23);
            button_license.TabIndex = 4;
            button_license.Text = "License";
            button_license.UseVisualStyleBackColor = true;
            button_license.Click += button_license_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 234);
            Controls.Add(button_license);
            Controls.Add(button_help);
            Controls.Add(groupBox_loop);
            Controls.Add(groupBox_crossfade);
            Controls.Add(groupBox_repeat);
            Name = "Form1";
            Text = "Sylvia's Loop Point Calculator Ver.2.0";
            groupBox_repeat.ResumeLayout(false);
            groupBox_repeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_repEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_repStart).EndInit();
            groupBox_crossfade.ResumeLayout(false);
            groupBox_crossfade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_xfLength).EndInit();
            groupBox_loop.ResumeLayout(false);
            groupBox_loop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_repeat;
        private Label label_repLength;
        private Label label_repEnd;
        private Label label_repStart;
        private GroupBox groupBox_crossfade;
        private GroupBox groupBox_loop;
        private Button button_help;
        private Button button_license;
        private Label label_xfEnd;
        private Label label_xfStart;
        private Label label_xfLength;
        private Label label_loopEnd;
        private Label label_loopStart;
        private TextBox textBox_repLength;
        private NumericUpDown numericUpDown_repEnd;
        private NumericUpDown numericUpDown_repStart;
        private TextBox textBox_xfEnd;
        private TextBox textBox_xfStart;
        private NumericUpDown numericUpDown_xfLength;
        private TextBox textBox_loopEnd;
        private TextBox textBox_loopStart;
    }
}
