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
    }
}