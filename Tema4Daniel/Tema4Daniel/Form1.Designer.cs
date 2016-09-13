namespace Tema4Daniel
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
            this.valea_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.getReady_button = new System.Windows.Forms.Button();
            this.work_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valea_button
            // 
            this.valea_button.Location = new System.Drawing.Point(36, 255);
            this.valea_button.Name = "valea_button";
            this.valea_button.Size = new System.Drawing.Size(75, 23);
            this.valea_button.TabIndex = 0;
            this.valea_button.Text = "Valea";
            this.valea_button.UseVisualStyleBackColor = true;
            this.valea_button.Click += new System.EventHandler(this.valea_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 242);
            this.textBox1.TabIndex = 1;
            // 
            // getReady_button
            // 
            this.getReady_button.Location = new System.Drawing.Point(36, 216);
            this.getReady_button.Name = "getReady_button";
            this.getReady_button.Size = new System.Drawing.Size(75, 23);
            this.getReady_button.TabIndex = 2;
            this.getReady_button.Text = "Get ready";
            this.getReady_button.UseVisualStyleBackColor = true;
            this.getReady_button.Click += new System.EventHandler(this.getReady_button_Click);
            // 
            // work_button
            // 
            this.work_button.Location = new System.Drawing.Point(36, 178);
            this.work_button.Name = "work_button";
            this.work_button.Size = new System.Drawing.Size(75, 23);
            this.work_button.TabIndex = 3;
            this.work_button.Text = "Work";
            this.work_button.UseVisualStyleBackColor = true;
            this.work_button.Click += new System.EventHandler(this.work_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 311);
            this.Controls.Add(this.work_button);
            this.Controls.Add(this.getReady_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.valea_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valea_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button getReady_button;
        private System.Windows.Forms.Button work_button;
    }
}

