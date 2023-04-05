using System.Text;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox8.Text;
            string output = remove_digits(input);

            textBox9.Text = output;
        }
      


        private string remove_digits(string input)
        {
            StringBuilder output = new StringBuilder();
            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    output.Append(c);
                }
            }
            return output.ToString();
        }

        private string double_spaces(string input)
        {
            return input.Replace(" ", "  ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox8.Text;
            string output = double_spaces(input);
            textBox9.Text = output;
        }
    }
}