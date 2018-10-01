namespace AudioWorkoutCreator
{
    partial class AudioWorkoutCreator
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
            this.ExerciseNameTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.RepsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToWorkoutButton = new System.Windows.Forms.Button();
            this.ExerciseListBox = new System.Windows.Forms.ListBox();
            this.SaveAsAudioButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SetTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.RestTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectSaveLocationButton = new System.Windows.Forms.Button();
            this.SaveLocationTextBox = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SetTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestTimeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ExerciseNameTextBox
            // 
            this.ExerciseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseNameTextBox.Location = new System.Drawing.Point(8, 36);
            this.ExerciseNameTextBox.Name = "ExerciseNameTextBox";
            this.ExerciseNameTextBox.Size = new System.Drawing.Size(196, 31);
            this.ExerciseNameTextBox.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(8, 97);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(95, 31);
            this.WeightTextBox.TabIndex = 2;
            // 
            // RepsTextBox
            // 
            this.RepsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepsTextBox.Location = new System.Drawing.Point(108, 97);
            this.RepsTextBox.Name = "RepsTextBox";
            this.RepsTextBox.Size = new System.Drawing.Size(95, 31);
            this.RepsTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exercise Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reps";
            // 
            // AddToWorkoutButton
            // 
            this.AddToWorkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToWorkoutButton.Location = new System.Drawing.Point(8, 134);
            this.AddToWorkoutButton.Name = "AddToWorkoutButton";
            this.AddToWorkoutButton.Size = new System.Drawing.Size(291, 49);
            this.AddToWorkoutButton.TabIndex = 5;
            this.AddToWorkoutButton.Text = "Add To Workout";
            this.AddToWorkoutButton.UseVisualStyleBackColor = true;
            this.AddToWorkoutButton.Click += new System.EventHandler(this.AddToWorkoutButton_Click);
            // 
            // ExerciseListBox
            // 
            this.ExerciseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseListBox.FormattingEnabled = true;
            this.ExerciseListBox.ItemHeight = 20;
            this.ExerciseListBox.Location = new System.Drawing.Point(305, 36);
            this.ExerciseListBox.Name = "ExerciseListBox";
            this.ExerciseListBox.Size = new System.Drawing.Size(471, 384);
            this.ExerciseListBox.TabIndex = 11;
            // 
            // SaveAsAudioButton
            // 
            this.SaveAsAudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsAudioButton.Location = new System.Drawing.Point(8, 370);
            this.SaveAsAudioButton.Name = "SaveAsAudioButton";
            this.SaveAsAudioButton.Size = new System.Drawing.Size(291, 50);
            this.SaveAsAudioButton.TabIndex = 7;
            this.SaveAsAudioButton.Text = "Save As Audio";
            this.SaveAsAudioButton.UseVisualStyleBackColor = true;
            this.SaveAsAudioButton.Visible = false;
            this.SaveAsAudioButton.Click += new System.EventHandler(this.SaveAsAudioButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Workout";
            // 
            // SetTimeNumeric
            // 
            this.SetTimeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimeNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SetTimeNumeric.Location = new System.Drawing.Point(210, 36);
            this.SetTimeNumeric.Name = "SetTimeNumeric";
            this.SetTimeNumeric.Size = new System.Drawing.Size(89, 31);
            this.SetTimeNumeric.TabIndex = 1;
            this.SetTimeNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // RestTimeNumeric
            // 
            this.RestTimeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestTimeNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RestTimeNumeric.Location = new System.Drawing.Point(210, 97);
            this.RestTimeNumeric.Name = "RestTimeNumeric";
            this.RestTimeNumeric.Size = new System.Drawing.Size(89, 31);
            this.RestTimeNumeric.TabIndex = 4;
            this.RestTimeNumeric.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rest Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Set Time";
            // 
            // SelectSaveLocationButton
            // 
            this.SelectSaveLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSaveLocationButton.Location = new System.Drawing.Point(8, 286);
            this.SelectSaveLocationButton.Name = "SelectSaveLocationButton";
            this.SelectSaveLocationButton.Size = new System.Drawing.Size(198, 36);
            this.SelectSaveLocationButton.TabIndex = 6;
            this.SelectSaveLocationButton.Text = "Select Save Location";
            this.SelectSaveLocationButton.UseVisualStyleBackColor = true;
            this.SelectSaveLocationButton.Click += new System.EventHandler(this.SelectSaveLocationButton_Click);
            // 
            // SaveLocationTextBox
            // 
            this.SaveLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLocationTextBox.Location = new System.Drawing.Point(8, 241);
            this.SaveLocationTextBox.Name = "SaveLocationTextBox";
            this.SaveLocationTextBox.ReadOnly = true;
            this.SaveLocationTextBox.Size = new System.Drawing.Size(291, 22);
            this.SaveLocationTextBox.TabIndex = 19;
            this.SaveLocationTextBox.Text = "NONE SELECTED";
            // 
            // AudioWorkoutCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 434);
            this.Controls.Add(this.SaveLocationTextBox);
            this.Controls.Add(this.SelectSaveLocationButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RestTimeNumeric);
            this.Controls.Add(this.SetTimeNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveAsAudioButton);
            this.Controls.Add(this.ExerciseListBox);
            this.Controls.Add(this.AddToWorkoutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepsTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.ExerciseNameTextBox);
            this.Name = "AudioWorkoutCreator";
            this.Text = "Audio Workout Creator";
            ((System.ComponentModel.ISupportInitialize)(this.SetTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestTimeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExerciseNameTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox RepsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddToWorkoutButton;
        private System.Windows.Forms.ListBox ExerciseListBox;
        private System.Windows.Forms.Button SaveAsAudioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SetTimeNumeric;
        private System.Windows.Forms.NumericUpDown RestTimeNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SelectSaveLocationButton;
        private System.Windows.Forms.TextBox SaveLocationTextBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

