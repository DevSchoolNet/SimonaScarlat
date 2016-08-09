namespace Tema1Daniel
{
    partial class Form2
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
            this.idRoom_textBox = new System.Windows.Forms.TextBox();
            this.width_textBox = new System.Windows.Forms.TextBox();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orientation_comboBox = new System.Windows.Forms.ComboBox();
            this.addRoom_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idRoom_textBox
            // 
            this.idRoom_textBox.Location = new System.Drawing.Point(75, 89);
            this.idRoom_textBox.Name = "idRoom_textBox";
            this.idRoom_textBox.Size = new System.Drawing.Size(100, 20);
            this.idRoom_textBox.TabIndex = 0;
            // 
            // width_textBox
            // 
            this.width_textBox.Location = new System.Drawing.Point(75, 125);
            this.width_textBox.Name = "width_textBox";
            this.width_textBox.Size = new System.Drawing.Size(100, 20);
            this.width_textBox.TabIndex = 1;
            // 
            // height_textBox
            // 
            this.height_textBox.Location = new System.Drawing.Point(75, 161);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(100, 20);
            this.height_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Orientation";
            // 
            // orientation_comboBox
            // 
            this.orientation_comboBox.FormattingEnabled = true;
            this.orientation_comboBox.Items.AddRange(new object[] {
            "N",
            "S",
            "E",
            "V"});
            this.orientation_comboBox.Location = new System.Drawing.Point(75, 196);
            this.orientation_comboBox.Name = "orientation_comboBox";
            this.orientation_comboBox.Size = new System.Drawing.Size(121, 21);
            this.orientation_comboBox.TabIndex = 7;
            // 
            // addRoom_button
            // 
            this.addRoom_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addRoom_button.Location = new System.Drawing.Point(75, 256);
            this.addRoom_button.Name = "addRoom_button";
            this.addRoom_button.Size = new System.Drawing.Size(75, 23);
            this.addRoom_button.TabIndex = 8;
            this.addRoom_button.Text = "Add room";
            this.addRoom_button.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 337);
            this.Controls.Add(this.addRoom_button);
            this.Controls.Add(this.orientation_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.height_textBox);
            this.Controls.Add(this.width_textBox);
            this.Controls.Add(this.idRoom_textBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox idRoom_textBox;
        public System.Windows.Forms.TextBox width_textBox;
        public System.Windows.Forms.TextBox height_textBox;
        public System.Windows.Forms.ComboBox orientation_comboBox;
        public System.Windows.Forms.Button addRoom_button;
    }
}