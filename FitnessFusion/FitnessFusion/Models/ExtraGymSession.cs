using System;
using System.Collections.Generic;

namespace FitnessFusion.Models
{
    public class ExtraGymSession : GymSession
    {

        #region Attributes

        private List<GymActivity> activities;
        private int duration;
        private string note;

        #endregion

        #region Properties

        public List<GymActivity> Activities { get => activities; set => activities = value;}
        public int Duration { get => duration; set => duration = value; }
        public string Note { get => note; set => note = value;}

        #endregion

        #region Constructor

        public ExtraGymSession(int id, DateTime date, bool isComplete, int calories,
                           int duration, List<GymActivity> activities, string note)
            : base(id, date, isComplete, calories)
        {
            Duration = duration;
            Activities = activities;
            Note = note;
        }

        public ExtraGymSession() : base() 
        {
        
        }

        #endregion

        #region Methods

        // TODO

        #endregion

    }
}
