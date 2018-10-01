﻿using AudioWorkoutCreator.Models;
using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Wavify.Core.Actions;

namespace AudioWorkoutCreator
{
    public partial class AudioWorkoutCreator : Form
    {
        List<Exercise> Workout = new List<Exercise>();

        public AudioWorkoutCreator()
        {
            InitializeComponent();
        }

        private void AddToWorkoutButton_Click(object sender, EventArgs e)
        {
            if(ExerciseBoxesFilled())
            {
                var exercise = new Exercise
                {
                    Name = ExerciseNameTextBox.Text,
                    Reps = RepsTextBox.Text,
                    Weight = WeightTextBox.Text,
                    SetTime = (int) SetTimeNumeric.Value,
                    RestTime = (int) RestTimeNumeric.Value
                };

                ExerciseListBox.Items.Add($"{exercise.Name} - {exercise.Reps} @ {exercise.Weight} (ST: {exercise.SetTime}) (RT: {exercise.RestTime})");
                Workout.Add(exercise);
            }
        }

        private void SaveAsAudioButton_Click(object sender, EventArgs e)
        {
            if(ExerciseListBoxPopulated())
            {
                var speechPrompt = new PromptBuilder();

                speechPrompt.AppendText("Generated by Workout Audio Assistant. Please visit Streets of smashville dot com to download.");
                speechPrompt.AppendText($"Welcome to Workout Assistant. Today you will be performing {ExerciseListBox.Items.Count} exercises.");
                
                

                foreach (var exercise in Workout)
                {
                    speechPrompt.AppendText($"Please get in position for exercise, {Workout[0].Name} for {Workout[0].Reps} reps at {Workout[0].Weight} pounds.");
                    AppendBreakToPrompt(speechPrompt, 0, 15);
                    speechPrompt.AppendText($"Time for  {exercise.Name} for {exercise.Reps} reps at {exercise.Weight} pounds.");
                    speechPrompt.AppendText($"You will have {exercise.SetTime} seconds to complete the set.");
                    AppendBreakToPrompt(speechPrompt, 0, 5);
                    speechPrompt.AppendText($"Begin {exercise.Name}");
                    AppendBreakToPrompt(speechPrompt, 0, (exercise.SetTime / 2));
                    speechPrompt.AppendText("Half set time.");
                    AppendBreakToPrompt(speechPrompt, 0, (exercise.SetTime / 2));
                    speechPrompt.AppendText($"Good set! Time to rest. You will have {exercise.RestTime} to rest.");
                    AppendBreakToPrompt(speechPrompt, 0, (exercise.RestTime / 2));
                    speechPrompt.AppendText("Half rest time.");
                    AppendBreakToPrompt(speechPrompt, 0, (exercise.RestTime / 2));
                    speechPrompt.AppendText("Rest time is over.");
                }

                speechPrompt.AppendText("Awesome workout! You are a step closer to achieving your goals! See you next time!");

                SpeechAction.ConvertSpeechSynthPromptToMp3File(speechPrompt, $@"c:\users\codas\desktop\test\Workout Assistant {DateTime.Now.ToString("yyyy-MM-dd hh_mm_ss_tt")}.mp3");
            }
            
        }

        private bool ExerciseBoxesFilled()
        {
            return
                !String.IsNullOrEmpty(ExerciseNameTextBox.Text) &&
                !String.IsNullOrEmpty(WeightTextBox.Text) &&
                !String.IsNullOrEmpty(RepsTextBox.Text) &&
                SetTimeNumeric.Value > 0 &&
                RestTimeNumeric.Value > 0;
        }

        private bool ExerciseListBoxPopulated()
        {
            return ExerciseListBox.Items.Count > 0;
        }
       
        private PromptBuilder AppendBreakToPrompt(PromptBuilder prompt, int minutes, int seconds)
        {
            prompt.AppendBreak(new TimeSpan(0, minutes, seconds));
            return prompt;
        }
    }
}