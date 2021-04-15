
namespace ProiectAtestat
{
    partial class Istorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istorie));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnQuiz = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(842, 394);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // BtnQuiz
            // 
            this.BtnQuiz.Location = new System.Drawing.Point(41, 525);
            this.BtnQuiz.Name = "BtnQuiz";
            this.BtnQuiz.Size = new System.Drawing.Size(94, 29);
            this.BtnQuiz.TabIndex = 2;
            this.BtnQuiz.Text = "Quiz";
            this.BtnQuiz.UseVisualStyleBackColor = true;
            this.BtnQuiz.Click += new System.EventHandler(this.BtnQuiz_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(718, 525);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(94, 29);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Înapoi";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Istorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 585);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnQuiz);
            this.Controls.Add(this.richTextBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Istorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istorie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnQuiz;
        private System.Windows.Forms.Button BtnClose;
    }
}