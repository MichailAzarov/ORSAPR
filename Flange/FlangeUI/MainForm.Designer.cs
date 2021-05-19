namespace FlangeUI
{
    partial class MainForm
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.BuildModelButton = new System.Windows.Forms.Button();
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HoleDiameterTextBox = new System.Windows.Forms.TextBox();
            this.FlangeLengthTextBox = new System.Windows.Forms.TextBox();
            this.HoleNumberTextBox = new System.Windows.Forms.TextBox();
            this.FlangeInnerDiameterTextBox = new System.Windows.Forms.TextBox();
            this.FlangeCenterDistanceTextBox = new System.Windows.Forms.TextBox();
            this.FlangeExternalDiameterTextBox = new System.Windows.Forms.TextBox();
            this.ParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.Location = new System.Drawing.Point(23, 186);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(122, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Очистить поля";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BuildModelButton
            // 
            this.BuildModelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuildModelButton.Location = new System.Drawing.Point(289, 186);
            this.BuildModelButton.Name = "BuildModelButton";
            this.BuildModelButton.Size = new System.Drawing.Size(122, 23);
            this.BuildModelButton.TabIndex = 6;
            this.BuildModelButton.Text = "Построить модель";
            this.BuildModelButton.UseVisualStyleBackColor = true;
            this.BuildModelButton.Click += new System.EventHandler(this.BuildModelButton_Click);
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParametersGroupBox.Controls.Add(this.label12);
            this.ParametersGroupBox.Controls.Add(this.label11);
            this.ParametersGroupBox.Controls.Add(this.label10);
            this.ParametersGroupBox.Controls.Add(this.label9);
            this.ParametersGroupBox.Controls.Add(this.label8);
            this.ParametersGroupBox.Controls.Add(this.label7);
            this.ParametersGroupBox.Controls.Add(this.label6);
            this.ParametersGroupBox.Controls.Add(this.label5);
            this.ParametersGroupBox.Controls.Add(this.label4);
            this.ParametersGroupBox.Controls.Add(this.label3);
            this.ParametersGroupBox.Controls.Add(this.label2);
            this.ParametersGroupBox.Controls.Add(this.label1);
            this.ParametersGroupBox.Controls.Add(this.HoleDiameterTextBox);
            this.ParametersGroupBox.Controls.Add(this.FlangeLengthTextBox);
            this.ParametersGroupBox.Controls.Add(this.HoleNumberTextBox);
            this.ParametersGroupBox.Controls.Add(this.FlangeInnerDiameterTextBox);
            this.ParametersGroupBox.Controls.Add(this.FlangeCenterDistanceTextBox);
            this.ParametersGroupBox.Controls.Add(this.FlangeExternalDiameterTextBox);
            this.ParametersGroupBox.Location = new System.Drawing.Point(18, 11);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(398, 169);
            this.ParametersGroupBox.TabIndex = 5;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Параметры";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(299, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "(от 4 до 32)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(299, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "(10 - 60 мм)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(299, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "(от 12 до 36 мм)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(95, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "(от 15 до 1220 мм)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(95, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "(от 50 до 1120 мм)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(95, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "(от 90 до 1450 мм)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество отверстий под крепёж:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Толщина фланца:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Диаметр крепёжного отверстия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Внутренний диаметр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Межосевое расстояние отверстий:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Внешний диаметр:";
            // 
            // HoleDiameterTextBox
            // 
            this.HoleDiameterTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HoleDiameterTextBox.Location = new System.Drawing.Point(213, 40);
            this.HoleDiameterTextBox.Name = "HoleDiameterTextBox";
            this.HoleDiameterTextBox.Size = new System.Drawing.Size(80, 20);
            this.HoleDiameterTextBox.TabIndex = 1;
            // 
            // FlangeLengthTextBox
            // 
            this.FlangeLengthTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FlangeLengthTextBox.Location = new System.Drawing.Point(213, 87);
            this.FlangeLengthTextBox.Name = "FlangeLengthTextBox";
            this.FlangeLengthTextBox.Size = new System.Drawing.Size(80, 20);
            this.FlangeLengthTextBox.TabIndex = 3;
            // 
            // HoleNumberTextBox
            // 
            this.HoleNumberTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HoleNumberTextBox.Location = new System.Drawing.Point(213, 134);
            this.HoleNumberTextBox.Name = "HoleNumberTextBox";
            this.HoleNumberTextBox.Size = new System.Drawing.Size(80, 20);
            this.HoleNumberTextBox.TabIndex = 5;
            // 
            // FlangeInnerDiameterTextBox
            // 
            this.FlangeInnerDiameterTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FlangeInnerDiameterTextBox.Location = new System.Drawing.Point(9, 134);
            this.FlangeInnerDiameterTextBox.Name = "FlangeInnerDiameterTextBox";
            this.FlangeInnerDiameterTextBox.Size = new System.Drawing.Size(80, 20);
            this.FlangeInnerDiameterTextBox.TabIndex = 4;
            // 
            // FlangeCenterDistanceTextBox
            // 
            this.FlangeCenterDistanceTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FlangeCenterDistanceTextBox.Location = new System.Drawing.Point(9, 87);
            this.FlangeCenterDistanceTextBox.Name = "FlangeCenterDistanceTextBox";
            this.FlangeCenterDistanceTextBox.Size = new System.Drawing.Size(80, 20);
            this.FlangeCenterDistanceTextBox.TabIndex = 2;
            // 
            // FlangeExternalDiameterTextBox
            // 
            this.FlangeExternalDiameterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlangeExternalDiameterTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FlangeExternalDiameterTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FlangeExternalDiameterTextBox.Location = new System.Drawing.Point(9, 40);
            this.FlangeExternalDiameterTextBox.Name = "FlangeExternalDiameterTextBox";
            this.FlangeExternalDiameterTextBox.Size = new System.Drawing.Size(80, 20);
            this.FlangeExternalDiameterTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 221);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.BuildModelButton);
            this.Controls.Add(this.ParametersGroupBox);
            this.MaximumSize = new System.Drawing.Size(450, 260);
            this.MinimumSize = new System.Drawing.Size(450, 260);
            this.Name = "MainForm";
            this.Text = "FlangePlagin";
            this.ParametersGroupBox.ResumeLayout(false);
            this.ParametersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BuildModelButton;
        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HoleDiameterTextBox;
        private System.Windows.Forms.TextBox FlangeLengthTextBox;
        private System.Windows.Forms.TextBox HoleNumberTextBox;
        private System.Windows.Forms.TextBox FlangeInnerDiameterTextBox;
        private System.Windows.Forms.TextBox FlangeCenterDistanceTextBox;
        private System.Windows.Forms.TextBox FlangeExternalDiameterTextBox;
    }
}

