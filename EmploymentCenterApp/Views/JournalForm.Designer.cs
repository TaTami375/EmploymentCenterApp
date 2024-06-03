namespace EmploymentCenterApp.Views
{
    partial class JournalForm
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
            logListView = new ListView();
            LogID = new ColumnHeader();
            IDApplicant = new ColumnHeader();
            IDWork = new ColumnHeader();
            EmploymentDate = new ColumnHeader();
            DismissalDate = new ColumnHeader();
            deleteLogButton = new Button();
            editLogButton = new Button();
            addLogButton = new Button();
            dismissalLogButton = new Button();
            SuspendLayout();
            // 
            // logListView
            // 
            logListView.Columns.AddRange(new ColumnHeader[] { LogID, IDApplicant, IDWork, EmploymentDate, DismissalDate });
            logListView.Location = new Point(34, 34);
            logListView.Margin = new Padding(4);
            logListView.Name = "logListView";
            logListView.Size = new Size(865, 383);
            logListView.TabIndex = 10;
            logListView.UseCompatibleStateImageBehavior = false;
            logListView.View = View.Details;
            // 
            // LogID
            // 
            LogID.Text = "ID";
            // 
            // IDApplicant
            // 
            IDApplicant.Text = "ID соискателя";
            IDApplicant.Width = 160;
            // 
            // IDWork
            // 
            IDWork.Text = "ID вакансии";
            IDWork.Width = 160;
            // 
            // EmploymentDate
            // 
            EmploymentDate.Text = "Дата найма";
            EmploymentDate.Width = 160;
            // 
            // DismissalDate
            // 
            DismissalDate.Text = "Дата увольнения";
            DismissalDate.Width = 160;
            // 
            // deleteLogButton
            // 
            deleteLogButton.Location = new Point(468, 450);
            deleteLogButton.Margin = new Padding(4);
            deleteLogButton.Name = "deleteLogButton";
            deleteLogButton.Size = new Size(209, 62);
            deleteLogButton.TabIndex = 16;
            deleteLogButton.Text = "Удалить запись";
            deleteLogButton.UseVisualStyleBackColor = true;
            // 
            // editLogButton
            // 
            editLogButton.Location = new Point(251, 450);
            editLogButton.Margin = new Padding(4);
            editLogButton.Name = "editLogButton";
            editLogButton.Size = new Size(209, 62);
            editLogButton.TabIndex = 15;
            editLogButton.Text = "Редактировать запись";
            editLogButton.UseVisualStyleBackColor = true;
            // 
            // addLogButton
            // 
            addLogButton.Location = new Point(34, 450);
            addLogButton.Margin = new Padding(4);
            addLogButton.Name = "addLogButton";
            addLogButton.Size = new Size(209, 62);
            addLogButton.TabIndex = 14;
            addLogButton.Text = "Добавить запись";
            addLogButton.UseVisualStyleBackColor = true;
            // 
            // dismissalLogButton
            // 
            dismissalLogButton.Location = new Point(685, 450);
            dismissalLogButton.Margin = new Padding(4);
            dismissalLogButton.Name = "dismissalLogButton";
            dismissalLogButton.Size = new Size(209, 62);
            dismissalLogButton.TabIndex = 17;
            dismissalLogButton.Text = "Зарегистрировать увольнение";
            dismissalLogButton.UseVisualStyleBackColor = true;
            // 
            // JournalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 574);
            Controls.Add(dismissalLogButton);
            Controls.Add(deleteLogButton);
            Controls.Add(editLogButton);
            Controls.Add(addLogButton);
            Controls.Add(logListView);
            Name = "JournalForm";
            Text = "Журнал учёта трудоустройства";
            ResumeLayout(false);
        }

        #endregion

        private ListView logListView;
        private ColumnHeader LogID;
        private ColumnHeader IDApplicant;
        private ColumnHeader IDWork;
        private ColumnHeader EmploymentDate;
        private ColumnHeader DismissalDate;
        private Button deleteLogButton;
        private Button editLogButton;
        private Button addLogButton;
        private Button dismissalLogButton;
    }
}