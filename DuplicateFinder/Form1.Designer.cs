namespace DuplicateFinder
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
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindDupeWords = new System.Windows.Forms.Button();
            this.FindDupeSentences = new System.Windows.Forms.Button();
            this.debugInfoBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(31, 93);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(575, 758);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(1069, 93);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(591, 758);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1688, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1066, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Duplicates Display";
            // 
            // FindDupeWords
            // 
            this.FindDupeWords.Location = new System.Drawing.Point(633, 296);
            this.FindDupeWords.Name = "FindDupeWords";
            this.FindDupeWords.Size = new System.Drawing.Size(131, 56);
            this.FindDupeWords.TabIndex = 6;
            this.FindDupeWords.Text = "Find Duplicate Words";
            this.FindDupeWords.UseVisualStyleBackColor = true;
            this.FindDupeWords.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindDupeSentences
            // 
            this.FindDupeSentences.Location = new System.Drawing.Point(885, 296);
            this.FindDupeSentences.Name = "FindDupeSentences";
            this.FindDupeSentences.Size = new System.Drawing.Size(131, 56);
            this.FindDupeSentences.TabIndex = 8;
            this.FindDupeSentences.Text = "Find Duplicate Sentences";
            this.FindDupeSentences.UseVisualStyleBackColor = true;
            this.FindDupeSentences.Click += new System.EventHandler(this.button2_Click);
            // 
            // debugInfoBox
            // 
            this.debugInfoBox.Location = new System.Drawing.Point(612, 425);
            this.debugInfoBox.Name = "debugInfoBox";
            this.debugInfoBox.Size = new System.Drawing.Size(451, 152);
            this.debugInfoBox.TabIndex = 9;
            this.debugInfoBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 406);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Debug Info";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(788, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 958);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debugInfoBox);
            this.Controls.Add(this.FindDupeSentences);
            this.Controls.Add(this.FindDupeWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FindDupeWords;
        private System.Windows.Forms.Button FindDupeSentences;
        private System.Windows.Forms.RichTextBox debugInfoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

