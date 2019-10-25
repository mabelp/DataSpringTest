namespace DataSpringWinForm
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
            this.buttonTestHere = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTestHere
            // 
            this.buttonTestHere.Location = new System.Drawing.Point(197, 42);
            this.buttonTestHere.Name = "buttonTestHere";
            this.buttonTestHere.Size = new System.Drawing.Size(166, 23);
            this.buttonTestHere.TabIndex = 0;
            this.buttonTestHere.Text = "TestHere";
            this.buttonTestHere.UseVisualStyleBackColor = true;
            this.buttonTestHere.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(197, 100);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(309, 21);
            this.resultBox.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(197, 82);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(47, 12);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result:";
            this.labelResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 262);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.buttonTestHere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTestHere;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label labelResult;
    }
}

