namespace WindowsFormsApp
{
    partial class MainForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MatrixSizeLabel = new System.Windows.Forms.Label();
            this.MatrixSizeComboBox = new System.Windows.Forms.ComboBox();
            this.ThreadingComboBox = new System.Windows.Forms.ComboBox();
            this.ThreadingLabel = new System.Windows.Forms.Label();
            this.StorageComboBox = new System.Windows.Forms.ComboBox();
            this.StorageLabel = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressHeadingLabel = new System.Windows.Forms.Label();
            this.TimeTakenLabel = new System.Windows.Forms.Label();
            this.RunsLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Run1Label = new System.Windows.Forms.Label();
            this.Run1TextBox = new System.Windows.Forms.TextBox();
            this.RunAverageTextBox = new System.Windows.Forms.TextBox();
            this.RunAverageLabel = new System.Windows.Forms.Label();
            this.Run5TextBox = new System.Windows.Forms.TextBox();
            this.Run5Label = new System.Windows.Forms.Label();
            this.Run4TextBox = new System.Windows.Forms.TextBox();
            this.Run4Label = new System.Windows.Forms.Label();
            this.Run3TextBox = new System.Windows.Forms.TextBox();
            this.Run3Label = new System.Windows.Forms.Label();
            this.Run2TextBox = new System.Windows.Forms.TextBox();
            this.Run2Label = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(13, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(75, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Choose:";
            // 
            // MatrixSizeLabel
            // 
            this.MatrixSizeLabel.AutoSize = true;
            this.MatrixSizeLabel.Location = new System.Drawing.Point(45, 49);
            this.MatrixSizeLabel.Name = "MatrixSizeLabel";
            this.MatrixSizeLabel.Size = new System.Drawing.Size(90, 20);
            this.MatrixSizeLabel.TabIndex = 1;
            this.MatrixSizeLabel.Text = "Matrix Size:";
            // 
            // MatrixSizeComboBox
            // 
            this.MatrixSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatrixSizeComboBox.FormattingEnabled = true;
            this.MatrixSizeComboBox.Location = new System.Drawing.Point(230, 46);
            this.MatrixSizeComboBox.Name = "MatrixSizeComboBox";
            this.MatrixSizeComboBox.Size = new System.Drawing.Size(174, 28);
            this.MatrixSizeComboBox.TabIndex = 2;
            // 
            // ThreadingComboBox
            // 
            this.ThreadingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThreadingComboBox.FormattingEnabled = true;
            this.ThreadingComboBox.Location = new System.Drawing.Point(230, 131);
            this.ThreadingComboBox.Name = "ThreadingComboBox";
            this.ThreadingComboBox.Size = new System.Drawing.Size(174, 28);
            this.ThreadingComboBox.TabIndex = 4;
            // 
            // ThreadingLabel
            // 
            this.ThreadingLabel.AutoSize = true;
            this.ThreadingLabel.Location = new System.Drawing.Point(45, 134);
            this.ThreadingLabel.Name = "ThreadingLabel";
            this.ThreadingLabel.Size = new System.Drawing.Size(131, 20);
            this.ThreadingLabel.TabIndex = 3;
            this.ThreadingLabel.Text = "Threading Model:";
            // 
            // StorageComboBox
            // 
            this.StorageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StorageComboBox.FormattingEnabled = true;
            this.StorageComboBox.Location = new System.Drawing.Point(230, 89);
            this.StorageComboBox.Name = "StorageComboBox";
            this.StorageComboBox.Size = new System.Drawing.Size(174, 28);
            this.StorageComboBox.TabIndex = 6;
            // 
            // StorageLabel
            // 
            this.StorageLabel.AutoSize = true;
            this.StorageLabel.Location = new System.Drawing.Point(45, 92);
            this.StorageLabel.Name = "StorageLabel";
            this.StorageLabel.Size = new System.Drawing.Size(117, 20);
            this.StorageLabel.TabIndex = 5;
            this.StorageLabel.Text = "Storage Model:";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(447, 181);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(81, 29);
            this.ExecuteButton.TabIndex = 7;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(49, 251);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(302, 23);
            this.ProgressBar.TabIndex = 8;
            // 
            // ProgressHeadingLabel
            // 
            this.ProgressHeadingLabel.AutoSize = true;
            this.ProgressHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressHeadingLabel.Location = new System.Drawing.Point(17, 216);
            this.ProgressHeadingLabel.Name = "ProgressHeadingLabel";
            this.ProgressHeadingLabel.Size = new System.Drawing.Size(85, 20);
            this.ProgressHeadingLabel.TabIndex = 9;
            this.ProgressHeadingLabel.Text = "Progress:";
            // 
            // TimeTakenLabel
            // 
            this.TimeTakenLabel.AutoSize = true;
            this.TimeTakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTakenLabel.Location = new System.Drawing.Point(17, 340);
            this.TimeTakenLabel.Name = "TimeTakenLabel";
            this.TimeTakenLabel.Size = new System.Drawing.Size(244, 20);
            this.TimeTakenLabel.TabIndex = 10;
            this.TimeTakenLabel.Text = "Time Taken (in milliseconds): ";
            // 
            // RunsLabel
            // 
            this.RunsLabel.AutoSize = true;
            this.RunsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunsLabel.Location = new System.Drawing.Point(17, 381);
            this.RunsLabel.Name = "RunsLabel";
            this.RunsLabel.Size = new System.Drawing.Size(51, 20);
            this.RunsLabel.TabIndex = 13;
            this.RunsLabel.Text = "Runs";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(17, 423);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(47, 20);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Time";
            // 
            // Run1Label
            // 
            this.Run1Label.AutoSize = true;
            this.Run1Label.Location = new System.Drawing.Point(125, 381);
            this.Run1Label.Name = "Run1Label";
            this.Run1Label.Size = new System.Drawing.Size(52, 20);
            this.Run1Label.TabIndex = 15;
            this.Run1Label.Text = "Run 1";
            // 
            // Run1TextBox
            // 
            this.Run1TextBox.Location = new System.Drawing.Point(96, 423);
            this.Run1TextBox.Name = "Run1TextBox";
            this.Run1TextBox.Size = new System.Drawing.Size(104, 26);
            this.Run1TextBox.TabIndex = 16;
            this.Run1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RunAverageTextBox
            // 
            this.RunAverageTextBox.Location = new System.Drawing.Point(647, 423);
            this.RunAverageTextBox.Name = "RunAverageTextBox";
            this.RunAverageTextBox.Size = new System.Drawing.Size(121, 26);
            this.RunAverageTextBox.TabIndex = 18;
            this.RunAverageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RunAverageLabel
            // 
            this.RunAverageLabel.AutoSize = true;
            this.RunAverageLabel.Location = new System.Drawing.Point(671, 381);
            this.RunAverageLabel.Name = "RunAverageLabel";
            this.RunAverageLabel.Size = new System.Drawing.Size(68, 20);
            this.RunAverageLabel.TabIndex = 17;
            this.RunAverageLabel.Text = "Average";
            // 
            // Run5TextBox
            // 
            this.Run5TextBox.Location = new System.Drawing.Point(534, 423);
            this.Run5TextBox.Name = "Run5TextBox";
            this.Run5TextBox.Size = new System.Drawing.Size(97, 26);
            this.Run5TextBox.TabIndex = 20;
            this.Run5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Run5Label
            // 
            this.Run5Label.AutoSize = true;
            this.Run5Label.Location = new System.Drawing.Point(553, 381);
            this.Run5Label.Name = "Run5Label";
            this.Run5Label.Size = new System.Drawing.Size(52, 20);
            this.Run5Label.TabIndex = 19;
            this.Run5Label.Text = "Run 5";
            // 
            // Run4TextBox
            // 
            this.Run4TextBox.Location = new System.Drawing.Point(425, 423);
            this.Run4TextBox.Name = "Run4TextBox";
            this.Run4TextBox.Size = new System.Drawing.Size(103, 26);
            this.Run4TextBox.TabIndex = 22;
            this.Run4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Run4Label
            // 
            this.Run4Label.AutoSize = true;
            this.Run4Label.Location = new System.Drawing.Point(443, 381);
            this.Run4Label.Name = "Run4Label";
            this.Run4Label.Size = new System.Drawing.Size(52, 20);
            this.Run4Label.TabIndex = 21;
            this.Run4Label.Text = "Run 4";
            // 
            // Run3TextBox
            // 
            this.Run3TextBox.Location = new System.Drawing.Point(310, 423);
            this.Run3TextBox.Name = "Run3TextBox";
            this.Run3TextBox.Size = new System.Drawing.Size(109, 26);
            this.Run3TextBox.TabIndex = 24;
            this.Run3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Run3Label
            // 
            this.Run3Label.AutoSize = true;
            this.Run3Label.Location = new System.Drawing.Point(338, 381);
            this.Run3Label.Name = "Run3Label";
            this.Run3Label.Size = new System.Drawing.Size(52, 20);
            this.Run3Label.TabIndex = 23;
            this.Run3Label.Text = "Run 3";
            // 
            // Run2TextBox
            // 
            this.Run2TextBox.Location = new System.Drawing.Point(206, 423);
            this.Run2TextBox.Name = "Run2TextBox";
            this.Run2TextBox.Size = new System.Drawing.Size(98, 26);
            this.Run2TextBox.TabIndex = 26;
            this.Run2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Run2Label
            // 
            this.Run2Label.AutoSize = true;
            this.Run2Label.Location = new System.Drawing.Point(226, 381);
            this.Run2Label.Name = "Run2Label";
            this.Run2Label.Size = new System.Drawing.Size(52, 20);
            this.Run2Label.TabIndex = 25;
            this.Run2Label.Text = "Run 2";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(45, 293);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(0, 20);
            this.ProgressLabel.TabIndex = 27;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(557, 181);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(81, 29);
            this.CancelBtn.TabIndex = 28;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(315, 293);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 20);
            this.MessageLabel.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 527);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.Run2TextBox);
            this.Controls.Add(this.Run2Label);
            this.Controls.Add(this.Run3TextBox);
            this.Controls.Add(this.Run3Label);
            this.Controls.Add(this.Run4TextBox);
            this.Controls.Add(this.Run4Label);
            this.Controls.Add(this.Run5TextBox);
            this.Controls.Add(this.Run5Label);
            this.Controls.Add(this.RunAverageTextBox);
            this.Controls.Add(this.RunAverageLabel);
            this.Controls.Add(this.Run1TextBox);
            this.Controls.Add(this.Run1Label);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.RunsLabel);
            this.Controls.Add(this.TimeTakenLabel);
            this.Controls.Add(this.ProgressHeadingLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.StorageComboBox);
            this.Controls.Add(this.StorageLabel);
            this.Controls.Add(this.ThreadingComboBox);
            this.Controls.Add(this.ThreadingLabel);
            this.Controls.Add(this.MatrixSizeComboBox);
            this.Controls.Add(this.MatrixSizeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Threaded Matrix Multiplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MatrixSizeLabel;
        private System.Windows.Forms.ComboBox MatrixSizeComboBox;
        private System.Windows.Forms.ComboBox ThreadingComboBox;
        private System.Windows.Forms.Label ThreadingLabel;
        private System.Windows.Forms.ComboBox StorageComboBox;
        private System.Windows.Forms.Label StorageLabel;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressHeadingLabel;
        private System.Windows.Forms.Label TimeTakenLabel;
        private System.Windows.Forms.Label RunsLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label Run1Label;
        private System.Windows.Forms.TextBox Run1TextBox;
        private System.Windows.Forms.TextBox RunAverageTextBox;
        private System.Windows.Forms.Label RunAverageLabel;
        private System.Windows.Forms.TextBox Run5TextBox;
        private System.Windows.Forms.Label Run5Label;
        private System.Windows.Forms.TextBox Run4TextBox;
        private System.Windows.Forms.Label Run4Label;
        private System.Windows.Forms.TextBox Run3TextBox;
        private System.Windows.Forms.Label Run3Label;
        private System.Windows.Forms.TextBox Run2TextBox;
        private System.Windows.Forms.Label Run2Label;
        private System.Windows.Forms.Label ProgressLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label MessageLabel;
    }
}

