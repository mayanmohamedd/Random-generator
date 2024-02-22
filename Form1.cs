using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Modeling_Task_4
{
    public partial class Form1 : Form
    {
        int a, X, c, m, itr;
        Generator obj = new Generator();

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void show_table()
        {
            dataGridView1.Rows.Add(itr);
            for (int i = 0; i < obj.RandomNumbers.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = obj.RandomNumbers[i];
            }

            int longest = obj.Longest_Period_length;
            if (longest == -1)
                LongestPeriod.Text = "Cannot Be Detected";
            else
                LongestPeriod.Text =Convert.ToString(longest);

            int actual = obj.ActualPeriodLength;
            Actual.Text = Convert.ToString(actual);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (mult.TextLength != 0)
                a = Convert.ToInt32(mult.Text);
            else
                MessageBox.Show("Multiplier Value is Required");

            if (seed.TextLength != 0)
                X = Convert.ToInt32(seed.Text);
            else
                MessageBox.Show("Seed Value is Required");

            if (increment.TextLength != 0)
                c = Convert.ToInt32(increment.Text);
            else
                MessageBox.Show("Increment Value is Required");

            if (modulus.TextLength != 0)
                m = Convert.ToInt32(modulus.Text);
            else
                MessageBox.Show("Increment Value is Required");

            if (iterations.TextLength != 0)
                itr = Convert.ToInt32(iterations.Text);
            else
                MessageBox.Show("Number of Iterations is Required");
            
            
            obj.RandomNumbers = obj.LCG(a, X, c, m, itr);
            obj.Longest_Period_length = obj.LongestPeriod(X,c, m, a);

            show_table();



        }
    }
}
