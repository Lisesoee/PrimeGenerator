
namespace PrimeGenerator2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generatePrimesSequential_btn = new System.Windows.Forms.Button();
            this.resultSyncronous_lbl = new System.Windows.Forms.Label();
            this.resultSyncronousOutput_lbl = new System.Windows.Forms.Label();
            this.rangeStart_input = new System.Windows.Forms.TextBox();
            this.rangeEnd_input = new System.Windows.Forms.TextBox();
            this.rangeStart_lbl = new System.Windows.Forms.Label();
            this.rangeEnd_lbl = new System.Windows.Forms.Label();
            this.primesOutput_list = new System.Windows.Forms.ListBox();
            this.generatePrimesParallel_btn = new System.Windows.Forms.Button();
            this.resultParallelOutput_lbl = new System.Windows.Forms.Label();
            this.resultParallel_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generatePrimesSequential_btn
            // 
            this.generatePrimesSequential_btn.Location = new System.Drawing.Point(24, 282);
            this.generatePrimesSequential_btn.Name = "generatePrimesSequential_btn";
            this.generatePrimesSequential_btn.Size = new System.Drawing.Size(171, 23);
            this.generatePrimesSequential_btn.TabIndex = 0;
            this.generatePrimesSequential_btn.Text = "GeneratePrimes - Sequential";
            this.generatePrimesSequential_btn.UseVisualStyleBackColor = true;
            this.generatePrimesSequential_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // resultSyncronous_lbl
            // 
            this.resultSyncronous_lbl.AutoSize = true;
            this.resultSyncronous_lbl.Location = new System.Drawing.Point(21, 308);
            this.resultSyncronous_lbl.Name = "resultSyncronous_lbl";
            this.resultSyncronous_lbl.Size = new System.Drawing.Size(82, 13);
            this.resultSyncronous_lbl.TabIndex = 1;
            this.resultSyncronous_lbl.Text = "Execution time: ";
            // 
            // resultSyncronousOutput_lbl
            // 
            this.resultSyncronousOutput_lbl.AutoSize = true;
            this.resultSyncronousOutput_lbl.Location = new System.Drawing.Point(109, 308);
            this.resultSyncronousOutput_lbl.Name = "resultSyncronousOutput_lbl";
            this.resultSyncronousOutput_lbl.Size = new System.Drawing.Size(16, 13);
            this.resultSyncronousOutput_lbl.TabIndex = 2;
            this.resultSyncronousOutput_lbl.Text = "...";
            // 
            // rangeStart_input
            // 
            this.rangeStart_input.Location = new System.Drawing.Point(95, 22);
            this.rangeStart_input.Name = "rangeStart_input";
            this.rangeStart_input.Size = new System.Drawing.Size(100, 20);
            this.rangeStart_input.TabIndex = 3;
            this.rangeStart_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rangeEnd_input
            // 
            this.rangeEnd_input.Location = new System.Drawing.Point(95, 60);
            this.rangeEnd_input.Name = "rangeEnd_input";
            this.rangeEnd_input.Size = new System.Drawing.Size(100, 20);
            this.rangeEnd_input.TabIndex = 4;
            this.rangeEnd_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rangeStart_lbl
            // 
            this.rangeStart_lbl.AutoSize = true;
            this.rangeStart_lbl.Location = new System.Drawing.Point(21, 25);
            this.rangeStart_lbl.Name = "rangeStart_lbl";
            this.rangeStart_lbl.Size = new System.Drawing.Size(65, 13);
            this.rangeStart_lbl.TabIndex = 5;
            this.rangeStart_lbl.Text = "Range start:";
            // 
            // rangeEnd_lbl
            // 
            this.rangeEnd_lbl.AutoSize = true;
            this.rangeEnd_lbl.Location = new System.Drawing.Point(21, 63);
            this.rangeEnd_lbl.Name = "rangeEnd_lbl";
            this.rangeEnd_lbl.Size = new System.Drawing.Size(63, 13);
            this.rangeEnd_lbl.TabIndex = 6;
            this.rangeEnd_lbl.Text = "Range end:";
            // 
            // primesOutput_list
            // 
            this.primesOutput_list.FormattingEnabled = true;
            this.primesOutput_list.Location = new System.Drawing.Point(463, 22);
            this.primesOutput_list.Name = "primesOutput_list";
            this.primesOutput_list.Size = new System.Drawing.Size(154, 420);
            this.primesOutput_list.TabIndex = 7;
            this.primesOutput_list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // generatePrimesParallel_btn
            // 
            this.generatePrimesParallel_btn.Location = new System.Drawing.Point(24, 392);
            this.generatePrimesParallel_btn.Name = "generatePrimesParallel_btn";
            this.generatePrimesParallel_btn.Size = new System.Drawing.Size(171, 23);
            this.generatePrimesParallel_btn.TabIndex = 8;
            this.generatePrimesParallel_btn.Text = "GeneratePrimes - Parallel";
            this.generatePrimesParallel_btn.UseVisualStyleBackColor = true;
            this.generatePrimesParallel_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultParallelOutput_lbl
            // 
            this.resultParallelOutput_lbl.AutoSize = true;
            this.resultParallelOutput_lbl.Location = new System.Drawing.Point(109, 418);
            this.resultParallelOutput_lbl.Name = "resultParallelOutput_lbl";
            this.resultParallelOutput_lbl.Size = new System.Drawing.Size(16, 13);
            this.resultParallelOutput_lbl.TabIndex = 10;
            this.resultParallelOutput_lbl.Text = "...";
            // 
            // resultParallel_lbl
            // 
            this.resultParallel_lbl.AutoSize = true;
            this.resultParallel_lbl.Location = new System.Drawing.Point(21, 418);
            this.resultParallel_lbl.Name = "resultParallel_lbl";
            this.resultParallel_lbl.Size = new System.Drawing.Size(82, 13);
            this.resultParallel_lbl.TabIndex = 9;
            this.resultParallel_lbl.Text = "Execution time: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(702, 513);
            this.Controls.Add(this.resultParallelOutput_lbl);
            this.Controls.Add(this.resultParallel_lbl);
            this.Controls.Add(this.generatePrimesParallel_btn);
            this.Controls.Add(this.primesOutput_list);
            this.Controls.Add(this.rangeEnd_lbl);
            this.Controls.Add(this.rangeStart_lbl);
            this.Controls.Add(this.rangeEnd_input);
            this.Controls.Add(this.rangeStart_input);
            this.Controls.Add(this.resultSyncronousOutput_lbl);
            this.Controls.Add(this.resultSyncronous_lbl);
            this.Controls.Add(this.generatePrimesSequential_btn);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeneratePrimeNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generatePrimesSequential_btn;
        private System.Windows.Forms.Label resultSyncronous_lbl;
        private System.Windows.Forms.Label resultSyncronousOutput_lbl;
        private System.Windows.Forms.TextBox rangeStart_input;
        private System.Windows.Forms.TextBox rangeEnd_input;
        private System.Windows.Forms.Label rangeStart_lbl;
        private System.Windows.Forms.Label rangeEnd_lbl;
        private System.Windows.Forms.ListBox primesOutput_list;
        private System.Windows.Forms.Button generatePrimesParallel_btn;
        private System.Windows.Forms.Label resultParallelOutput_lbl;
        private System.Windows.Forms.Label resultParallel_lbl;
    }
}

