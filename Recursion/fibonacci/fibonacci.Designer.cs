namespace fibonacci
{
    partial class fibonacci
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
            this.labelTotalIterative = new System.Windows.Forms.Label();
            this.labelTotalRecursive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelElapsedIterative = new System.Windows.Forms.Label();
            this.labelElapsedRecursive = new System.Windows.Forms.Label();
            this.listBoxIterative = new System.Windows.Forms.ListBox();
            this.listBoxRecursive = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotalIterative
            // 
            this.labelTotalIterative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalIterative.AutoSize = true;
            this.labelTotalIterative.Location = new System.Drawing.Point(400, 432);
            this.labelTotalIterative.Name = "labelTotalIterative";
            this.labelTotalIterative.Size = new System.Drawing.Size(88, 13);
            this.labelTotalIterative.TabIndex = 32;
            this.labelTotalIterative.Text = "Total Time (ms) : ";
            // 
            // labelTotalRecursive
            // 
            this.labelTotalRecursive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalRecursive.AutoSize = true;
            this.labelTotalRecursive.Location = new System.Drawing.Point(12, 432);
            this.labelTotalRecursive.Name = "labelTotalRecursive";
            this.labelTotalRecursive.Size = new System.Drawing.Size(88, 13);
            this.labelTotalRecursive.TabIndex = 31;
            this.labelTotalRecursive.Text = "Total Time (ms) : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Delay : 100 ms.";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(93, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 29;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Recursive : O((1.1680)^n) (Golden Ratio)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Iterative : O(n)";
            // 
            // labelElapsedIterative
            // 
            this.labelElapsedIterative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelElapsedIterative.AutoSize = true;
            this.labelElapsedIterative.Location = new System.Drawing.Point(400, 406);
            this.labelElapsedIterative.Name = "labelElapsedIterative";
            this.labelElapsedIterative.Size = new System.Drawing.Size(102, 13);
            this.labelElapsedIterative.TabIndex = 25;
            this.labelElapsedIterative.Text = "Elapsed Time (ms) : ";
            // 
            // labelElapsedRecursive
            // 
            this.labelElapsedRecursive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelElapsedRecursive.AutoSize = true;
            this.labelElapsedRecursive.Location = new System.Drawing.Point(12, 406);
            this.labelElapsedRecursive.Name = "labelElapsedRecursive";
            this.labelElapsedRecursive.Size = new System.Drawing.Size(102, 13);
            this.labelElapsedRecursive.TabIndex = 24;
            this.labelElapsedRecursive.Text = "Elapsed Time (ms) : ";
            // 
            // listBoxIterative
            // 
            this.listBoxIterative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxIterative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIterative.FormattingEnabled = true;
            this.listBoxIterative.ItemHeight = 16;
            this.listBoxIterative.Location = new System.Drawing.Point(403, 41);
            this.listBoxIterative.Name = "listBoxIterative";
            this.listBoxIterative.Size = new System.Drawing.Size(385, 324);
            this.listBoxIterative.TabIndex = 23;
            // 
            // listBoxRecursive
            // 
            this.listBoxRecursive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxRecursive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecursive.FormattingEnabled = true;
            this.listBoxRecursive.ItemHeight = 16;
            this.listBoxRecursive.Location = new System.Drawing.Point(12, 41);
            this.listBoxRecursive.Name = "listBoxRecursive";
            this.listBoxRecursive.Size = new System.Drawing.Size(385, 324);
            this.listBoxRecursive.TabIndex = 22;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 21;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.labelTotalIterative);
            this.Controls.Add(this.labelTotalRecursive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelElapsedIterative);
            this.Controls.Add(this.labelElapsedRecursive);
            this.Controls.Add(this.listBoxIterative);
            this.Controls.Add(this.listBoxRecursive);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalIterative;
        private System.Windows.Forms.Label labelTotalRecursive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelElapsedIterative;
        private System.Windows.Forms.Label labelElapsedRecursive;
        private System.Windows.Forms.ListBox listBoxIterative;
        private System.Windows.Forms.ListBox listBoxRecursive;
        private System.Windows.Forms.Button buttonStart;
    }
}

