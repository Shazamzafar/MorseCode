namespace StringProcessing_ProjectMorseCode_Zafar
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
            this.User_TextBox = new System.Windows.Forms.TextBox();
            this.Convert_Button = new System.Windows.Forms.Button();
            this.MorseCode_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // User_TextBox
            // 
            this.User_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(77)))), ((int)(((byte)(55)))));
            this.User_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_TextBox.Location = new System.Drawing.Point(12, 12);
            this.User_TextBox.Name = "User_TextBox";
            this.User_TextBox.Size = new System.Drawing.Size(209, 26);
            this.User_TextBox.TabIndex = 0;
            // 
            // Convert_Button
            // 
            this.Convert_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(77)))), ((int)(((byte)(55)))));
            this.Convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_Button.Location = new System.Drawing.Point(12, 54);
            this.Convert_Button.Name = "Convert_Button";
            this.Convert_Button.Size = new System.Drawing.Size(209, 36);
            this.Convert_Button.TabIndex = 1;
            this.Convert_Button.Text = "Covert";
            this.Convert_Button.UseVisualStyleBackColor = false;
            this.Convert_Button.Click += new System.EventHandler(this.Convert_Button_Click);
            // 
            // MorseCode_ListBox
            // 
            this.MorseCode_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(77)))), ((int)(((byte)(55)))));
            this.MorseCode_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MorseCode_ListBox.FormattingEnabled = true;
            this.MorseCode_ListBox.ItemHeight = 24;
            this.MorseCode_ListBox.Location = new System.Drawing.Point(12, 96);
            this.MorseCode_ListBox.Name = "MorseCode_ListBox";
            this.MorseCode_ListBox.Size = new System.Drawing.Size(209, 196);
            this.MorseCode_ListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(255, 304);
            this.Controls.Add(this.MorseCode_ListBox);
            this.Controls.Add(this.Convert_Button);
            this.Controls.Add(this.User_TextBox);
            this.Name = "Form1";
            this.Text = "Morse Code";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User_TextBox;
        private System.Windows.Forms.Button Convert_Button;
        private System.Windows.Forms.ListBox MorseCode_ListBox;
    }
}

