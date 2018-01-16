namespace CareemUI
{
    partial class SearchByRatingsForm
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
            this.resultsListBoxLabel = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.toRatingLabel = new System.Windows.Forms.Label();
            this.toRatingTextBox = new System.Windows.Forms.TextBox();
            this.fromRatingLabel = new System.Windows.Forms.Label();
            this.ratingsRangeSubmitButton = new System.Windows.Forms.Button();
            this.fromRatingTextBox = new System.Windows.Forms.TextBox();
            this.ratingsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsListBoxLabel
            // 
            this.resultsListBoxLabel.AutoSize = true;
            this.resultsListBoxLabel.Location = new System.Drawing.Point(13, 161);
            this.resultsListBoxLabel.Name = "resultsListBoxLabel";
            this.resultsListBoxLabel.Size = new System.Drawing.Size(371, 20);
            this.resultsListBoxLabel.TabIndex = 21;
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
            this.resultsListBox.TabIndex = 20;
            // 
            // toRatingLabel
            // 
            this.toRatingLabel.AutoSize = true;
            this.toRatingLabel.Location = new System.Drawing.Point(37, 85);
            this.toRatingLabel.Name = "toRatingLabel";
            this.toRatingLabel.Size = new System.Drawing.Size(31, 20);
            this.toRatingLabel.TabIndex = 19;
            this.toRatingLabel.Text = "To:";
            // 
            // toRatingTextBox
            // 
            this.toRatingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRatingTextBox.Location = new System.Drawing.Point(223, 85);
            this.toRatingTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toRatingTextBox.Name = "toRatingTextBox";
            this.toRatingTextBox.Size = new System.Drawing.Size(148, 26);
            this.toRatingTextBox.TabIndex = 18;
            this.toRatingTextBox.Text = "4.9";
            // 
            // fromRatingLabel
            // 
            this.fromRatingLabel.AutoSize = true;
            this.fromRatingLabel.Location = new System.Drawing.Point(37, 49);
            this.fromRatingLabel.Name = "fromRatingLabel";
            this.fromRatingLabel.Size = new System.Drawing.Size(50, 20);
            this.fromRatingLabel.TabIndex = 17;
            this.fromRatingLabel.Text = "From:";
            // 
            // ratingsRangeSubmitButton
            // 
            this.ratingsRangeSubmitButton.Location = new System.Drawing.Point(259, 121);
            this.ratingsRangeSubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ratingsRangeSubmitButton.Name = "ratingsRangeSubmitButton";
            this.ratingsRangeSubmitButton.Size = new System.Drawing.Size(112, 35);
            this.ratingsRangeSubmitButton.TabIndex = 16;
            this.ratingsRangeSubmitButton.Text = "Submit";
            this.ratingsRangeSubmitButton.UseVisualStyleBackColor = true;
            this.ratingsRangeSubmitButton.Click += new System.EventHandler(this.ratingsSubmitButton_Click);
            // 
            // fromRatingTextBox
            // 
            this.fromRatingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromRatingTextBox.Location = new System.Drawing.Point(223, 49);
            this.fromRatingTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromRatingTextBox.Name = "fromRatingTextBox";
            this.fromRatingTextBox.Size = new System.Drawing.Size(148, 26);
            this.fromRatingTextBox.TabIndex = 15;
            this.fromRatingTextBox.Text = "3.5";
            // 
            // ratingsLabel
            // 
            this.ratingsLabel.AutoSize = true;
            this.ratingsLabel.Location = new System.Drawing.Point(13, 13);
            this.ratingsLabel.Name = "ratingsLabel";
            this.ratingsLabel.Size = new System.Drawing.Size(258, 20);
            this.ratingsLabel.TabIndex = 14;
            this.ratingsLabel.Text = "Enter the range of ratings of drivers";
            // 
            // SearchByRatingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.resultsListBoxLabel);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.toRatingLabel);
            this.Controls.Add(this.toRatingTextBox);
            this.Controls.Add(this.fromRatingLabel);
            this.Controls.Add(this.ratingsRangeSubmitButton);
            this.Controls.Add(this.fromRatingTextBox);
            this.Controls.Add(this.ratingsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchByRatingsForm";
            this.Text = "Search By Ratings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultsListBoxLabel;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Label toRatingLabel;
        private System.Windows.Forms.TextBox toRatingTextBox;
        private System.Windows.Forms.Label fromRatingLabel;
        private System.Windows.Forms.Button ratingsRangeSubmitButton;
        private System.Windows.Forms.TextBox fromRatingTextBox;
        private System.Windows.Forms.Label ratingsLabel;
    }
}