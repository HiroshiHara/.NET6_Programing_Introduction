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

        // 1度目にクリックしたラベルを保持
        Label? firstClicked = null;
        // 2度目にクリックしたラベルを保持
        Label? secondClicked = null;

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
            // タイマーカウント中はプレイヤーの操作を無視する
            if (Timer.Enabled)
            {
                return;
            }

            Label? clickLabel = sender as Label;
            if (clickLabel != null)
            {
                // 文字色が黒なら選択済みラベルなので何もせず終了
                if (clickLabel.ForeColor == Color.Black)
                {
                    return;
                }
                if (firstClicked == null)
                {
                    firstClicked = clickLabel;
                    clickLabel.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickLabel;
                secondClicked.ForeColor = Color.Black;
                // 2つ目のアイコンをクリックするたびクリア判定を行う
                CheckForWinner();
                // ラベルのアイコンが一致した場合、文字色をそのままにラベルのトレースを終了する
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                // 異なるラベルのペアを選択したときのみタイマーを開始
                Timer.Start();
            }
        }

        /// <summary>
        /// インターバル経過時に可視化されているラベルを隠し、クリック済みのラベルをクリアする
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // インターバル経過時にタイマーを停止
            Timer.Stop();

            // 可視化されているラベルを隠す
            firstClicked!.ForeColor = firstClicked.BackColor;
            secondClicked!.ForeColor = secondClicked.BackColor;

            // クリック済みのラベルをクリアする
            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            // 全てのラベルの文字色が背景色と同じでない場合、クリアと判定する
            foreach (var ctrl in tableLayoutPanel1.Controls)
            {
                Label? iconLabel = ctrl as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }
    }
}