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
        public string UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Trainer")]
        public string TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        [Range(40, 160, ErrorMessage = "Mass must be between 40 and 160.")]
        public double Mass { get; set; }
        [Range(130, 230, ErrorMessage = "Height must be between 130 and 230.")]
        public double Height { get; set; }
        [DisplayName("Neck Circumference")]
        [Range(20, 80, ErrorMessage = "Neck circumference must be between 20 and 80.")]
        public double NeckCircumference { get; set; }
        [DisplayName("Waist Circumference")]
        [Range(40, 130, ErrorMessage = "Waist circumference must be between 40 and 130.")]
        public double WaistCircumference { get; set; }
        [DisplayName("Arm Circumference")]
        public double ArmCircumference { get; set; }
        [DisplayName("Hips Circumference")]
        [Range(40, 130, ErrorMessage = "Hips circumference must be between 40 and 130.")]
        public double HipsCircumference { get; set; }
        [DisplayName("Leg Circumference")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Leg circumference must be greater than zero.")]
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
