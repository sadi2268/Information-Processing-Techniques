namespace CareemUI
{
    partial class SearchByMakeAndModelForm
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
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.makeAndModelSubmitButton = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.makeAndModelLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.resultsListBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTextBox.Location = new System.Drawing.Point(222, 37);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(148, 26);
            this.makeTextBox.TabIndex = 0;
            this.makeTextBox.Text = "Toyota";
            // 
            // makeAndModelSubmitButton
            // 
            this.makeAndModelSubmitButton.Location = new System.Drawing.Point(258, 109);
            this.makeAndModelSubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makeAndModelSubmitButton.Name = "makeAndModelSubmitButton";
            this.makeAndModelSubmitButton.Size = new System.Drawing.Size(112, 35);
            this.makeAndModelSubmitButton.TabIndex = 1;
            this.makeAndModelSubmitButton.Text = "Submit";
            this.makeAndModelSubmitButton.UseVisualStyleBackColor = true;
            this.makeAndModelSubmitButton.Click += new System.EventHandler(this.makeAndModelSubmitButton_Click);
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 20;
            this.resultsListBox.Location = new System.Drawing.Point(13, 186);
            this.resultsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(400, 204);
            this.resultsListBox.TabIndex = 2;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(36, 37);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(52, 20);
            this.makeLabel.TabIndex = 3;
            this.makeLabel.Text = "Make:";
            // 
            // makeAndModelLabel
            // 
            this.makeAndModelLabel.AutoSize = true;
            this.makeAndModelLabel.Location = new System.Drawing.Point(36, 11);
            this.makeAndModelLabel.Name = "makeAndModelLabel";
            this.makeAndModelLabel.Size = new System.Drawing.Size(115, 20);
            this.makeAndModelLabel.TabIndex = 4;
            this.makeAndModelLabel.Text = "Enter vehicle\'s:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(36, 73);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(56, 20);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(222, 73);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(148, 26);
            this.modelTextBox.TabIndex = 5;
            this.modelTextBox.Text = "Corolla XLi";
            // 
            // resultsListBoxLabel
            // 
            this.resultsListBoxLabel.AutoSize = true;
            this.resultsListBoxLabel.Location = new System.Drawing.Point(12, 161);
            this.resultsListBoxLabel.Name = "resultsListBoxLabel";
            this.resultsListBoxLabel.Size = new System.Drawing.Size(371, 20);
            this.resultsListBoxLabel.TabIndex = 7;
            this.resultsListBoxLabel.Text = "Registration | Make | Model | Year | Type of Vehicle";
            this.resultsListBoxLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.resultsListBoxLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.makeAndModelLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.makeAndModelSubmitButton);
            this.Controls.Add(this.makeTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Search by Make and Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Button makeAndModelSubmitButton;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label makeAndModelLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label resultsListBoxLabel;
    }
}

