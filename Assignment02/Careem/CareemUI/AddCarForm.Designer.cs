namespace CareemUI
{
    partial class AddCarForm
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
            this.vehicleSubmitButton = new System.Windows.Forms.Button();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.addDriverLabel = new System.Windows.Forms.Label();
            this.accessory1Label = new System.Windows.Forms.Label();
            this.imeiTextBox = new System.Windows.Forms.TextBox();
            this.imeiLabel = new System.Windows.Forms.Label();
            this.accessoriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // vehicleSubmitButton
            // 
            this.vehicleSubmitButton.Location = new System.Drawing.Point(324, 383);
            this.vehicleSubmitButton.Name = "vehicleSubmitButton";
            this.vehicleSubmitButton.Size = new System.Drawing.Size(89, 30);
            this.vehicleSubmitButton.TabIndex = 19;
            this.vehicleSubmitButton.Text = "Submit";
            this.vehicleSubmitButton.UseVisualStyleBackColor = true;
            this.vehicleSubmitButton.Click += new System.EventHandler(this.vehicleSubmitButton_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(211, 162);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(141, 26);
            this.typeTextBox.TabIndex = 18;
            this.typeTextBox.Text = "Business";
            this.typeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(27, 168);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(47, 20);
            this.typeLabel.TabIndex = 17;
            this.typeLabel.Text = "Type:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(210, 118);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(141, 26);
            this.yearTextBox.TabIndex = 16;
            this.yearTextBox.Text = "2001";
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(26, 124);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(153, 20);
            this.yearLabel.TabIndex = 15;
            this.yearLabel.Text = "Manufacturing Year:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(211, 77);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(141, 26);
            this.modelTextBox.TabIndex = 14;
            this.modelTextBox.Text = "Corolla XLi";
            this.modelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(27, 80);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(56, 20);
            this.modelLabel.TabIndex = 13;
            this.modelLabel.Text = "Model:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(210, 36);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(141, 26);
            this.makeTextBox.TabIndex = 12;
            this.makeTextBox.Text = "Toyota";
            this.makeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(26, 42);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(52, 20);
            this.makeLabel.TabIndex = 11;
            this.makeLabel.Text = "Make:";
            // 
            // addDriverLabel
            // 
            this.addDriverLabel.AutoSize = true;
            this.addDriverLabel.Location = new System.Drawing.Point(12, 9);
            this.addDriverLabel.Name = "addDriverLabel";
            this.addDriverLabel.Size = new System.Drawing.Size(310, 20);
            this.addDriverLabel.TabIndex = 10;
            this.addDriverLabel.Text = "Please enter the information about the car:";
            // 
            // accessory1Label
            // 
            this.accessory1Label.AutoSize = true;
            this.accessory1Label.Location = new System.Drawing.Point(26, 253);
            this.accessory1Label.Name = "accessory1Label";
            this.accessory1Label.Size = new System.Drawing.Size(170, 20);
            this.accessory1Label.TabIndex = 22;
            this.accessory1Label.Text = "Accessories of the car:";
            // 
            // imeiTextBox
            // 
            this.imeiTextBox.Location = new System.Drawing.Point(211, 204);
            this.imeiTextBox.Name = "imeiTextBox";
            this.imeiTextBox.Size = new System.Drawing.Size(141, 26);
            this.imeiTextBox.TabIndex = 21;
            this.imeiTextBox.Text = "123456789012345";
            this.imeiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imeiLabel
            // 
            this.imeiLabel.AutoSize = true;
            this.imeiLabel.Location = new System.Drawing.Point(27, 207);
            this.imeiLabel.Name = "imeiLabel";
            this.imeiLabel.Size = new System.Drawing.Size(64, 20);
            this.imeiLabel.TabIndex = 20;
            this.imeiLabel.Text = "IMEI # :";
            // 
            // accessoriesCheckedListBox
            // 
            this.accessoriesCheckedListBox.CheckOnClick = true;
            this.accessoriesCheckedListBox.FormattingEnabled = true;
            this.accessoriesCheckedListBox.Location = new System.Drawing.Point(210, 253);
            this.accessoriesCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accessoriesCheckedListBox.Name = "accessoriesCheckedListBox";
            this.accessoriesCheckedListBox.Size = new System.Drawing.Size(202, 109);
            this.accessoriesCheckedListBox.TabIndex = 23;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 424);
            this.Controls.Add(this.accessoriesCheckedListBox);
            this.Controls.Add(this.accessory1Label);
            this.Controls.Add(this.imeiTextBox);
            this.Controls.Add(this.imeiLabel);
            this.Controls.Add(this.vehicleSubmitButton);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.addDriverLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCarForm";
            this.Text = "Add Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vehicleSubmitButton;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label addDriverLabel;
        private System.Windows.Forms.Label accessory1Label;
        private System.Windows.Forms.TextBox imeiTextBox;
        private System.Windows.Forms.Label imeiLabel;
        private System.Windows.Forms.CheckedListBox accessoriesCheckedListBox;
    }
}