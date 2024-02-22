
namespace Modeling_Task_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.TextBox();
            this.seed = new System.Windows.Forms.TextBox();
            this.increment = new System.Windows.Forms.TextBox();
            this.modulus = new System.Windows.Forms.TextBox();
            this.iterations = new System.Windows.Forms.TextBox();
            this.Actual = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Random_Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.LongestPeriod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplier (a)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seed (Xi)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Increment (c)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modulus (m)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Iterations";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Actual Period Length";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = " Generate Random Numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(248, 60);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(232, 22);
            this.mult.TabIndex = 7;
            // 
            // seed
            // 
            this.seed.Location = new System.Drawing.Point(245, 116);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(234, 22);
            this.seed.TabIndex = 8;
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(245, 172);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(235, 22);
            this.increment.TabIndex = 9;
            // 
            // modulus
            // 
            this.modulus.Location = new System.Drawing.Point(248, 231);
            this.modulus.Name = "modulus";
            this.modulus.Size = new System.Drawing.Size(232, 22);
            this.modulus.TabIndex = 10;
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(249, 282);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(231, 22);
            this.iterations.TabIndex = 11;
            // 
            // Actual
            // 
            this.Actual.Location = new System.Drawing.Point(181, 523);
            this.Actual.Name = "Actual";
            this.Actual.Size = new System.Drawing.Size(142, 22);
            this.Actual.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Random_Numbers});
            this.dataGridView1.Location = new System.Drawing.Point(833, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(254, 592);
            this.dataGridView1.TabIndex = 13;
            // 
            // Random_Numbers
            // 
            this.Random_Numbers.HeaderText = "Random Numbers";
            this.Random_Numbers.MinimumWidth = 6;
            this.Random_Numbers.Name = "Random_Numbers";
            this.Random_Numbers.Width = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Longest Period Length";
            // 
            // LongestPeriod
            // 
            this.LongestPeriod.Location = new System.Drawing.Point(599, 519);
            this.LongestPeriod.Name = "LongestPeriod";
            this.LongestPeriod.Size = new System.Drawing.Size(197, 22);
            this.LongestPeriod.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 639);
            this.Controls.Add(this.LongestPeriod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Actual);
            this.Controls.Add(this.iterations);
            this.Controls.Add(this.modulus);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mult;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.TextBox increment;
        private System.Windows.Forms.TextBox modulus;
        private System.Windows.Forms.TextBox iterations;
        private System.Windows.Forms.TextBox Actual;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random_Numbers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LongestPeriod;
    }
}

