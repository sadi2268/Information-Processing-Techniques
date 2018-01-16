namespace CareemUI
{
    partial class SearchByAccessoriesForm
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
            this.accessoriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.resultsListBoxLabel = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.accessoriesSubmitButton = new System.Windows.Forms.Button();
            this.accessoriesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accessoriesCheckedListBox
            // 
            this.accessoriesCheckedListBox.CheckOnClick = true;
            this.accessoriesCheckedListBox.FormattingEnabled = true;
            this.accessoriesCheckedListBox.Location = new System.Drawing.Point(42, 47);
            this.accessoriesCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accessoriesCheckedListBox.Name = "accessoriesCheckedListBox";
            this.accessoriesCheckedListBox.Size = new System.Drawing.Size(202, 109);
            this.accessoriesCheckedListBox.TabIndex = 0;
            // 
            // resultsListBoxLabel
            // 
            this.resultsListBoxLabel.AutoSize = true;
            this.resultsListBoxLabel.Location = new System.Drawing.Point(13, 171);
            this.resultsListBoxLabel.Name = "resultsListBoxLabel";
            this.resultsListBoxLabel.Size = new System.Drawing.Size(354, 20);
            this.resultsListBoxLabel.TabIndex = 25;
            this.resultsListBoxLabel.Text = "Registration | Accessories available in the vehicle";
            this.resultsListBoxLabel.Visible = false;
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 20;
            this.resultsListBox.Location = new System.Drawing.Point(13, 196);
            this.resultsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(400, 204);
            this.resultsListBox.TabIndex = 24;
            // 
            // accessoriesSubmitButton
            // 
            this.accessoriesSubmitButton.Location = new System.Drawing.Point(285, 79);
            this.accessoriesSubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accessoriesSubmitButton.Name = "accessoriesSubmitButton";
            this.accessoriesSubmitButton.Size = new System.Drawing.Size(112, 35);
            this.accessoriesSubmitButton.TabIndex = 23;
            this.accessoriesSubmitButton.Text = "Submit";
            this.accessoriesSubmitButton.UseVisualStyleBackColor = true;
            this.accessoriesSubmitButton.Click += new System.EventHandler(this.accessoriesSubmitButton_Click);
            // 
            // accessoriesLabel
            // 
            this.accessoriesLabel.AutoSize = true;
            this.accessoriesLabel.Location = new System.Drawing.Point(13, 13);
            this.accessoriesLabel.Name = "accessoriesLabel";
            this.accessoriesLabel.Size = new System.Drawing.Size(281, 20);
            this.accessoriesLabel.TabIndex = 22;
            this.accessoriesLabel.Text = "Please check your desired accessories";
            // 
            // SearchByAccessoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 414);
            this.Controls.Add(this.resultsListBoxLabel);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.accessoriesSubmitButton);
            this.Controls.Add(this.accessoriesLabel);
            this.Controls.Add(this.accessoriesCheckedListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchByAccessoriesForm";
            this.Text = "Search By Accessories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox accessoriesCheckedListBox;
        private System.Windows.Forms.Label resultsListBoxLabel;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button accessoriesSubmitButton;
        private System.Windows.Forms.Label accessoriesLabel;
    }
}