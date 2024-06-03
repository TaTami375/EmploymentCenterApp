namespace EmploymentCenterApp.Views
{
    partial class WorkCreateForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            WorkNameTextBox = new TextBox();
            WorkQualificationTextBox = new TextBox();
            WorkPlaceTextBox = new TextBox();
            SallaryTextBox = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 61);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Название работы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 127);
            label2.Name = "label2";
            label2.Size = new Size(251, 25);
            label2.TabIndex = 1;
            label2.Text = "Необходимая квалификация:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 196);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 2;
            label3.Text = "Месторасположение:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 262);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "Зарплата:";
            // 
            // WorkNameTextBox
            // 
            WorkNameTextBox.Location = new Point(294, 58);
            WorkNameTextBox.Name = "WorkNameTextBox";
            WorkNameTextBox.Size = new Size(180, 31);
            WorkNameTextBox.TabIndex = 4;
            // 
            // WorkQualificationTextBox
            // 
            WorkQualificationTextBox.Location = new Point(294, 124);
            WorkQualificationTextBox.Name = "WorkQualificationTextBox";
            WorkQualificationTextBox.Size = new Size(180, 31);
            WorkQualificationTextBox.TabIndex = 5;
            // 
            // WorkPlaceTextBox
            // 
            WorkPlaceTextBox.Location = new Point(294, 193);
            WorkPlaceTextBox.Name = "WorkPlaceTextBox";
            WorkPlaceTextBox.Size = new Size(180, 31);
            WorkPlaceTextBox.TabIndex = 6;
            // 
            // SallaryTextBox
            // 
            SallaryTextBox.Location = new Point(294, 259);
            SallaryTextBox.Name = "SallaryTextBox";
            SallaryTextBox.Size = new Size(180, 31);
            SallaryTextBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(88, 347);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(127, 43);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Location = new Point(281, 347);
            okButton.Name = "okButton";
            okButton.Size = new Size(127, 43);
            okButton.TabIndex = 9;
            okButton.Text = "Сохранить";
            okButton.UseVisualStyleBackColor = true;
            // 
            // WorkCreateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 446);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(SallaryTextBox);
            Controls.Add(WorkPlaceTextBox);
            Controls.Add(WorkQualificationTextBox);
            Controls.Add(WorkNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WorkCreateForm";
            Text = "Редактор вакансии";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox WorkNameTextBox;
        private TextBox WorkQualificationTextBox;
        private TextBox WorkPlaceTextBox;
        private TextBox SallaryTextBox;
        private Button cancelButton;
        private Button okButton;
    }
}