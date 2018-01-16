namespace CareemUI
{
    partial class AddDriverForm
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
            this.addDriverLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.cnicTextBox = new System.Windows.Forms.TextBox();
            this.cnicLabel = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.driverSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDriverLabel
            // 
            this.addDriverLabel.AutoSize = true;
            this.addDriverLabel.Location = new System.Drawing.Point(13, 13);
            this.addDriverLabel.Name = "addDriverLabel";
            this.addDriverLabel.Size = new System.Drawing.Size(326, 20);
            this.addDriverLabel.TabIndex = 0;
            this.addDriverLabel.Text = "Please enter the information about the driver:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 64);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(223, 63);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(141, 26);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.Text = "John";
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(223, 111);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(141, 26);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Text = "Doe";
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(28, 114);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // cnicTextBox
            // 
            this.cnicTextBox.Location = new System.Drawing.Point(223, 163);
            this.cnicTextBox.Name = "cnicTextBox";
            this.cnicTextBox.Size = new System.Drawing.Size(141, 26);
            this.cnicTextBox.TabIndex = 6;
            this.cnicTextBox.Text = "12345-1234567-1";
            this.cnicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnicLabel
            // 
            this.cnicLabel.AutoSize = true;
            this.cnicLabel.Location = new System.Drawing.Point(28, 169);
            this.cnicLabel.Name = "cnicLabel";
            this.cnicLabel.Size = new System.Drawing.Size(64, 20);
            this.cnicLabel.TabIndex = 5;
            this.cnicLabel.Text = "CNIC #:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(223, 212);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(141, 26);
            this.ratingTextBox.TabIndex = 8;
            this.ratingTextBox.Text = "2.5";
            this.ratingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(28, 218);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(60, 20);
            this.ratingLabel.TabIndex = 7;
            this.ratingLabel.Text = "Rating:";
            // 
            // driverSubmitButton
            // 
            this.driverSubmitButton.Location = new System.Drawing.Point(274, 266);
            this.driverSubmitButton.Name = "driverSubmitButton";
            this.driverSubmitButton.Size = new System.Drawing.Size(89, 30);
            this.driverSubmitButton.TabIndex = 9;
            this.driverSubmitButton.Text = "Submit";
            this.driverSubmitButton.UseVisualStyleBackColor = true;
            this.driverSubmitButton.Click += new System.EventHandler(this.driverSubmitButton_Click);
            // 
            // AddDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.driverSubmitButton);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.cnicTextBox);
            this.Controls.Add(this.cnicLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.addDriverLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDriverForm";
            this.Text = "Add Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addDriverLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox cnicTextBox;
        private System.Windows.Forms.Label cnicLabel;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button driverSubmitButton;
    }
}