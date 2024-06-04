using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploymentCenterApp.Views
{
    public partial class WelcomeForm : Form
    {
        private System.Windows.Forms.Timer inactivityTimer;
        private const int InactivityTimeout = 10000;
        public WelcomeForm()
        {
            InitializeComponent();
            InitializeInactivityTimer();
        }

        /// <summary>
        /// Инициализирует таймер простоя.
        /// </summary>
        private void InitializeInactivityTimer()
        {
            inactivityTimer = new System.Windows.Forms.Timer();
            inactivityTimer.Interval = InactivityTimeout;
            inactivityTimer.Tick += InactivityTimer_Tick;
            inactivityTimer.Start();

            this.MouseMove += new MouseEventHandler(ResetInactivityTimer);
            this.KeyPress += new KeyPressEventHandler(ResetInactivityTimer);
        }

        /// <summary>
        /// Обработчик события тика таймера простоя.
        /// </summary>
        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            // Остановить таймер
            inactivityTimer.Stop();
            // Закрыть текущее окно
            this.Close();
        }

        /// <summary>
        /// Сбрасывает таймер простоя при активности пользователя.
        /// </summary>
        private void ResetInactivityTimer(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            inactivityTimer.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Остановить таймер простоя
            inactivityTimer.Stop();
            // Скрыть текущее окно
            this.Hide();
            // Создать и отобразить главное окно приложения
            MainForm mainWindow = new MainForm();
            // Закрыть текущее окно после закрытия главного окна
            mainWindow.FormClosed += (s, args) => this.Close();
            mainWindow.Show();
        }
    }
}
