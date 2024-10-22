namespace NumberTranslator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBoxBefore = new TextBox();
            labelInput = new Label();
            comboBoxFrom = new ComboBox();
            labelNumberSystemFrom = new Label();
            comboBoxTo = new ComboBox();
            textBoxAfter = new TextBox();
            buttonStart = new Button();
            labelNumberSystemTo = new Label();
            labelAfter = new Label();
            SuspendLayout();
            // 
            // textBoxBefore
            // 
            textBoxBefore.Location = new Point(157, 50);
            textBoxBefore.Multiline = true;
            textBoxBefore.Name = "textBoxBefore";
            textBoxBefore.Size = new Size(222, 54);
            textBoxBefore.TabIndex = 0;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(12, 66);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(113, 20);
            labelInput.TabIndex = 1;
            labelInput.Text = "Введите число:";
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrom.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" });
            comboBoxFrom.Location = new Point(309, 147);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(151, 28);
            comboBoxFrom.TabIndex = 2;
            // 
            // labelNumberSystemFrom
            // 
            labelNumberSystemFrom.AutoSize = true;
            labelNumberSystemFrom.Location = new Point(12, 150);
            labelNumberSystemFrom.Name = "labelNumberSystemFrom";
            labelNumberSystemFrom.Size = new Size(244, 20);
            labelNumberSystemFrom.TabIndex = 3;
            labelNumberSystemFrom.Text = "Выберите его систему счисления:";
            // 
            // comboBoxTo
            // 
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTo.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" });
            comboBoxTo.Location = new Point(309, 195);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(151, 28);
            comboBoxTo.TabIndex = 4;
            // 
            // textBoxAfter
            // 
            textBoxAfter.Location = new Point(133, 335);
            textBoxAfter.Multiline = true;
            textBoxAfter.Name = "textBoxAfter";
            textBoxAfter.Size = new Size(288, 96);
            textBoxAfter.TabIndex = 5;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(179, 236);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(123, 45);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Перевести";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStart_Click;
            // 
            // labelNumberSystemTo
            // 
            labelNumberSystemTo.AutoSize = true;
            labelNumberSystemTo.Location = new Point(12, 198);
            labelNumberSystemTo.Name = "labelNumberSystemTo";
            labelNumberSystemTo.Size = new Size(290, 20);
            labelNumberSystemTo.TabIndex = 7;
            labelNumberSystemTo.Text = "Выберите конечную систему счисления:";
            // 
            // labelAfter
            // 
            labelAfter.AutoSize = true;
            labelAfter.Location = new Point(49, 335);
            labelAfter.Name = "labelAfter";
            labelAfter.Size = new Size(44, 20);
            labelAfter.TabIndex = 8;
            labelAfter.Text = "Итог:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(515, 490);
            Controls.Add(labelAfter);
            Controls.Add(labelNumberSystemTo);
            Controls.Add(buttonStart);
            Controls.Add(textBoxAfter);
            Controls.Add(comboBoxTo);
            Controls.Add(labelNumberSystemFrom);
            Controls.Add(comboBoxFrom);
            Controls.Add(labelInput);
            Controls.Add(textBoxBefore);
            MinimumSize = new Size(200, 500);
            Name = "MainForm";
            Text = "Перевод чисел";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBefore;
        private Label labelInput;
        private ComboBox comboBoxFrom;
        private Label labelNumberSystemFrom;
        private ComboBox comboBoxTo;
        private TextBox textBoxAfter;
        private Button buttonStart;
        private Label labelNumberSystemTo;
        private Label labelAfter;
    }
}
