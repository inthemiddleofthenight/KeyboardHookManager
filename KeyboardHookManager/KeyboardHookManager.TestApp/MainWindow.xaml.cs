using System;
using System.Windows;

namespace KeyboardHookManager.TestApp
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            HookManager.KeyDown += HookManager_KeyDown;
            HookManager.KeyPress += HookManager_KeyPress;
            HookManager.KeyUp += HookManager_KeyUp;
        }

        private void HookManager_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            KeyboardLog.Text += $"KeyUp {e.KeyCode.ToString()}\n";
        }

        private void HookManager_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            KeyboardLog.Text += $"KeyPress {e.KeyChar}\n";
        }

        private void HookManager_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            KeyboardLog.Text += $"KeyDown {e.KeyCode.ToString()}\n";
        }
    }
}
