using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public double Mass { get; set; }
        public double Height { get; set; }
        [DisplayName("Neck Circumference")]
        public double NeckCircumference { get; set; }
        [DisplayName("Waist Circumference")] 
        public double WaistCircumference { get; set; }
        [DisplayName("Arm Circumference")] 
        public double ArmCircumference { get; set; }
        [DisplayName("Hips Circumference")] 
        public double HipsCircumference { get; set; }
        [DisplayName("Leg Circumference")] 
        public double LegCircumference { get; set; }
        [DisplayName("Bench Press")]
        public double BenchPress { get; set; }
        public double Squat { get; set; }
        [DisplayName("Abs Test")]
        public int AbsTest { get; set; }
        public int PushUps { get; set; }
        [DisplayName("Sprint Running")]
        public double SprintRunning { get; set; }
        public double Running { get; set; }
        [DisplayName("Vertical Jump")]
        public double VerticalJump { get; set; }
        [DisplayName("Horizontal Jump")]
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
