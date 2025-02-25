namespace TP_LABA2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtFirstWord.Text = Properties.Settings.Default.firstWord.ToString();
            txtSecondWord.Text = Properties.Settings.Default.secondWord.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstWord = txtFirstWord.Text;
            string secondWord = txtSecondWord.Text;

            Properties.Settings.Default.firstWord = firstWord;
            Properties.Settings.Default.secondWord = secondWord;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.haveSameLetters(firstWord, secondWord));
        }
    }
    public class Logic
    {
        public static string haveSameLetters(string word1, string word2)
        {
            string msg = "";
            HashSet<char> uniqueChars = new HashSet<char>(word1);

            foreach (char ch in uniqueChars)
            {
                if (word2.Contains(ch)) msg += "да ";
                else msg += "нет ";
            }

            return msg;
        }
    }
}