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
        [Range(0.01, double.MaxValue, ErrorMessage = "Mass must be greater than zero.")]
        public double Mass { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Height must be greater than zero.")]
        public double Height { get; set; }
        [DisplayName("Neck Circumference")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Neck circumference must be greater than zero.")]
        public double NeckCircumference { get; set; }
        [DisplayName("Waist Circumference")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Waist circumference must be greater than zero.")]
        public double WaistCircumference { get; set; }
        [DisplayName("Arm Circumference")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Arm circumference must be greater than zero.")]
        public double ArmCircumference { get; set; }
        [DisplayName("Hips Circumference")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Hips circumference must be greater than zero.")]
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
