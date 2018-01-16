namespace CareemUI
{
    partial class SearchByManufacturingRangeForm
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
            this.manufacturingYearLabel = new System.Windows.Forms.Label();
            this.toYearLabel = new System.Windows.Forms.Label();
            this.toYearTextBox = new System.Windows.Forms.TextBox();
            this.fromYearLabel = new System.Windows.Forms.Label();
            this.manufacturingYearRangeSubmitButton = new System.Windows.Forms.Button();
            this.fromYearTextBox = new System.Windows.Forms.TextBox();
            this.resultsListBoxLabel = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // manufacturingYearLabel
            // 
            this.manufacturingYearLabel.AutoSize = true;
            this.manufacturingYearLabel.Location = new System.Drawing.Point(13, 13);
            this.manufacturingYearLabel.Name = "manufacturingYearLabel";
            this.manufacturingYearLabel.Size = new System.Drawing.Size(356, 20);
            this.manufacturingYearLabel.TabIndex = 0;
            this.manufacturingYearLabel.Text = "Enter the range of manufacturing year of vehicles";
            // 
            // toYearLabel
            // 
            this.toYearLabel.AutoSize = true;
            this.toYearLabel.Location = new System.Drawing.Point(37, 85);
            this.toYearLabel.Name = "toYearLabel";
            this.toYearLabel.Size = new System.Drawing.Size(69, 20);
            this.toYearLabel.TabIndex = 11;
            this.toYearLabel.Text = "To Year:";
            // 
            // toYearTextBox
            // 
            this.toYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toYearTextBox.Location = new System.Drawing.Point(223, 85);
            this.toYearTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toYearTextBox.Name = "toYearTextBox";
            this.toYearTextBox.Size = new System.Drawing.Size(148, 26);
            this.toYearTextBox.TabIndex = 10;
            this.toYearTextBox.Text = "2005";
            // 
            // fromYearLabel
            // 
            this.fromYearLabel.AutoSize = true;
            this.fromYearLabel.Location = new System.Drawing.Point(37, 49);
            this.fromYearLabel.Name = "fromYearLabel";
            this.fromYearLabel.Size = new System.Drawing.Size(88, 20);
            this.fromYearLabel.TabIndex = 9;
            this.fromYearLabel.Text = "From Year:";
            // 
            // manufacturingYearRangeSubmitButton
            // 
            this.manufacturingYearRangeSubmitButton.Location = new System.Drawing.Point(259, 121);
            this.manufacturingYearRangeSubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manufacturingYearRangeSubmitButton.Name = "manufacturingYearRangeSubmitButton";
            this.manufacturingYearRangeSubmitButton.Size = new System.Drawing.Size(112, 35);
            this.manufacturingYearRangeSubmitButton.TabIndex = 8;
            this.manufacturingYearRangeSubmitButton.Text = "Submit";
            this.manufacturingYearRangeSubmitButton.UseVisualStyleBackColor = true;
            this.manufacturingYearRangeSubmitButton.Click += new System.EventHandler(this.manufacturingRangeSubmitButton_Click);
            // 
            // fromYearTextBox
            // 
            this.fromYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromYearTextBox.Location = new System.Drawing.Point(223, 49);
            this.fromYearTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromYearTextBox.Name = "fromYearTextBox";
            this.fromYearTextBox.Size = new System.Drawing.Size(148, 26);
            this.fromYearTextBox.TabIndex = 7;
            this.fromYearTextBox.Text = "1995";
            // 
            // resultsListBoxLabel
            // 
            this.resultsListBoxLabel.AutoSize = true;
            this.resultsListBoxLabel.Location = new System.Drawing.Point(13, 161);
            this.resultsListBoxLabel.Name = "resultsListBoxLabel";
            this.resultsListBoxLabel.Size = new System.Drawing.Size(371, 20);
            this.resultsListBoxLabel.TabIndex = 13;
            this.resultsListBoxLabel.Text = "Registration | Make | Model | Year | Type of Vehicle";
            this.resultsListBoxLabel.Visible = false;
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 20;
            this.resultsListBox.Location = new System.Drawing.Point(14, 186);
            this.resultsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(400, 204);
            this.resultsListBox.TabIndex = 12;
            // 
            // SearchByManufacturingRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.resultsListBoxLabel);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.toYearLabel);
            this.Controls.Add(this.toYearTextBox);
            this.Controls.Add(this.fromYearLabel);
            this.Controls.Add(this.manufacturingYearRangeSubmitButton);
            this.Controls.Add(this.fromYearTextBox);
            this.Controls.Add(this.manufacturingYearLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchByManufacturingRangeForm";
            this.Text = "Search by Manufacturing Range";
            this.Click += new System.EventHandler(this.manufacturingRangeSubmitButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manufacturingYearLabel;
        private System.Windows.Forms.Label toYearLabel;
        private System.Windows.Forms.TextBox toYearTextBox;
        private System.Windows.Forms.Label fromYearLabel;
        private System.Windows.Forms.Button manufacturingYearRangeSubmitButton;
        private System.Windows.Forms.TextBox fromYearTextBox;
        private System.Windows.Forms.Label resultsListBoxLabel;
        private System.Windows.Forms.ListBox resultsListBox;
    }
}