namespace WinFormsControlLibrary1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(
                    "ユーザー名またはパスワードが空欄です。",
                    ".NET6の解説",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );
                return;
            }
            if (textBox2.Text == "AAA")
            {
                MessageBox.Show(
                    $"こんにちわ、{textBox1.Text}さん。",
                    ".NET6の解説",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"パスワードが間違っています。",
                    ".NET6の解説",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error
                );
            }
            return;
        }
    }
}