using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u13
{
    public partial class FormSolve : Form
    {
        public FormSolve()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, E, d, x1, x2;

            try
            {
                a = Convert.ToDouble(textBoxA.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода.");
                ClearForm();
                return;
            }
            try
            {
                b = Convert.ToDouble(textBoxB.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода.");
                ClearForm();
                return;
            }
            try
            {
                c = Convert.ToDouble(textBoxC.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода.");
                ClearForm();
                return;
            }
            try
            {
                E = Convert.ToDouble(textBoxE.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода.");
                ClearForm();
                return;
            }

            listBox1.Items.Clear();
            Solve s = new Solve(a, b, c, E);
            listBox1.Items.Add(s.Get());

            if (a != 0)
            {
                listBox1.Items.Add($"d: {s.Discriminant()}");

                x1 = s.X1();
                x2 = s.X2();

                listBox1.Items.Add($"x1: {x1}");
                listBox1.Items.Add($"x2: {x2}");
                listBox1.Items.Add($"Check x1: {s.Check(x1)}");
                listBox1.Items.Add($"Check x2: {s.Check(x2)}");
            }
            else
            {
                if (b == 0 && c != 0)
                    listBox1.Items.Add($"a = 0, b = 0");
                else if (b == 0 && c == 0)
                    listBox1.Items.Add($"a = 0, b = 0, c = 0");

                x1 = s.X1();

                listBox1.Items.Add($"x: {x1}");
                listBox1.Items.Add($"Check x1: {s.Check(x1)}");
            }
        }

        private void ClearForm()
        {
            textBoxA.Text = String.Empty;
            textBoxB.Text = String.Empty;
            textBoxC.Text = String.Empty;
            textBoxE.Text = String.Empty;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
