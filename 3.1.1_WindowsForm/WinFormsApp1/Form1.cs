using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // 画面を操作した時のイベント処理などを記述するファイル
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            MessageBox.Show(
                $"こんにちわ、{name}さん",
                ".NET6の解説",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int GetWindowText(IntPtr hWnd, string lpString, int nMaxCount);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);
        private void Win32ApiButton_Click(object sender, EventArgs e)
        {
            // Win32APIを利用
            var hwnd = textBox1.Handle;
            int length = GetWindowTextLength(hwnd);
            string name = new string('\0', length + 1);
            GetWindowText(hwnd, name, name.Length);
            MessageBox.Show(
             $"こんにちわ、{name}さん",
            ".NET6の解説(Win32 API)",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
    );
        }

    }
}