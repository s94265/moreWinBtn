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
            this.Text = "�䳷�H�C��";
            guess = new Random().Next(1, 4);
            if (alreadyGuess)
            {
                infoLable.Text = "���b�o�̡A�A�դ@��";
            }
            else
            {
                infoLable.Text = "�䳷�H�b����?";
            }

            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button1.Image = button2.Image = button3.Image = null;

        }

        public void CheckAns(int ans,object sender, EventArgs e)
        {
            if (ans == guess)
            {
                infoLable.Text = "���߲q��F!";
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
                infoLable.Text = "���b�o�̡A�A�դ@��";
                Form1_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)//���ӫ��s
        {
            alreadyGuess=false;
            Form1_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)//���}���s
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
