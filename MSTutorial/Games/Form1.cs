namespace Games
{
    public partial class Form1 : Form
    {

        Random randomizer = new Random();

        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int muliplicand;
        int multiplier;
        int dividend;
        int divisor;

        public Form1()
        {
            InitializeComponent();
        }

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
            muliplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            TimesLeftLabel.Text = muliplicand.ToString();
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
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            StartButton.Enabled = false;
        }
    }
}