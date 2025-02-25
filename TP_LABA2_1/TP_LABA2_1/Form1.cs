namespace TP_LABA2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNumberOfIdenticalNumbers.Text = Properties.Settings.Default.n.ToString();
            txtNumbers.Text = Properties.Settings.Default.savedNumbers.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumberOfIdenticalNumbers.Text);
            int[] numbers = (txtNumbers.Text)
                               .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            string savedNumbers = txtNumbers.Text;

            Properties.Settings.Default.n = n;
            Properties.Settings.Default.savedNumbers = savedNumbers;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.hasSameNeighbor(n, numbers));

        }
    }
    public class Logic
    {
        public static String hasSameNeighbor(int n, int[] numbers)
        {
            bool found = false;
            int startIndex = -1;

            for (int i = 0; i < numbers.Length - n; i++)
            {
                bool group = true;
                for (int j = 1; j < n; j++)
                {
                    if (numbers[i + j] != numbers[i])
                    {
                        group = false;
                        break;
                    }
                }
                if (group)
                {
                    found = true;
                    startIndex = i;
                    break;
                }
            }
            if (found)
            {
                return $"Найдены одинаковые соседние числа с {startIndex + 1}-й позиции по {startIndex + n}-ю";
            }
            else return "В последовательности нет одинаковых соседних чисел.";
        }
    }
}