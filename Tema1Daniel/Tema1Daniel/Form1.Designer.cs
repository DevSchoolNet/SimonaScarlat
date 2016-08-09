namespace Tema1Daniel
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
            this.components = new System.ComponentModel.Container();
            this.idApartment_textbox = new System.Windows.Forms.TextBox();
            this.numberOfRooms_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addApartment_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.floor_textBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idApartmentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberOfRoomsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idApartment_textbox
            // 
            this.idApartment_textbox.Location = new System.Drawing.Point(435, 108);
            this.idApartment_textbox.Name = "idApartment_textbox";
            this.idApartment_textbox.Size = new System.Drawing.Size(100, 20);
            this.idApartment_textbox.TabIndex = 1;
            // 
            // numberOfRooms_textbox
            // 
            this.numberOfRooms_textbox.Location = new System.Drawing.Point(434, 186);
            this.numberOfRooms_textbox.Name = "numberOfRooms_textbox";
            this.numberOfRooms_textbox.Size = new System.Drawing.Size(100, 20);
            this.numberOfRooms_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of rooms";
            // 
            // addApartment_button
            // 
            this.addApartment_button.Location = new System.Drawing.Point(434, 229);
            this.addApartment_button.Name = "addApartment_button";
            this.addApartment_button.Size = new System.Drawing.Size(84, 26);
            this.addApartment_button.TabIndex = 5;
            this.addApartment_button.Text = "Add apartment";
            this.addApartment_button.UseVisualStyleBackColor = true;
            this.addApartment_button.Click += new System.EventHandler(this.addApartment_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Floor";
            // 
            // floor_textBox
            // 
            this.floor_textBox.Location = new System.Drawing.Point(435, 147);
            this.floor_textBox.Name = "floor_textBox";
            this.floor_textBox.Size = new System.Drawing.Size(100, 20);
            this.floor_textBox.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idApartmentColumn,
            this.numberOfRoomsColumn});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(42, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(235, 163);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // idApartmentColumn
            // 
            this.idApartmentColumn.Text = "Id";
            this.idApartmentColumn.Width = 98;
            // 
            // numberOfRoomsColumn
            // 
            this.numberOfRoomsColumn.Text = "Number of rooms";
            this.numberOfRoomsColumn.Width = 129;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 343);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floor_textBox);
            this.Controls.Add(this.addApartment_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfRooms_textbox);
            this.Controls.Add(this.idApartment_textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idApartment_textbox;
        private System.Windows.Forms.TextBox numberOfRooms_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addApartment_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox floor_textBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idApartmentColumn;
        private System.Windows.Forms.ColumnHeader numberOfRoomsColumn;
    }
}

