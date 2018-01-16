namespace CareemUI
{
    partial class InitialForm
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
            this.welcomLabel = new System.Windows.Forms.Label();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.searchVehicleButton = new System.Windows.Forms.Button();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.deleteVehicleButton = new System.Windows.Forms.Button();
            this.deleteDriverButton = new System.Windows.Forms.Button();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.Location = new System.Drawing.Point(13, 13);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(231, 20);
            this.welcomLabel.TabIndex = 0;
            this.welcomLabel.Text = "Welcome to Careem Database!";
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLabel.Location = new System.Drawing.Point(13, 46);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(77, 20);
            this.vehicleLabel.TabIndex = 1;
            this.vehicleLabel.Text = "Vehicles";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLabel.Location = new System.Drawing.Point(25, 254);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(65, 20);
            this.driverLabel.TabIndex = 5;
            this.driverLabel.Text = "Drivers";
            // 
            // searchVehicleButton
            // 
            this.searchVehicleButton.Location = new System.Drawing.Point(39, 82);
            this.searchVehicleButton.Name = "searchVehicleButton";
            this.searchVehicleButton.Size = new System.Drawing.Size(138, 57);
            this.searchVehicleButton.TabIndex = 9;
            this.searchVehicleButton.Text = "Search";
            this.searchVehicleButton.UseVisualStyleBackColor = true;
            this.searchVehicleButton.Click += new System.EventHandler(this.searchVehicleButton_Click);
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Location = new System.Drawing.Point(39, 160);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(90, 44);
            this.addVehicleButton.TabIndex = 10;
            this.addVehicleButton.Text = "Add";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // deleteVehicleButton
            // 
            this.deleteVehicleButton.Location = new System.Drawing.Point(177, 160);
            this.deleteVehicleButton.Name = "deleteVehicleButton";
            this.deleteVehicleButton.Size = new System.Drawing.Size(90, 44);
            this.deleteVehicleButton.TabIndex = 12;
            this.deleteVehicleButton.Text = "Delete";
            this.deleteVehicleButton.UseVisualStyleBackColor = true;
            this.deleteVehicleButton.Click += new System.EventHandler(this.deleteVehicleButton_Click);
            // 
            // deleteDriverButton
            // 
            this.deleteDriverButton.Location = new System.Drawing.Point(177, 297);
            this.deleteDriverButton.Name = "deleteDriverButton";
            this.deleteDriverButton.Size = new System.Drawing.Size(90, 44);
            this.deleteDriverButton.TabIndex = 15;
            this.deleteDriverButton.Text = "Delete";
            this.deleteDriverButton.UseVisualStyleBackColor = true;
            this.deleteDriverButton.Click += new System.EventHandler(this.deleteDriverButton_Click);
            // 
            // addDriverButton
            // 
            this.addDriverButton.Location = new System.Drawing.Point(39, 297);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(90, 44);
            this.addDriverButton.TabIndex = 13;
            this.addDriverButton.Text = "Add";
            this.addDriverButton.UseVisualStyleBackColor = true;
            this.addDriverButton.Click += new System.EventHandler(this.addDriverButton_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.deleteDriverButton);
            this.Controls.Add(this.addDriverButton);
            this.Controls.Add(this.deleteVehicleButton);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.searchVehicleButton);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.welcomLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InitialForm";
            this.Text = "Careem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Button searchVehicleButton;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button deleteVehicleButton;
        private System.Windows.Forms.Button deleteDriverButton;
        private System.Windows.Forms.Button addDriverButton;
    }
}