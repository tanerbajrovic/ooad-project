using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public abstract class GymSession
    {
        #region Properties
        
        [Key]
        public int ID { get; set; }
        [ForeignKey("Schedule")]
        public int? IDSchedule { get; set; }
        public Schedule Schedule { get; set; }
        public DateTime DateTime { get; set; }   
        public bool IsComplete { get; set; }
        public int BurnedCalories { get; set; }

        #endregion

        #region Constructor

        protected GymSession(int id, DateTime dateTime, bool isComplete, int burnedCalories)
        {
            ID = id;
            DateTime = dateTime;
            IsComplete = isComplete;
            BurnedCalories = burnedCalories;
        }

        protected GymSession() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
