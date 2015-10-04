namespace WindowsFormsApplication1
{
    partial class ThreadSamples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreadSamples));
            this.btnStartThread = new System.Windows.Forms.Button();
            this.btnBreakExecution = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartThread
            // 
            this.btnStartThread.Location = new System.Drawing.Point(74, 39);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(75, 23);
            this.btnStartThread.TabIndex = 0;
            this.btnStartThread.Text = "Start Thread";
            this.btnStartThread.UseVisualStyleBackColor = true;
            this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
            // 
            // btnBreakExecution
            // 
            this.btnBreakExecution.Location = new System.Drawing.Point(74, 78);
            this.btnBreakExecution.Name = "btnBreakExecution";
            this.btnBreakExecution.Size = new System.Drawing.Size(75, 23);
            this.btnBreakExecution.TabIndex = 1;
            this.btnBreakExecution.Text = "Break Execution";
            this.btnBreakExecution.UseVisualStyleBackColor = true;
            this.btnBreakExecution.Click += new System.EventHandler(this.btnBreakExecution_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(636, 388);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // ThreadSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 502);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBreakExecution);
            this.Controls.Add(this.btnStartThread);
            this.Name = "ThreadSamples";
            this.Text = "Thread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartThread;
        private System.Windows.Forms.Button btnBreakExecution;
        private System.Windows.Forms.TextBox textBox1;
    }
}