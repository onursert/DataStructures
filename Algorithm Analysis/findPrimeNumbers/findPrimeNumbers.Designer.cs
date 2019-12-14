namespace findPrimeNumbers
{
    partial class findPrimeNumbers
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
            this.labelElapsedEasy = new System.Windows.Forms.Label();
            this.labelElapsedHard = new System.Windows.Forms.Label();
            this.listBoxEasyWay = new System.Windows.Forms.ListBox();
            this.listBoxHardWay = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalHard = new System.Windows.Forms.Label();
            this.labelTotalEasy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelElapsedEasy
            // 
            this.labelElapsedEasy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelElapsedEasy.AutoSize = true;
            this.labelElapsedEasy.Location = new System.Drawing.Point(400, 406);
            this.labelElapsedEasy.Name = "labelElapsedEasy";
            this.labelElapsedEasy.Size = new System.Drawing.Size(102, 13);
            this.labelElapsedEasy.TabIndex = 13;
            this.labelElapsedEasy.Text = "Elapsed Time (ms) : ";
            // 
            // labelElapsedHard
            // 
            this.labelElapsedHard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelElapsedHard.AutoSize = true;
            this.labelElapsedHard.Location = new System.Drawing.Point(12, 406);
            this.labelElapsedHard.Name = "labelElapsedHard";
            this.labelElapsedHard.Size = new System.Drawing.Size(102, 13);
            this.labelElapsedHard.TabIndex = 12;
            this.labelElapsedHard.Text = "Elapsed Time (ms) : ";
            // 
            // listBoxEasyWay
            // 
            this.listBoxEasyWay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxEasyWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEasyWay.FormattingEnabled = true;
            this.listBoxEasyWay.ItemHeight = 16;
            this.listBoxEasyWay.Location = new System.Drawing.Point(403, 41);
            this.listBoxEasyWay.Name = "listBoxEasyWay";
            this.listBoxEasyWay.Size = new System.Drawing.Size(385, 324);
            this.listBoxEasyWay.TabIndex = 11;
            this.listBoxEasyWay.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxEasyWay_DrawItem);
            // 
            // listBoxHardWay
            // 
            this.listBoxHardWay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxHardWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHardWay.FormattingEnabled = true;
            this.listBoxHardWay.ItemHeight = 16;
            this.listBoxHardWay.Location = new System.Drawing.Point(12, 41);
            this.listBoxHardWay.Name = "listBoxHardWay";
            this.listBoxHardWay.Size = new System.Drawing.Size(385, 324);
            this.listBoxHardWay.TabIndex = 10;
            this.listBoxHardWay.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxHardWay_DrawItem);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Easy Way : O(n^1/2)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hard Way : O(n)";
            // 
            // buttonStart2
            // 
            this.buttonStart2.Location = new System.Drawing.Point(93, 12);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(133, 23);
            this.buttonStart2.TabIndex = 16;
            this.buttonStart2.Text = "Start (above 5000000)";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(232, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 17;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Delay : 100 ms.";
            // 
            // labelTotalHard
            // 
            this.labelTotalHard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalHard.AutoSize = true;
            this.labelTotalHard.Location = new System.Drawing.Point(12, 432);
            this.labelTotalHard.Name = "labelTotalHard";
            this.labelTotalHard.Size = new System.Drawing.Size(88, 13);
            this.labelTotalHard.TabIndex = 19;
            this.labelTotalHard.Text = "Total Time (ms) : ";
            // 
            // labelTotalEasy
            // 
            this.labelTotalEasy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalEasy.AutoSize = true;
            this.labelTotalEasy.Location = new System.Drawing.Point(400, 432);
            this.labelTotalEasy.Name = "labelTotalEasy";
            this.labelTotalEasy.Size = new System.Drawing.Size(88, 13);
            this.labelTotalEasy.TabIndex = 20;
            this.labelTotalEasy.Text = "Total Time (ms) : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.labelTotalEasy);
            this.Controls.Add(this.labelTotalHard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelElapsedEasy);
            this.Controls.Add(this.labelElapsedHard);
            this.Controls.Add(this.listBoxEasyWay);
            this.Controls.Add(this.listBoxHardWay);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Find Prime Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelElapsedEasy;
        private System.Windows.Forms.Label labelElapsedHard;
        private System.Windows.Forms.ListBox listBoxEasyWay;
        private System.Windows.Forms.ListBox listBoxHardWay;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart2;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalHard;
        private System.Windows.Forms.Label labelTotalEasy;
    }
}

