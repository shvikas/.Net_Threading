namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.btnThreadBasics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThreadBasics
            // 
            this.btnThreadBasics.Location = new System.Drawing.Point(141, 54);
            this.btnThreadBasics.Name = "btnThreadBasics";
            this.btnThreadBasics.Size = new System.Drawing.Size(123, 23);
            this.btnThreadBasics.TabIndex = 0;
            this.btnThreadBasics.Text = "Thread Basics";
            this.btnThreadBasics.UseVisualStyleBackColor = true;
            this.btnThreadBasics.Click += new System.EventHandler(this.btnThreadBasics_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 491);
            this.Controls.Add(this.btnThreadBasics);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThreadBasics;
    }
}

