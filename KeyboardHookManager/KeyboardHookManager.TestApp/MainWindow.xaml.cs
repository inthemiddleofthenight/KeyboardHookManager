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

            HookManager.MouseClick += HookManager_MouseClick;
            HookManager.MouseDoubleClick += HookManager_MouseDoubleClick;
            HookManager.MouseWheel += HookManager_MouseWheel;
        }

        private void HookManager_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MouseLog.Text += $"MouseWheel {e.Delta}\n";
        }

        private void HookManager_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MouseLog.Text += $"MouseDoubleClick {e.X} - {e.Y} {e.Button.ToString()}\n";
        }

        private void HookManager_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MouseLog.Text += $"MouseClick {e.X} - {e.Y} {e.Button.ToString()}\n";
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
