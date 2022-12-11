using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StringTextBox.Text))
            {
                MessageBox.Show("Введите преложение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string str = StringTextBox.Text;
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
                if (char.IsPunctuation(c)) sb.Append(" ");
                else sb.Append(c);

            string[] words = sb.ToString().Split(' ');
            List<string> result = new List<string>();

            string min = words[0];
            foreach (string word in words)
                if (word.Length < min.Length && word != "") min = word;

            foreach (string word in words)
                if (word.Length == min.Length) result.Add(word);

            if (result.Count == 0)
                MessageBox.Show("Строка пуста!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (result.Count == 1)
                MessageBox.Show($"Самое короткое слово: {result[0]}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string message = "Самые короткие слова: ";
                foreach (string word in result) message += word + " ";
                MessageBox.Show(message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
