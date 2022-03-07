using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeGenerator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            // Sequential

            primesOutput_list.DataSource = null;
            primesOutput_list.Items.Clear();

            PrimeGenerator primeGenerator = new PrimeGenerator();
            List<long> primes = new List<long>();
            long rangeStart = long.Parse(rangeStart_input.Text);
            long rangeEnd = long.Parse(rangeEnd_input.Text);

            Stopwatch sw = Stopwatch.StartNew();
            primes = await primeGenerator.GetPrimesSequentialAsync(rangeStart, rangeEnd);
            sw.Stop();

            primesOutput_list.DataSource = primes;
            resultSyncronousOutput_lbl.Text = primes.Count() + " primes found in " + sw.Elapsed.TotalSeconds.ToString() + " seconds";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Parallel

            primesOutput_list.DataSource = null;
            primesOutput_list.Items.Clear();
            PrimeGenerator primeGenerator = new PrimeGenerator();
            List<long> primes = new List<long>();
            long rangeStart = long.Parse(rangeStart_input.Text);
            long rangeEnd = long.Parse(rangeEnd_input.Text);

            Stopwatch sw = Stopwatch.StartNew();
            primes = await primeGenerator.GetPrimesParallelAsync(rangeStart, rangeEnd);
            sw.Stop();

            primesOutput_list.DataSource = primes;
            resultParallelOutput_lbl.Text = primes.Count() + " primes found in " + sw.Elapsed.TotalSeconds.ToString() + " seconds";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(rangeStart_input.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                rangeStart_input.Text = rangeStart_input.Text.Remove(rangeStart_input.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(rangeStart_input.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                rangeStart_input.Text = rangeStart_input.Text.Remove(rangeStart_input.Text.Length - 1);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
