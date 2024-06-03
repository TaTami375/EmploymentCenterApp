namespace EmploymentCenterApp.Views
{
    partial class ApplicantCreateForm
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
            okButton = new Button();
            cancelButton = new Button();
            this.ApplicantPatronymicTextBox = new TextBox();
            this.ApplicantNameTextBox = new TextBox();
            ApplicantSurnameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            experienceNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)experienceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(280, 346);
            okButton.Name = "okButton";
            okButton.Size = new Size(127, 43);
            okButton.TabIndex = 19;
            okButton.Text = "Сохранить";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(87, 346);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(127, 43);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // ApplicantPatronymicTextBox
            // 
            this.ApplicantPatronymicTextBox.Location = new Point(239, 258);
            this.ApplicantPatronymicTextBox.Name = "ApplicantPatronymicTextBox";
            this.ApplicantPatronymicTextBox.Size = new Size(180, 31);
            this.ApplicantPatronymicTextBox.TabIndex = 17;
            this.ApplicantPatronymicTextBox.TextChanged += this.SallaryTextBox_TextChanged;
            // 
            // ApplicantNameTextBox
            // 
            this.ApplicantNameTextBox.Location = new Point(239, 192);
            this.ApplicantNameTextBox.Name = "ApplicantNameTextBox";
            this.ApplicantNameTextBox.Size = new Size(180, 31);
            this.ApplicantNameTextBox.TabIndex = 16;
            this.ApplicantNameTextBox.TextChanged += this.WorkPlaceTextBox_TextChanged;
            // 
            // ApplicantSurnameTextBox
            // 
            ApplicantSurnameTextBox.Location = new Point(239, 123);
            ApplicantSurnameTextBox.Name = "ApplicantSurnameTextBox";
            ApplicantSurnameTextBox.Size = new Size(180, 31);
            ApplicantSurnameTextBox.TabIndex = 15;
            ApplicantSurnameTextBox.TextChanged += WorkQualificationTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 261);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 13;
            label4.Text = "Отчество:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 195);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 12;
            label3.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 126);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 11;
            label2.Text = "Фамилия:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 60);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 10;
            label1.Text = "Опыт работы:";
            // 
            // experienceNumericUpDown
            // 
            experienceNumericUpDown.Location = new Point(239, 58);
            experienceNumericUpDown.Name = "experienceNumericUpDown";
            experienceNumericUpDown.Size = new Size(180, 31);
            experienceNumericUpDown.TabIndex = 20;
            experienceNumericUpDown.ValueChanged += this.experienceNumericUpDown_ValueChanged;
            // 
            // ApplicantCreateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 446);
            Controls.Add(experienceNumericUpDown);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(this.ApplicantPatronymicTextBox);
            Controls.Add(this.ApplicantNameTextBox);
            Controls.Add(ApplicantSurnameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ApplicantCreateForm";
            Text = "ApplicantCreateForm";
            ((System.ComponentModel.ISupportInitialize)experienceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private TextBox SallaryTextBox;
        private TextBox WorkPlaceTextBox;
        private TextBox ApplicantSurnameTextBox;
        private TextBox WorkNameTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown experienceNumericUpDown;
    }
}