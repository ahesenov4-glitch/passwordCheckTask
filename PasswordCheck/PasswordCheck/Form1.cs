namespace PasswordCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] sChars = { '@', '#', '$', '%', '!', '*' };

            if ((pcheck.Text.Length < 8) ||
                !(sChars.Any(c => pcheck.Text.Contains(c))) ||
                !(pcheck.Text.Any(c => Char.IsLower(c))) ||
                !(pcheck.Text.Any(c => Char.IsUpper(c))) ||
                !(pcheck.Text.Any(c => Char.IsDigit(c))) ||
                (pcheck.Text.Contains("abc")) ||
                (pcheck.Text.Contains("qwerty")) ||
                (pcheck.Text.Contains("123")))
            {

                MessageBox.Show("Please try another password", "Message");
            }
            else
            {
                MessageBox.Show("All Good!", "Confirmed");
            }
        }
    }

}


