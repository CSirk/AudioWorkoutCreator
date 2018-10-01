using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioWorkoutCreator.Models
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Reps { get; set; }
        public int SetTime { get; set; }
        public int RestTime { get; set; }
    }
}
