using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StringTextBox_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char c in StringTextBox.Text)
                if (char.IsDigit(c)) count++;
            NumbersLabel.Text = count.ToString(); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char c in StringTextBox.Text)
                if (char.IsDigit(c)) count++;
            NumbersLabel.Text = count.ToString(); ;
        }
    }
}
