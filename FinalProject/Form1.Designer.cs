namespace FinalProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.ArticleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShirtTextBox = new System.Windows.Forms.TextBox();
            this.PantsTextBox = new System.Windows.Forms.TextBox();
            this.FootwearTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClosetListBox = new System.Windows.Forms.ListBox();
            this.warmCheckBox = new System.Windows.Forms.CheckBox();
            this.coldCheckBox = new System.Windows.Forms.CheckBox();
            this.tempComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article of Clothing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ArticleTextBox
            // 
            this.ArticleTextBox.Location = new System.Drawing.Point(30, 107);
            this.ArticleTextBox.Name = "ArticleTextBox";
            this.ArticleTextBox.Size = new System.Drawing.Size(100, 20);
            this.ArticleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Shirt",
            "Pants",
            "Footwear"});
            this.TypeComboBox.Location = new System.Drawing.Point(151, 106);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Closet";
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Location = new System.Drawing.Point(467, 191);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
            this.RandomizeButton.TabIndex = 8;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shirt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pants";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Footwear";
            // 
            // ShirtTextBox
            // 
            this.ShirtTextBox.Location = new System.Drawing.Point(388, 259);
            this.ShirtTextBox.Name = "ShirtTextBox";
            this.ShirtTextBox.Size = new System.Drawing.Size(154, 20);
            this.ShirtTextBox.TabIndex = 12;
            // 
            // PantsTextBox
            // 
            this.PantsTextBox.Location = new System.Drawing.Point(388, 321);
            this.PantsTextBox.Name = "PantsTextBox";
            this.PantsTextBox.Size = new System.Drawing.Size(154, 20);
            this.PantsTextBox.TabIndex = 13;
            // 
            // FootwearTextBox
            // 
            this.FootwearTextBox.Location = new System.Drawing.Point(388, 386);
            this.FootwearTextBox.Name = "FootwearTextBox";
            this.FootwearTextBox.Size = new System.Drawing.Size(154, 20);
            this.FootwearTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Outfit Selector";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(386, 104);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 23);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add to Closet";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClosetListBox
            // 
            this.ClosetListBox.FormattingEnabled = true;
            this.ClosetListBox.Location = new System.Drawing.Point(33, 208);
            this.ClosetListBox.Name = "ClosetListBox";
            this.ClosetListBox.Size = new System.Drawing.Size(97, 199);
            this.ClosetListBox.TabIndex = 17;
            // 
            // warmCheckBox
            // 
            this.warmCheckBox.AutoSize = true;
            this.warmCheckBox.Location = new System.Drawing.Point(300, 86);
            this.warmCheckBox.Name = "warmCheckBox";
            this.warmCheckBox.Size = new System.Drawing.Size(54, 17);
            this.warmCheckBox.TabIndex = 18;
            this.warmCheckBox.Text = "Warm";
            this.warmCheckBox.UseVisualStyleBackColor = true;
            // 
            // coldCheckBox
            // 
            this.coldCheckBox.AutoSize = true;
            this.coldCheckBox.Location = new System.Drawing.Point(300, 110);
            this.coldCheckBox.Name = "coldCheckBox";
            this.coldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.coldCheckBox.TabIndex = 19;
            this.coldCheckBox.Text = "Cold";
            this.coldCheckBox.UseVisualStyleBackColor = true;
            // 
            // tempComboBox
            // 
            this.tempComboBox.FormattingEnabled = true;
            this.tempComboBox.Items.AddRange(new object[] {
            " ",
            "Cold",
            "Warm"});
            this.tempComboBox.Location = new System.Drawing.Point(323, 193);
            this.tempComboBox.Name = "tempComboBox";
            this.tempComboBox.Size = new System.Drawing.Size(121, 21);
            this.tempComboBox.TabIndex = 20;
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.FormattingEnabled = true;
            this.DescriptionListBox.Location = new System.Drawing.Point(208, 208);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.Size = new System.Drawing.Size(64, 199);
            this.DescriptionListBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Please only select one";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TypeListBox
            // 
            this.TypeListBox.FormattingEnabled = true;
            this.TypeListBox.Location = new System.Drawing.Point(137, 208);
            this.TypeListBox.Name = "TypeListBox";
            this.TypeListBox.Size = new System.Drawing.Size(65, 199);
            this.TypeListBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.TypeListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionListBox);
            this.Controls.Add(this.tempComboBox);
            this.Controls.Add(this.coldCheckBox);
            this.Controls.Add(this.warmCheckBox);
            this.Controls.Add(this.ClosetListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FootwearTextBox);
            this.Controls.Add(this.PantsTextBox);
            this.Controls.Add(this.ShirtTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArticleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArticleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ShirtTextBox;
        private System.Windows.Forms.TextBox PantsTextBox;
        private System.Windows.Forms.TextBox FootwearTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ClosetListBox;
        private System.Windows.Forms.CheckBox warmCheckBox;
        private System.Windows.Forms.CheckBox coldCheckBox;
        private System.Windows.Forms.ComboBox tempComboBox;
        private System.Windows.Forms.ListBox DescriptionListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox TypeListBox;
    }
}

