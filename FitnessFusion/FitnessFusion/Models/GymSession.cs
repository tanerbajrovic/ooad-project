﻿using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public abstract class GymSession
    {
        #region Properties
        
        [Key]
        public int Id { get; set; }
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public DateTime StartTime { get; set; }   
        public bool IsComplete { get; set; }
        [DisplayName("Burned Calories")]
        public int BurnedCalories { get; set; }

        #endregion

        #region Constructor

        protected GymSession() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
