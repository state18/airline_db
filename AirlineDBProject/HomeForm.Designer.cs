namespace AirlineDBProject
{
    partial class HomeForm
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
            this.customersFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customersFoundListbox
            // 
            this.customersFoundListbox.FormattingEnabled = true;
            this.customersFoundListbox.Location = new System.Drawing.Point(29, 96);
            this.customersFoundListbox.Name = "customersFoundListbox";
            this.customersFoundListbox.Size = new System.Drawing.Size(192, 225);
            this.customersFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(80, 36);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 39);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(68, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 622);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.customersFoundListbox);
            this.Name = "HomeForm";
            this.Text = "Airline";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customersFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
    }
}

