
namespace SingleLinkedList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.karaokeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // karaokeBtn
            // 
            this.karaokeBtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.karaokeBtn.Location = new System.Drawing.Point(208, 117);
            this.karaokeBtn.Name = "karaokeBtn";
            this.karaokeBtn.Size = new System.Drawing.Size(345, 170);
            this.karaokeBtn.TabIndex = 0;
            this.karaokeBtn.Text = "Click Here For Karaoke";
            this.karaokeBtn.UseVisualStyleBackColor = true;
            this.karaokeBtn.Click += new System.EventHandler(this.karaokeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.karaokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button karaokeBtn;
    }
}

