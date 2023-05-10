using System;
using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class Training : GymSession
    {
        #region Attributes

        private List<GymActivity> activities;
        private int estimatedDuration;

        #endregion

        #region Properties
        public int EstimatedDuration { get => estimatedDuration; set => estimatedDuration = value; }
        public List<GymActivity> Activities { get => activities; set => activities = value; }

        #endregion

        #region Constructor

        public Training(int id, DateTime date, bool isComplete, int calories, 
                        int estimatedDuration, List<GymActivity> activities) 
            : base(id, date, isComplete, calories)
        {
            EstimatedDuration = estimatedDuration;
            Activities = activities;
        }

        public Training() : base() 
        {
        
        }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
