namespace AirlineDBProject {
    partial class MyFlightsUserControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.titleLabel = new System.Windows.Forms.Label();
            this.flightsListBox = new System.Windows.Forms.ListBox();
            this.cancelFlightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titleLabel.Location = new System.Drawing.Point(430, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(111, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "My Flights";
            // 
            // flightsListBox
            // 
            this.flightsListBox.FormattingEnabled = true;
            this.flightsListBox.Location = new System.Drawing.Point(189, 63);
            this.flightsListBox.Name = "flightsListBox";
            this.flightsListBox.Size = new System.Drawing.Size(593, 355);
            this.flightsListBox.TabIndex = 1;
            // 
            // cancelFlightButton
            // 
            this.cancelFlightButton.Location = new System.Drawing.Point(413, 462);
            this.cancelFlightButton.Name = "cancelFlightButton";
            this.cancelFlightButton.Size = new System.Drawing.Size(144, 23);
            this.cancelFlightButton.TabIndex = 2;
            this.cancelFlightButton.Text = "Cancel Selected Flight";
            this.cancelFlightButton.UseVisualStyleBackColor = true;
            // 
            // MyFlightsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelFlightButton);
            this.Controls.Add(this.flightsListBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "MyFlightsUserControl";
            this.Size = new System.Drawing.Size(971, 537);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox flightsListBox;
        private System.Windows.Forms.Button cancelFlightButton;
    }
}
