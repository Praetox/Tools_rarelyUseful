namespace PBPMeasure
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
            this.lDistLast = new System.Windows.Forms.Label();
            this.lBeatsTotal = new System.Windows.Forms.Label();
            this.cClear = new System.Windows.Forms.Button();
            this.cBeat = new System.Windows.Forms.Button();
            this.lDistTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lBpmLast = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lBpmAverage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lDistAverage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total beats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last dist";
            // 
            // lDistLast
            // 
            this.lDistLast.AutoSize = true;
            this.lDistLast.Location = new System.Drawing.Point(91, 22);
            this.lDistLast.Name = "lDistLast";
            this.lDistLast.Size = new System.Drawing.Size(13, 13);
            this.lDistLast.TabIndex = 4;
            this.lDistLast.Text = "0";
            // 
            // lBeatsTotal
            // 
            this.lBeatsTotal.AutoSize = true;
            this.lBeatsTotal.Location = new System.Drawing.Point(91, 9);
            this.lBeatsTotal.Name = "lBeatsTotal";
            this.lBeatsTotal.Size = new System.Drawing.Size(13, 13);
            this.lBeatsTotal.TabIndex = 3;
            this.lBeatsTotal.Text = "0";
            // 
            // cClear
            // 
            this.cClear.Location = new System.Drawing.Point(12, 103);
            this.cClear.Name = "cClear";
            this.cClear.Size = new System.Drawing.Size(72, 23);
            this.cClear.TabIndex = 6;
            this.cClear.Text = "Clear";
            this.cClear.UseVisualStyleBackColor = true;
            this.cClear.Click += new System.EventHandler(this.cClear_Click);
            // 
            // cBeat
            // 
            this.cBeat.Location = new System.Drawing.Point(90, 103);
            this.cBeat.Name = "cBeat";
            this.cBeat.Size = new System.Drawing.Size(72, 23);
            this.cBeat.TabIndex = 7;
            this.cBeat.Text = "Beat";
            this.cBeat.UseVisualStyleBackColor = true;
            this.cBeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBeat_KeyDown);
            // 
            // lDistTotal
            // 
            this.lDistTotal.AutoSize = true;
            this.lDistTotal.Location = new System.Drawing.Point(91, 48);
            this.lDistTotal.Name = "lDistTotal";
            this.lDistTotal.Size = new System.Drawing.Size(13, 13);
            this.lDistTotal.TabIndex = 9;
            this.lDistTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total dist";
            // 
            // lBpmLast
            // 
            this.lBpmLast.AutoSize = true;
            this.lBpmLast.Location = new System.Drawing.Point(91, 61);
            this.lBpmLast.Name = "lBpmLast";
            this.lBpmLast.Size = new System.Drawing.Size(13, 13);
            this.lBpmLast.TabIndex = 11;
            this.lBpmLast.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last BPM";
            // 
            // lBpmAverage
            // 
            this.lBpmAverage.AutoSize = true;
            this.lBpmAverage.Location = new System.Drawing.Point(91, 74);
            this.lBpmAverage.Name = "lBpmAverage";
            this.lBpmAverage.Size = new System.Drawing.Size(13, 13);
            this.lBpmAverage.TabIndex = 13;
            this.lBpmAverage.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Average BPM";
            // 
            // lDistAverage
            // 
            this.lDistAverage.AutoSize = true;
            this.lDistAverage.Location = new System.Drawing.Point(91, 35);
            this.lDistAverage.Name = "lDistAverage";
            this.lDistAverage.Size = new System.Drawing.Size(13, 13);
            this.lDistAverage.TabIndex = 15;
            this.lDistAverage.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Average dist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 138);
            this.Controls.Add(this.lDistAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBpmAverage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lBpmLast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lDistTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBeat);
            this.Controls.Add(this.cClear);
            this.Controls.Add(this.lDistLast);
            this.Controls.Add(this.lBeatsTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDistLast;
        private System.Windows.Forms.Label lBeatsTotal;
        private System.Windows.Forms.Button cClear;
        private System.Windows.Forms.Button cBeat;
        private System.Windows.Forms.Label lDistTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lBpmLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lBpmAverage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lDistAverage;
        private System.Windows.Forms.Label label3;
    }
}

