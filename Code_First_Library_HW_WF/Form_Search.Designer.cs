namespace Code_First_Library_HW_WF
{
    partial class Form_Search
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonAuthor = new System.Windows.Forms.RadioButton();
            this.radioButtonCategory = new System.Windows.Forms.RadioButton();
            this.radioButtonPublishHouse = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 0;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(0, 19);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(74, 17);
            this.radioButtonName.TabIndex = 1;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "По имени";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonAuthor
            // 
            this.radioButtonAuthor.AutoSize = true;
            this.radioButtonAuthor.Location = new System.Drawing.Point(0, 42);
            this.radioButtonAuthor.Name = "radioButtonAuthor";
            this.radioButtonAuthor.Size = new System.Drawing.Size(77, 17);
            this.radioButtonAuthor.TabIndex = 2;
            this.radioButtonAuthor.TabStop = true;
            this.radioButtonAuthor.Text = "По Автору";
            this.radioButtonAuthor.UseVisualStyleBackColor = true;
            this.radioButtonAuthor.CheckedChanged += new System.EventHandler(this.radioButtonAuthor_CheckedChanged);
            // 
            // radioButtonCategory
            // 
            this.radioButtonCategory.AutoSize = true;
            this.radioButtonCategory.Location = new System.Drawing.Point(0, 65);
            this.radioButtonCategory.Name = "radioButtonCategory";
            this.radioButtonCategory.Size = new System.Drawing.Size(94, 17);
            this.radioButtonCategory.TabIndex = 3;
            this.radioButtonCategory.TabStop = true;
            this.radioButtonCategory.Text = "По категории";
            this.radioButtonCategory.UseVisualStyleBackColor = true;
            this.radioButtonCategory.CheckedChanged += new System.EventHandler(this.radioButtonCategory_CheckedChanged);
            // 
            // radioButtonPublishHouse
            // 
            this.radioButtonPublishHouse.AutoSize = true;
            this.radioButtonPublishHouse.Location = new System.Drawing.Point(0, 88);
            this.radioButtonPublishHouse.Name = "radioButtonPublishHouse";
            this.radioButtonPublishHouse.Size = new System.Drawing.Size(113, 17);
            this.radioButtonPublishHouse.TabIndex = 4;
            this.radioButtonPublishHouse.TabStop = true;
            this.radioButtonPublishHouse.Text = "По Издательству";
            this.radioButtonPublishHouse.UseVisualStyleBackColor = true;
            this.radioButtonPublishHouse.CheckedChanged += new System.EventHandler(this.radioButtonPublishHouse_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 168);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(269, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonName);
            this.groupBox1.Controls.Add(this.radioButtonAuthor);
            this.groupBox1.Controls.Add(this.radioButtonPublishHouse);
            this.groupBox1.Controls.Add(this.radioButtonCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 303);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Search";
            this.Text = "Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonAuthor;
        private System.Windows.Forms.RadioButton radioButtonCategory;
        private System.Windows.Forms.RadioButton radioButtonPublishHouse;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}