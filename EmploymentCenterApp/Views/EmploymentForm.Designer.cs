namespace EmploymentCenterApp.Views
{
    partial class EmploymentForm
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
            IDWorkTextBox = new TextBox();
            IDApplicantextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            EmploymentDatePicker = new DateTimePicker();
            DismissalDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(269, 331);
            okButton.Name = "okButton";
            okButton.Size = new Size(127, 43);
            okButton.TabIndex = 19;
            okButton.Text = "Сохранить";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(76, 331);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(127, 43);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // IDWorkTextBox
            // 
            IDWorkTextBox.Location = new Point(230, 108);
            IDWorkTextBox.Name = "IDWorkTextBox";
            IDWorkTextBox.Size = new Size(232, 31);
            IDWorkTextBox.TabIndex = 15;
            // 
            // IDApplicantextBox
            // 
            IDApplicantextBox.Location = new Point(230, 42);
            IDApplicantextBox.Name = "IDApplicantextBox";
            IDApplicantextBox.Size = new Size(232, 31);
            IDApplicantextBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 246);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 13;
            label4.Text = "Дата увольнения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 180);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 12;
            label3.Text = "Дата трудоустройства:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 111);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 11;
            label2.Text = "ID вакансии:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 45);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 10;
            label1.Text = "ID соискателя:";
            // 
            // EmploymentDatePicker
            // 
            EmploymentDatePicker.Location = new Point(230, 180);
            EmploymentDatePicker.Name = "EmploymentDatePicker";
            EmploymentDatePicker.Size = new Size(232, 31);
            EmploymentDatePicker.TabIndex = 20;
            // 
            // DismissalDatePicker
            // 
            DismissalDatePicker.Location = new Point(230, 241);
            DismissalDatePicker.Name = "DismissalDatePicker";
            DismissalDatePicker.Size = new Size(232, 31);
            DismissalDatePicker.TabIndex = 21;
            // 
            // EmploymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 446);
            Controls.Add(DismissalDatePicker);
            Controls.Add(EmploymentDatePicker);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(IDWorkTextBox);
            Controls.Add(IDApplicantextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmploymentForm";
            Text = "Трудоустройство";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private TextBox IDWorkTextBox;
        private TextBox IDApplicantextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker EmploymentDatePicker;
        private DateTimePicker DismissalDatePicker;
    }
}