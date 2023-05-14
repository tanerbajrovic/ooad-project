using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FitnessFusion.Models
{
    public class ExtraGymSession : GymSession
    {
        #region Properties

        public List<GymActivity> Activities { get; set;}
        public int Duration { get; set; }
        public string Note { get; set;}

        #endregion

        #region Constructor

        public ExtraGymSession(int id, DateTime dateTime, bool isComplete, int burnedCalories, 
            List<GymActivity> activities, int duration, string note) 
            : base(id, dateTime, isComplete, burnedCalories)
        {
            Activities = activities;
            Duration = duration;
            Note = note;
        }

        public ExtraGymSession() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
