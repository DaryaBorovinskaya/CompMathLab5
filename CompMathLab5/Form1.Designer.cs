namespace CompMathLab5
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
            labelFunc = new Label();
            labelLowerLimit = new Label();
            labelUpperLimit = new Label();
            numericUpperLimit = new NumericUpDown();
            numericLowerLimit = new NumericUpDown();
            comboBoxMethods = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            numericAccuracy = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            textIntegral = new TextBox();
            textStep = new TextBox();
            buttonApplyMethod = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpperLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericLowerLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAccuracy).BeginInit();
            SuspendLayout();
            // 
            // labelFunc
            // 
            labelFunc.AutoSize = true;
            labelFunc.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFunc.Location = new Point(331, 39);
            labelFunc.Name = "labelFunc";
            labelFunc.Size = new Size(336, 39);
            labelFunc.TabIndex = 0;
            labelFunc.Text = "f(x) = (1+x)/((3x+2)^2)";
            // 
            // labelLowerLimit
            // 
            labelLowerLimit.AutoSize = true;
            labelLowerLimit.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLowerLimit.Location = new Point(17, 210);
            labelLowerLimit.Name = "labelLowerLimit";
            labelLowerLimit.Size = new Size(458, 39);
            labelLowerLimit.TabIndex = 1;
            labelLowerLimit.Text = "Нижний предел интегрирования";
            // 
            // labelUpperLimit
            // 
            labelUpperLimit.AutoSize = true;
            labelUpperLimit.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUpperLimit.Location = new Point(15, 124);
            labelUpperLimit.Name = "labelUpperLimit";
            labelUpperLimit.Size = new Size(464, 39);
            labelUpperLimit.TabIndex = 2;
            labelUpperLimit.Text = "Верхний предел интегрирования";
            // 
            // numericUpperLimit
            // 
            numericUpperLimit.DecimalPlaces = 5;
            numericUpperLimit.Font = new Font("Segoe UI", 12F);
            numericUpperLimit.Location = new Point(483, 129);
            numericUpperLimit.Name = "numericUpperLimit";
            numericUpperLimit.Size = new Size(106, 34);
            numericUpperLimit.TabIndex = 3;
            numericUpperLimit.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // numericLowerLimit
            // 
            numericLowerLimit.DecimalPlaces = 5;
            numericLowerLimit.Font = new Font("Segoe UI", 12F);
            numericLowerLimit.Location = new Point(483, 215);
            numericLowerLimit.Name = "numericLowerLimit";
            numericLowerLimit.Size = new Size(106, 34);
            numericLowerLimit.TabIndex = 4;
            numericLowerLimit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxMethods
            // 
            comboBoxMethods.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMethods.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxMethods.FormattingEnabled = true;
            comboBoxMethods.Items.AddRange(new object[] { "Левых прямоугольников", "Трапеций", "4-го порядка" });
            comboBoxMethods.Location = new Point(146, 315);
            comboBoxMethods.Name = "comboBoxMethods";
            comboBoxMethods.Size = new Size(369, 46);
            comboBoxMethods.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(645, 168);
            label1.Name = "label1";
            label1.Size = new Size(142, 39);
            label1.TabIndex = 6;
            label1.Text = "Точность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(17, 311);
            label2.Name = "label2";
            label2.Size = new Size(103, 39);
            label2.TabIndex = 7;
            label2.Text = "Метод";
            // 
            // numericAccuracy
            // 
            numericAccuracy.DecimalPlaces = 10;
            numericAccuracy.Font = new Font("Segoe UI", 12F);
            numericAccuracy.Location = new Point(851, 173);
            numericAccuracy.Maximum = new decimal(new int[] { 1, 0, 0, 65536 });
            numericAccuracy.Name = "numericAccuracy";
            numericAccuracy.Size = new Size(166, 34);
            numericAccuracy.TabIndex = 8;
            numericAccuracy.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(207, 501);
            label3.Name = "label3";
            label3.Size = new Size(287, 39);
            label3.TabIndex = 9;
            label3.Text = "Значение интеграла";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(409, 566);
            label4.Name = "label4";
            label4.Size = new Size(69, 39);
            label4.TabIndex = 10;
            label4.Text = "Шаг";
            // 
            // textIntegral
            // 
            textIntegral.BackColor = SystemColors.Window;
            textIntegral.Font = new Font("Segoe UI", 14F);
            textIntegral.Location = new Point(531, 505);
            textIntegral.Name = "textIntegral";
            textIntegral.ReadOnly = true;
            textIntegral.Size = new Size(178, 39);
            textIntegral.TabIndex = 11;
            // 
            // textStep
            // 
            textStep.BackColor = SystemColors.Window;
            textStep.Font = new Font("Segoe UI", 14F);
            textStep.Location = new Point(531, 569);
            textStep.Name = "textStep";
            textStep.ReadOnly = true;
            textStep.Size = new Size(178, 39);
            textStep.TabIndex = 12;
            // 
            // buttonApplyMethod
            // 
            buttonApplyMethod.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonApplyMethod.Location = new Point(588, 313);
            buttonApplyMethod.Name = "buttonApplyMethod";
            buttonApplyMethod.Size = new Size(383, 48);
            buttonApplyMethod.TabIndex = 13;
            buttonApplyMethod.Text = "Применить метод";
            buttonApplyMethod.UseVisualStyleBackColor = true;
            buttonApplyMethod.Click += buttonApplyMethod_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1042, 664);
            Controls.Add(buttonApplyMethod);
            Controls.Add(textStep);
            Controls.Add(textIntegral);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericAccuracy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMethods);
            Controls.Add(numericLowerLimit);
            Controls.Add(numericUpperLimit);
            Controls.Add(labelUpperLimit);
            Controls.Add(labelLowerLimit);
            Controls.Add(labelFunc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Numerical Integration";
            ((System.ComponentModel.ISupportInitialize)numericUpperLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericLowerLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAccuracy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFunc;
        private Label labelLowerLimit;
        private Label labelUpperLimit;
        private NumericUpDown numericUpperLimit;
        private NumericUpDown numericLowerLimit;
        private ComboBox comboBoxMethods;
        private Label label1;
        private Label label2;
        private NumericUpDown numericAccuracy;
        private Label label3;
        private Label label4;
        private TextBox textIntegral;
        private TextBox textStep;
        private Button buttonApplyMethod;
    }
}
