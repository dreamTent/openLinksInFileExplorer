﻿

namespace openLinksInFileExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button_accept = new Button();
            textBox_allowedExtensions = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_accept
            // 
            button_accept.Location = new Point(12, 179);
            button_accept.Name = "button_accept";
            button_accept.Size = new Size(664, 83);
            button_accept.TabIndex = 0;
            button_accept.Text = "Accpet";
            button_accept.UseVisualStyleBackColor = true;
            button_accept.Click += button1_Click;
            // 
            // textBox_allowedExtensions
            // 
            textBox_allowedExtensions.Location = new Point(12, 107);
            textBox_allowedExtensions.Name = "textBox_allowedExtensions";
            textBox_allowedExtensions.Size = new Size(664, 23);
            textBox_allowedExtensions.TabIndex = 1;
            textBox_allowedExtensions.TextChanged += textBox_allowedExtensions_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 89);
            label1.Name = "label1";
            label1.Size = new Size(279, 15);
            label1.TabIndex = 2;
            label1.Text = "Please enter what file extensions should be allowed:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 274);
            Controls.Add(label1);
            Controls.Add(textBox_allowedExtensions);
            Controls.Add(button_accept);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Open Links in File Explorer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_accept;
        private TextBox textBox_allowedExtensions;
        private Label label1;
    }
}
