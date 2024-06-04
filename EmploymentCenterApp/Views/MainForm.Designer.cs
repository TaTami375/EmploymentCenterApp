namespace EmploymentCenterApp.Views
{
    partial class MainForm
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
            splitContainer1 = new SplitContainer();
            SearchGroupBox = new GroupBox();
            SortComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            SortActionButton = new Button();
            SearchComboBox = new ComboBox();
            dropSearchLink = new LinkLabel();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            deleteWorkButton = new Button();
            editWorkButton = new Button();
            addWorkButton = new Button();
            label2 = new Label();
            listView1 = new ListView();
            WorkID = new ColumnHeader();
            WorkName = new ColumnHeader();
            WorkQualification = new ColumnHeader();
            WorkPlace = new ColumnHeader();
            WorkSallary = new ColumnHeader();
            DBGroupBox = new GroupBox();
            DBActionButton = new Button();
            DBActionComboBox = new ComboBox();
            filterGroupBox = new GroupBox();
            employedFilterRadioButton = new RadioButton();
            unemployedFilterRadioButton = new RadioButton();
            dropFiltersLink = new LinkLabel();
            filterButton = new Button();
            label1 = new Label();
            deleteApplicantButton = new Button();
            editApplicantButton = new Button();
            addApplicantButton = new Button();
            applicants = new Label();
            applicantListView = new ListView();
            IDApplicant = new ColumnHeader();
            ExperienceYears = new ColumnHeader();
            Surname = new ColumnHeader();
            ApplicantName = new ColumnHeader();
            Patronymic = new ColumnHeader();
            JournalButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SearchGroupBox.SuspendLayout();
            DBGroupBox.SuspendLayout();
            filterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(SearchGroupBox);
            splitContainer1.Panel1.Controls.Add(deleteWorkButton);
            splitContainer1.Panel1.Controls.Add(editWorkButton);
            splitContainer1.Panel1.Controls.Add(addWorkButton);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(listView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DBGroupBox);
            splitContainer1.Panel2.Controls.Add(filterGroupBox);
            splitContainer1.Panel2.Controls.Add(deleteApplicantButton);
            splitContainer1.Panel2.Controls.Add(editApplicantButton);
            splitContainer1.Panel2.Controls.Add(addApplicantButton);
            splitContainer1.Panel2.Controls.Add(applicants);
            splitContainer1.Panel2.Controls.Add(applicantListView);
            splitContainer1.Panel2.Controls.Add(JournalButton);
            splitContainer1.Size = new Size(1578, 944);
            splitContainer1.SplitterDistance = 790;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(SortComboBox);
            SearchGroupBox.Controls.Add(label4);
            SearchGroupBox.Controls.Add(label3);
            SearchGroupBox.Controls.Add(SortActionButton);
            SearchGroupBox.Controls.Add(SearchComboBox);
            SearchGroupBox.Controls.Add(dropSearchLink);
            SearchGroupBox.Controls.Add(SearchButton);
            SearchGroupBox.Controls.Add(SearchTextBox);
            SearchGroupBox.Location = new Point(37, 593);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(551, 300);
            SearchGroupBox.TabIndex = 14;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Поиск и сортировка";
            // 
            // SortComboBox
            // 
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Items.AddRange(new object[] { "По з\\п (от меньшей к большей)", "По з\\п (от большей к меньшей)", "По квалификации (высокая=>средняя=>низкая)", "По квалификации (низкая=>средняя=>высокая)" });
            SortComboBox.Location = new Point(6, 242);
            SortComboBox.Margin = new Padding(4);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(259, 33);
            SortComboBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 205);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 8;
            label4.Text = "Сортировка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 7;
            label3.Text = "Тип поиска";
            // 
            // SortActionButton
            // 
            SortActionButton.Location = new Point(292, 239);
            SortActionButton.Margin = new Padding(4);
            SortActionButton.Name = "SortActionButton";
            SortActionButton.Size = new Size(130, 36);
            SortActionButton.TabIndex = 6;
            SortActionButton.Text = "Выполнить";
            SortActionButton.UseVisualStyleBackColor = true;
            // 
            // SearchComboBox
            // 
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Items.AddRange(new object[] { "По названию", "По месту" });
            SearchComboBox.Location = new Point(6, 146);
            SearchComboBox.Margin = new Padding(4);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(259, 33);
            SearchComboBox.TabIndex = 5;
            // 
            // dropSearchLink
            // 
            dropSearchLink.AutoSize = true;
            dropSearchLink.LinkColor = Color.FromArgb(64, 64, 64);
            dropSearchLink.Location = new Point(395, 45);
            dropSearchLink.Margin = new Padding(4, 0, 4, 0);
            dropSearchLink.Name = "dropSearchLink";
            dropSearchLink.Size = new Size(89, 25);
            dropSearchLink.TabIndex = 4;
            dropSearchLink.TabStop = true;
            dropSearchLink.Text = "Сбросить";
            // 
            // SearchButton
            // 
            SearchButton.Image = Properties.Resources.search;
            SearchButton.Location = new Point(311, 36);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(56, 42);
            SearchButton.TabIndex = 1;
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(6, 42);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(289, 31);
            SearchTextBox.TabIndex = 0;
            // 
            // deleteWorkButton
            // 
            deleteWorkButton.Location = new Point(532, 495);
            deleteWorkButton.Margin = new Padding(4);
            deleteWorkButton.Name = "deleteWorkButton";
            deleteWorkButton.Size = new Size(216, 62);
            deleteWorkButton.TabIndex = 13;
            deleteWorkButton.Text = "Удалить запись";
            deleteWorkButton.UseVisualStyleBackColor = true;
            // 
            // editWorkButton
            // 
            editWorkButton.Location = new Point(284, 495);
            editWorkButton.Margin = new Padding(4);
            editWorkButton.Name = "editWorkButton";
            editWorkButton.Size = new Size(216, 62);
            editWorkButton.TabIndex = 12;
            editWorkButton.Text = "Редактировать запись";
            editWorkButton.UseVisualStyleBackColor = true;
            // 
            // addWorkButton
            // 
            addWorkButton.Location = new Point(35, 495);
            addWorkButton.Margin = new Padding(4);
            addWorkButton.Name = "addWorkButton";
            addWorkButton.Size = new Size(216, 62);
            addWorkButton.TabIndex = 11;
            addWorkButton.Text = "Добавить запись";
            addWorkButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(29, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 40);
            label2.TabIndex = 10;
            label2.Text = "Вакансии";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { WorkID, WorkName, WorkQualification, WorkPlace, WorkSallary });
            listView1.Location = new Point(29, 79);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(733, 383);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // WorkID
            // 
            WorkID.Text = "ID";
            // 
            // WorkName
            // 
            WorkName.Text = "Название работы";
            WorkName.Width = 160;
            // 
            // WorkQualification
            // 
            WorkQualification.Text = "Необходимая квалификация";
            WorkQualification.Width = 260;
            // 
            // WorkPlace
            // 
            WorkPlace.Text = "Расположение";
            WorkPlace.Width = 140;
            // 
            // WorkSallary
            // 
            WorkSallary.Text = "Зарплата";
            WorkSallary.Width = 160;
            // 
            // DBGroupBox
            // 
            DBGroupBox.Controls.Add(DBActionButton);
            DBGroupBox.Controls.Add(DBActionComboBox);
            DBGroupBox.Location = new Point(23, 761);
            DBGroupBox.Margin = new Padding(4);
            DBGroupBox.Name = "DBGroupBox";
            DBGroupBox.Padding = new Padding(4);
            DBGroupBox.Size = new Size(432, 132);
            DBGroupBox.TabIndex = 16;
            DBGroupBox.TabStop = false;
            DBGroupBox.Text = "Взаимодействие с базой данных";
            // 
            // DBActionButton
            // 
            DBActionButton.Location = new Point(283, 56);
            DBActionButton.Margin = new Padding(4);
            DBActionButton.Name = "DBActionButton";
            DBActionButton.Size = new Size(130, 36);
            DBActionButton.TabIndex = 3;
            DBActionButton.Text = "Выполнить";
            DBActionButton.UseVisualStyleBackColor = true;
            // 
            // DBActionComboBox
            // 
            DBActionComboBox.FormattingEnabled = true;
            DBActionComboBox.Items.AddRange(new object[] { "Удалить БД", "Создать БД", "Сохранить БД в файл" });
            DBActionComboBox.Location = new Point(8, 58);
            DBActionComboBox.Margin = new Padding(4);
            DBActionComboBox.Name = "DBActionComboBox";
            DBActionComboBox.Size = new Size(259, 33);
            DBActionComboBox.TabIndex = 0;
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(employedFilterRadioButton);
            filterGroupBox.Controls.Add(unemployedFilterRadioButton);
            filterGroupBox.Controls.Add(dropFiltersLink);
            filterGroupBox.Controls.Add(filterButton);
            filterGroupBox.Controls.Add(label1);
            filterGroupBox.Location = new Point(23, 593);
            filterGroupBox.Margin = new Padding(4);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Padding = new Padding(4);
            filterGroupBox.Size = new Size(710, 88);
            filterGroupBox.TabIndex = 15;
            filterGroupBox.TabStop = false;
            // 
            // employedFilterRadioButton
            // 
            employedFilterRadioButton.AutoSize = true;
            employedFilterRadioButton.Location = new Point(102, 36);
            employedFilterRadioButton.Name = "employedFilterRadioButton";
            employedFilterRadioButton.Size = new Size(165, 29);
            employedFilterRadioButton.TabIndex = 5;
            employedFilterRadioButton.TabStop = true;
            employedFilterRadioButton.Text = "Трудоустроены";
            employedFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // unemployedFilterRadioButton
            // 
            unemployedFilterRadioButton.AutoSize = true;
            unemployedFilterRadioButton.Location = new Point(283, 36);
            unemployedFilterRadioButton.Name = "unemployedFilterRadioButton";
            unemployedFilterRadioButton.Size = new Size(175, 29);
            unemployedFilterRadioButton.TabIndex = 4;
            unemployedFilterRadioButton.TabStop = true;
            unemployedFilterRadioButton.Text = "В поиске работы";
            unemployedFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // dropFiltersLink
            // 
            dropFiltersLink.AutoSize = true;
            dropFiltersLink.LinkColor = Color.FromArgb(64, 64, 64);
            dropFiltersLink.Location = new Point(602, 36);
            dropFiltersLink.Margin = new Padding(4, 0, 4, 0);
            dropFiltersLink.Name = "dropFiltersLink";
            dropFiltersLink.Size = new Size(89, 25);
            dropFiltersLink.TabIndex = 3;
            dropFiltersLink.TabStop = true;
            dropFiltersLink.Text = "Сбросить";
            // 
            // filterButton
            // 
            filterButton.Location = new Point(465, 32);
            filterButton.Margin = new Padding(4);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(130, 36);
            filterButton.TabIndex = 2;
            filterButton.Text = "Выполнить";
            filterButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(8, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 0;
            label1.Text = "фильтр: ";
            // 
            // deleteApplicantButton
            // 
            deleteApplicantButton.Location = new Point(517, 495);
            deleteApplicantButton.Margin = new Padding(4);
            deleteApplicantButton.Name = "deleteApplicantButton";
            deleteApplicantButton.Size = new Size(216, 62);
            deleteApplicantButton.TabIndex = 14;
            deleteApplicantButton.Text = "Удалить запись";
            deleteApplicantButton.UseVisualStyleBackColor = true;
            // 
            // editApplicantButton
            // 
            editApplicantButton.Location = new Point(269, 495);
            editApplicantButton.Margin = new Padding(4);
            editApplicantButton.Name = "editApplicantButton";
            editApplicantButton.Size = new Size(216, 62);
            editApplicantButton.TabIndex = 13;
            editApplicantButton.Text = "Редактировать запись";
            editApplicantButton.UseVisualStyleBackColor = true;
            // 
            // addApplicantButton
            // 
            addApplicantButton.Location = new Point(20, 495);
            addApplicantButton.Margin = new Padding(4);
            addApplicantButton.Name = "addApplicantButton";
            addApplicantButton.Size = new Size(216, 62);
            addApplicantButton.TabIndex = 12;
            addApplicantButton.Text = "Добавить запись";
            addApplicantButton.UseVisualStyleBackColor = true;
            // 
            // applicants
            // 
            applicants.AutoSize = true;
            applicants.Font = new Font("Segoe UI", 14.25F);
            applicants.Location = new Point(31, 23);
            applicants.Margin = new Padding(4, 0, 4, 0);
            applicants.Name = "applicants";
            applicants.Size = new Size(170, 40);
            applicants.TabIndex = 11;
            applicants.Text = "Соискатели";
            // 
            // applicantListView
            // 
            applicantListView.Columns.AddRange(new ColumnHeader[] { IDApplicant, ExperienceYears, Surname, ApplicantName, Patronymic });
            applicantListView.Location = new Point(21, 79);
            applicantListView.Margin = new Padding(4);
            applicantListView.Name = "applicantListView";
            applicantListView.Size = new Size(733, 383);
            applicantListView.TabIndex = 10;
            applicantListView.UseCompatibleStateImageBehavior = false;
            applicantListView.View = View.Details;
            // 
            // IDApplicant
            // 
            IDApplicant.Text = "ID";
            // 
            // ExperienceYears
            // 
            ExperienceYears.Text = "Опыт работы";
            ExperienceYears.Width = 160;
            // 
            // Surname
            // 
            Surname.Text = "Фамилия";
            Surname.Width = 160;
            // 
            // ApplicantName
            // 
            ApplicantName.Text = "Имя";
            ApplicantName.Width = 160;
            // 
            // Patronymic
            // 
            Patronymic.Text = "Отчество";
            Patronymic.Width = 160;
            // 
            // JournalButton
            // 
            JournalButton.Location = new Point(517, 798);
            JournalButton.Margin = new Padding(4);
            JournalButton.Name = "JournalButton";
            JournalButton.Size = new Size(216, 62);
            JournalButton.TabIndex = 9;
            JournalButton.Text = "Журнал";
            JournalButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 944);
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
            MaximumSize = new Size(1600, 1000);
            MinimumSize = new Size(1600, 1000);
            Name = "MainForm";
            Text = "Центр занятости";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            DBGroupBox.ResumeLayout(false);
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox SearchGroupBox;
        private ComboBox SortComboBox;
        private Label label4;
        private Label label3;
        private Button SortActionButton;
        private ComboBox SearchComboBox;
        private LinkLabel dropSearchLink;
        private Button SearchButton;
        private TextBox SearchTextBox;
        private Button deleteWorkButton;
        private Button editWorkButton;
        private Button addWorkButton;
        private Label label2;
        private ListView listView1;
        private ColumnHeader WorkID;
        private ColumnHeader WorkName;
        private ColumnHeader WorkQualification;
        private ColumnHeader WorkPlace;
        private ColumnHeader WorkSallary;
        private GroupBox DBGroupBox;
        private Button DBActionButton;
        private ComboBox DBActionComboBox;
        private GroupBox filterGroupBox;
        private LinkLabel dropFiltersLink;
        private Button filterButton;
        private Label label1;
        private Button deleteApplicantButton;
        private Button editApplicantButton;
        private Button addApplicantButton;
        private Label applicants;
        private ListView applicantListView;
        private ColumnHeader IDApplicant;
        private ColumnHeader ExperienceYears;
        private ColumnHeader Surname;
        private ColumnHeader ApplicantName;
        private ColumnHeader Patronymic;
        private Button JournalButton;
        private RadioButton employedFilterRadioButton;
        private RadioButton unemployedFilterRadioButton;
    }
}