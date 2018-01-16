namespace CareemUI
{
    partial class SearchForm
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
            this.makeAndModelButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.yearButton = new System.Windows.Forms.Button();
            this.accessoriesButton = new System.Windows.Forms.Button();
            this.ratingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeAndModelButton
            // 
            this.makeAndModelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeAndModelButton.Location = new System.Drawing.Point(26, 60);
            this.makeAndModelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makeAndModelButton.Name = "makeAndModelButton";
            this.makeAndModelButton.Size = new System.Drawing.Size(189, 97);
            this.makeAndModelButton.TabIndex = 0;
            this.makeAndModelButton.Text = "Make and Model";
            this.makeAndModelButton.UseVisualStyleBackColor = true;
            this.makeAndModelButton.Click += new System.EventHandler(this.makeAndModelButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(13, 20);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(84, 20);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search by:";
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(245, 60);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(189, 97);
            this.yearButton.TabIndex = 2;
            this.yearButton.Text = "Range of Manufacturing Year";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // accessoriesButton
            // 
            this.accessoriesButton.Location = new System.Drawing.Point(26, 196);
            this.accessoriesButton.Name = "accessoriesButton";
            this.accessoriesButton.Size = new System.Drawing.Size(190, 97);
            this.accessoriesButton.TabIndex = 3;
            this.accessoriesButton.Text = "Accessories Filter";
            this.accessoriesButton.UseVisualStyleBackColor = true;
            this.accessoriesButton.Click += new System.EventHandler(this.accessoriesButton_Click);
            // 
            // ratingsButton
            // 
            this.ratingsButton.Location = new System.Drawing.Point(245, 196);
            this.ratingsButton.Name = "ratingsButton";
            this.ratingsButton.Size = new System.Drawing.Size(189, 97);
            this.ratingsButton.TabIndex = 4;
            this.ratingsButton.Text = "Ratings Filter";
            this.ratingsButton.UseVisualStyleBackColor = true;
            this.ratingsButton.Click += new System.EventHandler(this.ratingsButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 341);
            this.Controls.Add(this.ratingsButton);
            this.Controls.Add(this.accessoriesButton);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.makeAndModelButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchForm";
            this.Text = "Search Vehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeAndModelButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Button accessoriesButton;
        private System.Windows.Forms.Button ratingsButton;
    }
}