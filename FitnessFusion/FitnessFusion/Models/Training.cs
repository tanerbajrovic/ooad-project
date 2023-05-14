using System;
using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class Training : GymSession
    {
        #region Properties

        public List<GymActivity> Activities { get; set; }
        public int EstimatedDuration { get; set; }

        #endregion

        #region Constructor

        public Training(int id, DateTime dateTime, bool isComplete, int burnedCalories,
            List<GymActivity> activities, int estimatedTime) : base(id, dateTime, isComplete, burnedCalories)
        {
            Activities = activities;
            EstimatedDuration = estimatedTime;
        }

        public Training() : base() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
