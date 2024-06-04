namespace EmploymentCenterApp.Views
{
    partial class WelcomeForm
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
            StartButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(78, 70);
            label1.Name = "label1";
            label1.Size = new Size(442, 40);
            label1.TabIndex = 0;
            label1.Text = "Приложение \"Центр занятости\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(39, 155);
            label2.Name = "label2";
            label2.Size = new Size(522, 40);
            label2.TabIndex = 1;
            label2.Text = "Выполнил Куприянов Максим 22ВП2 ";
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 14.25F);
            StartButton.Location = new Point(209, 284);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(171, 58);
            StartButton.TabIndex = 2;
            StartButton.Text = "Запустить";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 408);
            Controls.Add(StartButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button StartButton;
    }
}