namespace Exercise3
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
            this.starButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // starButton
            // 
            this.starButton.Location = new System.Drawing.Point(445, 206);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(110, 33);
            this.starButton.TabIndex = 0;
            this.starButton.Text = "Draw Stars";
            this.starButton.UseVisualStyleBackColor = true;
            this.starButton.Click += new System.EventHandler(this.starButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 444);
            this.Controls.Add(this.starButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button starButton;
    }
}

