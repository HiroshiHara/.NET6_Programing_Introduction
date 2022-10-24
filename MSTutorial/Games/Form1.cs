namespace Games
{
    public partial class Form1 : Form
    {

        Random randomizer = new Random();

        // 式の項を保持するフィールド
        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor;

        // 残り時間を保持するフィールド
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開始ボタン押下時に式の項をセットし、タイマーを開始する
        /// </summary>
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            // 式のラベルに乱数をセット
            // 加算
            PlusLeftLabel.Text = addend1.ToString();
            PlusRightLabel.Text = addend2.ToString();
            // 減算
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            MinusLeftLabel.Text = minuend.ToString();
            MinusRightLabel.Text = subtrahend.ToString();
            // 乗算
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            TimesLeftLabel.Text = multiplicand.ToString();
            TimesRightLabel.Text = multiplier.ToString();
            // 除算
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            DivideLeftLabel.Text = dividend.ToString();
            DivideRightLabel.Text = divisor.ToString();

            // 式の結果に初期値をセット
            Sum.Value = 0;
            Difference.Value = 0;
            Product.Value = 0;
            Quotient.Value = 0;

            // タイマーを開始する
            timeLeft = 30;
            TimeLabel.Text = timeLeft + " seconds";
            Timer.Start();
        }

        /// <summary>
        /// 式の結果が全て正解のときtrueを返却する
        /// </summary>
        /// <returns>式の結果が全て正解のときtrue</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == Sum.Value)
                && (minuend - subtrahend == Difference.Value)
                && (multiplicand * multiplier == Product.Value)
                && (dividend / divisor == Quotient.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 開始ボタン押下時に式の項をセットし、タイマーを開始する。また、開始ボタンを非活性にする
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            StartButton.Enabled = false;
        }

        /// <summary>
        /// タイマーのインターバル(1秒)ごとに発火する<br/>
        /// ①：<see cref="CheckTheAnswer"/>がtrueのとき、タイマーを停止し正解ウィンドウを表示する<br/>
        /// ②：①でないとき、タイマーの表示から1秒減らす<br/>
        /// ③：①②でないとき(=残り時間がなくなったとき)タイマーを停止し終了ウィンドウを表示する
        /// </summary>
        /// <param name="sender">未使用</param>
        /// <param name="e">未使用</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                Timer.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                StartButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                TimeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                Timer.Stop();
                TimeLabel.Text = "Time's up!";
                MessageBox.Show("you didn't finish in time.", "Sorry!");
                Sum.Value = addend1 + addend2;
                Difference.Value = minuend - subtrahend;
                Product.Value = multiplicand * multiplier;
                Quotient.Value = dividend / divisor;
                StartButton.Enabled = true;
            }
        }
    }
}