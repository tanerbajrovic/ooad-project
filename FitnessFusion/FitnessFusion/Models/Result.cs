using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace FitnessFusion.Models
{
    public class Result
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey("ApplicationUser")]
        public string TrainerId { get; set; }
        public ApplicationUser Trainer { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public double Mass { get; set; }
        public double Height { get; set; }  
        public double WaistCircumference { get; set; }
        public double BenchPress { get; set; }
        public double Squat { get; set; }
        public int AbsTest { get; set; }
        public int PushUps { get; set; }
        public double SprintRunning { get; set; }
        public double Running { get; set; }
        public double VerticalJump { get; set; }
        public double HorizontalJump { get; set; }

        #endregion

        #region Constructor

        public Result() { }

        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
