namespace moreWinBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int guess;
        bool alreadyGuess=false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "找雪人遊戲";
            guess = new Random().Next(1, 4);
            if (alreadyGuess)
            {
                infoLable.Text = "不在這裡，再試一次";
            }
            else
            {
                infoLable.Text = "找雪人在哪裡?";
            }

            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button1.Image = button2.Image = button3.Image = null;

        }

        public void CheckAns(int ans,object sender, EventArgs e)
        {
            if (ans == guess)
            {
                infoLable.Text = "恭喜猜對了!";
                if (ans == 1)
                {
                    button1.Image = new Bitmap("snowMan.jpg");
                }
                else if (ans == 2)
                {
                    button2.Image = new Bitmap("snowMan.jpg");
                }
                else
                {
                    button3.Image = new Bitmap("snowMan.jpg");
                }
            }
            else
            {
                alreadyGuess = true;
                infoLable.Text = "不在這裡，再試一次";
                Form1_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)//重來按鈕
        {
            alreadyGuess=false;
            Form1_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)//離開按鈕
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
            button3.Enabled = false;
            CheckAns(1, sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button1.Enabled = false;
            button3.Enabled = false;
            CheckAns(2, sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            button1.Enabled = false;
            button2.Enabled = false;
            CheckAns(3, sender, e);
        }
    }
}
