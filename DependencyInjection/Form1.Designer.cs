namespace DependencyInjection
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
            this.message_textBox = new System.Windows.Forms.TextBox();
            this.sendMessage_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sendTo_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // message_textBox
            // 
            this.message_textBox.Location = new System.Drawing.Point(131, 145);
            this.message_textBox.Multiline = true;
            this.message_textBox.Name = "message_textBox";
            this.message_textBox.Size = new System.Drawing.Size(239, 176);
            this.message_textBox.TabIndex = 0;
            // 
            // sendMessage_button
            // 
            this.sendMessage_button.Location = new System.Drawing.Point(198, 337);
            this.sendMessage_button.Name = "sendMessage_button";
            this.sendMessage_button.Size = new System.Drawing.Size(75, 23);
            this.sendMessage_button.TabIndex = 1;
            this.sendMessage_button.Text = "Send";
            this.sendMessage_button.UseVisualStyleBackColor = true;
            this.sendMessage_button.Click += new System.EventHandler(this.sendMessage_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Send To";
            // 
            // sendTo_listBox
            // 
            this.sendTo_listBox.FormattingEnabled = true;
            this.sendTo_listBox.Location = new System.Drawing.Point(224, 27);
            this.sendTo_listBox.Name = "sendTo_listBox";
            this.sendTo_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sendTo_listBox.Size = new System.Drawing.Size(146, 82);
            this.sendTo_listBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 372);
            this.Controls.Add(this.sendTo_listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMessage_button);
            this.Controls.Add(this.message_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_textBox;
        private System.Windows.Forms.Button sendMessage_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox sendTo_listBox;
    }
}

