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

        private void button1_Click_1(object sender, EventArgs e)
        {
           // Sequential
            PrimeGenerator primeGenerator = new PrimeGenerator();
            List<long> primes = new List<long>();
            long rangeStart = long.Parse(rangeStart_input.Text);
            long rangeEnd = long.Parse(rangeEnd_input.Text);


            Stopwatch sw = Stopwatch.StartNew();
            // TODO: Make call asyncronous / wrap in async wrapper method
            primes = primeGenerator.GetPrimesSequential(rangeStart, rangeEnd);
            sw.Stop();

            primesOutput_list.DataSource = primes;
            resultSyncronousOutput_lbl.Text = primes.Count() + " primes found in " + sw.Elapsed.TotalSeconds.ToString() + " seconds";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parallel

            PrimeGenerator primeGenerator = new PrimeGenerator();
            List<long> primes = new List<long>();
            long rangeStart = long.Parse(rangeStart_input.Text);
            long rangeEnd = long.Parse(rangeEnd_input.Text);

            Stopwatch sw = Stopwatch.StartNew();
            // TODO: Make call asyncronous / wrap in async wrapper method
            primes = primeGenerator.GetPrimesParallel(rangeStart, rangeEnd);
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
