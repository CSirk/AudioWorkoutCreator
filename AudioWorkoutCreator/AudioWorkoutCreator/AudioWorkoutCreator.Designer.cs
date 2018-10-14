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
            this.label7 = new System.Windows.Forms.Label();
            this.VoiceSelectListBox = new System.Windows.Forms.ListBox();
            this.RemoveExerciseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SetTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestTimeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ExerciseNameTextBox
            // 
            this.ExerciseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseNameTextBox.Location = new System.Drawing.Point(11, 44);
            this.ExerciseNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExerciseNameTextBox.Name = "ExerciseNameTextBox";
            this.ExerciseNameTextBox.Size = new System.Drawing.Size(260, 37);
            this.ExerciseNameTextBox.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(11, 119);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(125, 37);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextBox_KeyPress);
            // 
            // RepsTextBox
            // 
            this.RepsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepsTextBox.Location = new System.Drawing.Point(148, 119);
            this.RepsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RepsTextBox.Name = "RepsTextBox";
            this.RepsTextBox.Size = new System.Drawing.Size(125, 37);
            this.RepsTextBox.TabIndex = 3;
            this.RepsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepsTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exercise Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weight (lb)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reps (#)";
            // 
            // AddToWorkoutButton
            // 
            this.AddToWorkoutButton.BackColor = System.Drawing.Color.Black;
            this.AddToWorkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddToWorkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToWorkoutButton.ForeColor = System.Drawing.Color.White;
            this.AddToWorkoutButton.Location = new System.Drawing.Point(11, 165);
            this.AddToWorkoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddToWorkoutButton.Name = "AddToWorkoutButton";
            this.AddToWorkoutButton.Size = new System.Drawing.Size(388, 60);
            this.AddToWorkoutButton.TabIndex = 5;
            this.AddToWorkoutButton.Text = "Add To Workout";
            this.AddToWorkoutButton.UseVisualStyleBackColor = false;
            this.AddToWorkoutButton.Click += new System.EventHandler(this.AddToWorkoutButton_Click);
            // 
            // ExerciseListBox
            // 
            this.ExerciseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseListBox.FormattingEnabled = true;
            this.ExerciseListBox.ItemHeight = 25;
            this.ExerciseListBox.Location = new System.Drawing.Point(441, 41);
            this.ExerciseListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExerciseListBox.Name = "ExerciseListBox";
            this.ExerciseListBox.Size = new System.Drawing.Size(627, 554);
            this.ExerciseListBox.TabIndex = 11;
            // 
            // SaveAsAudioButton
            // 
            this.SaveAsAudioButton.BackColor = System.Drawing.Color.Black;
            this.SaveAsAudioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveAsAudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsAudioButton.ForeColor = System.Drawing.Color.White;
            this.SaveAsAudioButton.Location = new System.Drawing.Point(11, 550);
            this.SaveAsAudioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveAsAudioButton.Name = "SaveAsAudioButton";
            this.SaveAsAudioButton.Size = new System.Drawing.Size(388, 62);
            this.SaveAsAudioButton.TabIndex = 7;
            this.SaveAsAudioButton.Text = "Save As Audio";
            this.SaveAsAudioButton.UseVisualStyleBackColor = false;
            this.SaveAsAudioButton.Visible = false;
            this.SaveAsAudioButton.Click += new System.EventHandler(this.SaveAsAudioButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
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
            this.SetTimeNumeric.Location = new System.Drawing.Point(285, 44);
            this.SetTimeNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.SetTimeNumeric.Name = "SetTimeNumeric";
            this.SetTimeNumeric.Size = new System.Drawing.Size(119, 37);
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
            this.RestTimeNumeric.Location = new System.Drawing.Point(285, 119);
            this.RestTimeNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.RestTimeNumeric.Name = "RestTimeNumeric";
            this.RestTimeNumeric.Size = new System.Drawing.Size(119, 37);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rest Time (sec)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Set Time (sec)";
            // 
            // SelectSaveLocationButton
            // 
            this.SelectSaveLocationButton.BackColor = System.Drawing.Color.Black;
            this.SelectSaveLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectSaveLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSaveLocationButton.ForeColor = System.Drawing.Color.White;
            this.SelectSaveLocationButton.Location = new System.Drawing.Point(11, 477);
            this.SelectSaveLocationButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectSaveLocationButton.Name = "SelectSaveLocationButton";
            this.SelectSaveLocationButton.Size = new System.Drawing.Size(264, 44);
            this.SelectSaveLocationButton.TabIndex = 6;
            this.SelectSaveLocationButton.Text = "Select Save Location";
            this.SelectSaveLocationButton.UseVisualStyleBackColor = false;
            this.SelectSaveLocationButton.Click += new System.EventHandler(this.SelectSaveLocationButton_Click);
            // 
            // SaveLocationTextBox
            // 
            this.SaveLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLocationTextBox.Location = new System.Drawing.Point(11, 443);
            this.SaveLocationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SaveLocationTextBox.Name = "SaveLocationTextBox";
            this.SaveLocationTextBox.ReadOnly = true;
            this.SaveLocationTextBox.Size = new System.Drawing.Size(387, 26);
            this.SaveLocationTextBox.TabIndex = 19;
            this.SaveLocationTextBox.Text = "NONE SELECTED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Selected Voice For Audio";
            // 
            // VoiceSelectListBox
            // 
            this.VoiceSelectListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoiceSelectListBox.FormattingEnabled = true;
            this.VoiceSelectListBox.ItemHeight = 25;
            this.VoiceSelectListBox.Location = new System.Drawing.Point(11, 346);
            this.VoiceSelectListBox.Margin = new System.Windows.Forms.Padding(4);
            this.VoiceSelectListBox.Name = "VoiceSelectListBox";
            this.VoiceSelectListBox.Size = new System.Drawing.Size(296, 54);
            this.VoiceSelectListBox.TabIndex = 21;
            // 
            // RemoveExerciseButton
            // 
            this.RemoveExerciseButton.BackColor = System.Drawing.Color.Black;
            this.RemoveExerciseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveExerciseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveExerciseButton.ForeColor = System.Drawing.Color.White;
            this.RemoveExerciseButton.Location = new System.Drawing.Point(11, 233);
            this.RemoveExerciseButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveExerciseButton.Name = "RemoveExerciseButton";
            this.RemoveExerciseButton.Size = new System.Drawing.Size(388, 60);
            this.RemoveExerciseButton.TabIndex = 22;
            this.RemoveExerciseButton.Text = "Remove Selected Workout";
            this.RemoveExerciseButton.UseVisualStyleBackColor = false;
            this.RemoveExerciseButton.Click += new System.EventHandler(this.RemoveExerciseButton_Click);
            // 
            // AudioWorkoutCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 626);
            this.Controls.Add(this.RemoveExerciseButton);
            this.Controls.Add(this.VoiceSelectListBox);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox VoiceSelectListBox;
        private System.Windows.Forms.Button RemoveExerciseButton;
    }
}

