namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.numQ1 = new System.Windows.Forms.NumericUpDown();
            this.numQ2 = new System.Windows.Forms.NumericUpDown();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.numQ4 = new System.Windows.Forms.NumericUpDown();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.numQ3 = new System.Windows.Forms.NumericUpDown();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerQuiz = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimer.Location = new System.Drawing.Point(59, 33);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(485, 42);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Pozostały czas: 20sek.";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQ1
            // 
            this.lblQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ1.Location = new System.Drawing.Point(65, 105);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(200, 49);
            this.lblQ1.TabIndex = 1;
            this.lblQ1.Text = "12 + 13 =";
            this.lblQ1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQ1
            // 
            this.numQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ1.Location = new System.Drawing.Point(271, 112);
            this.numQ1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQ1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numQ1.Name = "numQ1";
            this.numQ1.Size = new System.Drawing.Size(120, 38);
            this.numQ1.TabIndex = 2;
            // 
            // numQ2
            // 
            this.numQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ2.Location = new System.Drawing.Point(271, 169);
            this.numQ2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQ2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numQ2.Name = "numQ2";
            this.numQ2.Size = new System.Drawing.Size(120, 38);
            this.numQ2.TabIndex = 4;
            // 
            // lblQ2
            // 
            this.lblQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ2.Location = new System.Drawing.Point(65, 162);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(200, 49);
            this.lblQ2.TabIndex = 3;
            this.lblQ2.Text = "12 + 13 =";
            this.lblQ2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQ4
            // 
            this.numQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ4.Location = new System.Drawing.Point(271, 282);
            this.numQ4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQ4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numQ4.Name = "numQ4";
            this.numQ4.Size = new System.Drawing.Size(120, 38);
            this.numQ4.TabIndex = 8;
            // 
            // lblQ4
            // 
            this.lblQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ4.Location = new System.Drawing.Point(65, 275);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(200, 49);
            this.lblQ4.TabIndex = 7;
            this.lblQ4.Text = "12 + 13 =";
            this.lblQ4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQ3
            // 
            this.numQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ3.Location = new System.Drawing.Point(271, 225);
            this.numQ3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQ3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numQ3.Name = "numQ3";
            this.numQ3.Size = new System.Drawing.Size(120, 38);
            this.numQ3.TabIndex = 6;
            // 
            // lblQ3
            // 
            this.lblQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ3.Location = new System.Drawing.Point(65, 218);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(200, 49);
            this.lblQ3.TabIndex = 5;
            this.lblQ3.Text = "12 + 13 =";
            this.lblQ3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(201, 362);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 65);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerQuiz
            // 
            this.timerQuiz.Interval = 1000;
            this.timerQuiz.Tick += new System.EventHandler(this.timerQuiz_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 474);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numQ4);
            this.Controls.Add(this.lblQ4);
            this.Controls.Add(this.numQ3);
            this.Controls.Add(this.lblQ3);
            this.Controls.Add(this.numQ2);
            this.Controls.Add(this.lblQ2);
            this.Controls.Add(this.numQ1);
            this.Controls.Add(this.lblQ1);
            this.Controls.Add(this.lblTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.NumericUpDown numQ1;
        private System.Windows.Forms.NumericUpDown numQ2;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.NumericUpDown numQ4;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.NumericUpDown numQ3;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerQuiz;
    }
}

