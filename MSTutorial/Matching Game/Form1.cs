namespace Matching_Game
{
    public partial class Form1 : Form
    {
        // 乱数オブジェクト
        Random random = new Random();

        // Weddingsフォントにおけるアイコン文字列のリスト
        // 全てのアイコンが2度表示されるようにする
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public Form1()
        {
            InitializeComponent();
            AssingIconsToSquares();
        }

        /// <summary>
        /// tableLayoutPanel配下のLabel要素のTextをランダムで<see cref="icons"/>要素に置き換える
        /// </summary>
        private void AssingIconsToSquares()
        {
            // 親要素tableLayoutPanel1のコントロールの分だけループ
            foreach (var ctrl in tableLayoutPanel1.Controls)
            {
                Label? iconLabel = ctrl as Label;
                if (iconLabel != null)
                {
                    int randomNum = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNum];
                    // 背景色と同じ文字色にして隠す
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNum);
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label? clickLabel = sender as Label;
            if (clickLabel != null)
            {
                // 文字色が黒なら選択済みラベルなので何もせず終了
                if (clickLabel.ForeColor == Color.Black)
                {
                    return;
                }
                clickLabel.ForeColor = Color.Black;
            }
        }
    }
}